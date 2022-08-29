using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITowerOpenComponent : Entity, IAwake, IUpdate
    {
        public GameObject Lab_ChapterName;
        public GameObject PostionSet;
        public GameObject ObjImageDi;
        public float PassTime;
    }


    [ObjectSystem]
    public class UITowerOpenComponentAwakeSystem : AwakeSystem<UITowerOpenComponent>
    {
        public override void Awake(UITowerOpenComponent self)
        {
            self.Lab_ChapterName = self.GetParent<UI>().GameObject.Get<GameObject>("Lab_ChapterName");
            self.PostionSet = self.GetParent<UI>().GameObject.Get<GameObject>("PostionSet");
            self.ObjImageDi = self.GetParent<UI>().GameObject.Get<GameObject>("ImageDi");

            self.PassTime = 0f;
        }
    }

    [ObjectSystem]
    public class UITowerOpenComponentUpdateSystem : UpdateSystem<UITowerOpenComponent>
    {
        public override void Update(UITowerOpenComponent self)
        {
            self.PassTime += Time.deltaTime;
            if (self.PassTime < 2f)
            {
                float colorValue = 0.3f - 0.3f * self.PassTime / 2f;
                self.ObjImageDi.GetComponent<Image>().color = new Color(0, 0, 0, colorValue);
                self.Lab_ChapterName.GetComponent<Text>().color = new Color(1, 1, 1, 1 - self.PassTime / 2f);
                return;
            }
            self.GetParent<UI>().Dispose();
        }
    }

    public static class UITowerOpenComponentSystem
    {
        public static void OnUpdateUI(this UITowerOpenComponent self, int towerId)
        {
            self.Lab_ChapterName.GetComponent<Text>().text = TowerConfigCategory.Instance.Get(towerId).Name;
        }
    }
}
