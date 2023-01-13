using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    public static class IPHoneHelper
    {

        public static void SetPosition(GameObject gameObject, Vector2 newPosition)
        {
            if (!CheckIphone())
            {
                return;
            }

            if (gameObject.GetComponent<DoTweeningMove>() != null)
            {
                gameObject.GetComponent<DoTweeningMove>().enabled = false;  
            }
            //Vector3 vector3 = gameObject.GetComponent<RectTransform>().anchoredPosition;
            //vector3.x += 100f;
            gameObject.GetComponent<RectTransform>().anchoredPosition = newPosition;
        }

        public static bool CheckIphone()
        {
        //https://blog.csdn.net/qq_39162826/article/details/121654464
#if !UNITY_EDITOR && UNITY_IOS
        string modelStr = UnityEngine.SystemInfo.deviceModel;
        Log.ILog.Debug(deviceModel + ":  " + modelStr);
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
