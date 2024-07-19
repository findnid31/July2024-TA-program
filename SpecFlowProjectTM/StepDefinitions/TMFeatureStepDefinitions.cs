using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTM.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions
    {
        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I create a time record")]
        public void WhenICreateATimeRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
