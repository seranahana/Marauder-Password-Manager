using Microsoft.Win32;
using SimplePM.Library.Cryptography;
using SimplePM.Themes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace SimplePM
{
    public sealed class SettingsProcessor : ISettingsProcessor
    {
        public event EventHandler<ThemeChangedEventArgs> ThemeChanged;

        private const string appName = "Marauder";
        private readonly RegistryKey registryKey;
        private static readonly Dictionary<AppTheme, Theme> themes = new()
        {
            { AppTheme.Cattleya, new Cattleya() },
            { AppTheme.Marauder, new Marauder() }
        };

        public SettingsProcessor()
        {
            registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        }

        internal static bool Authenticate(string enteredPassword)
        {
            string currentMasterPassword = Properties.Settings.Default.MasterPasswordHash;
            string masterSalt = Properties.Settings.Default.MasterSalt;
            var saltedhashedPassword = CryptographyProvider.SHA256.SaltAndHashPassword(enteredPassword, masterSalt);
            return (saltedhashedPassword == currentMasterPassword);
        }

        internal static string GetAppNameWithVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            return $"{appName} v.{versionInfo.FileVersion} beta";
        }

        internal static Theme GetCurrentTheme()
        {
            return themes.GetValueOrDefault((AppTheme)Properties.Settings.Default.CurrentTheme, new Marauder());
        }

        public Dictionary<string, AppTheme> GetAvailableThemesDict()
        {
            Dictionary<string, AppTheme> result = new();
            foreach (var theme in themes)
            {
                result.Add(theme.Value.Name, theme.Key);
            }
            return result;
        }

        public void SetCurrentTheme(AppTheme theme)
        {
            Properties.Settings.Default.CurrentTheme = (int)theme;
            Properties.Settings.Default.Save();
            ThemeChangedEventArgs args = new()
            {
                Theme = themes.GetValueOrDefault(theme, new Cattleya())
            };
            OnThemeChanged(args);
        }

        public void SetStartup(bool enableOrDisableStartup)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                if (enableOrDisableStartup)
                {
                    registryKey.SetValue(appName, Application.ExecutablePath);
                    return;
                }
                registryKey.DeleteValue(appName, false);
            }
        }

        internal static void UpdateOnSettingNewMasterPassword(string newMasterPassword, string masterSalt = null)
        {
            if (newMasterPassword is null)
            {
                return;
            }
            if (masterSalt is not null)
            {
                Properties.Settings.Default.MasterPasswordHash = newMasterPassword;
                Properties.Settings.Default.MasterSalt = masterSalt;
            }
            else
            {
                string salt = CryptographyProvider.SHA256.GenerateSalt();
                var saltedhashedPassword = CryptographyProvider.SHA256.SaltAndHashPassword(newMasterPassword, salt);
                Properties.Settings.Default.MasterPasswordHash = saltedhashedPassword;
                Properties.Settings.Default.MasterSalt = salt;
            }
            Properties.Settings.Default.IsReset = false;
            Properties.Settings.Default.Save();
        }

        internal static void UpdateOnSignInOrUp(string accountID, string login, string masterPasswordHash, string masterSalt)
        {
            Properties.Settings.Default.AccountID = accountID;
            Properties.Settings.Default.Username = login;
            Properties.Settings.Default.MasterPasswordHash = masterPasswordHash;
            Properties.Settings.Default.MasterSalt = masterSalt;
            Properties.Settings.Default.IsSignedIn = true;
            Properties.Settings.Default.Save();
        }

        internal static void UpdateOnSignOut()
        {
            Properties.Settings.Default.AccountID = null;
            Properties.Settings.Default.IsSignedIn = false;
            Properties.Settings.Default.Save();
        }

        internal static void UpdateOnReset(string username, string operationCode)
        {
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.OperationCode = operationCode;
            Properties.Settings.Default.MasterPasswordHash = string.Empty;
            Properties.Settings.Default.MasterSalt = string.Empty;
            Properties.Settings.Default.IsReset = true;
            Properties.Settings.Default.Save();
        }

        private void OnThemeChanged(ThemeChangedEventArgs e)
        {
            EventHandler<ThemeChangedEventArgs> handler = ThemeChanged;
            if (handler is not null)
            {
                handler(this, e);
            }
        }
    }
}

