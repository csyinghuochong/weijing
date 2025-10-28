using System.Collections.Generic;

namespace Douyin.Game
{
    public class CloudGameInfo
    {
        // 云游戏平台的名称，自定义字符串，建议包含有标识性的应用名或公司名
        // 必填，不允许为null或空串
        public string CloudGameName;

        // 可选字段
        public string HostPackageName;
        public string HostVersionName;
        public int HostVersionCode;
        public string HostDeviceModel;
        public string HostIp;
        public string HostUserAgent;
        public string HostOsType;
        public string HostMac;
        public string HostAndroidId;
        public string HostOaid;
        public string HostImei;
        public string HostIdfa;
        public string HostCaid;

        // 扩展字段（可选），如果非空，SDK将内部字段打平上报到埋点公参，自动加上前缀"cg_cgi_ex_"
        public Dictionary<string, string> Extra = new Dictionary<string, string>();
    }
}