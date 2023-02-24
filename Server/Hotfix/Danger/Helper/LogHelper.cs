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

        public static void KillPlayerInfo(Unit attack, Unit defend)
        {
            UserInfoComponent attackUserinfo = attack.GetComponent<UserInfoComponent>();
            UserInfoComponent defendUserinfo = defend.GetComponent<UserInfoComponent>();
            string attackName = attackUserinfo.UserInfo.Name;
            string defendName = defendUserinfo.UserInfo.Name;
            attackName = attack.IsRobot() ? $"{attackName}（人机）" : attackName;
            defendName = defend.IsRobot() ? $"{defendName}（人机）" : defendName;
            int attackOcc = attackUserinfo.UserInfo.OccTwo > 0 ? attackUserinfo.UserInfo.OccTwo : attackUserinfo.UserInfo.Occ;
            int defendOcc = defendUserinfo.UserInfo.OccTwo > 0 ? defendUserinfo.UserInfo.OccTwo : defendUserinfo.UserInfo.Occ;

            string log = $"{attackName} 等级({attackUserinfo.UserInfo.Lv}) 职业:({attackOcc}) 战力:({attackUserinfo.UserInfo.Combat}) 击杀了： {defendName} 等级({defendUserinfo.UserInfo.Lv}) 职业:({defendOcc}) 战力:({defendUserinfo.UserInfo.Combat})";

            string filePath = "../Logs/WJ_KillPlayer.txt";
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

        public static void LoginInfo(string log)
        {
            string filePath = "../Logs/WJ_login.txt";
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
            string filePath = "../Logs/WJ_ZuoBi.txt";
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

            UserInfoComponent userInfo = unit.GetComponent<UserInfoComponent>();

            //GM账号免于检测
            if (GMHelp.GmAccount.Contains(userInfo.Account)) {
                return;
            }

            int openDay = DBHelper.GetOpenServerDay(unit.DomainZone());
            //钻石线
            if (userInfo.UserInfo.Diamond >= unit.GetComponent<NumericComponent>().GetAsLong(NumericType.RechargeNumber) * 150 + 50000)
            {
                LogHelper.ZuobiInfo("钻石作弊:" + userInfo.UserInfo.Diamond + "服务器:" + unit.DomainZone() + "名字:" + userInfo.UserName);
            }

            //等级线
            ServerInfo serverInfo = unit.DomainScene().GetComponent<ServerInfoComponent>().ServerInfo;
            if (userInfo.UserInfo.Lv > serverInfo.WorldLv) {
                LogHelper.ZuobiInfo("玩家等级超过服务器等级限制:" + userInfo.UserInfo.Lv + "服务器:" + unit.DomainZone() + "名字:" + userInfo.UserName);
            }

            if (openDay <= 180 || userInfo.UserInfo.Lv < 60)
            {
                //金币线
                if (userInfo.UserInfo.Gold >= unit.GetComponent<NumericComponent>().GetAsLong(NumericType.RechargeNumber) * 300000 + 5000000 + userInfo.UserInfo.Lv * 500000)
                {
                    LogHelper.ZuobiInfo("金币作弊:" + userInfo.UserInfo.Diamond + "服务器:" + unit.DomainZone() + "名字:" + userInfo.UserName);
                }

                //道具线
                if (unit.GetComponent<BagComponent>().GetItemNumber(10010083) > 1000 + unit.GetComponent<NumericComponent>().GetAsLong(NumericType.RechargeNumber) * 10) {
                    LogHelper.ZuobiInfo("洗练石作弊:" + unit.GetComponent<BagComponent>().GetItemNumber(10010083) + "服务器:" + unit.DomainZone() + "名字:" + userInfo.UserName);
                }
            }
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
