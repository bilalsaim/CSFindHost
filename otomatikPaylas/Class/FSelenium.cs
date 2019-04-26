using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomatikPaylas.Class
{
    class FSelenium
    {
        public void openAcount(string em, string pa)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(15));

            //Notice navigation is slightly different than the Java version
            //This is because 'get' is a keyword in C#

            WaitForElementToNotExist("page", "https://m.facebook.com/", driver);

            IWebElement query = driver.FindElement(By.Name("email"));
            query.SendKeys(em);
            query = driver.FindElement(By.Name("pass"));
            query.SendKeys(pa);
            query.SendKeys(OpenQA.Selenium.Keys.Return);

            WaitForElementToNotExist("feed_jewel", "", driver);


            WaitForElementToNotExist("page", "https://www.facebook.org/browsegroups/?category=membership", driver);

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //string title = (string)js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight");
            for (int i = 0; i < 1; i++)
            {
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                wait(1);
            }

            string html = driver.PageSource;
            string wo = "href=\"/groups/";

            int f1, f2;
            ArrayList groups = new ArrayList();
            while (true)
            {
                if (html.Contains(wo))
                    f1 = html.IndexOf(wo);
                else
                    break;

                string temp = html.Substring(f1, 120);
                f2 = temp.IndexOf("\"", 15);

                string group = temp.Substring(14, f2 - 14);
                //if (group.Contains("?ref= browser"))
                groups.Add(group);

                html = html.Substring(f1 + 14);
            }

            foreach (string g in groups)
            {
                WaitForElementToNotExist("page", "https://www.facebook.com/groups/" + g, driver);
                wait(1);
            }

            driver.Quit();
        }

        public static void wait(int sec)
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(sec) > DateTime.Now);
        }

        public static void WaitForElementToNotExist(string ID, string URL, IWebDriver driver)
        {
            if (URL != "")
                driver.Navigate().GoToUrl(URL);
            int i = 0;
            while (true)
            {
                try
                {
                    /*
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                    wait.Until<bool>((d) =>
                    {
                        try
                        {
                            // If the find succeeds, the element exists, and
                            // we want the element to *not* exist, so we want
                            // to return true when the find throws an exception.
                            IWebElement element = d.FindElement(By.Id(ID));
                            return false;
                        }
                        catch (NoSuchElementException)
                        {
                            if (URL != "")
                                driver.Navigate().GoToUrl(URL);
                            return true;
                        }
                    });
                    */
                    break;
                }
                catch
                {
                    i++;
                    if (i == 10)
                        break;
                }
            }

        }
    }
}
