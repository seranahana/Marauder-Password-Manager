using SimplePM.Library.Diagnostics;
using SimplePM.Library.Networking;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePM.Forms
{
    public partial class IdentityConfirmationForm : ShadowedForm
    {
        private readonly RequiringIdentificationOperation _operation;
        private readonly IAccountClient _client;

        public IdentityConfirmationForm(IAccountClient client, RequiringIdentificationOperation operation)
        {
            InitializeComponent();
            _operation = operation;
            _client = client;
            ApplyTheme(SettingsProcessor.GetCurrentTheme());
            DialogResult = DialogResult.Cancel;
        }

        private async void confirmButton_Click(object sender, EventArgs e)
        {
            string enteredLogin = loginTextBox.Texts;
            string enteredPassword = passwordTextBox.Texts;
            if (string.IsNullOrWhiteSpace(enteredLogin))
            {
                loginEmptyLabel.Visible = true;
                return;
            }
            else
            {
                loginEmptyLabel.Visible = false;
            }
            if (string.IsNullOrWhiteSpace(enteredPassword))
            {
                passwordEmptyLabel.Visible = true;
                return;
            }
            else
            {
                passwordEmptyLabel.Visible = false;
            }
            try
            {
                switch (_operation)
                {
                    case RequiringIdentificationOperation.DeleteUserAccount:
                        await _client.DeleteAsync(enteredLogin, enteredPassword);
                        SettingsProcessor.UpdateOnSignOut();
                        break;
                    case RequiringIdentificationOperation.FirstStartupSignIn:
                        await AuthenticateAsync(enteredLogin, enteredPassword);
                        StartupForm startupForm = new(enteredLogin);
                        startupForm.Show();
                        break;
                    case RequiringIdentificationOperation.ResetMasterPassword:
                        string operationCode = await _client.ResetMasterPasswordAsync(enteredLogin, enteredPassword);
                        SettingsProcessor.UpdateOnReset(enteredLogin, operationCode);
                        break;
                    case RequiringIdentificationOperation.SignIn:
                        await AuthenticateAsync(enteredLogin, enteredPassword);
                        break;
                    
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                switch (ex.ParamName)
                {
                    case nameof(enteredLogin):
                        loginNotFoundLabel.Visible = true;
                        break;
                    case nameof(enteredPassword):
                        invalidPasswordLabel.Visible = true;
                        break;
                    default:
                        MessageBox.Show($"Request cannot be completed. {ex.Message}.", 
                            ex.GetType().ToString(), 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                        Logger.CreateExceptionEntry(ex);
                        break;
                }
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                MessageBox.Show($"Request cannot be completed. {ex.Message}.",
                    ex.GetType().ToString(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Request cannot be completed. {ex.Message}.",
                    ex.GetType().ToString(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Logger.CreateExceptionEntry(ex);
                Close();
            }
        }

        private async Task AuthenticateAsync(string login, string password)
        {
            var (Id, masterPasswordHash, masterSalt) = await _client.AuthenticateAsync(login, password);
            SettingsProcessor.UpdateOnSignInOrUp(Id, login, masterPasswordHash, masterSalt);
        }
    }
}
