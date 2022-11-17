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
        public TowerConfig TowerConfig;
        public Action<int> ClickHandle;

        public void OnInitUI(GameObject gameObject, TowerConfig towerConfig, Action<int> action)
        {
            this.GameObject = gameObject;
            this.TowerConfig = towerConfig;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            this.Lab_Lv = rc.Get<GameObject>("Lab_Lv");
            this.Lab_HP = rc.Get<GameObject>("Lab_HP");
            this.Lab_Name = rc.Get<GameObject>("Lab_Name").GetComponent<Text>();

            this.Image_XuanZhong = rc.Get<GameObject>("Btn_XuanZhong").GetComponent<Image>();
            this.Image_XuanZhong.color = new Color(255, 255, 255, 0);
            this.Btn_XuanZhong = rc.Get<GameObject>("Btn_XuanZhong");
            this.Btn_XuanZhong.GetComponent<Button>().onClick.AddListener(this.OnBtn_XuanZhong);

            this.Lab_PetName = rc.Get<GameObject>("Lab_PetName");
            this.ItemHeroIon = rc.Get<GameObject>("ItemHeroIon");

            this.Lab_Name.text = towerConfig.Name;
            this.ClickHandle = action;
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
