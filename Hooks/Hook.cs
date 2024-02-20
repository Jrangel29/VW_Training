using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using TechTalk.SpecFlow;
using VW_Training.Hooks;

namespace Hook;

[Binding]
public class Hooks {
    public readonly Context _context;

    public Hooks(Context context) => _context = context;

    [STAThread]
    static void Main()
    {
    } 

    [BeforeTestRun]
    public static void InstallBrowsers() {
        var exitCode = Microsoft.Playwright.Program.Main(new[] {"install"});
        if (exitCode != 0){
            throw new Exception($"Playwright exited with code {exitCode}");
        }
    }

    [BeforeScenario]
    public async Task Init() {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{
            Headless = false
        });
        _context.Page = await browser.NewPageAsync();
        await _context.Page.GotoAsync("https://demoqa.com/");
        await _context.Page.ClickAsync("text=Elements");
    }

    [AfterScenario]
    public async Task AfterScenario() {
        await _context.Page.CloseAsync();
    }

}