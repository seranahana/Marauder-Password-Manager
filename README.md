# Marauder
Marauder (ex. Simple Password Manager) v0.4.1 beta is an open-source password manager.

Main features:
 - Stores login data (eg. name/url/login/password) in encrypted form using AES algorithm (master password is used as a key), allowing to add, edit and delete them.
 - Allows to create and manage your own account to syncronize entries between clients.
 - Build-in password generator, which can generate reliable password ("reliable" means that password will include at least one uppercase letter, one lowercase letter, one numberic and one special symbol) with specified length.
 - User interface themes.
 - Auto-start with Windows.
 
 Interface language: English.
 
 Installation: Download and run Setup.exe, further application will automaticly scan for updates on Github (shows a message if any release marked as "lastest" won't be found).
 
 To add your own themes simply create a class which inherits from Theme base class, and contains implementation of all abstract classes named Base*ControlName*Style.
 Then add a name of your new theme to AppTheme enum and add new entry into Dictionary named themes in SettingsProcessor class.
