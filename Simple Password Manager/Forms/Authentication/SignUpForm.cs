using SimplePM.Library;
using SimplePM.Library.Diagnostics;
using SimplePM.Library.Factories;
using SimplePM.Library.Networking;
using System;
using System.Windows.Forms;

namespace SimplePM.Forms
{
    public partial class SignUpForm : ShadowedForm
    {
        private readonly IAccountClient client;
        private readonly string _caller;
        private readonly string _masterPassword;

        public SignUpForm(string caller, string masterPassword = null)
        {
            InitializeComponent();
            _caller = caller;
            client = AccountClientFactory.Create();
            _masterPassword = masterPassword;
            FormClosed += SignUpForm_FormClosed;
            ApplyTheme(SettingsProcessor.GetCurrentTheme());
            DialogResult = DialogResult.Cancel;
        }

        private async void confirmButton_Click(object sender, EventArgs e)
        {
            string enteredLogin = usernameTextBox.Texts;
            string enteredPassword = passwordTextBox.Texts;
            string passwordConfirmation = confirmPasswordTextBox.Texts;
            if (!enteredLogin.IsValidLogin())
            {
                illegalUsernameLabel.Visible = true;
                return;
            }
            else
            {
                illegalUsernameLabel.Visible = false;
            }
            try
            {
                if (!await client.CheckLoginAvailabilityAsync(enteredLogin))
                {
                    usernameNotAvailableLabel.Visible = true;
                    return;
                }
                else
                {
                    usernameNotAvailableLabel.Visible = false;
                }
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                MessageBox.Show($"Request cannot be completed: {ex.InnerException.Message}.",
                    $"{ex.StatusCode}: {ex.Message}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                switch (_caller)
                {
                    case nameof(FirstStartupForm):
                        StartupForm startupForm = new();
                        startupForm.Show();
                        Hide();
                        break;
                    case nameof(MainForm):
                        Close();
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Request cannot be completed: {ex.Message}.",
                    ex.GetType().ToString(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Logger.CreateExceptionEntry(ex);
                switch (_caller)
                {
                    case nameof(FirstStartupForm):
                        StartupForm _masterPassForm = new();
                        _masterPassForm.Show();
                        break;
                    case nameof(MainForm):
                        break;
                }
                Close();
            }
            if (!enteredPassword.IsValidPassword())
            {
                invalidPasswordLabel.Visible = true;
                return;
            }
            else
            {
                invalidPasswordLabel.Visible = false;
            }
            if (enteredPassword != passwordConfirmation)
            {
                passwordsNotMatchLabel.Visible = true;
                return;
            }
            else
            {
                passwordsNotMatchLabel.Visible = false;
            }
            try
            {
                switch (_caller)
                {
                    case nameof(FirstStartupForm):
                        StartupForm _masterPassForm = new(enteredLogin, enteredPassword);
                        _masterPassForm.Show();
                        break;
                    case nameof(MainForm):
                        if (_masterPassword is not null)
                        {
                            var (accountID, masterPasswordHash, masterSalt) = await client.RegisterAsync(enteredLogin,
                                enteredPassword,
                                _masterPassword);
                            SettingsProcessor.UpdateOnSignInOrUp(accountID, enteredLogin, masterPasswordHash, masterSalt);
                        }
                        break;
                }
                Close();
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                MessageBox.Show($"Request cannot be completed: {ex.InnerException.Message}.",
                    $"{ex.StatusCode}: {ex.Message}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Request cannot be completed: {ex.Message}.",
                    ex.GetType().ToString(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Logger.CreateExceptionEntry(ex);
                switch (_caller)
                {
                    case nameof(FirstStartupForm):
                        StartupForm _masterPassForm = new();
                        _masterPassForm.Show();
                        break;
                    case nameof(MainForm):
                        break;
                }
                Close();
            }
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_caller == nameof(FirstStartupForm))
            {
                Application.Exit();
            }
        }
    }
}
