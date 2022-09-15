using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UICellChapterItemComponent : Entity, IAwake
    {

        public GameObject Image_DI;
        public GameObject UnLock;
        public GameObject Obj_ShowLv;
        public GameObject ShowTargetPosi;
        public Action<int> ClickHandler;

        public int ChapterId;
    }

    [ObjectSystem]
    public class UICellChapterItemComponentAwakeSystem : AwakeSystem<UICellChapterItemComponent>
    {
        public override void Awake(UICellChapterItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Image_DI = rc.Get<GameObject>("Image_DI");
            self.UnLock = rc.Get<GameObject>("UnLock");
            self.Obj_ShowLv = rc.Get<GameObject>("Image_ShowLv");
            self.ShowTargetPosi = rc.Get<GameObject>("ShowTargetPosi");
            self.Image_DI.GetComponent<Button>().onClick.AddListener(() => { self.OnShowChpaterLevels().Coroutine(); });
        }
    }

    public static class UICellChapterItemComponentSystem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="chapterId"></param>
        /// <param name="passLevels">已经通关的关卡id</param>
        public static void OnInitData(this UICellChapterItemComponent self, int chapterId, List<int> passLevels)
        {
            //默认暂时只开启第一章
            self.ChapterId = chapterId;
            bool chapterOpen = self.ZoneScene().GetComponent<UserInfoComponent>().IsChapterOpen(chapterId);
            self.UnLock.SetActive(!chapterOpen);
            self.Obj_ShowLv.SetActive(chapterOpen);

            GameObject Image_Icon = self.UnLock.transform.Find("Image_Icon").gameObject;
            UICommonHelper.SetImageGray(Image_Icon, !chapterOpen);
            //self.Image_DI.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ChapterIcon, "ZhangJie_" + chapterId.ToString());
        }

        public static void SetClickHandler(this UICellChapterItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static async ETTask OnShowChpaterLevels(this UICellChapterItemComponent self)
        {
            UI uiChapterSelect = UIHelper.GetUI( self.ZoneScene(), UIType.UICellChapterSelect );
            if (uiChapterSelect.GetComponent<UICellChapterSelectComponent>().EnterScale)
                return;

            self.Obj_ShowLv.SetActive(false);           //隐藏标签显示
            int cid = int.Parse(self.GetParent<UI>().GameObject.name);
            self.ClickHandler(cid);
            //await TimerComponent.Instance.WaitAsync(500);
            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UICellDungeonSelect);
            if (uI != null)
            {
                uI.GetComponent<UICellDungeonSelectComponent>().OnInitData(self.ChapterId);
            }
        }

    }
}