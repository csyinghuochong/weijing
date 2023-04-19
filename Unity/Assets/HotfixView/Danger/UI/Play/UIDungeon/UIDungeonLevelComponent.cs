using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


namespace ET
{
    public class UIDungeonLevelComponent : Entity, IAwake
    {

        public GameObject NanDu_3_Button;
        public GameObject NanDu_2_Button;
        public GameObject NanDu_1_Button;
        public GameObject NanDu_3_Select;
        public GameObject NanDu_2_Select;
        public GameObject NanDu_1_Select;

        public GameObject Lab_OpenNumShow;
        public GameObject Lab_LevelName;
        public GameObject ButtonClose;
        public GameObject ChapterContent;

        public List<UIDungeonLevelItemComponent> LevelListUI = new List<UIDungeonLevelItemComponent>();
        public DungeonSectionConfig chapterSectionConfig1;

        public int Difficulty;
        public int ChapterId;
    }


    public class UIDungeonLevelComponentAwakeSystem : AwakeSystem<UIDungeonLevelComponent>
    {
        public override void Awake(UIDungeonLevelComponent self)
        {
            self.LevelListUI.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.NanDu_3_Button = rc.Get<GameObject>("NanDu_3_Button");
            self.NanDu_2_Button = rc.Get<GameObject>("NanDu_2_Button");
            self.NanDu_1_Button = rc.Get<GameObject>("NanDu_1_Button");
            self.NanDu_3_Select = rc.Get<GameObject>("NanDu_3_Select");
            self.NanDu_2_Select = rc.Get<GameObject>("NanDu_2_Select");
            self.NanDu_1_Select = rc.Get<GameObject>("NanDu_1_Select");
            self.NanDu_1_Button.GetComponent<Button>().onClick.AddListener(() => { self.OnNanDu_Button(1); });
            self.NanDu_2_Button.GetComponent<Button>().onClick.AddListener(() => { self.OnNanDu_Button(2); });
            self.NanDu_3_Button.GetComponent<Button>().onClick.AddListener(() => { self.OnNanDu_Button(3); });

            self.Lab_LevelName = rc.Get<GameObject>("Lab_LevelName");
            self.Lab_OpenNumShow = rc.Get<GameObject>("Lab_OpenNumShow");
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ChapterContent = rc.Get<GameObject>("ChapterContent");

            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseChapter(); });
        }
    }

    public static class UIDungeonLevelComponentSystem
    {

        public static void OnNanDu_Button(this UIDungeonLevelComponent self, int diff)
        {
            int openLv = DungeonSectionConfigCategory.Instance.Get(self.ChapterId).OpenLevel[diff - 1];
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.Lv < openLv)
            {
                self.Difficulty = 1;
                FloatTipManager.Instance.ShowFloatTip($"{openLv}级开启");
                return;
            }

            self.Difficulty = diff;
            self.NanDu_1_Select.SetActive(diff == 1);
            self.NanDu_2_Select.SetActive(diff == 2);
            self.NanDu_3_Select.SetActive(diff == 3);

            UserInfo userinfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            PlayerPrefsHelp.SetChapterDifficulty($"{userinfo.UserId}{self.ChapterId}", diff);
        }

        public static void OnClickHandler(this UIDungeonLevelComponent self, int chapterId)
        {
            for (int i = 0; i < self.LevelListUI.Count; i++)
            {
                UIDungeonLevelItemComponent uILevelItemComponent = self.LevelListUI[i];
                uILevelItemComponent.SetSelected(uILevelItemComponent.ChapterId == chapterId);
            }
        }

        public static async void OnCloseChapter(this UIDungeonLevelComponent self)
        {
            UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIDungeon);
            UIHelper.Remove(self.ZoneScene(), UIType.UIDungeonLevel);
        }

        public static void OnInitData(this UIDungeonLevelComponent self, int chapterId)
        {
            self.ChapterId = chapterId;

            int[] openLv = DungeonSectionConfigCategory.Instance.Get(self.ChapterId).OpenLevel;
            self.NanDu_1_Button.transform.Find("TextOpenLevel").GetComponent<Text>().text = $"激活等级:{openLv[0]}级";
            self.NanDu_2_Button.transform.Find("TextOpenLevel").GetComponent<Text>().text = $"激活等级:{openLv[1]}级";
            self.NanDu_3_Button.transform.Find("TextOpenLevel").GetComponent<Text>().text = $"激活等级:{openLv[2]}级";

            UserInfo userinfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            self.OnNanDu_Button(PlayerPrefsHelp.GetChapterDifficulty($"{userinfo.UserId}{self.ChapterId}"));
            self.UpdateLevelList(chapterId).Coroutine();
        }

        public static async ETTask UpdateLevelList(this UIDungeonLevelComponent self, int chapterid)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Dungeon/UIDungeonLevelItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            DungeonSectionConfig chapterSectionConfig = DungeonSectionConfigCategory.Instance.Get(chapterid);
            self.chapterSectionConfig1 = chapterSectionConfig;
         
            int number = 0;
            for (int i = 0; i < chapterSectionConfig.RandomArea.Length; i++)
            {
                //只显示满足进入等级的关卡
                DungeonConfig chapterCof = DungeonConfigCategory.Instance.Get(chapterSectionConfig.RandomArea[i]);
                if (userInfo.Lv < chapterCof.EnterLv)
                {
                    break;
                }

                UIDungeonLevelItemComponent uiitem = null;
                if (number < self.LevelListUI.Count)
                {
                    uiitem = self.LevelListUI[i];
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    go.transform.SetParent(self.ChapterContent.transform);
                    go.transform.localPosition = Vector3.zero;
                    go.transform.localScale = Vector3.one;

                    uiitem = self.AddChild<UIDungeonLevelItemComponent, GameObject>(go);
                    uiitem.OnInitData(chapterid, i, chapterSectionConfig.RandomArea[i]);
                    self.LevelListUI.Add(uiitem);
                }
                number++;

                self.Lab_LevelName.GetComponent<Text>().text = chapterSectionConfig.Name;
                self.Lab_OpenNumShow.GetComponent<Text>().text = "(" + GameSettingLanguge.LoadLocalization("冒险进度") + "：" + (i + 1).ToString() + "/" + chapterSectionConfig.RandomArea.Length.ToString() + ")";
            }

            await TimerComponent.Instance.WaitAsync(10);
            self.ZoneScene().GetComponent<GuideComponent>().OnTrigger(GuideTriggerType.OpenUI, UIType.UIDungeonLevel);
        }
    }

}
