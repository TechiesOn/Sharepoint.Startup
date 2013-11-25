using System;
using System.Web;
using System.Web.Caching;

namespace Sharepoint.Startup
{
    public class Application
    {
        const string KEY = "SHAREPOINT.STARTUP.APPLICATION.START.1234567890";

        public static void Start(Action action)
        {
            if (HttpRuntime.Cache[KEY] == null)
            {
                Insert();
                action();
            }
        }

        protected static void Insert()
        {
            var onCacheRemove = new CacheItemRemovedCallback(CacheItemRemoved);

            HttpRuntime.Cache.Insert(
                KEY,
                KEY,
                null,
                DateTime.UtcNow.AddDays(7),
                Cache.NoSlidingExpiration,
                CacheItemPriority.NotRemovable,
                onCacheRemove);
        }

        protected static void CacheItemRemoved(String k, object v, CacheItemRemovedReason r)
        {
            Insert();
        }
    }
}