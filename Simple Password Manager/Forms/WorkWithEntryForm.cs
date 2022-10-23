using SimplePM.Library.Assets.Processors;
using SimplePM.Library.Models;
using System;
using System.Windows.Forms;

namespace SimplePM.Forms
{
    public partial class WorkWithEntryForm : ShadowedForm
    {
        private readonly bool asEditor = false;
        private readonly Entry _entryToEdit;
        private readonly string _masterPassword;
        private readonly IEntriesProcessor _processor;

        public WorkWithEntryForm(IEntriesProcessor processor, string masterPassword)
        {
            InitializeComponent();
            ApplyTheme(SettingsProcessor.GetCurrentTheme());
            _processor = processor;
            _masterPassword = masterPassword;
            asEditor = false;
            DialogResult = DialogResult.Cancel;
        }
        public WorkWithEntryForm(IEntriesProcessor processor, Entry entryToEdit, string masterPassword)
        {
            InitializeComponent();
            addEntryButton.Text = "Confirm";
            nameTextBox.Texts = entryToEdit.Name;
            urlTextBox.Texts = entryToEdit.URL;
            usernameTextBox.Texts = entryToEdit.Login;
            passwordTextBox.Texts = entryToEdit.Password;
            Text = "Edit entry";
            _processor = processor;
            _entryToEdit = entryToEdit;
            _masterPassword = masterPassword;
            asEditor = true;
            DialogResult = DialogResult.Cancel;
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Texts;
            string url = urlTextBox.Texts;
            string login = usernameTextBox.Texts;
            string password = passwordTextBox.Texts;
            try
            {
                if (asEditor)
                {
                    _processor.Update(_entryToEdit.ID, name, url, login, password, _masterPassword);
                }
                else
                {
                    _processor.Create(name, url, login, password, _masterPassword);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.GetType()}: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"{ex.GetType()}: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
