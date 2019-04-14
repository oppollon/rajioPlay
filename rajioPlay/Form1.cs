using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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

            //on Load
            onLoad();
        }

        public void onLoad()
        {
            //Hide app
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.ShowInTaskbar = false;

            if (this.WindowState == FormWindowState.Minimized)
            {
                try
                {
                    LoadToolStripMenu();
                    Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_NET_PLAYLIST, 2);
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
            string[] b = Bass.BASS_ChannelGetTagsMETA(channel);
            if (b == null) return "Unknown :( (null)";
            int sep = b[0].IndexOf(";");
            if (sep == 0) return "Unknown :( (no seperator)";
            string title = b[0].Substring(0, sep);
            title = title.Substring(title.IndexOf("=") + 1).Replace("'", "");
            if (title == "") return "Unknown :( (no title)";
            return title;
        }
        
        public void playRadioSong(string url)
        {
            try
            {
                if (Bass.BASS_ChannelPlay(channel, false))
                {
                    UncheckAll();
                    Bass.BASS_ChannelStop(channel);
                }
                Bass.BASS_StreamFree(channel);
                channel = Bass.BASS_StreamCreateURL(url, 0, BASSFlag.BASS_STREAM_STATUS, null, IntPtr.Zero);
            }
            catch
            {
                ntfPlayer.ShowBalloonTip(1500, "Eeeeeeeh?", "BASS Error:" + Bass.BASS_ErrorGetCode(), ToolTipIcon.Error);
            }
            Bass.BASS_ChannelPlay(channel, false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bass.BASS_ChannelStop(channel);
                Bass.BASS_Free();
            }
            catch
            {
                ntfPlayer.ShowBalloonTip(1500, "Weird error.. still exiting.", "BASS Error:" + Bass.BASS_ErrorGetCode(), ToolTipIcon.Error);
                Application.Exit();
            }
            Application.Exit();
        }

        private void LoadToolStripMenu()
        {
            int id = 0;
            foreach (String radioLine in GetAllRadios())
            {
                ToolStripMenuItem item = new ToolStripMenuItem(radioLine.Split('|')[0]);
                item.Tag = id;
                id++;

                radioToolStripMenuItem.DropDownItems.Add(item);
                item.Click += new EventHandler(item_Click);
            }
        }
       
        public void UncheckAll()
        {
            foreach (ToolStripMenuItem item in radioToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }
        }

        private void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            playRadioSong(GetAllRadios()[(int)item.Tag].Split('|')[1]);
            item.Checked = true;
        }

        private List<String> GetAllRadios()
        {
            List<String> radioList = new List<String>();
            string fname = "radios.txt";
            
            if (!(FileCreationNeeded(fname, "Insert your custom radios below this line like this (no spaces): radioName|radioURL")))
            {
                int lineCount = File.ReadLines(fname).Count();
                string[] lines = new string[lineCount - 1];

                //    string[] radioUrls = new string[lineCount], radioNames = new string[lineCount];
                try
                {
                    lines = File.ReadAllLines(fname, Encoding.UTF8);
                } catch (Exception ex)
                {
                    ntfPlayer.ShowBalloonTip(1000, "FileRead Error!", ex.Message, ToolTipIcon.Error);
                }

                for (int i = 1; i < lineCount; i++)
                {
                   radioList.Add(lines[i]);
                }
            }
            return radioList;
        }

        public bool FileCreationNeeded(string fname, string titleText)
        {
            //checks if file to create and returns false when alredy created
            if (!(File.Exists(fname)))
            {
                string createText = titleText + Environment.NewLine;
                File.WriteAllText(fname, createText, Encoding.UTF8);
            } 
            return false;
        }

        public void FileAppend(string fname, string appendText)
        {
            //appends string to a file fname
            try
            {
                File.AppendAllText(fname, appendText, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                ntfPlayer.ShowBalloonTip(1000, "FileWrite Error!", ex.Message, ToolTipIcon.Error);
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ntfPlayer.ShowBalloonTip(1000, "Current song", CurrentPlay(), ToolTipIcon.None);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(CurrentPlay());
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e) //stop button
        {
            if (Bass.BASS_Start())
            {
                UncheckAll();
                Bass.BASS_ChannelStop(channel);
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

        private void likeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = "likes.txt";

            if(!(FileCreationNeeded(fname, "Liked Songs - File created on " + DateTime.Now.ToString())))
            {
                FileAppend(fname, DateTime.Now.ToString() + ": " + CurrentPlay() + Environment.NewLine);
            }
        }
    }
}
