using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadFBPrivate
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string fileName = txtName.Text;
            string link = txtLink.Text;
            ProcessStartInfo videoProcInfo = new ProcessStartInfo();
            videoProcInfo.FileName = @"cmd.exe";
            videoProcInfo.Arguments = $"/k youtube-dl \"{link}\" --cookies cookies.txt -f bestvideo --output \"video.%(ext)s\"&youtube-dl \"{link}\" --cookies cookies.txt -f bestaudio --output \"audio.%(ext)s\"&ffmpeg -i video.mp4 -i audio.m4a -c copy Output\\{fileName}.mp4&del \"video.mp4\"&del \"audio.m4a\"&echo ##### Successfully.......... #####";
            Process videoProc = new Process();
            videoProc.StartInfo = videoProcInfo;
            videoProc.Start();
        }
    }
}
