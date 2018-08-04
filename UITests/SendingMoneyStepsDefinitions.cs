using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace UITests
{
    [Binding]
    public class StepDefinitions
    {
        IApp app;

        [BeforeScenario]
        public void BeforeEachScenario()
        {
            app = FeatureContext.Current.Get<IApp>("App");
        }

        [Given(@"I have a different local currency than my friend")]
        public void GivenIHaveADifferentLocalCurrencyThanMyFriend()
        {
            app.Tap(x => x.Marked("EUR"));
            app.Screenshot("Tapped on view with class: UILabel marked: EUR");

            app.Tap(x => x.Marked("GBP"));
            app.Screenshot("Tapped on view with class: UILabel marked: GBP");
        }

        [When(@"I make a tranfer")]
        public void WhenIMakeATranfer()
        {
            app.Tap(x => x.Class("UITextField"));
            app.Screenshot("Tapped on view with class: UITextField");

            app.EnterText(x => x.Class("UITextField"), "25");
            app.PressEnter();

            app.Tap(x => x.Marked("CONFIRM"));
            app.Screenshot("Tapped on view with class: UIButton marked: CONFIRM");
        }

        [Then(@"my friend should receive money in his local currency")]
        public void ThenMyFriendShouldReceiveMoneyInHisLocalCurrency()
        {
            app.WaitForElement("Done!");
            app.Screenshot("Done message appeared on screen");
        }
    }
}