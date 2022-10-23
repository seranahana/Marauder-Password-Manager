namespace SimplePM
{
    public enum RequiringIdentificationOperation
    {
        DeleteUserAccount,
        FirstStartupSignIn,
        ResetMasterPassword,
        SignIn
    }

    public enum LabelType
    {
        Standart,
        Large,
        Small,
        Header
    }

    public enum fStyle
    {
        Telegram
    }

    public enum AppTheme
    {
        Cattleya,
        Marauder
    }

    enum BorderHoverPositionEnum
    {
        None, // Не наведен
        Left, Top, Right, Bottom, // Стороны
        TopLeft, TopRight, BottomLeft, BottomRight // Углы
    }
}
