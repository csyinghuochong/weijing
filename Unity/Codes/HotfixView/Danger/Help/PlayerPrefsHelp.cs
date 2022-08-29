using System.Collections.Generic;
using UnityEngine;

namespace ET
{


    public static class PlayerPrefsHelp
    {
        public static string MyServerID = "WJa_MyServerID";
        public static string LastUserID = "WJa_LastUserID";
        public static string LastLoginType = "WJa_LastLoginType";
        public static string ChapterDifficulty = "WJa_ChapterDifficulty";

        public static string LastAccount(string loginType)
        {
            return $"WJa_LastAccount_{loginType}";
        }

        public static string LastPassword(string loginType)
        {
             return $"WJa_LastPassword_{loginType}";
        }

        public static void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }

        public static int GetInt(string key)
        {
            return PlayerPrefs.GetInt(key);
        }

        public static void SetString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
        }

        public static string GetString(string key)
        {
            return PlayerPrefs.GetString(key);
        }


        public static int GetChapterDifficulty(int chapterid)
        {
            string difficultyinfo = GetString(ChapterDifficulty);
            if (string.IsNullOrEmpty(difficultyinfo))
            {
                return 1;
            }
            string[] difficultylist = difficultyinfo.Split('@');
            for (int i = 0; i < difficultylist.Length; i++)
            {
                string[] chapterinfo = difficultylist[i].Split(';');
                if (int.Parse(chapterinfo[0]) == chapterid)
                {
                    return int.Parse(chapterinfo[1]);
                }
            }
            return 1;
        }

        public static void SetChapterDifficulty(int chapterid, int difficulty)
        {
            string difficultyinfo = GetString(ChapterDifficulty);
            if (string.IsNullOrEmpty(difficultyinfo))
            {
                difficultyinfo = $"{chapterid};{difficulty}";
                SetString(ChapterDifficulty, difficultyinfo);
                return;
            }

            string[] difficultylist = difficultyinfo.Split('@');
            Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
            for (int i = 0; i < difficultylist.Length; i++)
            {
                string[] chapterinfo = difficultylist[i].Split(';');
                keyValuePairs.Add(int.Parse(chapterinfo[0]), int.Parse(chapterinfo[1]));
            }
            if (!keyValuePairs.ContainsKey(chapterid))
            {
                keyValuePairs.Add(chapterid, difficulty);
            }
            else
            {
                keyValuePairs[chapterid] = difficulty;
            }
            difficultyinfo = string.Empty;
            foreach (var item in keyValuePairs)
            {
                difficultyinfo += $"{item.Key};{item.Value}@";
            }
            if (difficultyinfo.Length > 0)
            {
                difficultyinfo = difficultyinfo.Substring(0, difficultyinfo.Length - 1);
            }

            Log.ILog.Debug($" 11:  {difficultyinfo}");
            SetString(ChapterDifficulty, difficultyinfo);
        }
    }
}
