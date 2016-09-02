using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Net;

namespace Launcher //STOP CRYING I FIXED IT GOD DAMN IT
{
    class AppGameInfo
    {
        public static Dictionary<string, string> gameinfo;
        public static void Initialize()
        {
            gameinfo = new Dictionary<string, string>();
            WebClient client = new WebClient(); //some web client stuff for retriving info
            string reply = client.DownloadString("https://raw.githubusercontent.com/ryakr/Launcher/master/titletest.txt"); //Retrive ze information
            foreach (string line in reply.Split('\n'))
            {
                if (line.StartsWith("//") || line.Length < 4) //commenting a comment ignore code, interestin...
                    continue;
                string[] line_components = line.Split('=');
                gameinfo[line_components[0]] = line_components[1];
            }
        }
        public static void SetButtonShit(string fileDataName, Button btn)
        {
            if (!gameinfo.ContainsKey(fileDataName + "Title"))
            {
                Console.WriteLine("Dumbass, this doesn't exist in the file ;) " + fileDataName); //a nice notification that the author done fucked up
            }
            if (gameinfo.ContainsKey(fileDataName + "Title") && gameinfo[fileDataName + "Title"] == "null") //hiding unexisting buttons
            {
                btn.Visible = false;
                return;
            }
            if (gameinfo.ContainsKey(fileDataName + "Title"))
            {
                btn.Text = gameinfo[fileDataName + "ButtonName"];
            }
        }
    }
}
