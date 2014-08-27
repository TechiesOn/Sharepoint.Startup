using System;

namespace Sharepoint.Startup
{
    public class Application
    {
        public static void Start(Action action)
        {
            if (StaticHelper.RunAction())
            {
                action();
            }
        }
    }
}