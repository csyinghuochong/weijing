using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITrialDungeonItemComponent : Entity, IAwake
    {
        public GameObject Lab_Lv;
        public GameObject Lab_HP;
        public Text Lab_Name;
        public Image Image_XuanZhong;
        public GameObject Btn_XuanZhong;
        public GameObject Lab_PetName;
        public GameObject ItemHeroIon;
        public GameObject GameObject;
        public GameObject Hint_1;
        public GameObject Hint_2;
        public GameObject Hint_3;
        public TowerConfig TowerConfig;
        public Action<int> ClickHandle;

        public void OnInitUI(TowerConfig towerConfig, Action<int> action)
        {
            this.TowerConfig = towerConfig;
            ReferenceCollector rc = this.GameObject.GetComponent<ReferenceCollector>();

            this.Lab_Lv = rc.Get<GameObject>("Lab_Lv");
            this.Lab_HP = rc.Get<GameObject>("Lab_HP");
            this.Lab_Name = rc.Get<GameObject>("Lab_Name").GetComponent<Text>();

            this.Image_XuanZhong = rc.Get<GameObject>("Btn_XuanZhong").GetComponent<Image>();
            this.Image_XuanZhong.color = new Color(255, 255, 255, 0);
            this.Btn_XuanZhong = rc.Get<GameObject>("Btn_XuanZhong");
            this.Btn_XuanZhong.GetComponent<Button>().onClick.AddListener(this.OnBtn_XuanZhong);

            this.Lab_PetName = rc.Get<GameObject>("Lab_PetName");
            this.ItemHeroIon = rc.Get<GameObject>("ItemHeroIon");

            this.Hint_1 = rc.Get<GameObject>("Hint_1");
            this.Hint_2 = rc.Get<GameObject>("Hint_2");
            this.Hint_3 = rc.Get<GameObject>("Hint_3");

            this.Lab_Name.text = towerConfig.Name;
            this.ClickHandle = action;

            //1;0,0,3;72000001;1
            string monsterSet = towerConfig.MonsterSet;
            string[] monsterInfo = monsterSet.Split(';');
            int monster = int.Parse(monsterInfo[2]);
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monster);
            this.Lab_Lv.GetComponent<Text>().text = $"等级: {monsterConfig.Lv}";
            this.Lab_HP.GetComponent<Text>().text = $"生命: {monsterConfig.Hp}";

            //int curId = 
            UserInfo userInfo = this.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            NumericComponent numcom = UnitHelper.GetMyUnitFromZoneScene(this.ZoneScene()).GetComponent<NumericComponent>();
            int towerid = numcom.GetAsInt(NumericType.TrialDungeonId);   // 
            //已经打完
            if (towerid >= towerConfig.Id) {
                //是否领取
                if (userInfo.TowerRewardIds.Contains(towerConfig.Id))
                {
                    //包含
                    this.Hint_2.SetActive(true);
                }
                else {
                    //不包含
                    this.Hint_3.SetActive(true);
                }
            }
            else {
                if (towerid + 1 == towerConfig.Id) {
                    this.Hint_1.SetActive(true);
                }
            }
        }

        public void OnBtn_XuanZhong()
        {
            this.ClickHandle(this.TowerConfig.Id);
        }

        public void OnSelected(int towerId)
        {
            this.Image_XuanZhong.color = new Color(255,255,255, towerId == this.TowerConfig.Id?255:0);
        }
    }
}
