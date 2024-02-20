using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Training.Pages.QATests;
using VW_Training.Hooks;
using VW_Training.Pages.QATests;

namespace Training.Steps
{
    [Binding]
    public class ButtonSteps
    {
        private readonly Context _page;
        private readonly ButtonTest _test;
	
        public ButtonSteps(Context context)
        {
            _page = context;
            _test = new ButtonTest(_page);
        }

        
        [When(@"I click the Buttons option in the Elements menu")]
        public async Task WhenIclicktheButtonsoptionintheElementsmenu()
        {
            await _test.ClickTab();
        }

        
        [When(@"I click the buttons")]
        public async Task WhenIclickthebuttons()
        {
            await _test.ClickButtons();
        }

        
        [Then(@"They return a message")]
        public async Task ThenTheyreturnamessage()
        {
            await _test.CheckMessages();
        }


    }
}