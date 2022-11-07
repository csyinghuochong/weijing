using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleQiangHuaItemComponent : Entity, IAwake<GameObject>
    {
        public int ItemSubType;
        public Action<int> ClickHandler;

        public GameObject GameObject;
        public GameObject Btn_Equip;
        public GameObject Text_QiangHua;
    }

    [ObjectSystem]
    public class UIRoleQiangHuaItemComponentAwakeSystem : AwakeSystem<UIRoleQiangHuaItemComponent, GameObject>
    {
        public override void Awake(UIRoleQiangHuaItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            self.Btn_Equip = gameObject.transform.Find("Btn_Equip").gameObject;
            self.Btn_Equip.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Equip(); });

            self.Text_QiangHua = gameObject.transform.Find("Text_QiangHua").gameObject;
        }
    }

    public static class UIRoleQiangHuaItemComponentSystem
    {
        public static void OnInitUI(this UIRoleQiangHuaItemComponent self,int index)
        { 
            self.ItemSubType = index;
        }

        public static void OnBtn_Equip(this UIRoleQiangHuaItemComponent self)
        {
            self.ClickHandler(self.ItemSubType);
        }

        public static void SetClickHandler(this UIRoleQiangHuaItemComponent self, Action<int> action)
        { 
            self.ClickHandler = action; 
        }

        public static void OnUpateUI(this UIRoleQiangHuaItemComponent self, int qianghuaLevel)
        {
            self.Text_QiangHua.GetComponent<Text>().text = $"强化+{qianghuaLevel}";
        }
    }
}