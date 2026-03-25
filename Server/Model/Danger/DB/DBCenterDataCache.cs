using System;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Options;

namespace ET
{
    [BsonIgnoreExtraElements]
    public class DBCenterDataCache : Entity, IAwake
    {
        //设备ID
        public string anid;

        //该设备登陆的账号
        public string AccountName;
       
        //数据创建时间
        public long CreateTimeLong;
        public string CreateTimeString;
        //登陆游戏总次数
        public int TotalLoginNumber;
        //最后一次登陆时间
        public string LastLoginTime;
        //第一次热更新完成
        public string HotUpdatecomplte;
        //第一次账号登陆时间
        public string FirstLoginTime;
        //第一次创角时间
        public string FristCrateRoleTime;
        //第一次进入主城
        public string FirstEnterMainCityTime;
      
        //是否是广告下载
        //tap广告渠道  自然渠道 0  tap广告渠道11
        public int DownloadType;


        //机型
        public string DeviceName;
        //平台
        public string Platform;


        /* XiaoMi,
         ViVo,
         OPPO,
         HuaWei ,*/
        //TapTapADS   //小米 
        public string DownloadFrom;    //下载渠道

        //总充值
        public int TotalRecharge;
        //最高等级
        public int MaxLevel;
        //总时间
        public long TotalOnlineTime;

        //是否老账号 老号为1 新号是0
        public int OldAccount;
        //该设备登陆的账号创建时间
        public string OldAccountTime;

        public string IP;    //上次登陆ip

        public void OnLogin(string devicename)
        {
            if (this.TotalLoginNumber == 0)
            { 
                this.FirstLoginTime = TimeHelper.DateTimeNow().ToString();
            }
            this.DeviceName = devicename;   
            this.TotalLoginNumber++;
        }

        public void SetDownloadType(int downloadType, int platform, int platformtwo, string devicename) 
        {
            this.DownloadType = downloadType;   
            this.DeviceName = devicename;    
            this.Platform = GetPlatformName(platform, platformtwo);
            if (downloadType == 11)
            {
                this.DownloadFrom = "TapTapADS";
            }
            else if (platform == 20001)
            {
                this.DownloadFrom = "IOS";
            }
            else if (platform == 5 || platform == 6)
            {
                this.DownloadFrom = "TikTok";
            }
            else if( platform == 100)
            {
                /*XiaoMi = 15,
                ViVo = 17,
                OPPO = 23,
                HuaWei = 24,
                HuaWeiHaiWai = 1073,
                YongYao = 2376,*/
                switch (platformtwo)
                {
                    case 15:
                        this.DownloadFrom = "XiaoMi";
                        break;
                    case 17:
                        this.DownloadFrom = "ViVo";
                        break;
                    case 23:
                        this.DownloadFrom = "OPPO";
                        break;
                    case 24:
                        this.DownloadFrom = "HuaWei";
                        break;
                    case 1073:
                        this.DownloadFrom = "HuaWeiHaiWai";
                        break;
                    case 2376:
                        this.DownloadFrom = "RongYao";
                        break;
                    default:
                        this.DownloadFrom = "QuDao";
                        break;
                }
            }
            else
            {
                this.DownloadFrom = "TapTap";
            }
        }


        public string GetPlatformName(int platformid, int platformtwo)
        {
            ///0 默认 taptap1  QQ2 platform3 小说推广 platform4备用  TikTok5  TikTokMuBao6(抖音母包) Google7  TikTokGuanFu8  渠道包100+  ios20001
            string platformname = string.Empty;
            switch (platformid)
            {
                case 20001:
                    platformname = "苹果";
                    break;
                case 1:
                    platformname = "TapTap";
                    break;
                case 2:
                    platformname = "QQ";
                    break;
                case 3:
                    platformname = "小说推广";
                    break;
                case 5:
                case 6:
                case 8:
                    platformname = "抖音";
                    break;
                case 7:
                    platformname = "谷歌";
                    break;
                case 100:
                    platformname = GetPlatformTwoName(platformtwo);
                    break;
                default:
                    platformname = "安卓";
                    break;
            }

            return platformname;
        }

        public string GetPlatformTwoName(int platformtwo)
        {
            string platformname = string.Empty;
            switch (platformtwo)
            {

                case 15:
                    platformname = "小米";
                    break;
                case 17:
                    platformname = "ViVo";
                    break;
                case 23:
                    platformname = "OPPO";
                    break;
                case 24:
                    platformname = "华为";
                    break;
                case 1073:
                    platformname = "华为海外";
                    break;
                case 2376:
                    platformname = "荣耀";
                    break;
                default:
                    platformname = "安卓渠道";
                    break;
            }
            return platformname;
        }
    }
}
