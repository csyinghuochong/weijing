
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Net;
using System.Text;

namespace ET
{

    public static class UILoginHelper
    {
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