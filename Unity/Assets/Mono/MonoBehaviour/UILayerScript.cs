using UnityEngine;

namespace ET
{
    public enum UILayer
    {
        Hidden = 0,
        Blood = 10,
        Low = 20,
        Mid = 30,
        High = 40,
    }

    public enum UIEnum
    {
        FullScreen = 0,
        PopupUI = 1,
    }

    public class UILayerScript : MonoBehaviour
    {
        public UILayer UILayer;
        public UIEnum UIType;
        public bool HideMainUI;
        public bool ShowHuoBi;
    }
}