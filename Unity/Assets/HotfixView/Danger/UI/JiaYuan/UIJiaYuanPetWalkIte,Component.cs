using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPetWalkItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Button_Walk;
        public GameObject Text_Tip_121;
        public GameObject Text_TotalExp;
        public GameObject Button_Stop;

        public GameObject[] ImageMood_List = new GameObject[5];

        public GameObject Text_Level;
        public GameObject Text_Name;
        public GameObject ImagePetIcon;

        public RolePetInfo RolePetInfo;
    }

    public class UIJiaYuanPetWalkItemComponentA : AwakeSystem<UIJiaYuanPetWalkItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanPetWalkItemComponent self, GameObject a)
        {
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Text_TotalExp = rc.Get<GameObject>("Text_TotalExp");

            self.Button_Stop = rc.Get<GameObject>("Button_Stop");
            ButtonHelp.AddListenerEx( self.Button_Stop, () => { self.OnButton_Stop().Coroutine();  } );
            self.Button_Walk = rc.Get<GameObject>("Button_Walk");
            ButtonHelp.AddListenerEx(self.Button_Walk, () => { self.OnButton_Walk().Coroutine(); });

            self.Text_Tip_121 = rc.Get<GameObject>("Text_Tip_121");

            for (int i = 0; i < 5; i++)
            { 
                self.ImageMood_List[i] = rc.Get<GameObject>($"ImageMood_{i}");
            }

            self.Text_Level = rc.Get<GameObject>("Text_Level");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.ImagePetIcon = rc.Get<GameObject>("ImagePetIcon");
        }
    }

    public static class UIJiaYuanPetWalkItemComponentSystem
    {

        public static async ETTask OnButton_Stop(this UIJiaYuanPetWalkItemComponent self)
        {
            C2M_JiaYuanPetWalkRequest request = new C2M_JiaYuanPetWalkRequest() { PetStatus = 0, PetId = self.RolePetInfo.Id };
            M2C_JiaYuanPetWalkResponse response = (M2C_JiaYuanPetWalkResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.Button_Walk.SetActive(self.RolePetInfo.PetStatus == 0);
            self.Button_Stop.SetActive(self.RolePetInfo.PetStatus == 2);
        }

        public static async ETTask OnButton_Walk(this UIJiaYuanPetWalkItemComponent self)
        {
            if (self.RolePetInfo.PetStatus == 1)
            {
                FloatTipManager.Instance.ShowFloatTip("出战状态不能散步！");
                return;
            }
            int lv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            if (jiaYuanComponent.JiaYuanPetList_2.Count >= 1 && lv < 10)
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！");
                return;
            }
            if (jiaYuanComponent.JiaYuanPetList_2.Count >= 2 && lv < 20)
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！");
                return;
            }

            C2M_JiaYuanPetWalkRequest  request = new C2M_JiaYuanPetWalkRequest() { PetStatus = 2, PetId = self.RolePetInfo.Id };
            M2C_JiaYuanPetWalkResponse response= (M2C_JiaYuanPetWalkResponse) await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.Button_Walk.SetActive(self.RolePetInfo.PetStatus == 0);
            self.Button_Stop.SetActive(self.RolePetInfo.PetStatus == 2);
        }

        public static void OnUpdateUI(this UIJiaYuanPetWalkItemComponent self, RolePetInfo rolePetInfo, JiaYuanPet jiaYuanPet)
        {

            self.RolePetInfo = rolePetInfo;
            self.Text_TotalExp.GetComponent<Text>().text = $"{jiaYuanPet.TotalExp}";

            for (int i = 0; i < self.ImageMood_List.Length; i++)
            {
                self.ImageMood_List[i].SetActive( i < jiaYuanPet.MoodValue );
            }

            self.Text_Level.GetComponent<Text>().text = $"等级：{rolePetInfo.PetLv}";
            self.Text_Name.GetComponent<Text>().text = rolePetInfo.PetName;

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            self.ImagePetIcon.GetComponent<Image>().sprite = sp;

            long walkTime = jiaYuanPet.StartTime > 0 ? TimeHelper.ServerNow() - jiaYuanPet.StartTime : 0;
            self.Text_Tip_121.GetComponent<Text>().text = $"已经散步:{TimeHelper.ShowLeftTime(walkTime)}";

            self.Button_Walk.SetActive(self.RolePetInfo.PetStatus == 0);
            self.Button_Stop.SetActive(self.RolePetInfo.PetStatus == 2);
        }

    }
}
