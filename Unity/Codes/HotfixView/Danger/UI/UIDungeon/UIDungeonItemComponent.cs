using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIDungeonItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Text_UnlockLevel;
        public GameObject Move;
        public GameObject Text_Index;
        public GameObject Text_Name;
        public GameObject Node_1;
        public GameObject UnLock;
        public GameObject Image_DI;
        public Action<int> ClickHandler;

        public int ChapterId;
    }

    [ObjectSystem]
    public class UIDungeonItemComponentAwakeSystem : AwakeSystem<UIDungeonItemComponent, GameObject>
    {
        public override void Awake(UIDungeonItemComponent self, GameObject go)
        {
            ReferenceCollector rc = go.GetComponent<ReferenceCollector>();

            self.Move  = rc.Get<GameObject>("Move");
            self.Text_Index = rc.Get<GameObject>("Text_Index");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Node_1 = rc.Get<GameObject>("Node_1");
            self.UnLock = rc.Get<GameObject>("UnLock");
            self.Image_DI = rc.Get<GameObject>("Image_DI");
            self.Text_UnlockLevel = rc.Get<GameObject>("Text_UnlockLevel");

            self.Image_DI.GetComponent<Button>().onClick.AddListener(() => { self.OnShowChpaterLevels().Coroutine(); });
        }
    }

    public static class UIDungeonItemComponentSystem
    {
        public static int GetOpenLevel(this UIDungeonItemComponent self, int chapterId)
        {
            int level = 100;
            int[] chapters = DungeonSectionConfigCategory.Instance.Get(chapterId).RandomArea;
            for (int i = 0; i < chapters.Length; i++)
            {
                DungeonConfig dungeonConfig = DungeonConfigCategory.Instance.Get(chapters[i]);
                if (dungeonConfig.EnterLv < level)
                {
                    level = dungeonConfig.EnterLv;
                }
            }
            return level;
        }

        public static async ETTask OnInitData(this UIDungeonItemComponent self, int index, int chapterId)
        {
            self.ChapterId = chapterId;
            self.UnLock.SetActive(false);
            self.Move.SetActive(false);
            self.Text_Index.GetComponent<Text>().text = DungeonSectionConfigCategory.Instance.Get(chapterId).ChapterName;
            self.Text_Name.GetComponent<Text>().text = DungeonSectionConfigCategory.Instance.Get(chapterId).Name;

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            int openlv = self.GetOpenLevel(chapterId);
            int selfLv = userInfoComponent.UserInfo.Lv;
            if (selfLv < openlv)
            {
                self.UnLock.SetActive(true);
                self.Text_UnlockLevel.GetComponent<Text>().text = $"{openlv}级解锁";
            }
            else
            {
                self.UnLock.SetActive(false);
            }

            long instanceid = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(index * 100);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            self.Move.SetActive(true);
            self.Move.GetComponent<DoTweeningMove>().enabled = true;
        }

        public static void SetClickHandler(this UIDungeonItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static async ETTask OnShowChpaterLevels(this UIDungeonItemComponent self)
        {
            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIDungeonLevel);
            if (uI != null)
            {
                uI.GetComponent<UIDungeonLevelComponent>().OnInitData(self.ChapterId);
            }

            UIHelper.Remove(self.ZoneScene(), UIType.UIDungeon).Coroutine();
        }

    }
}
