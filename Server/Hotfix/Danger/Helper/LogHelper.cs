using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;
using System.Linq;

namespace ET
{
    public static class LogHelper
    {

        public static void LoginInfo(string log)
        {
            string filePath = "../Logs/login.txt";
            if (File.Exists(filePath))
            {
                StreamWriter sw = File.AppendText(filePath);
                sw.WriteLineAsync(log);
                sw.Flush();
                sw.Close();
            }
            else
            {
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                sw.WriteLineAsync(log);
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                fs.Close();
            }
        }

        public static void ZuobiInfo(string log)
        {
            string filePath = "../Logs/ZuoBi.txt";
            if (File.Exists(filePath))
            {
                StreamWriter sw = File.AppendText(filePath);
                sw.WriteLineAsync(log);
                sw.Flush();
                sw.Close();
            }
            else
            {
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                sw.WriteLineAsync(log);
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                fs.Close();
            }
        }


        /// <summary>
        /// 每小时检测一次
        /// </summary>
        /// <param name="unit"></param>
        public static void CheckZuoBi(Unit unit)
        {
            LogHelper.ZuobiInfo($"ceshi {unit.Id} ");

        }

        public static Dictionary<int, string> ToItemGetWay = new Dictionary<int, string>()
        {
            { ItemGetWay.System, "系统"},
            { ItemGetWay.FubenGetReward, "副本"},
        };

        public static string GetItemGetWay(int getWay)
        {
            string info = string.Empty;
            ToItemGetWay.TryGetValue(getWay, out info);
            return info;
        }

    }
}
