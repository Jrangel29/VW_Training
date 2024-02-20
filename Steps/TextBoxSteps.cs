using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using VW_Training.Hooks;
using VW_Training.Pages.QATests;

namespace Training.Steps
{
    [Binding]
    public class TextBoxSteps
    {
        
			private readonly Context _page;
            private readonly TextBoxTest _textBoxTest;
	
			public TextBoxSteps(Context context)
			{
				_page = context;
                _textBoxTest = new TextBoxTest(_page);
			}
			
            [When(@"I click Text Box in the Elements menu")]
            public async Task WhenIclickinthemenu()
            {
                await _textBoxTest.EnterTab();
            }

            
            [When(@"I fill the various fields with:")]
            public async Task WhenIfillthevariousfieldswith()
            {
                await _textBoxTest.FillForm("Test Dummy", "testdummy@gmail.com", "Current Road, 124", "Permanent Road, 253");
            }


            [When(@"Press the Submit button")]
            public async Task WhenPressthebutton()
            {
                await _textBoxTest.SubmitForm();
            }

	
    }
}