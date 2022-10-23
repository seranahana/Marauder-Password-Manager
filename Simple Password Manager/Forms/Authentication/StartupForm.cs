using SimplePM.Library.Assets.Processors;
using SimplePM.Library.Diagnostics;
using SimplePM.Library.Factories;
using SimplePM.Library.Networking;
using Squirrel;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePM.Forms
{
    public partial class StartupForm : ShadowedForm
    {
        private readonly IAccountClient client;
        private readonly IEntriesProcessor entriesProcessor;
        private readonly string _login;
        private readonly string _password;
        private readonly bool isSigningUp = false;
        private readonly bool isSigningIn = false;

        // Constructor
        public StartupForm(string login = null, string password = null)
        {
            InitializeComponent();
            SetWindowHeader(SettingsProcessor.GetAppNameWithVersion());
            ApplyTheme(SettingsProcessor.GetCurrentTheme());
            SetLabels();
            _login = login;
            _password = password;
            if (_login is not null && _password is not null)
            {
                isSigningUp = true;
            }
            if (_password is not null && _login is null)
            {
                isSigningIn = true;
            }
            client = AccountClientFactory.Create();
            entriesProcessor = EntriesProcessorFactory.Create();
            Text = SettingsProcessor.GetAppNameWithVersion();
        }

        // Form Event Handlers
        private void MasterPassForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmButton_Click(this, null);
            }
        }

        private async void StartupForm_Load(object sender, EventArgs e)
        {
            try
            {
                await CheckForUpdates();
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                MessageBox.Show("Unable to check updates: Destination unreachable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.CreateExceptionEntry(ex);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Unable to check updates: No releases found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to check updates: {ex.GetType()} {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.CreateExceptionEntry(ex);
            }
        }

        // UI Elements Event Handlers
        private async void confirmButton_Click(object sender, EventArgs e)
        {
            string enteredMasterPassword = masterPasswordTextBox.Texts;
            if (string.IsNullOrWhiteSpace(enteredMasterPassword))
            {
                invalidPasswordLabel.Visible = true;
                return;
            }
            try
            {
                if (isSigningUp)
                {
                    await SignUpAsync(enteredMasterPassword);
                }
                else
                {
                    if (Properties.Settings.Default.IsReset || Properties.Settings.Default.IsFirstRun)
                    {
                        await SetNewMasterPasswordAsync(enteredMasterPassword);
                        if (Properties.Settings.Default.IsFirstRun)
                        {
                            Properties.Settings.Default.IsFirstRun = false;
                            Properties.Settings.Default.Save();
                        }
                    }
                    else
                    {
                        if (!await AuthenticateAsync(enteredMasterPassword))
                        {
                            return;
                        }
                    }
                }
                MainForm mainForm = new(client, entriesProcessor, enteredMasterPassword);
                mainForm.Show();
                Close();
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                MessageBox.Show($"Request cannot be completed: {ex.InnerException.Message}. Proceeding in standalone mode",
                    $"{ex.StatusCode}: {ex.Message}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()}: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.CreateExceptionEntry(ex);
            }
        }

        private void visibilityButton_Click(object sender, EventArgs e)
        {
            if (masterPasswordTextBox.PasswordChar)
            {
                masterPasswordTextBox.PasswordChar = false;
            }
            else
            {
                masterPasswordTextBox.PasswordChar = true;
            }
        }

        private void resetLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will erase all of your entries. Do you wish to proceed?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                IdentityConfirmationForm confirmIdentityForm = new(client, RequiringIdentificationOperation.ResetMasterPassword);
                if (confirmIdentityForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }

        // Private methods
        private async Task SignUpAsync(string enteredMasterPassword)
        {
            var (accountID, MasterPasswordHash, MasterSalt) = await client.RegisterAsync(_login, _password, enteredMasterPassword);
            SettingsProcessor.UpdateOnSignInOrUp(accountID, _login, MasterPasswordHash, MasterSalt);
        }

        private async Task SetNewMasterPasswordAsync(string newMasterPassword)
        {
            if (Properties.Settings.Default.IsSignedIn)
            {
                if (Properties.Settings.Default.IsStandalone)
                {
                    MessageBox.Show("Setting new master password is unavailable in standalone mode. Check internet connection and try again later",
                        "Restricted operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                var (masterPasswordHash, MasterSalt) = await client.SetNewMasterPasswordAsync(
                                Properties.Settings.Default.Username,
                                Properties.Settings.Default.OperationCode,
                                newMasterPassword);
                SettingsProcessor.UpdateOnSettingNewMasterPassword(masterPasswordHash, MasterSalt);
                return;
            }
            SettingsProcessor.UpdateOnSettingNewMasterPassword(newMasterPassword);
        }

        private async Task<bool> AuthenticateAsync(string enteredMasterPassword)
        {
            bool masterPasswordChanged = false;
            if ((!Properties.Settings.Default.IsStandalone) && Properties.Settings.Default.IsSignedIn)
            {
                masterPasswordChanged = await UpdateLocalMasterPasswordHash(enteredMasterPassword);
            }
            if (!SettingsProcessor.Authenticate(enteredMasterPassword))
            {
                incorrectPasswordLabel.Visible = true;
                return false;
            }
            if (isSigningIn && masterPasswordChanged)
            {
                entriesProcessor.ReencryptAll(_password, enteredMasterPassword);
            }
            return true;
        }

        private async Task<bool> UpdateLocalMasterPasswordHash(string enteredMasterPassword)
        {
            var (masterPasswordHash, masterSalt) = await client.GetMasterPasswordAsync(Properties.Settings.Default.Username);
            if (masterPasswordHash != Properties.Settings.Default.MasterPasswordHash)
            {
                SettingsProcessor.UpdateOnSettingNewMasterPassword(masterPasswordHash, masterSalt);
                return true;
            }
            return false;
        }

        private async Task CheckForUpdates()
        {
            using UpdateManager updateManager = await UpdateManager.GitHubUpdateManager(@"https://github.com/seranahana/Simple-Password-Manager");
            await updateManager.UpdateApp();
        }
    }
}
