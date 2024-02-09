using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Microsoft.Playwright;

namespace RadioButton;

public class RadioButton {
    private readonly IPage _page;
    private readonly ILocator _RadioTabButton;

    public RadioButton(IPage page) {
        _page = page;
        _RadioTabButton = _page.Locator("text=Radio Button");    
    }

    public async Task ClickTab() => await _RadioTabButton.ClickAsync();

}