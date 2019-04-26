using System;
using System.Windows.Forms;

namespace CSHelper.Control
{
    public class Util
    {
        public static void wait(int sec)
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(sec) > DateTime.Now);
        }
    }
}
