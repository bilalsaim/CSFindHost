using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace CSHelper.Control
{
    public class FileUtil
    {
        private Dictionary<String,String> paths;
        //w: waiting, d: done, e: error, i: info
        private String[] suffixes = new String[4] {"w","d","e","i"};

        private String folderName = "Profiles";

        public FileUtil(String city)
        {
            setPaths(city);
        }

        public void setPaths(string city)
        {
            paths = new Dictionary<String, String>();
            foreach (String s in suffixes)
                paths.Add(s, setPath(city, s));

            checkFilesExists();
        }

        public void saveInfo(Dictionary<string, object> post)
        {
            List<String> infos = new List<String>();
            foreach(KeyValuePair<String,Object> ob in post)
            {
                infos.Add(ob.Value.ToString().Replace("\n", System.Environment.NewLine));
            }

            File.WriteAllLines(getInfoPath(), infos);
        }

        public Dictionary<String, Object> getInfos()
        {
            String[] infos = File.ReadAllLines(getInfoPath());

            Dictionary<String, Object> post = new Dictionary<string, object>();

            if (infos.Length < 7)
            {
                post.Add("Arrival", DateTime.Today);
                post.Add("Departure", DateTime.Today.AddDays(1));
                post.Add("AFlexible", false);
                post.Add("DFlexible", false);
                post.Add("Guests", 1);
                post.Add("Introduce", "Hello");
                post.Add("Message", "");
            }
            else
            {
                post.Add("Arrival", infos[0]);
                post.Add("Departure", infos[1]);
                post.Add("AFlexible", Convert.ToBoolean(infos[2]));
                post.Add("DFlexible", Convert.ToBoolean(infos[3]));
                post.Add("Guests", Convert.ToInt16(infos[4]));
                post.Add("Introduce", infos[5]);
                String message = "";

                for (int i = 6; i < infos.Length; i++)
                {
                    if(infos[i] == "")
                        message += Environment.NewLine;
                    else
                        message += infos[i];
                }

                post.Add("Message", message);
            }

            return post;
        }

        /*
        * Check If Files Exist 
        */
        public bool checkFilesExists()
        {
            bool allCon = false;

            //Create Folder If Doesn't Exist
            if(!Directory.Exists(folderName))
                Directory.CreateDirectory(folderName);

            //Check Files Exist
            foreach (String path in paths.Values)
            {
                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                    allCon = true;
                }
            }

            return allCon;
        }

        /*
         * Check if New Links already exist in File 
         */
        public List<String> checkLinksExist(List<String> links)
        {
            List<String> plinks = new List<string>();
            List<String> lines = new List<string>();

            //Read all files and add in one list
            foreach (String path in paths.Values)
                lines.AddRange(File.ReadAllLines(path));

            //Check if new links exist in files
            foreach (String val1 in links)
                if(!lines.Contains(val1))
                    plinks.Add(val1);

            //Be sure that there is not duplicate links
            for (int i = 0; i < plinks.Count; i++)
            {
                for (int j = i + 1; j < plinks.Count; j++)
                {
                    if (plinks[i] == plinks[j])
                        plinks.RemoveAt(i);
                }
            }

            return plinks;
        }

        public void appendWaitingLinks(List<String> plinks)
        {
            StreamWriter SW = File.AppendText(getWaitingPath());
            foreach (String val in plinks)
                SW.WriteLine(val);
            SW.Close();
        }

        public void writeResult(String profile, bool shareResult)
        {
            //Pick file according to share result
            StreamWriter SW = File.AppendText((shareResult) ? getDonePath() : getErrorPath());
            SW.WriteLine(profile);
            SW.Close();

            //Remove profile in waiting list
            List<String> rd = new List<string>();
            rd.AddRange(readWaitingLinks());
            rd.Remove(profile);

            File.WriteAllLines(getWaitingPath(), rd);
        }

        public void deletePath()
        {
            if(Directory.Exists(folderName))
                Directory.Delete(folderName,true);
        }

        private string setPath(String city, String suffix)
        {
            return folderName + "/" + city + "-" + suffix + ".txt";
        }

        public List<string> readWaitingLinks()
        {
            return new List<string>(File.ReadAllLines(getWaitingPath()));
        }

        public List<string> readDoneLinks()
        {
            return new List<string>(File.ReadAllLines(getDonePath()));
        }

        public List<string> readErrorLinks()
        {
            return new List<string>(File.ReadAllLines(getErrorPath()));
        }

        public string getWaitingPath()
        {
            return paths[suffixes[0]];
        }

        public string getDonePath()
        {
            return paths[suffixes[1]];
        }

        public string getErrorPath()
        {
            return paths[suffixes[2]];
        }

        public string getInfoPath()
        {
            return paths[suffixes[3]];
        }

        public string getFolderName()
        {
            return folderName;
        }
    }
}
