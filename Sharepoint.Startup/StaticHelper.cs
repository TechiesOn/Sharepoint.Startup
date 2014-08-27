namespace Sharepoint.Startup
{
    internal static class StaticHelper
    {
        private static int Count;

        static StaticHelper()
        {
            Count = 0;
        }

        public static bool RunAction()
        {
            Count++;

            return Count == 1;
        }
    }
}
