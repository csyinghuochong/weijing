using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanUpLvComponent : Entity, IAwake
    {
        public GameObject Text_ZiZhiValue;
        public GameObject JiaYuanUpHint;
        public GameObject ImageExpValue;
        public GameObject JiaYuanName;
        public GameObject JiaYuanLv;
        public GameObject Lab_GengDi;
        public GameObject Lab_RenKou;
        public GameObject ZiJinDuiHuanText;
        public GameObject ExpDuiHuanText;
    }

    [ObjectSystem]
    public class UIJiaYuanUpLvComponentAwake : AwakeSystem<UIJiaYuanUpLvComponent>
    {
        public override void Awake(UIJiaYuanUpLvComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_ZiZhiValue = rc.Get<GameObject>("Text_ZiZhiValue");
            self.JiaYuanUpHint = rc.Get<GameObject>("JiaYuanUpHint");
            self.ImageExpValue = rc.Get<GameObject>("ImageExpValue");
            self.JiaYuanName = rc.Get<GameObject>("JiaYuanName");
            self.JiaYuanLv = rc.Get<GameObject>("JiaYuanLv");

            self.Lab_GengDi = rc.Get<GameObject>("Lab_GengDi");
            self.Lab_RenKou = rc.Get<GameObject>("Lab_RenKou");

            self.ZiJinDuiHuanText = rc.Get<GameObject>("ZiJinDuiHuanText");
            self.ExpDuiHuanText = rc.Get<GameObject>("ExpDuiHuanText");

            self.InitUI();

        }
    }

    public static class UIJiaYuanUpLvComponentSystem
    {

        //初始化
        public static void InitUI(this UIJiaYuanUpLvComponent self)
        {

            UserInfoComponent userInfoCom = self.ZoneScene().GetComponent<UserInfoComponent>();
            int lv = userInfoCom.UserInfo.JiaYuanLv;
            JiaYuanConfig jiayuanCof = JiaYuanConfigCategory.Instance.Get(10000 + lv);
            self.JiaYuanName.GetComponent<Text>().text = userInfoCom.UserInfo.Name + "的家园";
            self.Text_ZiZhiValue.GetComponent<Text>().text = userInfoCom.UserInfo.JiaYuanExp + "/" + jiayuanCof.Exp;
            self.ImageExpValue.GetComponent<Image>().fillAmount = (float)userInfoCom.UserInfo.JiaYuanExp / (float)jiayuanCof.Exp;

            self.Lab_GengDi.GetComponent<Text>().text = jiayuanCof.FarmNumMax.ToString();
            self.Lab_RenKou.GetComponent<Text>().text = jiayuanCof.PeopleNumMax.ToString();

            self.JiaYuanLv.GetComponent<Text>().text = "等级:" + jiayuanCof.Lv;

            //提示描述
            int hour = (int)((float)(jiayuanCof.Exp - (int)userInfoCom.UserInfo.JiaYuanExp)/ jiayuanCof.JiaYuanAddExp) + 1;
            self.JiaYuanUpHint.GetComponent<Text>().text = "提示:经验产出" + jiayuanCof.JiaYuanAddExp + "/小时,预计" + hour + "小时后可升级家园";

            self.ZiJinDuiHuanText.GetComponent<Text>().text = "兑换次数:" + "10" + "/10";
            self.ExpDuiHuanText.GetComponent<Text>().text = "兑换次数:" + "10" + "/10";
        }


        public static void OnUpdateUI(this UIJiaYuanUpLvComponent self)
        {

        }
    }

}
