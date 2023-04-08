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
        public GameObject Text_Tip_121;
        public GameObject Text_TotalExp;
        public GameObject Button_Stop;

        public GameObject[] ImageMood_List = new GameObject[5];

        public GameObject Text_Level;
        public GameObject Text_Name;
        public GameObject ImagePetIcon;
    }

    public class UIJiaYuanPetWalkItemComponentA : AwakeSystem<UIJiaYuanPetWalkItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanPetWalkItemComponent self, GameObject a)
        {
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Text_TotalExp = rc.Get<GameObject>("Text_TotalExp");
            self.Button_Stop = rc.Get<GameObject>("Button_Stop");
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

        public static void OnUpdateUI(this UIJiaYuanPetWalkItemComponent self, RolePetInfo rolePetInfo, JiaYuanPet jiaYuanPet)
        {
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
        }

    }
}
