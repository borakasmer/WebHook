




using System.Web.Http;

namespace WebHook
{
    public static class WebHookConfig
    {
        public static void Register(HttpConfiguration config)
        {

			config.InitializeReceiveWordPressWebHooks();

        }
    }
}
