using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{
    public class UICellChapterSelectComponent : Entity, IAwake, IDestroy, IUpdate
    {
        public GameObject ButtonClose;
        public GameObject ChapterContent;
        public GameObject ChapterList;
        public GameObject Lab_ChapterName;
        public UI NowChapterObj;

        public bool EnterScale;
        public bool ExitScale;
        public float ScaleValue;

        public float ClickPositionX;
        public float ClickPositionY;

        public List<UI> ChapterListUI = new List<UI>();
    }

    [ObjectSystem]
    public class UICellChapterSelectComponentAwakeSystem : AwakeSystem<UICellChapterSelectComponent>
    {

        public override void Awake(UICellChapterSelectComponent self)
        {
            self.EnterScale = false;
            self.ExitScale = false;
            self.ScaleValue = 1f;

            self.ChapterListUI.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ChapterContent = rc.Get<GameObject>("ChapterContent");
            self.ChapterList = rc.Get<GameObject>("ChapterList");
            self.Lab_ChapterName = rc.Get<GameObject>("Lab_ChapterName");

            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseChapter(); });
            //显示章节名称
            //self.Lab_ChapterName.GetComponent<Text>().text = "第一章";
            self.UpdateChapterList();
        }
    }

    [ObjectSystem]
    public class UIChapterSelectComponentDestroySystem : DestroySystem<UICellChapterSelectComponent>
    {
        public override void Destroy(UICellChapterSelectComponent self)
        {
            for (int i = 0; i < self.ChapterListUI.Count; i++)
            {
                self.ChapterListUI[i].Dispose();
            }
            self.ChapterListUI = null;
        }
    }

    [ObjectSystem]
    public class UICellChapterSelectComponentUpdateSystem : UpdateSystem<UICellChapterSelectComponent>
    {
        public override void Update(UICellChapterSelectComponent self)
        {
            if (self.EnterScale)
            {
                self.ScaleValue += Time.deltaTime * 5;
                GameObject gameObject = self.GetParent<UI>().GameObject;
                gameObject.transform.localScale = Vector3.one * self.ScaleValue;

                float newX = self.ClickPositionX * (self.ScaleValue - 1f);
                float newY = self.ClickPositionY * (self.ScaleValue - 1f);

                gameObject.transform.localPosition = new Vector3(newX * -1f, newY * -1f, 0f);
                if (self.ScaleValue >= 3)
                {
                    self.EnterScale = false;
                }
            }
            if (self.ExitScale)
            {
                self.ScaleValue -= Time.deltaTime * 5;
             
                if (self.ScaleValue <= 1)
                {
                    self.ScaleValue = 1;
                    self.ExitScale = false;
                    //显示
                    self.NowChapterObj.GetComponent<UICellChapterItemComponent>().Obj_ShowLv.SetActive(true);
                }
                float newX = self.ClickPositionX * (self.ScaleValue - 1f);
                float newY = self.ClickPositionY * (self.ScaleValue - 1f);
                GameObject gameObject = self.GetParent<UI>().GameObject;
                gameObject.transform.localPosition = new Vector3(newX * -1f, newY * -1f, 0f);
                gameObject.transform.localScale = Vector3.one * self.ScaleValue;

            }
        }
    }

    public static class UICellChapterSelectComponentSystem
    {
        public static void OnCloseChapter(this UICellChapterSelectComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UICellChapterSelect).Coroutine();
        }

        public static void OnChapterReturn(this UICellChapterSelectComponent self)
        {
            self.ExitScale = true;
            self.EnterScale = false;
        }

        public static void OnClickHandler(this UICellChapterSelectComponent self, int chapterId)
        {
            GameObject clickItem = null;
            Transform ShowTargetPosi = null;

            for (int i = 0; i < self.ChapterListUI.Count; i++) 
            {
                GameObject go = self.ChapterListUI[i].GameObject;
                if (chapterId == int.Parse(go.name))
                {
                    clickItem = go;
                    ShowTargetPosi = go.transform.Find("ShowTargetPosi");
                    self.NowChapterObj = self.ChapterListUI[i];
                    break;
                }
            }

            if (clickItem == null)
            return;

            self.ClickPositionX = clickItem.transform.localPosition.x + ShowTargetPosi.localPosition.x;
            self.ClickPositionY = clickItem.transform.localPosition.y + ShowTargetPosi.localPosition.y;
            self.EnterScale = true;
            self.ExitScale = false;
            self.ScaleValue = 1f;
        }

        public static void UpdateChapterList(this UICellChapterSelectComponent self)
        {
            //var path = ABPathHelper.GetUGUIPath("Chapter/UIChapterItem");
            //var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < self.ChapterList.transform.childCount; i++)
            {
                GameObject go = self.ChapterList.transform.GetChild(i).gameObject;
                int chapterid = int.Parse(go.name);

                UI uiitem = self.AddChild<UI, string, GameObject>("ChapterItem_" + chapterid, go);
                UICellChapterItemComponent uIChapterItemComponent = uiitem.AddComponent<UICellChapterItemComponent>();
                uIChapterItemComponent.OnInitData(chapterid, null);
                uIChapterItemComponent.SetClickHandler((int cid) => { self.OnClickHandler(cid); });
                self.ChapterListUI.Add(uiitem);
            }
        }
    }
}
