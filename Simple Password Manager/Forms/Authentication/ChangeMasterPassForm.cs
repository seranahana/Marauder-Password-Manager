using SimplePM.Library.Assets.Processors;
using SimplePM.Library.Diagnostics;
using SimplePM.Library.Networking;
using System;
using System.Windows.Forms;

namespace SimplePM.Forms
{
    public partial class ChangeMasterPassForm : ShadowedForm
    {
        internal string MasterPassword { get; private set; }

        private readonly IAccountClient _accountClient;
        private readonly IEntriesProcessor _entriesProcessor; 

        public ChangeMasterPassForm(IAccountClient accountClient, IEntriesProcessor entriesProcessor)
        {
            InitializeComponent();
            ApplyTheme(SettingsProcessor.GetCurrentTheme());
            _accountClient = accountClient;
            _entriesProcessor = entriesProcessor;
            DialogResult = DialogResult.Cancel;
        }

        private async void confirmButton_Click(object sender, EventArgs e)
        {
            string enteredCurrentMasterPassword = currentMasterPassTextBox.Texts;
            string newMasterPassword = newMasterPassTextBox.Texts;
            string newPasswordConfirmation = confirmMasterPassTextBox.Texts;
            if (string.IsNullOrWhiteSpace(enteredCurrentMasterPassword))
            {
                passwordEmptyLabel.Visible = true;
                incorrectCurrentPassLabel.Visible = false;
                return;
            }
            else
            {
                passwordEmptyLabel.Visible = false;
            }
            if (newMasterPassword.Length < 8)
            {
                newPasswordInvalidLengthLabel.Visible = true;
                incorrectCurrentPassLabel.Visible = false;
                return;
            }
            else
            {
                newPasswordInvalidLengthLabel.Visible = false;
            }
            if (newMasterPassword != newPasswordConfirmation)
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
                var (newMasterPasswordHash, newMasterSalt) = await _accountClient.SetNewMasterPasswordAsync(currentLogin, enteredCurrentMasterPassword, newMasterPassword);
                _entriesProcessor.ReencryptAll(enteredCurrentMasterPassword, newMasterPassword);
                SettingsProcessor.UpdateOnSettingNewMasterPassword(newMasterPasswordHash, newMasterSalt);
                MasterPassword = newMasterPassword;
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
                    case nameof(enteredCurrentMasterPassword):
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
