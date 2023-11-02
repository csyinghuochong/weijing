using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIOneSellSetComponent: Entity, IAwake
    {
        public GameObject Btn_OneSell;
        public GameObject OneSellSet;
        public GameObject ImageButton;

        public List<KeyValuePair> GameSettingInfos = new List<KeyValuePair>();
    }

    public class UIOneSellSetComponentAwakeSystem: AwakeSystem<UIOneSellSetComponent>
    {
        public override void Awake(UIOneSellSetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_OneSell = rc.Get<GameObject>("Btn_OneSell");
            self.OneSellSet = rc.Get<GameObject>("OneSellSet");
            self.ImageButton = rc.Get<GameObject>("ImageButton");

            self.Btn_OneSell.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_OneSell(); });
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClose().Coroutine(); });

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            string value = userInfoComponent.GetGameSettingValue(GameSettingEnum.OneSellSet2);
            string[] setvalues = value.Split('@');
            self.OneSellSet.transform.Find("Image_Click_0").gameObject.SetActive(setvalues[0] == "1");
            self.OneSellSet.transform.Find("Image_Click_1").gameObject.SetActive(setvalues[1] == "1");
            self.OneSellSet.transform.Find("Image_Click_2").gameObject.SetActive(setvalues[2] == "1");
            self.OneSellSet.transform.Find("Image_Click_3").gameObject.SetActive(setvalues[3] == "1");
            self.OneSellSet.transform.Find("Image_Click_4").gameObject.SetActive(setvalues[4] == "1");

            self.OneSellSet.transform.Find("Btn_Click_0").GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_OneSellSet(0); });
            self.OneSellSet.transform.Find("Btn_Click_1").GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_OneSellSet(1); });
            self.OneSellSet.transform.Find("Btn_Click_2").GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_OneSellSet(2); });
            self.OneSellSet.transform.Find("Btn_Click_3").GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_OneSellSet(3); });
            self.OneSellSet.transform.Find("Btn_Click_4").GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_OneSellSet(4); });
        }
    }

    public static class UIOneSellSetComponentSystem
    {
        public static void OnBtn_OneSellSet(this UIOneSellSetComponent self, int index)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            string value = userInfoComponent.GetGameSettingValue(GameSettingEnum.OneSellSet2);
            string[] setvalues = value.Split('@');
            setvalues[index] = setvalues[index] == "1"? "0" : "1";
            value = $"{setvalues[0]}@{setvalues[1]}@{setvalues[2]}@{setvalues[3]}@{setvalues[4]}";

            self.OneSellSet.transform.Find($"Image_Click_{index}").gameObject.SetActive(setvalues[index] == "1");
            self.SaveSettings(GameSettingEnum.OneSellSet2, value);
        }

        public static void OnBtn_OneSell(this UIOneSellSetComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            bagComponent.RequestOneSell(ItemLocType.ItemLocBag).Coroutine();
        }

        public static void SaveSettings(this UIOneSellSetComponent self, GameSettingEnum gameSettingEnum, string value)
        {
            bool exit = false;
            for (int i = 0; i < self.GameSettingInfos.Count; i++)
            {
                if (self.GameSettingInfos[i].KeyId == (int)gameSettingEnum)
                {
                    self.GameSettingInfos[i].Value = value;
                    exit = true;
                    break;
                }
            }

            if (!exit)
            {
                self.GameSettingInfos.Add(new KeyValuePair() { KeyId = (int)gameSettingEnum, Value = value });
            }

            self.ZoneScene().GetComponent<UserInfoComponent>().UpdateGameSetting(self.GameSettingInfos);
        }

        public static async ETTask OnClose(this UIOneSellSetComponent self)
        {
            if (self.GameSettingInfos.Count > 0)
            {
                self.ZoneScene().GetComponent<UserInfoComponent>().UpdateGameSetting(self.GameSettingInfos);
                HintHelp.GetInstance().DataUpdate(DataType.SettingUpdate);
                C2M_GameSettingRequest c2M_GameSettingRequest = new C2M_GameSettingRequest() { GameSettingInfos = self.GameSettingInfos };
                M2C_GameSettingResponse r2c_roleEquip =
                        (M2C_GameSettingResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_GameSettingRequest);
            }

            UIHelper.Remove(self.DomainScene(), UIType.UIOneSellSet);
        }
    }
}