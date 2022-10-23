using SimplePM.Library.Factories;
using SimplePM.Library.Networking;
using System;

namespace SimplePM.Forms
{
    public partial class FirstStartupForm : ShadowedForm
    {
        private readonly IAccountClient client;

        public FirstStartupForm()
        {
            InitializeComponent();
            SetWindowHeader(SettingsProcessor.GetAppNameWithVersion());
            ApplyTheme(SettingsProcessor.GetCurrentTheme());
            client = AccountClientFactory.Create();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            IdentityConfirmationForm confirmIdentityForm = new(client, RequiringIdentificationOperation.FirstStartupSignIn);
            confirmIdentityForm.Show();
            Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new(nameof(FirstStartupForm));
            signUpForm.Show();
            Close();
        }
    }
}
