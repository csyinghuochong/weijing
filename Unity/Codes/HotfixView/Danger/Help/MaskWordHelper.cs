using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

namespace ET
{
    class MaskWordHelper : Singleton<MaskWordHelper>
    {

        public string MaskWord;
        public string[] sensitiveWordsArray = null;
        public Dictionary<char, IList<string>> keyDict;


        protected override  void InternalInit()
        {
            base.InternalInit();

            InitMaskWord().Coroutine();
        }

        public async ETTask InitMaskWord()
        {
            var path = ABPathHelper.GetTextPath();
            await ETTask.CompletedTask;
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            TextAsset textAsset3 = prefab.Get<TextAsset>("MaskWord");
            MaskWord = textAsset3.text;
            sensitiveWordsArray = Regex.Split(MaskWord, "、", RegexOptions.IgnoreCase);

            keyDict = new Dictionary<char, IList<string>>();
            foreach (string s in sensitiveWordsArray)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                if (keyDict.ContainsKey(s[0]))
                    keyDict[s[0]].Add(s.Trim(new char[] { '\r' }));
                else
                    keyDict.Add(s[0], new List<string> { s.Trim(new char[] { '\r' }) });
            }
        }

        //判断一个字符串是否包含敏感词，包括含的话将其替换为*
        public bool IsContainSensitiveWords(string text)
        {
            bool isFind = false;
            if (null == sensitiveWordsArray || string.IsNullOrEmpty(text))
                return isFind;

            int len = text.Length;
            bool isOK = true;
            for (int i = 0; i < len; i++)
            {
                if (!keyDict.ContainsKey(text[i]))
                {
                    continue;
                }
                foreach (string s in keyDict[text[i]])
                {
                    isOK = true;
                    int j = i;
                    foreach (char c in s)
                    {
                        if (j >= len || c != text[j++])
                        {
                            isOK = false;
                            break;
                        }
                    }
                    if (isOK)
                    {
                        isFind = true;
                        i += s.Length - 1;
                        break;
                    }
                }
                if (isFind)
                {
                    break;
                }
            }

            return isFind;
        }

        //判断一个字符串是否包含敏感词，包括含的话将其替换为*
        public bool IsContainSensitiveWords(ref string text, out string SensitiveWords)
        {
            bool isFind = false;
            SensitiveWords = "";
            if (null == sensitiveWordsArray || string.IsNullOrEmpty(text))
                return isFind;

            int len = text.Length;
            StringBuilder sb = new StringBuilder(len);
            bool isOK = true;
            for (int i = 0; i < len; i++)
            {
                if (keyDict.ContainsKey(text[i]))
                {
                    foreach (string s in keyDict[text[i]])
                    {
                        isOK = true;
                        int j = i;
                        foreach (char c in s)
                        {
                            if (j >= len || c != text[j++])
                            {
                                isOK = false;
                                break;
                            }
                        }
                        if (isOK)
                        {
                            SensitiveWords += s;
                            isFind = true;
                            i += s.Length - 1;
                            sb.Append('*', s.Length);
                            break;
                        }

                    }
                    if (!isOK)
                        sb.Append(text[i]);
                }
                else
                    sb.Append(text[i]);
            }

            if (isFind)
                text = sb.ToString();

            return isFind;
        }
    }
}
