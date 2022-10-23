using SimplePM.Factories;
using SimplePM.Library;
using SimplePM.Library.Assets.Processors;
using SimplePM.Library.Diagnostics;
using SimplePM.Library.Networking;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePM.Forms
{
    public partial class MainForm : ShadowedForm
    {
        #region --Fields--

        private string currentEntryID;
        private string _masterPassword;
        private readonly IEntriesProcessor _entriesProcessor;
        private readonly ISettingsProcessor settingsProcessor;
        private readonly IAccountClient _accountClient;

        #endregion

        // Constructor
        public MainForm(IAccountClient accountClient, IEntriesProcessor entriesProcessor, string masterPassword)
        {
            InitializeComponent();
            SetWindowHeader(SettingsProcessor.GetAppNameWithVersion());
            ApplyTheme(SettingsProcessor.GetCurrentTheme());
            settingsProcessor = SettingsProcessorFactory.Create();
            _accountClient = accountClient;
            _entriesProcessor = entriesProcessor;
            _masterPassword = masterPassword;
            settingsProcessor.ThemeChanged += settingsProcessor_ThemeChanged;
        }

        #region --Private Methods--

        private async Task PerformSync()
        {
            if ((!Properties.Settings.Default.IsStandalone) && Properties.Settings.Default.IsSignedIn)
            {
                try
                {
                    await _entriesProcessor.SynchronizeAsync(Properties.Settings.Default.AccountID);
                }
                catch (System.Net.Http.HttpRequestException ex)
                {
                    MessageBox.Show($"{ex.Message} Proceeding in standalone mode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (IncompleteSyncException ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.GetType()}: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.CreateExceptionEntry(ex);
                }
            }
        }

        #endregion

        #region --Notify Icon Click Event Handler--
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            UpdateEntriesPanel();
            ShowInTaskbar = true;
        }

        #endregion

        #region --Side Menu Buttons Event Handlers--

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            using WorkWithEntryForm workWithEntryForm = new(_entriesProcessor, _masterPassword);
            if (workWithEntryForm.ShowDialog() == DialogResult.OK)
            {
                UpdateEntriesPanel();
            }
        }

        private void generatePassButton_Click(object sender, EventArgs e)
        {
            PassGeneratorForm passGeneratorForm = new();
            passGeneratorForm.ShowDialog();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.IsStandalone)
            {
                UpdateAccountManageButtonsPanelsVisibility();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            using SettingsForm settingsForm = new(settingsProcessor);
            settingsForm.ShowDialog();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            minimizeButton.MouseEntered = false;
            minimizeButton.MousePressed = false;
            ShowInTaskbar = false;
        }

        #endregion

        #region --Buttons On Drop-down Menu Event Handlers--

        private void signInButton_Click(object sender, EventArgs e)
        {
            using IdentityConfirmationForm confirmIdentityForm = new(_accountClient, RequiringIdentificationOperation.SignIn);
            UpdateAccountManageButtonsPanelsVisibility();
            if (confirmIdentityForm.ShowDialog() == DialogResult.OK)
            {
                StartupForm startupForm = new(null, _masterPassword);
                startupForm.Show();
                Close();
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            using SignUpForm signUpForm = new(nameof(MainForm), _masterPassword);
            UpdateAccountManageButtonsPanelsVisibility();
            signUpForm.ShowDialog();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            using ChangePassForm changePassForm = new(_accountClient);
            UpdateAccountManageButtonsPanelsVisibility();
            changePassForm.ShowDialog();
        }

        private void changeMasterPasswordButton_Click(object sender, EventArgs e)
        {
            using ChangeMasterPassForm changeMasterPassForm = new(_accountClient, _entriesProcessor);
            UpdateAccountManageButtonsPanelsVisibility();
            if (changeMasterPassForm.ShowDialog() == DialogResult.OK)
            {
                _masterPassword = changeMasterPassForm.MasterPassword;
            }
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            SettingsProcessor.UpdateOnSignOut();
            UpdateAccountManageButtonsPanelsVisibility();
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            using IdentityConfirmationForm confirmIdentityForm = new(_accountClient, RequiringIdentificationOperation.DeleteUserAccount);
            UpdateAccountManageButtonsPanelsVisibility();
            confirmIdentityForm.ShowDialog();
        }

        #endregion

        #region --Entry-related Buttons Event Handlers--

        private void entryButton_Click(object sender, EventArgs e, string id)
        {
            try
            {
                var item = _entriesProcessor.Retrieve(id, _masterPassword);
                entryNameLabel.Text = item.Name;
                loginTextBox.Texts = item.Login;
                passwordTextBox.Texts = item.Password;
                currentEntryID = id;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()}: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.CreateExceptionEntry(ex);
            }
            loginLabel.Visible = true;
            passwordLabel.Visible = true;
            entryNameLabel.Visible = true;
            loginTextBox.Visible = true;
            passwordTextBox.Visible = true;
            passVisibilityButton.Visible = true;
        }

        private void editEntryButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(currentEntryID))
            {
                try
                {
                    var item = _entriesProcessor.Retrieve(currentEntryID, _masterPassword);
                    WorkWithEntryForm workWithEntryForm = new(_entriesProcessor, item, _masterPassword);
                    if (workWithEntryForm.ShowDialog() == DialogResult.OK)
                    {
                        UpdateEntriesPanel();
                        entryButton_Click(this, null, currentEntryID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.GetType()}: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            try
            {
                _entriesProcessor.Delete(currentEntryID);
                UpdateEntriesPanel();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"{ex.GetType()}: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passVisibilityButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar)
            {
                passwordTextBox.PasswordChar = false;
            }
            else
            {
                passwordTextBox.PasswordChar = true;
            }
        }

        #endregion

        #region --Theme Event Handlers--

        private void settingsProcessor_ThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ApplyTheme(e.Theme);
        }

        #endregion

        #region --Form Event Handlers--

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
            }
            else
            {
                notifyIcon1.Visible = false;
            }
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
