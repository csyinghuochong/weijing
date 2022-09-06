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
        public Dictionary<char, IList<string>> keyDict = new Dictionary<char, IList<string>>();


        protected override  void InternalInit()
        {
            base.InternalInit();

            InitMaskWord().Coroutine();
        }

        public async ETTask InitMaskWord()
        {
            keyDict.Clear();
            await InitMaskWordText("MaskWord", "、");
            await InitMaskWordText("MaskWord2", "、\r\n");
        }

        public async ETTask InitMaskWordText(string maskword, string split)
        {
            var path = ABPathHelper.GetTextPath();
            GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            TextAsset textAsset3 = prefab.Get<TextAsset>(maskword);
            MaskWord = textAsset3.text;
            sensitiveWordsArray = Regex.Split(MaskWord, split, RegexOptions.IgnoreCase);

            Log.ILog.Debug($" xxx;   {sensitiveWordsArray.Length}  { sensitiveWordsArray[0]}   { sensitiveWordsArray[1]}  { sensitiveWordsArray[2]}");
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
