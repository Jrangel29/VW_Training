using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace VW_Training.Hooks
{
    public class Context
    {
        public IBrowserContext BrowserContext {get; set;}
        public IPage Page {get; set;}
    }
}