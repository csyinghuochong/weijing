
namespace ET
{
    public static class PlatformHelper
    {

        public static string GetPlatformName(int platformid)
        {
            ///0 默认 taptap1  QQ2 platform3 小说推广 platform4备用  TikTok5  TikTokMuBao6(抖音母包) Google7  TikTokGuanFu8  渠道包100+  ios20001
            string platformname  = string.Empty;    
            switch (platformid)
            {
                case 20001:
                    platformname = "IOS";
                    break;
                case 1:
                    platformname = "TapTap";
                    break;
                case 2:
                    platformname = "QQ";
                    break;
                case 3:
                    platformname = "Book";
                    break;
                case 5:
                case 6:
                case 8:
                    platformname = "TikTok";
                    break;
                case 7:
                    platformname = "Google";
                    break;
                case 100:
                    platformname = "QuDao";
                    break;
                default:
                    platformname = "ANDROID";
                    break;
            }

            return platformname;    
        }
        
    }

}

