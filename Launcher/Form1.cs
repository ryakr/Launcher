﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //¯\_(ツ)_/¯
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DownloadHandle.Initialize(progressBar1, label1);
            AppGameInfo.Initialize();
            MessageBox.Show("game title is " + AppGameInfo.gameinfo["FirstTitle"] + "\n" + "Version is " + AppGameInfo.gameinfo["Version"]); //current tester of URL
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    AppGameInfo.SetButtonShit(ctrl.Name, (Button)ctrl); //set button info
                }
            }
        }

        private void First_Click(object sender, EventArgs e)
        {
            DownloadHandle.ButtonChange("https://raw.githubusercontent.com/ryakr/Launcher/master/filelist.txt", "https://raw.githubusercontent.com/ryakr/Launcher/master/");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //jack shit for ever probably
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadHandle.BeginDownload(sender, e);
        }

        private void Second_Click(object sender, EventArgs e)
        {
            DownloadHandle.ButtonChange("https://raw.githubusercontent.com/ryakr/Launcher/master/filelist.txt", "https://raw.githubusercontent.com/ryakr/Launcher/master/");
        }
    }
}
