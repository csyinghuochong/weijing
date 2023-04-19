using System.Collections.Generic;

namespace ET
{
    public static class UIHelper
    {
        public static string CurrentNpcUI = "";
        public static int CurrentNpcId = 0;
        public static List<string> WaitUI = new List<string>();
        public static List<string> OpenUIList = new List<string>();

        public static void Clear()
        {
            WaitUI.Clear();
            OpenUIList.Clear();
        }

        public static async ETTask<UI> Create(Scene scene, string uiType)
        {
            UI uI = UIHelper.GetUI( scene, uiType );
            if (uI != null )
            {
                return uI;
            }
            if (!WaitUI.Contains(uiType))
            {
                WaitUI.Add(uiType);
                uI = await scene.GetComponent<UIComponent>().Create(uiType);
                WaitUI.Remove(uiType);
                if (uI == null)
                { 
                    return null;
                }
                UILayerScript uILayerScript = uI.GameObject.GetComponent<UILayerScript>();
                if (uILayerScript.ShowHuoBi)
                {
                    OpenUIList.Insert(0,uiType);
                    UI ui_huobi = UIHelper.GetUI(scene, UIType.UICommonHuoBiSet);
                    if (ui_huobi != null)
                    {
                        ui_huobi.GetComponent<UICommonHuoBiSetComponent>().OnUpdateTitle(OpenUIList[0]);
                    }
                    else
                    {
                        Create(scene, UIType.UICommonHuoBiSet).Coroutine();
                    }
                }
                if (uILayerScript.HideMainUI)
                {
                    UI mainUi = scene.GetComponent<UIComponent>().Get(UIType.UIMain);
                    mainUi?.GetComponent<UIMainComponent>().ShowMainUI(false);
                }

                uI.OnShowUI?.Invoke();
            }
            return uI;
        }
        
        public static  void Remove(Scene scene, string uiType)
        {
            UI uI = UIHelper.GetUI(scene, uiType);
            if (uI == null)
            {
                return;
            }
            if (CurrentNpcUI == uiType)
            {
                scene.CurrentScene().GetComponent<CameraComponent>().SetBuildExit();
                CurrentNpcId = 0;
                CurrentNpcUI = "";
            }
          
            UILayerScript uILayerScript = uI.GameObject.GetComponent<UILayerScript>();
            if (uILayerScript.ShowHuoBi)
            {
                OpenUIList.Remove(uiType);
                bool haveView = OpenUIList.Count > 0;
                UI ui_huobi = UIHelper.GetUI(scene, UIType.UICommonHuoBiSet);
                if (ui_huobi != null && haveView)
                {
                    ui_huobi.GetComponent<UICommonHuoBiSetComponent>().OnUpdateTitle(OpenUIList[0]);
                }
                if (ui_huobi != null && !haveView)
                {
                    scene.GetComponent<UIComponent>().Remove(UIType.UICommonHuoBiSet);
                }
            }

            bool hideMainUI = uILayerScript.HideMainUI;
            if (hideMainUI)
            {
                UI mainUi = scene.GetComponent<UIComponent>().Get(UIType.UIMain);
                mainUi?.GetComponent<UIMainComponent>().ShowMainUI(true);
            }

            scene.GetComponent<UIComponent>().Remove(uiType);
        }

        public static UI GetUI(Scene scene, string uiType)
        {
            return scene.GetComponent<UIComponent>().Get(uiType);
        }

        public static string ZhuaPuProToStr(int par) 
        {
            float pro =  (float)par / 10000f;
            string str = "ץ���Ѷ�:";
            if (pro <= 0.05f) {
                str += "ϡ��";
            }
            if (pro > 0.1f && pro <= 0.1f)
            {
                str += "����";
            }
            if (pro > 0.1f && pro <= 0.2f)
            {
                str += "�е�";
            }
            if (pro > 0.2f && pro <= 0.3f)
            {
                str += "��";
            }
            if (pro > 0.3f)
            {
                str += "����";
            }
            return str;
        }
    }
}