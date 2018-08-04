using System;
using NUnit.Framework;
using Xamarin.UITest;
using TechTalk.SpecFlow;

namespace UITests
{
    [TestFixture (Platform.iOS)]
    public partial class SendingLocalCurrencyFeature
    {
        IApp app;
        Platform platform;

        public SendingLocalCurrencyFeature(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
            FeatureContext.Current.Add ("App", app);
        }
    }
}

