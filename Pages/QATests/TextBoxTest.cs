using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using VW_Training.Hooks;

namespace VW_Training.Pages.QATests
{

    public class TextBoxTest
    {

        public readonly Context _page;
        public TextBoxTest(Context context) => _page = context;

        private ILocator TabButton => _page.Page.Locator("text=Text Box");
        private ILocator Username => _page.Page.Locator("#userName");
        private ILocator UserEmail => _page.Page.Locator("#userEmail");
        private ILocator CurrAddress => _page.Page.Locator("#currentAddress");
        private ILocator PermAddress => _page.Page.Locator("#permanentAddress");
        private ILocator Submit => _page.Page.Locator("text=Submit");

        public async Task EnterTab() => TabButton.ClickAsync();
        
        public async Task Execution(string username, string email, string currentAddress, string permanentAddress) {

        }
    }
}