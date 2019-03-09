using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;

namespace rajioPlay
{
    public partial class rajio : Form
    {
        public int channel = 0;
        public rajio()
        {
            InitializeComponent();

            //Hide app
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.ShowInTaskbar = false;

            //Load
            onLoad();
        }

        public void onLoad()
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                try
                {
                    Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_NET_PLAYLIST, 2);
                    Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UNICODE, true); //unicode error
                    Bass.BASS_StreamFree(channel);
                    Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero); //Init BASS
                }
                catch
                {
                    ntfPlayer.ShowBalloonTip(1000, "Dameee!", "Rajio's got just hurt! :( " + Bass.BASS_ErrorGetCode(), ToolTipIcon.Error);
                }
                ntfPlayer.ShowBalloonTip(1000, "Ohayoo!", "Rajio's is waiting in the notification tray!", ToolTipIcon.None);

            }
        }
        public string CurrentPlay()
        {
            String[] b = Bass.BASS_ChannelGetTagsMETA(channel);
            if (b == null) return "Unknown :(";
            int sep = b[0].IndexOf(";");
            if (sep == 0) return "Unknown :(";
            string title = b[0].Substring(0, sep);
            title = title.Substring(title.IndexOf("=") + 1).Replace("'", "");
            if (title == "") return "Unknown :(";
            return title;
        }

        public void UncheckAll()
        {
            radioToolStripMenuItem1.CheckState = CheckState.Unchecked;
            edenOfTheWestToolStripMenuItem.CheckState = CheckState.Unchecked;
            listenmoeToolStripMenuItem.CheckState = CheckState.Unchecked;
        }
        public void playRadioSong(string url)
        {
            try
            {
                if (Bass.BASS_ChannelPlay(channel, false))
                {
                    Bass.BASS_ChannelStop(channel);
                    UncheckAll();

                }
                channel = Bass.BASS_StreamCreateURL(url, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);
            }
            catch
            {
                ntfPlayer.ShowBalloonTip(1500, "Eeeeeeeh?", "BASS Error:" + Bass.BASS_ErrorGetCode(), ToolTipIcon.Error);
            }
            Bass.BASS_ChannelPlay(channel, false);

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            playRadioSong("https://relay0.r-a-d.io/main.mp3");
            radioToolStripMenuItem1.CheckState = CheckState.Checked;
        }

        private void edenOfTheWestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playRadioSong("http://edenofthewest.com:8080/eden.mp3");
            edenOfTheWestToolStripMenuItem.CheckState = CheckState.Checked;
        }

        private void listenmoeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playRadioSong("https://listen.moe/fallback");
            listenmoeToolStripMenuItem.CheckState = CheckState.Checked;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ntfPlayer.ShowBalloonTip(1000, "Current song", CurrentPlay(), ToolTipIcon.None);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(CurrentPlay());
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bass.BASS_Start())
            {
                Bass.BASS_ChannelStop(channel);
                UncheckAll();
            }
        }

        private void duckDuckGoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://duckduckgo.com/?q=" + CurrentPlay().Replace(" ", "+") + "&ia=web";
            System.Diagnostics.Process.Start(url);
        }

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/results?search_query=" + CurrentPlay().Replace(" ", "+");
            System.Diagnostics.Process.Start(url);
        }
    }
}
