using System.Collections.Generic;

namespace ET
{
    public static class ConfigData
    {
        public static int PackageLimit = 100;

        public static int PopularizeZone = 2;

        public static bool AccountOldLogic = false;

        public static bool CleanSkill = false;

        public static bool LogRechargeNumber = false;

        public static bool ShowLieOpen = false;

        public static Dictionary<int , ServerInfo> ServerInfoList = new Dictionary<int , ServerInfo>();    


        public static List<int> FunctionOpenIds = new List<int> { 1025, 1043, 1044, 1045, 1052, 1055, 1057, 1058, 1059 };


        //公众平台上开发者设置的token, appID, EncodingAESKey
        public const string sToken = "yinhuochongweijing666";
        public const string sAppID = "wx8fe94511cb4701c1";
        public const string sAppSecret = "f54fcbc601209c2ba3500cd5f56e448c";
        public const string sEncodingAESKey = "yinhuochongweijing666yinhuochongweijing666a";

        //Access_Token: 95_M1EEN9KRnrHABxE1CFDdObLASQEtQ5-kf4f_6LRGQ8tOiHNCfGjrHxlOzYJcEkC4ji6N9wjqnGhq0b7H2U5R-YERYNB_L090EV0IAKYApIs1yNmngs8bjPiadhIECOiAGAPNZ
        //public const string sToken = "yinhuochongweijing666";
        //public const string sAppID = "wx7854ea0905d50363";
        //public const string sAppSecret = "f54fcbc601209c2ba3500cd5f56e448c";
        //public const string sEncodingAESKey = "yinhuochongweijing666yinhuochongweijing666a";
    }
}
