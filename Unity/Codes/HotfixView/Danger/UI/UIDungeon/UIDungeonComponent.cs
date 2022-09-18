using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public class UIDungeonComponent : Entity, IAwake, IDestroy
    {
        public GameObject ChapterList;
        public GameObject ButtonClose;
    }

    [ObjectSystem]
    public class UIDungeonComponentAwakeSystem : AwakeSystem<UIDungeonComponent>
    {
        public override void Awake(UIDungeonComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ChapterList = rc.Get<GameObject>("ChapterList");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseChapter(); });

            self.UpdateChapterList().Coroutine();
        }
    }

    public static class UIDungeonComponentSystem
    {
        public static async ETTask UpdateChapterList(this UIDungeonComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Dungeon/UIDungeonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            List<DungeonSectionConfig> dungeonConfigs = DungeonSectionConfigCategory.Instance.GetAll().Values.ToList(); 
            for (int i = 0; i < dungeonConfigs.Count; i++)
            {
                int chapterid = dungeonConfigs[i].Id;
                GameObject go =  GameObject.Instantiate(bundleGameObject);

                UICommonHelper.SetParent(go, self.ChapterList);
                UIDungeonItemComponent uIChapterItemComponent = self.AddChild<UIDungeonItemComponent, GameObject>(go);
                uIChapterItemComponent.OnInitData(i, chapterid).Coroutine();
            }
        }

        public static void OnCloseChapter(this UIDungeonComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIDungeon);
        }
    }
}
