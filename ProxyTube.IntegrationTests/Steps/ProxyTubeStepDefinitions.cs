using TechTalk.SpecFlow;

namespace ProxyTube.IntegrationTests.Steps
{
    [Binding]
    public class ProxyTubeStepDefinitions
    {
        [Given(@"I have entered a youtube id")]
        public void GivenIHaveEnteredAYoutubeId()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be downloading youtube id on my screen")]
        public void ThenTheResultShouldBeDownloadingYoutubeIdOnMyScreen()
        {
            ScenarioContext.Current.Pending();
        }
    }
}