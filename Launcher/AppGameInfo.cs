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
            string reply = client.DownloadString("https://raw.githubusercontent.com/ryakr/Launcher/master/titletest.txt"); //test url
            foreach (string line in reply.Split('\n'))
            {
                if (line.StartsWith("//") || line.Length < 4)
                    continue;
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
