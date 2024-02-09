using System.ComponentModel.DataAnnotations;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Textbox;
using Buttonclick;

namespace Training;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task RunTests()
    {
        //using elimina a instancia de playwright quando acaba
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{
            Headless = false
        });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://demoqa.com/");
        await page.ClickAsync("text=Elements");
        
        //TextBox Tests
        TextBox textboxTest = new TextBox(page);
        await textboxTest.ClickTab();
        await textboxTest.FillFields("Jose Maria", "maria@gmail.com", "rua do teste, 444", "teste da rua, 333"); 

        //Button Tests
        ButtonClick buttonClickTest = new ButtonClick(page);
        await buttonClickTest.ClickTab();
        await buttonClickTest.ClickButtons();
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
}