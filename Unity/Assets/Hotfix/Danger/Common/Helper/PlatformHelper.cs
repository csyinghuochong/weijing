
namespace ET
{
    public static class PlatformHelper
    {

        public static string GetPlatformName(int platformid)
        {
            ///0 默认 TapTap1  QQ2 platform3 小说推广 platform4备用  TikTok5  TikTokMuBao6(抖音母包)  ios20001
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
                    platformname = "TikTok";
                    break;
                default:
                    platformname = "ANDROID";
                    break;
            }

            return platformname;    
        }
        
    }

}

