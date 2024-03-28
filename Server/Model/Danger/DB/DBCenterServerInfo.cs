using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Options;

namespace ET
{ 
    [BsonIgnoreExtraElements]
    public class DBCenterServerInfo : Entity
    {
        public int RechageOpen;

        public List<long> GmWhiteList = new List<long>();

        public List<int> RechageDic = new List<int>();


        /// <summary>
        /// 设备黑名单
        /// </summary>
        public List<string> BanDeviceID = new List<string>();  

        /// <summary>
        /// 身份证黑名单
        /// </summary>
        public List<string> BanIdCard = new List<string>(); 


        /// <summary>
        /// ip黑名单
        /// </summary>
        public List<string> BanIPList = new List<string>();

        //封号的时候 记录 设备ID + IP + 身份信息 + 封禁时间+关联封禁帐号
        //登陆的时候会禁止登陆
        //设备ID
        //IP
        //身份信息 无法用这个ID进行注册
    }
}
