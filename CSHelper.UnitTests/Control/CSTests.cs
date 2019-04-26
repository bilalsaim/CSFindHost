using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSHelper.Control;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;

namespace CSHelper.UnitTests
{
    [TestClass]
    public class CSTests
    {
        /* TESTED CASES:
         * Selenium.WebDriver 3.8.0
         * Selenium.WebDriver.GeckoDriver.Win64 0.19.1
         * Selenium.Firefox.WebDriver 0.19.1
         * Firefox 56.0 Win86
         * NOTE: If doesn't work properly, Update all of them with lastest version
         */

        IWebDriver driver;
        CS cs;
        String city;
        String testRequestProfile;

        [TestInitialize]
        public void before()
        {
            city = "Bursa";
            testRequestProfile = "https://www.couchsurfing.com/people/bilalsaim";

            FirefoxOptions options = new FirefoxOptions();
            driver = new FirefoxDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
        }

        [TestMethod]
        public void seleniumTest()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Assert.AreEqual("Google", driver.Title);
        }

        [TestMethod]
        public void loginTest()
        {
            cs = new CS(driver, city);
            cs.login("zeynep_unal_14@hotmail.com","123123az");
        }

        [TestMethod]
        public void getProfilesTest()
        {
            loginTest();
            //Search Host in Krakow
            Util.wait(5);
            driver.Navigate().GoToUrl("https://www.couchsurfing.com/members/hosts?utf8=%E2%9C%93&search_query=ChIJ0RhONcBEFkcRv4pHdrW2a7Q&placeid=&latitude=37.7749295&longitude=-122.4194155&country=&region=&city=San+Francisco&date_modal_dismissed=true&arrival_date=&departure_date=&num_guests=1&has_references=1&can_host%5Baccepting_guests%5D=1&last_login=2&join_date=0&gender=0&min_age=&max_age=&languages_spoken=&interests=&smoking=0&radius=5&keyword=&host_sort=0&button=");
            cs.getProfiles();
        }

        [TestMethod]
        public void automaticSendTest()
        {
            loginTest();
            Util.wait(5);

            Dictionary<String, Object> post = new Dictionary<string, object>();
            post.Add("Arrival", DateTime.Now.ToString("yyyy-MM-dd"));
            post.Add("Departure", DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"));
            post.Add("AFlexible", true);
            post.Add("DFlexible", false);
            post.Add("Guests", 2);
            post.Add("Introduce", "Merhaba");
            post.Add("Message", "Demo try hoop hooop try try yop..");

            cs.automaticSend(testRequestProfile, post, 5);
        }



        [TestCleanup]
        public void after()
        {
            driver.Quit();
        }

    }
}
