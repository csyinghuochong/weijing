
namespace ET
{
    public static class PlatformHelper
    {

        public static string GetPlatformName(int platformid)
        {
            string platformname  = string.Empty;    
            switch (platformid)
            {
                case 20001:
                    platformname = "IOS";
                    break;

                default:
                    platformname = "ANDROID";
                    break;
            }

            return platformname;    
        }
        
    }

}

