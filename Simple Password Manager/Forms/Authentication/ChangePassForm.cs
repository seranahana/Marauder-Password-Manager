using SimplePM.Library;
using SimplePM.Library.Diagnostics;
using SimplePM.Library.Networking;
using System;
using System.Windows.Forms;

namespace SimplePM.Forms
{
    public partial class ChangePassForm : ShadowedForm
    {
        private readonly IAccountClient _client;

        public ChangePassForm(IAccountClient client)
        {
            InitializeComponent();
            ApplyTheme(SettingsProcessor.GetCurrentTheme());
            _client = client;
            DialogResult = DialogResult.Cancel;
        }

        private async void confirmButton_Click(object sender, EventArgs e)
        {
            string enteredCurrentPassword = currentPassTextBox.Texts;
            string newPassword = newPassTextBox.Texts;
            string newPasswordConfirmation = confirmPassTextBox.Texts;
            if (string.IsNullOrWhiteSpace(enteredCurrentPassword))
            {
                passwordEmptyLabel.Visible = true;
                incorrectCurrentPassLabel.Visible = false;
                return;
            }
            else
            {
                passwordEmptyLabel.Visible = false;
            }
            if (!newPassword.IsValidPassword())
            {
                invalidNewPasswordLabel.Visible = true;
                incorrectCurrentPassLabel.Visible = false;
                return;
            }
            else
            {
                invalidNewPasswordLabel.Visible = false;
            }
            if (newPassword != newPasswordConfirmation)
            {
                passwordsNotMatchLabel.Visible = true;
                incorrectCurrentPassLabel.Visible = false;
                return;
            }
            else
            {
                passwordsNotMatchLabel.Visible = false;
            }
            string currentLogin = Properties.Settings.Default.Username;
            try
            {
                await _client.ChangePasswordAsync(newPassword, currentLogin, enteredCurrentPassword);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                switch (ex.ParamName)
                {
                    case nameof(currentLogin):
                        MessageBox.Show("Critical malfunction: Your username cannot be found by server. " +
                            "This may occur due to this application assets, server DB or server cache corruption. " +
                            "Try again or contact software developer.");
                        Logger.CreateExceptionEntry(new ApplicationException("Critical malfunction: Username not found by server."));
                        Close();
                        break;
                    case nameof(enteredCurrentPassword):
                        incorrectCurrentPassLabel.Visible = true;
                        break;
                    default:
                        MessageBox.Show($"{ex.GetType()}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Logger.CreateExceptionEntry(ex);
                        Close();
                        break;
                }
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.CreateExceptionEntry(ex);
                Close();
            }
        }
    }
}
