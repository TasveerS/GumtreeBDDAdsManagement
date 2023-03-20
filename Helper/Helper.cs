using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumtreeAdsBDD.Helper
{
    public static class Helper
    {
        public static IWebDriver _driver { get; set; }

        public static void ScrollToMiddle()
        {
            IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0, 500);");
        }

        public static void ScrollToBottom()
        {
            IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
    }
}
