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
        //机型
        public string DeviceName;
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

        public void OnLogin(string devicename)
        {
            if (this.TotalLoginNumber == 0)
            { 
                this.FirstLoginTime = TimeHelper.DateTimeNow().ToString();
            }
            this.DeviceName = devicename;   
            this.TotalLoginNumber++;
        }
    }
}
