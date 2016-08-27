using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Net;

namespace WindowsFormsApplication1
{
    class AppGameInfo
    {
        public static Dictionary<string, string> gameinfo;
        public static void Initialize()
        {
            gameinfo = new Dictionary<string, string>();
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://gist.githubusercontent.com/ryakr/2e225835fdf7a1e511fc051ae4b50e33/raw/374ad38e917d767c944b44b0135189d850667dd3/test.txt");
            foreach (string line in reply.Split('\n'))
            {
                string[] line_components = line.Split('=');
                gameinfo[line_components[0]] = line_components[1];
            }
        }
        public static void SetButtonShit(string fileDataName, Button btn)
        {
            if (!gameinfo.ContainsKey(fileDataName + "Title"))
            {
                throw new Exception("Dumbass, this doesn't exist in the file ;)"); //a nice notification that the author done fucked up
            }
            if (gameinfo[fileDataName + "Title"] == "null")
            {
                btn.Visible = false;
                return;
            }
            btn.Text = gameinfo[fileDataName + "ButtonName"];
        }
    }
}
