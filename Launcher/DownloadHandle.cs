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
using ICSharpCode.SharpZipLib.Tar;

namespace Launcher
{
    class DownloadHandle
    {
        public static ProgressBar DownloadBar;

        public static void Initialize(ProgressBar DownloadProgress)
        {
            DownloadBar = DownloadProgress;
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send("api.github.com");

            if(reply.Status == IPStatus.Success)
            {
                MessageBox.Show("Connected Successfully");
            } else
            {
                MessageBox.Show("Failed To Connect");
            }
        }
        public static void BeginDownload(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            string zipname = "Game" + ".tar.gz";
            String ZipSave = "E:\\test\\" + zipname;
            webClient.DownloadFileAsync(new Uri("https://github.com/ryakr/Launcher/tarball/master"), ZipSave);
        }
        private static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadBar.Value = e.ProgressPercentage;
        }

        private static void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download completed!");
            String ZipSave = "E:\\test\\" + "Game.tar.gz";
            Stream inStream = File.OpenRead(ZipSave);

            TarArchive tarArchive = TarArchive.CreateInputTarArchive(inStream);
            tarArchive.ExtractContents("E:\\test");
            tarArchive.Close();

            inStream.Close();

        }
    }
}
