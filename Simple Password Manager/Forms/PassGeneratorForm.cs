using SimplePM.Library;
using SimplePM.Library.Factories;
using System;

namespace SimplePM.Forms
{
    public partial class PassGeneratorForm : ShadowedForm
    {
        private readonly IPasswordGenerator _passwordGenerator;

        public PassGeneratorForm()
        {
            InitializeComponent();
            ApplyTheme(SettingsProcessor.GetCurrentTheme());
            FillComboBox();
            _passwordGenerator = PasswordGeneratorFactory.Create();
            lengthComboBox.SelectedIndex = 8;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lengthComboBox.SelectedItem.ToString(), out int value))
            {
                generatedPassTextBox.Texts = _passwordGenerator.Generate(value);
            }
        }
    }
}
