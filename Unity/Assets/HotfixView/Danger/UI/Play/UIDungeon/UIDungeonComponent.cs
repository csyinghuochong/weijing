using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public class UIDungeonComponent : Entity, IAwake, IDestroy
    {
        public GameObject ScrollView;
        public GameObject ChapterList;
        public GameObject ButtonClose;
    }


    public class UIDungeonComponentAwakeSystem : AwakeSystem<UIDungeonComponent>
    {
        public override void Awake(UIDungeonComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ChapterList = rc.Get<GameObject>("ChapterList");
            self.ScrollView = rc.Get<GameObject>("ScrollView");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseChapter(); });
        }
    }

    public static class UIDungeonComponentSystem
    {

        public static  async ETTask UpdateChapterList(this UIDungeonComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Dungeon/UIDungeonItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            List<DungeonSectionConfig> dungeonConfigs = DungeonSectionConfigCategory.Instance.GetAll().Values.ToList(); 
            for (int i = 0; i < dungeonConfigs.Count; i++)
            {
                int chapterid = dungeonConfigs[i].Id;
                GameObject go =  GameObject.Instantiate(bundleGameObject);

                UICommonHelper.SetParent(go, self.ChapterList);
                UIDungeonItemComponent uIChapterItemComponent = self.AddChild<UIDungeonItemComponent, GameObject>(go);
                uIChapterItemComponent.OnInitData(i, chapterid).Coroutine();
            }

            if (userInfoComponent.UserInfo.Lv > 50)
            {
                await TimerComponent.Instance.WaitAsync(10);
                self.ScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
            }

            await TimerComponent.Instance.WaitAsync(10);    
            self.ZoneScene().GetComponent<GuideComponent>().OnTrigger(GuideTriggerType.OpenUI, UIType.UIDungeon);
            UIHelper.GuideUISet = UIType.UIDungeon;
        }

        public static void OnCloseChapter(this UIDungeonComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIDungeon);
        }
    }
}
