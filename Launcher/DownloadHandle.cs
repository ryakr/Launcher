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
        private static string lastDownloadedFile = "RYANFAPSTOFURRYPORN.FAP";
        private static List<string> downloadList = new List<string>();
        public static void Initialize(ProgressBar DownloadProgress)
        {
            DownloadBar = DownloadProgress;
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send("api.github.com");

            if (reply.Status == IPStatus.Success)
            {
                MessageBox.Show("Connected Successfully");
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedFilelist);
                webClient.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/ryakr/Launcher/master/filelist.txt"), "filelist.txt");


            }
            else {
                MessageBox.Show("Failed To Connect");
            }
        }
        public static void BeginDownload(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            if (downloadList.Count > 0)
            {
                lastDownloadedFile = downloadList[0];
                string downloadlink = "https://raw.githubusercontent.com/ryakr/Launcher/master/" + lastDownloadedFile;
                webClient.DownloadFileAsync(new Uri(downloadlink), lastDownloadedFile);
            }
        }
        private static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadBar.Value = e.ProgressPercentage;
        }

        private static void Completed(object sender, AsyncCompletedEventArgs e)
        {

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
            MessageBox.Show("List Indexed");
        }
    }
}
