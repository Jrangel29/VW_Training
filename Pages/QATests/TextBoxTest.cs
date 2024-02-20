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
        private readonly ILocator _TabButton;
        private readonly ILocator _Username;
        private readonly ILocator _UserEmail;
        private readonly ILocator _CurrAddress;
        private readonly ILocator _PermAddress;
        private readonly ILocator _Submit;
        
        public TextBoxTest(Context context) {
            _page = context;
            _TabButton = _page.Page.Locator("text=Text Box");
            _Username = _page.Page.Locator("#userName");
            _UserEmail = _page.Page.Locator("#userEmail");
            _CurrAddress = _page.Page.Locator("#currentAddress");
            _PermAddress = _page.Page.Locator("#permanentAddress");
            _Submit = _page.Page.Locator("text=Submit");
        }

        
        public async Task EnterTab () => await _TabButton.ClickAsync();
        
        
        public async Task FillForm(string username, string email, string currentAddress, string permanentAddress) {
            await _Username.FillAsync(username);
            await _UserEmail.FillAsync(email);
            await _CurrAddress.FillAsync(currentAddress);
            await _PermAddress.FillAsync(permanentAddress);
        }

        public async Task SubmitForm() => await _Submit.ClickAsync();
    }
}