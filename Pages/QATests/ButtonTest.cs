using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Playwright;
using VW_Training.Hooks;

namespace Training.Pages.QATests
{
    public class ButtonTest
    {
        private readonly Context _page;
        private readonly ILocator _ButtonClickTab;
        private readonly ILocator _DoubleClickButton;
        private readonly ILocator _RightClickButton;
        private readonly ILocator _DynamicClickButton;
        private readonly ILocator _DoubleClickMessage;
        private readonly ILocator _RightClickMessage;
        private readonly ILocator _DynamicClickMessage;

        public ButtonTest(Context context) {
            _page = context;
            _ButtonClickTab = _page.Page.Locator("text=Buttons");
            
            _DoubleClickButton = _page.Page.Locator("#doubleClickBtn");
            _DoubleClickMessage = _page.Page.Locator("#doubleClickMessage");

            _RightClickButton = _page.Page.Locator("text=Right Click Me");
            _RightClickMessage = _page.Page.Locator("#rightClickMessage");  

            _DynamicClickButton = _page.Page.GetByText("Click Me", new() { Exact = true });  
            _DynamicClickMessage = _page.Page.Locator("#dynamicClickMessage");
        }

        public async Task ClickTab() => await _ButtonClickTab.ClickAsync();

        public async Task ClickButtons() {
            await _DoubleClickButton.DblClickAsync();
            await _RightClickButton.ClickAsync(new() { Button = MouseButton.Right });
            await _DynamicClickButton.ClickAsync();
        }

        public async Task CheckMessages() {
            await _DoubleClickMessage.IsVisibleAsync();
            await _RightClickMessage.IsVisibleAsync();
            await _DynamicClickMessage.IsVisibleAsync();
        }
    }
}