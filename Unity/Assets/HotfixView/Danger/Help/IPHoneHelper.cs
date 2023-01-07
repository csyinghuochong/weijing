using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class IPHoneHelper
    {


        public static bool CheckIphone()
        {
#if !UNITY_EDITOR && UNITY_IOS
        string modelStr = UnityEngine.SystemInfo.deviceModel;
        if (modelStr == "iPhone10,3" || modelStr == "iPhone10,6" || modelStr == "iPhone11,2" || modelStr == "iPhone11,6" || modelStr == "iPhone11,8")
        {
            return true;
        }
        else
        {
            return false;
        }
#else
            return false;
#endif
        }
    }

}
