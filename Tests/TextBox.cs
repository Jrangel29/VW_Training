using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Microsoft.Playwright;

namespace Textbox;

public class TextBox {
    private readonly IPage _page;
    private readonly ILocator _TextBoxButton;
    private readonly ILocator _Username;
    private readonly ILocator _UserEmail;
    private readonly ILocator _CurrentAdress;
    private readonly ILocator _PermanentAdress;
    private readonly ILocator _SubmitButton;

    public TextBox(IPage page) {
        _page = page;
        _TextBoxButton = _page.Locator("text=Text Box");
        _Username = _page.Locator("#userName");
        _UserEmail = _page.Locator("#userEmail");
        _CurrentAdress = _page.Locator("#currentAddress");
        _PermanentAdress = _page.Locator("#permanentAddress");
        _SubmitButton = _page.Locator("text=Submit");        
    }

    public async Task ClickTab() => await _TextBoxButton.ClickAsync();

    public async Task FillFields(string username, string email, string currAddres, string permaAdress) {
        await _Username.FillAsync(username);
        await _UserEmail.FillAsync(email);
        await _CurrentAdress.FillAsync(currAddres);
        await _PermanentAdress.FillAsync(permaAdress);
        await _SubmitButton.ClickAsync();
    }

}