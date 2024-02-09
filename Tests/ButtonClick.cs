using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Microsoft.Playwright;

namespace Buttonclick;

public class ButtonClick {
    private readonly IPage _page;
    private readonly ILocator _ButtonClickTab;
    private readonly ILocator _DoubleClickButton;
    private readonly ILocator _RightClickButton;
    private readonly ILocator _DynamicClickButton;
    private readonly ILocator _DoubleClickMessage;
    private readonly ILocator _RightClickMessage;
    private readonly ILocator _DynamicClickMessage;

    public ButtonClick(IPage page) {
        _page = page;
        _ButtonClickTab = _page.Locator("text=Buttons");
        
        _DoubleClickButton = _page.Locator("#doubleClickBtn");
        _DoubleClickMessage = _page.Locator("#doubleClickMessage");

        _RightClickButton = _page.Locator("text=Right Click Me");
        _RightClickMessage = _page.Locator("#rightClickMessage");  

        _DynamicClickButton = _page.GetByText("Click Me", new() { Exact = true });  
        _DynamicClickMessage = _page.Locator("#dynamicClickMessage");
    }

    public async Task ClickTab() => await _ButtonClickTab.ClickAsync();

    public async Task ClickButtons() {
        await _DoubleClickButton.DblClickAsync();
        await _DoubleClickMessage.IsVisibleAsync();
        await _RightClickButton.ClickAsync(new() { Button = MouseButton.Right });
        await _RightClickMessage.IsVisibleAsync();
        await _DynamicClickButton.ClickAsync();
        await _DynamicClickMessage.IsVisibleAsync();
    }
}