using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET
{

    public class UICommonHuoBiSetComponent : Entity, IAwake, IDestroy
    {
        public GameObject Lab_RongYu;
        public GameObject Img_Back_Title;
        public GameObject Lab_ZuanShi;
        public GameObject Lab_Gold;
        public GameObject ButtonClose;
        public GameObject ButtonClose2;
        public GameObject Btn_AddZuanShi;
    }

    [ObjectSystem]
    public class UICommonHuoBiSetComponentAwakeSystem : AwakeSystem<UICommonHuoBiSetComponent>
    {
        public override void Awake(UICommonHuoBiSetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Lab_ZuanShi = rc.Get<GameObject>("Lab_ZuanShi");
            self.Lab_Gold = rc.Get<GameObject>("Lab_Gold");
            self.Img_Back_Title = rc.Get<GameObject>("Img_Back_Title");
            self.Lab_RongYu = rc.Get<GameObject>("Lab_RongYu");

            self.Btn_AddZuanShi = rc.Get<GameObject>("Btn_AddZuanShi");
            self.Btn_AddZuanShi.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_AddZuanShi(); });

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonClose(); });

            self.ButtonClose2 = rc.Get<GameObject>("ButtonClose_2");
            self.ButtonClose2.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonClose(); });

            self.InitShow();
            DataUpdateComponent.Instance.AddListener(DataType.UpdateRoleData, self);
        }
    }


    [ObjectSystem]
    public class UICommonHuoBiSetComponentDestroySystem : DestroySystem<UICommonHuoBiSetComponent>
    {
        public override void Destroy(UICommonHuoBiSetComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.UpdateRoleData, self);
        }
    }

    public static class UICommonHuoBiSetComponentSystem
    {

        public static void OnUpdateTitle(this UICommonHuoBiSetComponent self, string uiType)
        {
            string[] paths = uiType.Split('/');
            string titlePath = paths[paths.Length - 1];
            if (uiType.Contains("UITeamDungeon"))
            {
                titlePath = "UITeamDungeon";
            }

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.TiTleIcon, "Img_" + titlePath);
            self.Img_Back_Title.GetComponent<Image>().sprite = sp;
        }

        public static void OnBtn_AddZuanShi(this UICommonHuoBiSetComponent self)
        {
            if (UIHelper.GetUI(self.DomainScene(), UIType.UIRecharge) != null)
            {
                return;
            }
            UIHelper.Create(self.DomainScene(), UIType.UIRecharge).Coroutine() ;
        }

        public static void OnButtonClose(this UICommonHuoBiSetComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIItemTips);
            UIHelper.Remove(self.ZoneScene(), UIType.UIEquipDuiBiTips);
            UIHelper.Remove(self.ZoneScene(), UIType.UIGuide);

            if (UIHelper.OpenUIList.Count >0 )
            {
                if (UIHelper.OpenUIList[0] == UIType.UISetting)
                {
                    UIHelper.GetUI(self.DomainScene(), UIType.UISetting).GetComponent<UISettingComponent>().OnBeforeClose();
                }
                UIHelper.Remove(self.DomainScene(), UIHelper.OpenUIList[0]);
            }
        }

        public static void InitShow(this UICommonHuoBiSetComponent self)
        {
            self.UpdataGoldShow();
            self.UpdataRmbShow();
            self.UpdateRongYu();
            if (UIHelper.OpenUIList.Count > 0)
            {
                self.OnUpdateTitle(UIHelper.OpenUIList[0]);
            }
        }

        public static void UpdateRongYu(this UICommonHuoBiSetComponent self)
        { 
            self.Lab_RongYu.GetComponent<Text>().text = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.RongYu.ToString();
        }

        public static void UpdataGoldShow(this UICommonHuoBiSetComponent self)
        {
            self.Lab_Gold.GetComponent<Text>().text = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Gold.ToString();
        }

        public static void UpdataRmbShow(this UICommonHuoBiSetComponent self)
        {
            self.Lab_ZuanShi.GetComponent<Text>().text = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Diamond.ToString();
        }

    }
}
