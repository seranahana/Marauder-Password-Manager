using System;
using System.Collections.Generic;

namespace SimplePM
{
    public interface ISettingsProcessor
    {
        event EventHandler<ThemeChangedEventArgs> ThemeChanged;

        void SetCurrentTheme(AppTheme theme);
        void SetStartup(bool enableOrDisableStartup);
        Dictionary<string, AppTheme> GetAvailableThemesDict();
    }
}
