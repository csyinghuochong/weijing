using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIDungeonMapTransferComponent: Entity, IAwake, IDestroy
    {
        public List<UIDungeonMapTransferItemComponent> LevelListUI = new List<UIDungeonMapTransferItemComponent>();
        public Dictionary<int, Text> BossRefreshObjs = new Dictionary<int, Text>();
        public Dictionary<int, long> BossRefreshTime = new Dictionary<int, long>();
        public long Timer;
        public GameObject ChapterText;
        public GameObject BossRefreshTimeList;
        public GameObject UIBossRefreshTimeItem;
        public GameObject BossRefreshSettingBtn;
        public GameObject BossRefreshSettingPanel;
        public GameObject BossRefreshSettingList;
        public GameObject UIBossRefreshSettingItem;
        public GameObject CloseBossRefreshSettingBtn;
        public GameObject ChapterList;
        public GameObject UIDungeonLevelItem;
        public GameObject ButtonClose;
        public List<string> AssetPath = new List<string>();
    }

    public class UIDungeonMapTransferComponentAwakeSystem: AwakeSystem<UIDungeonMapTransferComponent>
    {
        public override void Awake(UIDungeonMapTransferComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ChapterText = rc.Get<GameObject>("ChapterText");
            self.BossRefreshTimeList = rc.Get<GameObject>("BossRefreshTimeList");
            self.UIBossRefreshTimeItem = rc.Get<GameObject>("UIBossRefreshTimeItem");
            self.BossRefreshSettingBtn = rc.Get<GameObject>("BossRefreshSettingBtn");
            self.BossRefreshSettingPanel = rc.Get<GameObject>("BossRefreshSettingPanel");
            self.BossRefreshSettingList = rc.Get<GameObject>("BossRefreshSettingList");
            self.UIBossRefreshSettingItem = rc.Get<GameObject>("UIBossRefreshSettingItem");
            self.CloseBossRefreshSettingBtn = rc.Get<GameObject>("CloseBossRefreshSettingBtn");
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ChapterList = rc.Get<GameObject>("ChapterList");
            self.UIDungeonLevelItem = rc.Get<GameObject>("UIDungeonLevelItem");

            self.UIDungeonLevelItem.SetActive(false);
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseChapter(); });
            self.BossRefreshSettingBtn.GetComponent<Button>().onClick.AddListener(self.OnBossRefreshSetting);
            self.CloseBossRefreshSettingBtn.GetComponent<Button>().onClick.AddListener(self.OnCloseBossRefreshSetting);

            self.UIBossRefreshTimeItem.SetActive(false);
            self.UIBossRefreshSettingItem.SetActive(false);
            self.BossRefreshSettingPanel.SetActive(false);
        }
    }

    public class UIDungeonMapTransferComponentDestoySystem: DestroySystem<UIDungeonMapTransferComponent>
    {
        public override void Destroy(UIDungeonMapTransferComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [Timer(TimerType.MapTransferBossRefreshTimer)]
    public class MapTransferBossRefreshTimer: ATimer<UIDungeonMapTransferComponent>
    {
        public override void Run(UIDungeonMapTransferComponent self)
        {
            self.UpdateBossRefreshTimer();
        }
    }

    public static class UIDungeonMapTransferComponentSystem
    {
        public static async ETTask UpdateChapterList(this UIDungeonMapTransferComponent self)
        {
            int sceneId = self.ZoneScene().GetComponent<MapComponent>().SceneId;
            int chapterid = 0;
            DungeonSectionConfig mdungeonSectionConfig = null;
            foreach (DungeonSectionConfig dungeonSectionConfig in DungeonSectionConfigCategory.Instance.GetAll().Values)
            {
                if (dungeonSectionConfig.RandomArea.Contains(sceneId))
                {
                    chapterid = dungeonSectionConfig.Id;
                    mdungeonSectionConfig = dungeonSectionConfig;
                    break;
                }
            }

            if (chapterid == 0)
            {
                return;
            }

            self.ChapterText.GetComponent<Text>().text = mdungeonSectionConfig.ChapterName;
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;

            int number = 0;
            for (int i = 0; i < mdungeonSectionConfig.RandomArea.Length; i++)
            {
                //只显示满足进入等级的关卡
                DungeonConfig chapterCof = DungeonConfigCategory.Instance.Get(mdungeonSectionConfig.RandomArea[i]);
                if (userInfo.Lv < chapterCof.EnterLv)
                {
                    break;
                }

                UIDungeonMapTransferItemComponent uiitem = null;
                if (number < self.LevelListUI.Count)
                {
                    uiitem = self.LevelListUI[i];
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.UIDungeonLevelItem);
                    go.transform.SetParent(self.ChapterList.transform);
                    go.SetActive(true);
                    go.transform.localPosition = Vector3.zero;
                    go.transform.localScale = Vector3.one;

                    uiitem = self.AddChild<UIDungeonMapTransferItemComponent, GameObject>(go);
                    uiitem.OnInitData(chapterid, i, mdungeonSectionConfig.RandomArea[i]);
                    self.LevelListUI.Add(uiitem);
                }

                number++;
            }
        }

        /// <summary>
        /// Boss刷新倒计时显示
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask UpdateBossRefreshTimeList(this UIDungeonMapTransferComponent self)
        {
            // 重新从服务器同步Booss刷新数据
            long instance = self.InstanceId;
            await NetHelper.RequestUserInfo(self.ZoneScene());
            if (instance != self.InstanceId)
            {
                return;
            }

            // 获取所有Boss的刷新数据
            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            var bossRevivesTime = myUnit.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.MonsterRevives;

            // 根据时间排序,从小到大
            bossRevivesTime.Sort((s1, s2) => long.Parse(s1.Value).CompareTo(long.Parse(s2.Value)));

            // 为Boss刷新列表添加子物体
            self.BossRefreshObjs.Clear();
            self.BossRefreshTime.Clear();
            for (int i = 0; i < bossRevivesTime.Count; i++)
            {
                var bossConfId = bossRevivesTime[i].KeyId;

                // 判断该boss是否需要显示,暂时从本地获取设置
                if (PlayerPrefs.HasKey(bossConfId.ToString()))
                {
                    if (PlayerPrefs.GetString(bossConfId.ToString()) == "0")
                    {
                        continue;
                    }
                }
                else
                {
                    PlayerPrefs.SetString(bossConfId.ToString(), "1");
                }

                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(bossConfId);

                GameObject go = GameObject.Instantiate(self.UIBossRefreshTimeItem);
                go.SetActive(true);
                ReferenceCollector boosTimeItemRc = go.gameObject.GetComponent<ReferenceCollector>();

                // Boss头像
                string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.MonsterIcon, monsterConfig.MonsterHeadIcon);
                Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                if (!self.AssetPath.Contains(path))
                {
                    self.AssetPath.Add(path);
                }

                boosTimeItemRc.Get<GameObject>("Photo").GetComponent<Image>().sprite = sp;

                // Boss名字
                boosTimeItemRc.Get<GameObject>("Name").GetComponent<Text>().text = monsterConfig.MonsterName;

                int dungeonid = SceneConfigHelper.GetFubenByMonster(monsterConfig.Id);
                if (dungeonid > 0)
                {
                    // Boss出生地
                    boosTimeItemRc.Get<GameObject>("Map").GetComponent<Text>().text =
                            $"({DungeonConfigCategory.Instance.Get(dungeonid).ChapterName})";
                }

                if (self.BossRefreshTime.ContainsKey(bossRevivesTime[i].KeyId))
                {
                    continue;
                }

                // Boss刷新时间
                self.BossRefreshTime.Add(bossRevivesTime[i].KeyId, long.Parse(bossRevivesTime[i].Value));
                self.BossRefreshObjs.Add(bossRevivesTime[i].KeyId,
                    go.GetComponent<ReferenceCollector>().Get<GameObject>("Time").GetComponent<Text>());

                UICommonHelper.SetParent(go, self.BossRefreshTimeList);
            }

            self.UpdateBossRefreshTimer();

            // 开启定时器
            if (self.Timer != 0)
            {
                TimerComponent.Instance.Remove(ref self.Timer);
            }

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.MapTransferBossRefreshTimer, self);
        }

        /// <summary>
        /// UI刷新Bosss复活时间
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateBossRefreshTimer(this UIDungeonMapTransferComponent self)
        {
            foreach (KeyValuePair<int, long> it in self.BossRefreshTime)
            {
                long time = it.Value;
                if (time > TimeHelper.ServerNow())
                {
                    time -= TimeHelper.ClientNow();
                    time /= 1000;
                    int hour = (int)time / 3600;
                    int min = (int)((time - (hour * 3600)) / 60);
                    int sec = (int)(time - (hour * 3600) - (min * 60));
                    string showStr = hour + "时" + min + "分" + sec + "秒";
                    self.BossRefreshObjs[it.Key].text = $"刷新时间:{showStr}";
                }
                else
                {
                    self.BossRefreshObjs[it.Key].text = "已刷新";
                }
            }
        }

        public static void OnCloseChapter(this UIDungeonMapTransferComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIDungeonMapTransfer);
        }

        /// <summary>
        /// 打开Boss刷新设置界面
        /// </summary>
        /// <param name="self"></param>
        public static void OnBossRefreshSetting(this UIDungeonMapTransferComponent self)
        {
            self.BossRefreshSettingPanel.SetActive(true);
            // 为Boss设置列表添加子物体
            foreach (int bossConfigId in ConfigHelper.BossShowTimeList)
            {
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(bossConfigId);

                GameObject go = GameObject.Instantiate(self.UIBossRefreshSettingItem);
                go.SetActive(true);
                // Boss名字
                ReferenceCollector rc = go.GetComponent<ReferenceCollector>();
                go.Get<GameObject>("NameText").GetComponent<Text>().text = monsterConfig.MonsterName;

                // 按钮
                if (!PlayerPrefs.HasKey(bossConfigId.ToString()))
                {
                    PlayerPrefs.SetString(bossConfigId.ToString(), "1");
                }

                go.Get<GameObject>("ShowText").SetActive(PlayerPrefs.GetString(bossConfigId.ToString()) == "1");

                go.Get<GameObject>("ToggleBtn").GetComponent<Button>().onClick.AddListener(() =>
                {
                    self.OnSettingChanged(bossConfigId.ToString(), go.Get<GameObject>("ShowText"));
                });

                UICommonHelper.SetParent(go, self.BossRefreshSettingList);
            }
        }

        /// <summary>
        /// 点击Boss显示按钮
        /// </summary>
        /// <param name="self"></param>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        public static void OnSettingChanged(this UIDungeonMapTransferComponent self, string key, GameObject obj)
        {
            if (PlayerPrefs.GetString(key) == "0")
            {
                PlayerPrefs.SetString(key, "1");
                obj.SetActive(true);
            }
            else
            {
                PlayerPrefs.SetString(key, "0");
                obj.SetActive(false);
            }
        }

        /// <summary>
        /// 关闭Boss刷新列表界面
        /// </summary>
        /// <param name="self"></param>
        public static void OnCloseBossRefreshSetting(this UIDungeonMapTransferComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);

            int childCount = self.BossRefreshTimeList.transform.childCount;
            for (int i = 1; i < childCount; i++)
            {
                GameObject.Destroy(self.BossRefreshTimeList.transform.GetChild(i).gameObject);
            }

            self.UpdateBossRefreshTimeList().Coroutine();
            self.BossRefreshSettingPanel.SetActive(false);
        }
    }
}