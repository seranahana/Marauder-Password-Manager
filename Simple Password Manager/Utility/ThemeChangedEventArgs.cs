using SimplePM.Themes;
using System;

namespace SimplePM
{
    public class ThemeChangedEventArgs : EventArgs
    {
        public Theme Theme { get; set; }
    }
}
