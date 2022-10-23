using System;
using System.Collections.Generic;
using System.Linq;

namespace SimplePM.Forms
{
    public partial class SettingsForm : ShadowedForm
    {
        private readonly ISettingsProcessor _settingsProcessor;
        private readonly Dictionary<string, AppTheme> _availableThemes = new();

        public SettingsForm(ISettingsProcessor settingsProcessor)
        {
            InitializeComponent();
            _settingsProcessor = settingsProcessor;
            _settingsProcessor.ThemeChanged += _settingsProcessor_ThemeChanged;
            _availableThemes = _settingsProcessor.GetAvailableThemesDict();
            FillThemesComboBox(_availableThemes.Keys.ToList());
            ApplyTheme(SettingsProcessor.GetCurrentTheme());
            startupCheckBox.Checked = Properties.Settings.Default.StartupWithOS;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (startupCheckBox.Checked != Properties.Settings.Default.StartupWithOS)
            {
                _settingsProcessor.SetStartup(startupCheckBox.Checked);
            }
            Close();
        }

        private void themesComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            _availableThemes.TryGetValue(themesComboBox.SelectedItem.ToString(), out AppTheme theme);
            _settingsProcessor.SetCurrentTheme(theme);
        }

        private void _settingsProcessor_ThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ApplyTheme(e.Theme);
        }
    }
}
