using System.ComponentModel.DataAnnotations;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace Training;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task TextBoxTest()
    {
        //using elimina a instancia de playwright quando acaba
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{
            Headless = false
        });
        var page = await browser.NewPageAsync();
        //Preciso usar estes awaits todos?
        await page.GotoAsync("https://demoqa.com/");
        await page.ClickAsync("text=Elements");
        await page.ClickAsync("text=Text Box");
        await page.FillAsync("#userName", "Jose Maria");
        await page.FillAsync("#userEmail", "maria@gmail.com");
        await page.FillAsync("#currentAddress", "rua do teste, 444");
        await page.FillAsync("#permanentAddress", "teste da rua, 333"); 
        await page.ClickAsync("text=Submit");
    }

    [Test]
    public async Task RadioButtonTest()
    {
        //using elimina a instancia de playwright quando acaba
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{
            Headless = false
        });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://demoqa.com/");
        await page.ClickAsync("text=Elements");
        await page.ClickAsync("text=Radio Button");
        await page.GetByLabel("Yes").CheckAsync();
    }

    [Test]
    public async Task ButtonsTest()
    {
        //using elimina a instancia de playwright quando acaba
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{
            Headless = false
        });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://demoqa.com/");
        await page.ClickAsync("text=Elements");
        await page.ClickAsync("text=Buttons");
        await page.DblClickAsync("#doubleClickBtn");
        await page.IsVisibleAsync("#doubleClickMessage");
        await page.GetByText("Right Click Me").ClickAsync(new() { Button = MouseButton.Right });
        await page.IsVisibleAsync("#rightClickMessage");
        await page.GetByText("Click Me", new() { Exact = true }).ClickAsync();
        await page.IsVisibleAsync("#dynamicClickMessage");
    }
}