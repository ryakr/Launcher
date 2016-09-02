using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Net;
using System.ComponentModel;
using System.IO;

namespace Launcher
{
    class DownloadHandle
    {
        public static ProgressBar DownloadBar;
        public static Label DownloadInfo;
        private static string lastDownloadedFile = "Launcher/App.config";
        private static List<string> downloadList = new List<string>();
        private static int lastDownloadPercent = 0;
        private static string downloadlink = "https://raw.githubusercontent.com/ryakr/Launcher/master/";
        private static string filelistdownload = "https://raw.githubusercontent.com/ryakr/Launcher/master/filelist.txt";
        public static void Initialize(ProgressBar DownloadProgress, Label DownloadLabel)
        {
            DownloadBar = DownloadProgress;
            DownloadInfo = DownloadLabel;
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send("api.github.com");

            if (reply.Status == IPStatus.Success)
            {
                MessageBox.Show("Connected Successfully");
            }
            else {
                MessageBox.Show("Failed To Connect");
            }
        }
        public static void ButtonChange(string filelist, string downloadpre)
        {
            filelistdownload = filelist;
            downloadlink = downloadpre;
            if (File.Exists("filelist.txt"))
            {
                File.Delete("filelist.txt");
            }
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFilelist);
            webClient.DownloadFileAsync(new Uri(filelistdownload), "filelist.txt");
        }
        public static void BeginDownload(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            string downloadlink2 = downloadlink + lastDownloadedFile;
            DownloadInfo.Text = downloadlink2;
            Console.WriteLine(downloadlink2);
            string dir = lastDownloadedFile.Substring(0, lastDownloadedFile.LastIndexOf("/"));
            if (lastDownloadedFile.Contains("/"))
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
            webClient.DownloadFileAsync(new Uri(downloadlink), lastDownloadedFile);
        }
        private static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadBar.Value = lastDownloadPercent + e.ProgressPercentage;
        }

        private static void Completed(object sender, AsyncCompletedEventArgs e)
        {
            lastDownloadPercent = DownloadBar.Value;
            downloadList.Remove(lastDownloadedFile);
            if (downloadList.Count > 0)
            {
                lastDownloadedFile = downloadList[0];
                BeginDownload(sender, e);
            }
        }
        private static void CompletedFilelist(object sender, AsyncCompletedEventArgs e)
        {
            foreach (string line in File.ReadAllLines("filelist.txt"))
            {
                downloadList.Add(line);
            }
            DownloadBar.Maximum = downloadList.Count * 100;
            MessageBox.Show("List Indexed");
        }
    }
}
