using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelody
{
    static class GameEngine
    {
        static public List<string> playList = new List<string>();
        static public int gameDuration = 120;
        static public int musicDuration = 10;
        static public bool randomStart = true;
        static public string lastFolder = "";
        static public bool subFolders = false;
        static string regKeyName = "Software\\RomanK\\GuessMusic";
        static public string musicName = "";
        static public bool buttonHighlight = false;
        static public string playerName1 = "Jack";
        static public string playerName2 = "Suzie";
        static public char answerKey1 = 'A';
        static public char answerKey2 = 'L';

        #region *** Methods ***
        static public void ReadMusic()
        {
            try
            {
                string[] musicList = Directory.GetFiles(lastFolder, "*.mp3", subFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                playList.Clear();
                playList.AddRange(musicList);
            }
            catch
            {

            }
        }
        static public void WriteSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("RandomStart", GameEngine.randomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("SubFolders", subFolders);
                rk.SetValue("PlayerName1", playerName1);
                rk.SetValue("PlayerName2", playerName2);
                rk.SetValue("AnswerKey1", answerKey1);
                rk.SetValue("AnswerKey2", answerKey2);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
        static public void ReadSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    gameDuration = Convert.ToInt32(rk.GetValue("GameDuration"));
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart", false));
                    musicDuration = Convert.ToInt32(rk.GetValue("MusicDuration"));
                    subFolders = Convert.ToBoolean(rk.GetValue("SubFolders", false));
                    playerName1 = (string)rk.GetValue("PlayerName1");
                    playerName2 = (string)rk.GetValue("PlayerName2");
                    answerKey1 = Convert.ToChar(rk.GetValue("AnswerKey1"));
                    answerKey2 = Convert.ToChar(rk.GetValue("AnswerKey2"));
                }
            }

            finally
            {
                if (rk != null) rk.Close();
            }
        }
        #endregion
    }
}
