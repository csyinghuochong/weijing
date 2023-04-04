using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPopularizeItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ImageHeadIcon;
        public GameObject Text_Level;
        public GameObject Text_Name;

        public GameObject GameObject;
    }

    public class UIPopularizeItemComponentAwake : AwakeSystem<UIPopularizeItemComponent, GameObject>
    {
        public override void Awake(UIPopularizeItemComponent self, GameObject a)
        {
            self.GameObject = a;

            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.ImageHeadIcon = rc.Get<GameObject>("ImageHeadIcon");
            self.Text_Level = rc.Get<GameObject>("Text_Level");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
        }
    }

    public static class UIPopularizeItemComponentSystem
    {
        public static void OnUpdateUI(this UIPopularizeItemComponent self, PopularizeInfo popularizeInfo)
        {
            self.Text_Name.GetComponent<Text>().text = popularizeInfo.Nmae;
            self.Text_Level.GetComponent<Text>().text = "等级:" + popularizeInfo.Level.ToString();
        }
    }
}
