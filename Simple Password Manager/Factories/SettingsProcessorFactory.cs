namespace SimplePM.Factories
{
    internal static class SettingsProcessorFactory
    {
        internal static ISettingsProcessor Create()
        {
            return new SettingsProcessor();
        }
    }
}
