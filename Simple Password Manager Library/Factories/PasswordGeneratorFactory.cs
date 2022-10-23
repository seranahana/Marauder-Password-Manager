namespace SimplePM.Library.Factories
{
    public static class PasswordGeneratorFactory
    {
        public static IPasswordGenerator Create()
        {
            return new PasswordGenerator();
        }
    }
}
