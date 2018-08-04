using Xamarin.UITest;

namespace UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile ("../../Binaries/money_sending_app-Signed.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .AppBundle ("../../Binaries/MoneySendingApp.iOS.app")
                .StartApp();
        }
    }
}

