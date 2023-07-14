using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace ET
{
    public class UIDungeonComponent : Entity, IAwake, IDestroy
    {
        public Dictionary<long, GameObject> BossRefreshObjs = new Dictionary<long, GameObject>();
        public long Timer;
        public GameObject BossRefreshTimeList;
        public GameObject ScrollView;
        public GameObject ChapterList;
        public GameObject ButtonClose;
    }


    [Timer(TimerType.UIDungenBossRefreshTimer)]
    public class UIDungenBossRefreshTimer: ATimer<UIDungeonComponent>
    {
        public override void Run(UIDungeonComponent self)
        {
            self.OnTimer();
        }
    }
    
    public class UIDungeonComponentAwakeSystem : AwakeSystem<UIDungeonComponent>
    {
        public override void Awake(UIDungeonComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BossRefreshTimeList = rc.Get<GameObject>("BossRefreshTimeList");
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ChapterList = rc.Get<GameObject>("ChapterList");
            self.ScrollView = rc.Get<GameObject>("ScrollView");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseChapter(); });
        }
    }

    public class UIDungeonComponentDestoySystem: DestroySystem<UIDungeonComponent>
    {
        public override void Destroy(UIDungeonComponent self)
        {
            if (self.Timer != 0)
            {
                TimerComponent.Instance.Remove(ref self.Timer);
            }
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

            
            
            #region Boss刷新倒计时显示

            // 获取所有Boss的刷新数据
            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            var bossRevivesTime = myUnit.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.MonsterRevives;
            
            // 根据时间排序,从小到大
            bossRevivesTime.Sort((s1, s2) => long.Parse(s1.Value).CompareTo(long.Parse(s2.Value)));

            // 为Boss刷新列表添加子物体
            var uiBossRefreshTimeItemPath = ABPathHelper.GetUGUIPath("Dungeon/UIBossRefreshTimeItem");
            var uiBossRefreshTimeItemObj =  ResourcesComponent.Instance.LoadAsset<GameObject>(uiBossRefreshTimeItemPath);

            self.BossRefreshObjs.Clear();
            for (int i = 0; i < bossRevivesTime.Count; i++)
            {
                var bossConfId = bossRevivesTime[i].KeyId;
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(bossConfId);
                
                GameObject go =  GameObject.Instantiate(uiBossRefreshTimeItemObj);
                ReferenceCollector boosTimeItemRc = go.gameObject.GetComponent<ReferenceCollector>();

                // Boss头像
                Sprite sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.MonsterIcon, monsterConfig.MonsterHeadIcon);
                boosTimeItemRc.Get<GameObject>("Photo").GetComponent<Image>().sprite = sprite;
                
                // Boss名字
                boosTimeItemRc.Get<GameObject>("Name").GetComponent<Text>().text = monsterConfig.MonsterName;
                
                // Boss刷新时间
                long time = long.Parse(bossRevivesTime[i].Value);
                self.BossRefreshObjs.Add(time,go);
                
                UICommonHelper.SetParent(go, self.BossRefreshTimeList);
                
            }
            // 开启定时器
            if (self.Timer != 0)
            {
                TimerComponent.Instance.Remove(ref self.Timer);
            }
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.UIDungenBossRefreshTimer, self);

            #endregion
        }

        /// <summary>
        /// UI刷新Bosss复活时间
        /// </summary>
        /// <param name="self"></param>
        public static void OnTimer(this UIDungeonComponent self)
        {
            foreach (KeyValuePair<long, GameObject> it in self.BossRefreshObjs)
            {
                long time = it.Key;
                if (time > TimeHelper.ServerNow())
                {
                    time -= TimeHelper.ClientNow();
                    time /= 1000;
                    int hour = (int)time / 3600;
                    int min = (int)((time - (hour * 3600)) / 60);
                    int sec = (int)(time - (hour * 3600) - (min * 60));
                    string showStr = hour + "时" + min + "分" + sec + "秒";
                    it.Value.gameObject.GetComponent<ReferenceCollector>().Get<GameObject>("Time").GetComponent<Text>().text = $"刷新时间:{showStr}";
                }
                else
                {
                    it.Value.gameObject.GetComponent<ReferenceCollector>().Get<GameObject>("Time").GetComponent<Text>().text = "已刷新";
                }
            }
        }

        public static void OnCloseChapter(this UIDungeonComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIDungeon);
        }
    }
}
