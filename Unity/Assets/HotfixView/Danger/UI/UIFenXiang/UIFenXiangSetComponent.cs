using System;
using UnityEngine;
using cn.sharesdk.unity3d;

namespace ET
{
    public class UIFenXiangSetComponent : Entity, IAwake
    {
        public GameObject Button_support;
        public GameObject FenXiang_WeiXin;
        public GameObject FenXiang_QQ;

        public int ShareType;
    }

    [ObjectSystem]
    public class UIFenXiangSetComponentAwake : AwakeSystem<UIFenXiangSetComponent>
    {
        public override void Awake(UIFenXiangSetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
    
            self.Button_support = rc.Get<GameObject>("Button_support");
            self.FenXiang_WeiXin = rc.Get<GameObject>("FenXiang_WeiXin");
            self.FenXiang_QQ = rc.Get<GameObject>("FenXiang_QQ");

            ButtonHelp.AddListenerEx(self.FenXiang_QQ.transform.Find("Button_Share").gameObject, self.OnQQZone);
            ButtonHelp.AddListenerEx(self.FenXiang_QQ.transform.Find("Button_Friend").gameObject, self.OnQQShare);
            ButtonHelp.AddListenerEx(self.FenXiang_WeiXin.transform.Find("Button_Share").gameObject, self.OnWeiXinShare);
            ButtonHelp.AddListenerEx(self.FenXiang_WeiXin.transform.Find("Button_Friend").gameObject, self.OnWeChatMoments);
            ButtonHelp.AddListenerEx(self.Button_support, () => { UIHelper.Create(self.ZoneScene(), UIType.UIRecharge).Coroutine(); });

            GameObject.Find("Global").GetComponent<Init>().OnShareHandler = (int pType, bool value) => { self.OnShareHandler(pType, value).Coroutine(); };
            self.OnUpdateUI();
        }
    }

    public static class UIFenXiangSetComponentSystem
    {
        public static async ETTask OnShareHandler(this UIFenXiangSetComponent self, int pType, bool share)
        {
            //1 4微信  2 5QQ
            Log.ILog.Debug($"分享回调：  {pType} {share}");
            int sType = self.ShareType == 1 || self.ShareType == 4 ? 1 : 0;
            if (sType == 0)
            {
                sType = self.ShareType == 2 || self.ShareType == 5 ? 2 : 0;
            }
            if (sType == 0)
            {
                return;
            }
            C2M_ShareSucessRequest c2M_ShareSucessRequest = new C2M_ShareSucessRequest() { ShareType = sType };
            await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_ShareSucessRequest);
            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIFenXiangSetComponent self)
        {
            self.FenXiang_WeiXin.transform.Find("Image_complete").gameObject.SetActive(self.IsShared(1));
            self.FenXiang_QQ.transform.Find("Image_complete").gameObject.SetActive(self.IsShared(2));
        }

        public static bool IsShared(this UIFenXiangSetComponent self, int sType)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long shareSet = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.FenShangSet);
            return (shareSet & sType) > 0;
        }

        public static void FenXiangByType(this UIFenXiangSetComponent self, int shareType)
        {
            FenXiangContent fenXiangContent = new FenXiangContent();
            fenXiangContent.FenXiang_Title = "危境";
            fenXiangContent.FenXiang_Text = "危境";
            fenXiangContent.FenXiang_ImageUrl = "https://img.tapimg.com/market/icons/6ae4a1e5df9d56dca02ecec3aa7e1252_360.png?imageMogr2/auto-orient/strip";
            fenXiangContent.FenXiang_ClickUrl = "http://39.96.194.143/weijing1/apk/beta/weijing.apk";
            fenXiangContent.Fenxiangtype = shareType;
            self.ShareType = shareType;

#if UNITY_EDITOR
            self.OnShareHandler(shareType, true).Coroutine();
#else
            GlobalHelp.FenXiang(fenXiangContent);
#endif
        }

        public static void OnQQShare(this UIFenXiangSetComponent self)
        {
            //QQ空间
            if (self.IsShared(2))
            {
                return;
            }
            self.FenXiangByType(2);
        }

        public static void OnWeiXinShare(this UIFenXiangSetComponent self)
        {
            //微信朋友圈
            if (self.IsShared(1))
            {
                return;
            }
            self.FenXiangByType(1);
        }

        public static void OnWeChatMoments(this UIFenXiangSetComponent self)
        {
            //微信好友
            if (self.IsShared(1))
            {
                return;
            }
            self.FenXiangByType(4);
        }

        public static void OnQQZone(this UIFenXiangSetComponent self)
        {
            //QQ好友
            if (self.IsShared(2))
            {
                return;
            }
            self.FenXiangByType(5);
        }
    }
}
