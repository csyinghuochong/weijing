using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{


    public class UICellChapterOpenComponent : Entity, IAwake, IUpdate
    {
        public GameObject Lab_ChapterName;
        public GameObject PostionSet;
        public GameObject ObjImageDi;
        public float PassTime;
    }


    [ObjectSystem]
    public class UICellChapterOpenComponentAwakeSystem : AwakeSystem<UICellChapterOpenComponent>
    {
        public override void Awake(UICellChapterOpenComponent self)
        {
            self.Lab_ChapterName = self.GetParent<UI>().GameObject.Get<GameObject>("Lab_ChapterName");
            self.PostionSet = self.GetParent<UI>().GameObject.Get<GameObject>("PostionSet");
            self.ObjImageDi = self.GetParent<UI>().GameObject.Get<GameObject>("ImageDi");

            self.PassTime = 0f;
        }
    }

    [ObjectSystem]
    public class UICellChapterOpenComponentUpdateSystem : UpdateSystem<UICellChapterOpenComponent>
    {
        public override void Update(UICellChapterOpenComponent self)
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

    public static class UICellChapterOpenComponentSystem
    {
        public static void OnUpdateUI(this UICellChapterOpenComponent self)
        {
            //self.Lab_ChapterName.GetComponent<Text>().text = "新关卡开启！";
        }
    }
}
