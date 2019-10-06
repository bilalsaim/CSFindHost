using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CSHelper.Control
{

    public class CS
    {
        private IWebDriver driver;

        public FileUtil file;

        public CS(IWebDriver dri, FileUtil fl)
        {
            this.driver = dri;
            file = fl;
        }

        public void login(String user, String pass)
        {
            driver.Navigate().GoToUrl("https://www.couchsurfing.com/users/sign_in?cs_new_fe=true");

            Util.wait(2);
            IWebElement query = driver.FindElement(By.Id("user_login"));
            query.SendKeys(user);
            //Util.wait(5);
            //query = driver.FindElement(By.Id("user_password"));
            //query.SendKeys(pass);
            //query.SendKeys(OpenQA.Selenium.Keys.Enter);
        }

        public void postPaste(Dictionary<String, Object> post)
        {
            IWebElement query = driver.FindElement(By.Id("arrival"));
            query.Clear();
            query.SendKeys(post["Arrival"].ToString());

            query = driver.FindElement(By.Id("departure"));
            query.Clear();
            query.SendKeys(post["Departure"].ToString());

            if (Convert.ToBoolean(post["AFlexible"]))
            {
                query = driver.FindElement(By.Id("arrival_flexible"));
                query.Click();
            }

            if (Convert.ToBoolean(post["DFlexible"]))
            {
                query = driver.FindElement(By.Id("departure_flexible"));
                query.Click();
            }

            if (Convert.ToInt16(post["Guests"]) != 1)
            {
                query = driver.FindElement(By.Id("number_of_guests"));
                query.SendKeys(post["Guests"].ToString());
            }

            try
            {
                String value = driver.FindElements(By.ClassName("profile-sidebar__username-link"))[1].Text;
                string[] name = value.Split(' ');
                query = driver.FindElement(By.Id("body"));
                query.SendKeys(post["Introduce"].ToString() + " " + name[0] + ",\n" + post["Message"].ToString());
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public IEnumerable<String> getProfiles()
        {
            List<String> links = new List<string>();
            List<String> plinks;

            while (true)
            {
                try
                {
                    /*
                    IList<IWebElement> elements = container.FindElements(By.XPath("//*[@class='card mod-user']/[@class='card-image mod-small']/a"));
                    IList<IWebElement> elements = driver.FindElements(By.XPath("//a[@class='user-card__profile-link']"));
                    IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                    if (js != null)
                    {
                        string innerHtml = (string)js.ExecuteScript("return arguments[0].innerHTML;", elements);
                        File.WriteAllText("Log.txt", innerHtml);
                        break;
                    }*/


                    Util.wait(5);

                    var elements = driver.FindElements(By.ClassName("user-card__profile-link"));

                    String[] newlink = new String[elements.Count];

                    for (int i = 0; i < elements.Count; i++)
                    {
                        newlink[i] = elements[i].GetAttribute("href");
                    }

                    for (int i = 0; i < newlink.Length; i++)
                        if (!links.Contains(newlink[i]))
                            links.Add(newlink[i]);

                }
                catch
                {
                    MessageBox.Show("I couldn't select profiles!");
                }

                try
                {
                    Util.wait(2);
                    IWebElement query = driver.FindElement(By.ClassName("mod-next"));
                    query.Click();
                    Util.wait(4);
                }
                catch
                {
                    break;
                }
            }

            file.checkFilesExists();

            if (links.Count != 0)
            {
                plinks = file.checkLinksExist(links);
                file.appendWaitingLinks(plinks);
            }

            return file.readWaitingLinks();
        }

        public void postSend()
        {
            try
            {
                ReadOnlyCollection<IWebElement> query = driver.FindElements(By.ClassName("form-action"));
                query[1].Click();
            }
            catch
            {
                //MessageBox.Show("Hata!");
            }
        }

        public void nextProfile(string profile)
        {
            driver.Navigate().GoToUrl(profile);
        }

        public bool requestClick()
        {
            try
            {
                ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.CssSelector(".js-send-request"));
                elements[0].Click();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool automaticSend(String profile, Dictionary<string, object> post, int waitingNextProfile)
        {
            try
            {
                NavigateWait(profile, "header");
                Util.wait(2);
                bool result = requestClick();
                Util.wait(4);
                postPaste(post);
                Util.wait(6);
                postSend();
                Util.wait(3);
                file.writeResult(profile, result);
                Util.wait(waitingNextProfile);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void quit()
        {
            driver.Quit();
        }

        public void NavigateWait(string website, string id)
        {
            while (true)
            {
                try
                {
                    driver.Navigate().GoToUrl(website);

                    try { driver.SwitchTo().Alert().Accept(); }
                    catch { }

                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName(id)));
                    // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                    //IWebElement element = wait.Until(driver => driver.FindElement(By.Id(id)));
                    break;
                }
                catch (NoSuchElementException)
                {
                    Util.wait(5);
                }
                catch
                {
                    Util.wait(5);
                }
            }
            //catch(UnhandledAlertException)
        }
    }
}
