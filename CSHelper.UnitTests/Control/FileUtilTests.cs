using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSHelper.Control;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSHelper.UnitTests.Control
{
    [TestClass]
    public class FileUtilTests
    {
        FileUtil file;
        String city;
        List<String> exampleProfileList;

        [TestInitialize]
        public void before()
        {
            city = "Orhangazi";
            file = new FileUtil(city);
            file.deletePath();

            exampleProfileList = new List<string>{
            "https://www.couchsurfing.com/users/1005578050",
            "https://www.couchsurfing.com/users/1348206",
            "https://www.couchsurfing.com/users/841936",
            "https://www.couchsurfing.com/users/4925815"};
        }

        [TestMethod]
        public void checkFilesExistsTest()
        {
            file.checkFilesExists();

            Assert.IsTrue(Directory.Exists(file.getFolderName()));
            Assert.IsTrue(File.Exists(file.getWaitingPath()));
            Assert.IsTrue(File.Exists(file.getDonePath()));
            Assert.IsTrue(File.Exists(file.getErrorPath()));
        }

        [TestMethod]
        public void checkLinksExistTest()
        {
            file.checkFilesExists();

            List<String> waitingLinks = new List<string>{
            "https://www.couchsurfing.com/users/77655555",
            "https://www.couchsurfing.com/users/66664444"};

            File.WriteAllLines(file.getWaitingPath(), waitingLinks);

            List<String> doneLinks = new List<string>{
            "https://www.couchsurfing.com/users/12344444",
            "https://www.couchsurfing.com/users/55334211"};

            File.WriteAllLines(file.getDonePath(), doneLinks);

            List<String> errorLinks = new List<string>{
            "https://www.couchsurfing.com/users/45199002",
            "https://www.couchsurfing.com/users/33383888"};

            File.WriteAllLines(file.getErrorPath(), errorLinks);

            List<String> addingLinks = new List<string>{
            "https://www.couchsurfing.com/users/77655555",
            "https://www.couchsurfing.com/users/21312312",
            "https://www.couchsurfing.com/users/21312312",
            "https://www.couchsurfing.com/users/55334211",
            "https://www.couchsurfing.com/users/23121555",
            "https://www.couchsurfing.com/users/33383888"};

            List<String> actualLinks = file.checkLinksExist(addingLinks);

            List<String> expectingLinks = new List<string>{
            "https://www.couchsurfing.com/users/21312312",
            "https://www.couchsurfing.com/users/23121555"};

            CollectionAssert.Equals(expectingLinks, actualLinks);
        }

        [TestMethod]
        public void appendWaitingLinksTest()
        {
            file.checkFilesExists();

            file.appendWaitingLinks(exampleProfileList);
            file.appendWaitingLinks(new List<string>{
            "https://www.couchsurfing.com/users/2312312",
            "https://www.couchsurfing.com/users/4343434"});

            Assert.IsTrue(file.readWaitingLinks().Contains("https://www.couchsurfing.com/users/2312312"));
            Assert.IsTrue(file.readWaitingLinks().Contains(exampleProfileList[1]));
        }

        [TestMethod]
        public void writeResultTest()
        {
            file.checkFilesExists();

            //Pick random from example list for test
            String testProfile = exampleProfileList[1];

            //Check for Done Result
            File.WriteAllLines(file.getWaitingPath(), exampleProfileList);
            
            file.writeResult(testProfile, true);

            //Check If profile deleted in Waiting File
            Assert.IsFalse(file.readWaitingLinks().Contains(testProfile));

            //Check If profile moved to Done File
            Assert.IsTrue(file.readDoneLinks().Contains(testProfile));

            //Check for Error Result
            File.WriteAllLines(file.getWaitingPath(), exampleProfileList);

            file.writeResult(testProfile, false);

            //Check If profile deleted in Waiting File
            Assert.IsFalse(file.readWaitingLinks().Contains(testProfile));

            //Check If profile moved to Error File
            Assert.IsTrue(file.readErrorLinks().Contains(testProfile));

        }


        [TestMethod]
        public void saveInfoTest()
        {
            file.checkFilesExists();

            Dictionary<String, Object> post = new Dictionary<string, object>();
            post.Add("Arrival", DateTime.Now.ToString("yyyy-MM-dd"));
            post.Add("Departure", DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"));
            post.Add("AFlexible", true);
            post.Add("DFlexible", false);
            post.Add("Guests", 2);
            post.Add("Introduce", "Merhaba");
            post.Add("Message", "Demo try hoop hooop try try yqqop..\nLine2\nLine3".Replace("\n", Environment.NewLine));
            file.saveInfo(post);
        }


    }
}
