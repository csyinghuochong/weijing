using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UISerialComponent : Entity, IAwake
    {
        public GameObject UICommonItem;
        public GameObject ItemList;
        public GameObject InputField_Code;
        public GameObject ButtonGet;
        public GameObject ButtonOk;

        public float LastTime;
    }

    public class UISerialComponentAwake : AwakeSystem<UISerialComponent>
    {
        public override void Awake(UISerialComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.InputField_Code = rc.Get<GameObject>("InputField_Code");

            self.ItemList = rc.Get<GameObject>("ItemList");

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem.SetActive(false);

            self.ButtonGet = rc.Get<GameObject>("ButtonGet");
            ButtonHelp.AddListenerEx(self.ButtonGet, () => { self.OnButtonGet().Coroutine(); });

            self.ButtonOk = rc.Get<GameObject>("ButtonOk");
            ButtonHelp.AddListenerEx(self.ButtonOk, self.OnButtonOk);

            string[] rewardItems = ConfigHelper.SerialReward[1].Split('@');
            for (int i = 0; i < rewardItems.Length; i++)
            {
                string[] iteminfo = rewardItems[i].Split(';');
                GameObject itemSpace = GameObject.Instantiate(self.UICommonItem);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.ItemList);
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
              
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = int.Parse(iteminfo[0]), ItemNum = int.Parse(iteminfo[1]) }, ItemOperateEnum.None);
                uIItemComponent.Label_ItemName.SetActive(true);
                uIItemComponent.Label_ItemNum.SetActive(true);
                itemSpace.transform.localScale = Vector3.one * 1f;
            }
        }
    }

    public static class UISerialComponentSystem
    {

        public static async ETTask OnButtonGet(this UISerialComponent self)
        {
            if (Time.time - self.LastTime < 1f)
            {
                return;
            }

            string serial = self.InputField_Code.GetComponent<InputField>().text;
            if (string.IsNullOrEmpty(serial))
            {
                return;
            }
            self.LastTime = Time.time;

            int publicserial = ActivityConfigCategory.Instance.GetPulicSerial(serial);
            if (publicserial > 0)
            {
                C2M_ActivityReceiveRequest request = new C2M_ActivityReceiveRequest() { ActivityType = 34, ActivityId = publicserial };
                M2C_ActivityReceiveResponse r2c_roleEquip = (M2C_ActivityReceiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);
            }
            else
            {
                C2M_SerialReardRequest request = new C2M_SerialReardRequest() { SerialNumber = serial };
                M2C_SerialReardResponse response = (M2C_SerialReardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            }
        }

        public static HotVersion GetHotVersion(this UISerialComponent self)
        {
            var path_1 = ABPathHelper.GetTextPath("Version");
            var request = libx.Assets.LoadAsset(path_1, typeof(TextAsset));
            TextAsset textAsset3 = request.asset as TextAsset;
            return JsonHelper.FromJson<HotVersion>(textAsset3.text);
        }

        public static void OnButtonOk(this UISerialComponent self)
        {
            HotVersion hotVersion = self.GetHotVersion();

#if UNITY_IPHONE || UNITY_IOS
            Application.OpenURL(hotVersion.IOS_URL);
#else
            Application.OpenURL("https://apps.apple.com/us/app/%E5%8D%B1%E5%A2%83/id1510177862");
#endif
        }

    }
}
