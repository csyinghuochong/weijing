
using LC.Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public static class UILoginHelper
    {

        public static  List<string> SplitString(Text[] texts, string value)
        {
            List<string> listStr = new List<string>();
            string leftValue = value;
            for (int i = 0; i < texts.Length; i++)
            {
                string tempstr = "";
                var generator = new TextGenerator();//文本生成器
                var rect = texts[i].GetComponent<RectTransform>().rect;
                var setting = texts[i].GetGenerationSettings(rect.size);//文本设置
                generator.Populate(leftValue, setting);
                int charactreCountVisible = generator.characterCount;//可见字数index
                if (string.IsNullOrEmpty(leftValue))
                    break;
                if (leftValue.Length > charactreCountVisible)
                {
                    tempstr = leftValue.Substring(0, charactreCountVisible);
                    leftValue = leftValue.Substring(charactreCountVisible, leftValue.Length - charactreCountVisible);
                }
                else
                {
                    tempstr = leftValue;
                    leftValue = "";
                }
                listStr.Add(tempstr);
            }
            return listStr;
        }


        public static void ShowTextList(Text text, string pageHtml)
        {
            string tempstr = string.Empty;
            string leftValue = pageHtml;
            int indexlist = pageHtml.IndexOf('\n');

            int whileNumber = 0;

            while (indexlist != -1)
            {
                whileNumber++;
                if (whileNumber >= 1000)
                {
                    break;
                }

                tempstr = leftValue.Substring(0, indexlist);

                Log.Debug("aaaaaaaaaaaaaatempstr1:" + tempstr + "   " + indexlist.ToString());

                indexlist += 1;
                leftValue = leftValue.Substring(indexlist, leftValue.Length - indexlist);

                indexlist = leftValue.IndexOf('\n');

                if (indexlist == -1)
                {
                    Log.Debug("aaaaaaaaaaaaaatempstr2:" + leftValue + "   " + whileNumber);
                }
            }
        }

        public static string GetGongGaoText()
        {
            try
            {
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = MyWebClient.DownloadData("http://verification.weijinggame.com/weijing/gonggao.txt"); //从指定网站下载数据
                string pageHtml = Encoding.UTF8.GetString(pageData);
                return pageHtml;
            }

            catch (WebException webEx)
            {
                Log.Debug(webEx.ToString());
            }
            return "服务器维护中！";
        }

        public static string GetYingSiText()
        {
            try
            {
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = MyWebClient.DownloadData("http://verification.weijinggame.com/weijing/yinsi1.txt"); //从指定网站下载数据
                string pageHtml = Encoding.UTF8.GetString(pageData);
                return pageHtml;
            }

            catch (WebException webEx)
            {
                Log.Debug(webEx.ToString());
            }
            return "服务器维护中！";
        }

    }
}