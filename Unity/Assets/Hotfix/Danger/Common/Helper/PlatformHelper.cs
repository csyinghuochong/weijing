
namespace ET
{
    public static class PlatformHelper
    {

        public static string GetPlatformName(int platformid, int platformtwo)
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

        public static string GetPlatformTwoName(int platformtwo)
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

