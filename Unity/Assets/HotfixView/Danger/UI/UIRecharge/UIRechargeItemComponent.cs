using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRechargeItemComponent: Entity, IAwake
    {

        public GameObject ImageIcon;
        public GameObject Text_ZuanShi;
        public GameObject Text_RMB;
        public GameObject ButtonCharge;
        public GameObject Text_give;
        public GameObject ZengSong;
     
        public int RechargeNumber;
        public Action<int> ClickHandler;
    }


    public class UIRechargeItemComponentAwakeSystem : AwakeSystem<UIRechargeItemComponent>
    {

        public override void Awake(UIRechargeItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_give = rc.Get<GameObject>("Text_give");
            self.ZengSong = rc.Get<GameObject>("ZengSong");
            self.Text_ZuanShi = rc.Get<GameObject>("Text_ZuanShi");
            self.Text_RMB = rc.Get<GameObject>("Text_RMB");
            self.ImageIcon = rc.Get<GameObject>("ImageIcon");

            self.ButtonCharge = rc.Get<GameObject>("ButtonCharge");
            self.ButtonCharge.GetComponent<Button>().onClick.AddListener(() => { self.OnImageButton(); });
        }
    }

    public static class UIRechargeItemComponentSystem
    {

        public static void OnInitData(this UIRechargeItemComponent self, int recharge, int giveNumber)
        {
            self.RechargeNumber = recharge;

            self.Text_give.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("赠送") + " " +giveNumber.ToString();
            self.ZengSong.SetActive(giveNumber > 0);
            self.Text_ZuanShi.GetComponent<Text>().text = (recharge * 100).ToString();
            self.Text_RMB.GetComponent<Text>().text = "￥" + recharge.ToString();

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RechageIcon, "UI_Image_Recharge_"+ recharge.ToString());
            self.ImageIcon.GetComponent<Image>().sprite = sp;
            self.ImageIcon.GetComponent<Image>().SetNativeSize();
            self.ImageIcon.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        }

        public static void OnImageButton(this UIRechargeItemComponent self)
        {
            self.ClickHandler(self.RechargeNumber);
        }

        public static void SetClickHandler(this UIRechargeItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }
    }

}
