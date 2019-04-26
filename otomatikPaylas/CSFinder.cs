using CSHelper.Control;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;


namespace otomatikPaylas
{
    public partial class CSFinder : Form
    {
        public CSFinder()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        CS cs;
        FileUtil file;

        System.Collections.Generic.IEnumerable<String> profiles;
        string user, pass;

        //TODO: Move into classes
        private void CSFinder_Load(object sender, EventArgs e)
        {
            try
            {
                String pa = "Profiles";
                if (!Directory.Exists(pa))
                {
                    DirectoryInfo di = Directory.CreateDirectory(pa);
                }

                DirectoryInfo dinfo = new DirectoryInfo(pa);
                FileInfo[] Files = dinfo.GetFiles("*-w.txt");
                foreach (FileInfo file in Files)
                {
                    cbFile.Items.Add(file.Name.Replace("-w.txt",""));
                }
                
                profiles = File.ReadLines("Profiles.txt");
                foreach (String val in profiles)
                {
                    String[] inform = val.Split('\t');
                    user = inform[0];
                    pass = inform[1];
                    emailTB.Text = inform[0];
                    passwordTB.Text = inform[1];
                }
                dtpArrive.Value = DateTime.Now;
                dtpDeparture.Value = DateTime.Now.AddDays(1);
            }
            catch
            {
                MessageBox.Show("I didn't read some files!");
            }
        }

        private void bBrowser_Click(object sender, EventArgs e)
        {
            if(file == null)
            {
                MessageBox.Show("Select or Add City First!");
                return;
            }
        
            FirefoxOptions p = new FirefoxOptions();
            cs = new CS(new FirefoxDriver(p), file);
            cs.login(user, pass);
            //p.SetPreference("webdriver.log.file", "/tmp/firefox_console");
            //p.SetPreference("dom.ipc.plugins.flash.disable-protected-mode", true);
            //driver.Manage().Window.Maximize();
            // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        private void bQuit_Click(object sender, EventArgs e)
        {
            cs.quit();
        }

        private void bPostPaste_Click(object sender, EventArgs e)
        {
            cs.postPaste(getPostDetails());
        }

        private void bGetProfiles_Click(object sender, EventArgs e)
        {
            if (cbFile.SelectedIndex == -1)
            {
                MessageBox.Show("Select a city first!");
                tbCity.Focus();
                return;
            }

            foreach(String val in cs.getProfiles())
                lbProfileList.Items.Add(val);

            label4.Text = "0 / " + lbProfileList.Items.Count.ToString();
        }

        private void tbCity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bNextProfile_Click(object sender, EventArgs e)
        {
            if(lbProfileList.Items.Count != 0)
            {
                if (lbProfileList.SelectedIndex != -1)
                {
                    cs.file.writeResult(lbProfileList.Items[0].ToString(),true);

                    lbProfileList.Items.RemoveAt(0);
                }
                if (lbProfileList.Items.Count != 0)
                {
                    lbProfileList.SelectedIndex = 0;
                    cs.nextProfile(lbProfileList.Items[0].ToString());
                }
            }
        }

        private void bPostSend_Click(object sender, EventArgs e)
        {
            cs.postSend();
        }

        private Dictionary<String,Object> getPostDetails()
        {
            Dictionary<String, Object> post = new Dictionary<string, object>();
            post.Add("Arrival", dtpArrive.Text);
            post.Add("Departure", dtpDeparture.Text);
            post.Add("AFlexible", cbAflexible.Checked);
            post.Add("DFlexible", cbDflexible.Checked);
            post.Add("Guests", nudPassenger.Value);
            post.Add("Introduce", tbIntroduce.Text);
            post.Add("Message", tbMessage.Text);
            return post;
        }

        private void setPostDetails(Dictionary<String, Object> post)
        {
            dtpArrive.Text = post["Arrival"].ToString();
            dtpDeparture.Text = post["Departure"].ToString();
            cbAflexible.Checked = Convert.ToBoolean(post["AFlexible"]);
            cbDflexible.Checked = Convert.ToBoolean(post["DFlexible"]);
            nudPassenger.Value = Convert.ToInt16(post["Guests"]);
            tbIntroduce.Text = post["Introduce"].ToString();
            tbMessage.Text = post["Message"].ToString();
        }

        private void bRequest_Click(object sender, EventArgs e)
        {
            cs.requestClick();
        }

        private void bwAutomatic_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i < lbProfileList.Items.Count; i++)
            {
                label4.Text = (i + 1).ToString() + " / " + lbProfileList.Items.Count.ToString();
                lbProfileList.SelectedIndex = i;
                cs.automaticSend(lbProfileList.Items[i].ToString(), getPostDetails(), 
                    Convert.ToInt32(numWait.Value));
            }
        }

        private void bAutomaticStart_Click(object sender, EventArgs e)
        {
            bwAutomatic.RunWorkerAsync();
        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {
            user = emailTB.Text;
            pass = passwordTB.Text;
        }

        private void cbFile_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFile.SelectedIndex == -1)
                return;

            if (cbFile.Text == "")
                return;

            lbProfileList.Items.Clear();

            if (file == null)
                file = new FileUtil(cbFile.Text);
            else
                file.setPaths(cbFile.Text);

            setPostDetails(file.getInfos());

            foreach (String val in file.readWaitingLinks())
            {
                lbProfileList.Items.Add(val);
            }
        }

        private void bSaveInfo_Click(object sender, EventArgs e)
        {
            if (file != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure to SAVE!", "Save Request Infos", 
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                    file.saveInfo(getPostDetails());
            }
            else
                MessageBox.Show("Pick a city name!");
        }

        private void bRefreshInfo_Click(object sender, EventArgs e)
        {
            if (file != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure to Refresh! You will lose your current changes!", "Refresh Request Infos",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                    setPostDetails(file.getInfos());
            }
            else
                MessageBox.Show("Pick a city name!");
        }

        private void saveCity_Click(object sender, EventArgs e)
        {
            if(cbFile.Items.Contains(tbCity.Text))
            {
                MessageBox.Show("Already exist!");
                return;
            }

            if (tbCity.Text == "")
            {
                MessageBox.Show("City name can't be null!");
                return;
            }

            cbFile.Items.Add(tbCity.Text);
            cbFile.SelectedIndex = cbFile.Items.Count - 1;           
        }

        private void bAutomaticStop_Click(object sender, EventArgs e)
        {
            bwAutomatic.CancelAsync();
        }
    }
}
