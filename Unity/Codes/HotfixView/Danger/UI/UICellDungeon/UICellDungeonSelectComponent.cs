
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{
    public class UICellDungeonSelectComponent : Entity, IAwake, IUpdate
    {
        public GameObject NanDuSelect_1;
        public GameObject EnterBtnSet;
        public GameObject Nandu3_Button;
        public GameObject Nandu2_Button;
        public GameObject Nandu1_Button;

        public GameObject EnterContion_2_OK;
        public GameObject EnterContion_2_Text;
        public GameObject EnterContion_1_OK;
        public GameObject EnterContion_1_Text;
        public GameObject EnterContion_2;
        public GameObject EnterContion_1;

        public GameObject Lab_LevelName_2;
        public GameObject Lab_LevelDesc;
        public GameObject Lab_LevelName;
        public GameObject Lab_OpenNumShow;

        public GameObject ButtonClose;
        public GameObject ChapterContent;
        public GameObject RightPositionSet;
        public const float OneMoveTime = 0.2f;

        public List<UI> LevelListUI = new List<UI>();
        public float PassTime;
        public float TotalTime;
        public int CurrentMoveIndex;
        public int CurrentChapterID;
        public int ChapterSectionId;

        public string ErrorString;
        //1 difficulty普通 2 挑战  3困难
        public int SelectDifficulty;
        public ChapterSectionConfig chapterSectionConfig1;
        public CellDungeonComponent FubenComponent;
    }

    [ObjectSystem]
    public class UICellDungeonSelectComponentAwakeSystem : AwakeSystem<UICellDungeonSelectComponent>
    {
        public override void Awake(UICellDungeonSelectComponent self)
        {
            self.ErrorString = "";
            self.PassTime = 0f;
            self.CurrentMoveIndex = 0;
            self.SelectDifficulty = FubenDifficulty.Normal;
            self.LevelListUI.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.EnterBtnSet = rc.Get<GameObject>("EnterBtnSet");
            self.NanDuSelect_1 = rc.Get<GameObject>("NanDuSelect_1");

            self.Nandu3_Button = rc.Get<GameObject>("Nandu3_Button");
            self.Nandu2_Button = rc.Get<GameObject>("Nandu2_Button");
            self.Nandu1_Button = rc.Get<GameObject>("Nandu1_Button");

            self.EnterContion_2_OK = rc.Get<GameObject>("EnterContion_2_OK");
            self.EnterContion_2_Text = rc.Get<GameObject>("EnterContion_2_Text");
            self.EnterContion_1_OK = rc.Get<GameObject>("EnterContion_1_OK");
            self.EnterContion_1_Text = rc.Get<GameObject>("EnterContion_1_Text");
            self.EnterContion_2 = rc.Get<GameObject>("EnterContion_2");
            self.EnterContion_1 = rc.Get<GameObject>("EnterContion_1");

            self.Lab_LevelName_2 = rc.Get<GameObject>("Lab_LevelName_2");
            self.Lab_LevelDesc = rc.Get<GameObject>("Lab_LevelDesc");
            self.Lab_LevelName = rc.Get<GameObject>("Lab_LevelName");
            self.Lab_OpenNumShow = rc.Get<GameObject>("Lab_OpenNumShow");
            
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ChapterContent = rc.Get<GameObject>("ChapterContent");
            self.RightPositionSet = rc.Get<GameObject>("RightPositionSet");

            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseChapter(); });
            self.EnterBtnSet.GetComponent<Button>().onClick.AddListener(() => { self.OnEnterChapter().Coroutine(); });

            self.Nandu1_Button.GetComponent<Button>().onClick.AddListener(() => { self.OnSelectNandu(FubenDifficulty.Normal); });
            self.Nandu2_Button.GetComponent<Button>().onClick.AddListener(() => { self.OnSelectNandu(FubenDifficulty.TianZhan); });
            self.Nandu3_Button.GetComponent<Button>().onClick.AddListener(() => { self.OnSelectNandu(FubenDifficulty.DiYu); });


            UI uimove1 = self.AddChild<UI, string, GameObject>("RightPositionSet", self.RightPositionSet);
            UIMoveComponent uiMoveComponent = uimove1.AddComponent<UIMoveComponent>();
            uiMoveComponent.SetMovePosition(self.RightPositionSet.transform.localPosition, Vector3.zero, 0.5f);

            self.FubenComponent = self.ZoneScene().GetComponent<CellDungeonComponent>();
        }
    }

    [ObjectSystem]
    public class UICellDungeonSelectComponentUpdateSystem : UpdateSystem<UICellDungeonSelectComponent>
    {
        public override void Update(UICellDungeonSelectComponent self)
        {
            if (self.PassTime > self.TotalTime + 1f)
                return;
            if (self.LevelListUI.Count == 0)
                return;

            self.PassTime += Time.deltaTime;
            int index =  Mathf.FloorToInt(self.PassTime / UICellDungeonSelectComponent.OneMoveTime);
            if (index != self.CurrentMoveIndex)
            {
                self.LevelListUI[self.CurrentMoveIndex].GetComponent<UICellDungeonItemComponent>().UpdatePostion(UICellDungeonSelectComponent.OneMoveTime);
            }
            if (index >= self.LevelListUI.Count)
                return;
            float passTime = self.PassTime - index * UICellDungeonSelectComponent.OneMoveTime;
            self.LevelListUI[index].GetComponent<UICellDungeonItemComponent>().UpdatePostion(passTime);
            self.CurrentMoveIndex = index;
        }
    }

    public static class UICellDungeonSelectComponentSystem
    {
        public static async ETTask OnEnterChapter(this UICellDungeonSelectComponent self)
        {
            int errorCode = await EnterFubenHelp.EnterFubenRequest(self.ZoneScene(), self.SelectDifficulty, self.CurrentChapterID);
            if (errorCode != ErrorCore.ERR_Success)
            {
                ErrorHelp.Instance.ErrorHint(errorCode);
                return;
            }

            UIHelper.Remove(self.DomainScene(), UIType.UICellChapterSelect).Coroutine();
            UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonSelect).Coroutine();
        }

        public static void OnSelectNandu(this UICellDungeonSelectComponent self, int difficulty)
        {
            self.SelectDifficulty = difficulty;

            self.OnUpdateUI2();
        }

        public static void OnClickHandler(this UICellDungeonSelectComponent self, int chapterId)
        {
            self.SelectDifficulty = FubenDifficulty.Normal;
            self.CurrentChapterID = chapterId;

            for (int i = 0; i < self.LevelListUI.Count; i++)
            {
                UICellDungeonItemComponent uILevelItemComponent = self.LevelListUI[i].GetComponent<UICellDungeonItemComponent>();
                uILevelItemComponent.SetSelected(uILevelItemComponent.ChapterId == chapterId);
            }

            self.OnUpdateUI2();
        }

        public static void OnUpdateUI2(this UICellDungeonSelectComponent self)
        {
            ChapterConfig chapterConfig = ChapterConfigCategory.Instance.Get(self.CurrentChapterID);

            self.Lab_LevelName_2.GetComponent<Text>().text = chapterConfig.ChapterName;
            self.Lab_LevelDesc.GetComponent<Text>().text = chapterConfig.ChapterDes;
;
            self.Lab_LevelName.GetComponent<Text>().text = self.chapterSectionConfig1.ChapterName + " " + self.chapterSectionConfig1.Name;

            self.OnUpdateContion(chapterConfig);
        }

        public static void OnUpdateContion(this UICellDungeonSelectComponent self, ChapterConfig chapterConfig)
        {
            self.ErrorString = "";
            self.EnterContion_2.SetActive(false);
            FubenPassInfo fubenPassInfo = self.ZoneScene().GetComponent<UserInfoComponent>().GetPassInfoByID(chapterConfig.Id);

            GameObject selectParent = null;
            if (self.SelectDifficulty == FubenDifficulty.Normal)
            {
                UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
                self.EnterContion_1_Text.GetComponent<Text>().text = "进入等级:" + chapterConfig.EnterLv.ToString();
                self.EnterContion_1_OK.SetActive(userInfo.Lv >= chapterConfig.EnterLv);
                self.ErrorString = (userInfo.Lv < chapterConfig.EnterLv) ?  "等级不足！" : "";
                selectParent = self.Nandu1_Button.transform.parent.gameObject;
            }
            if (self.SelectDifficulty == FubenDifficulty.TianZhan)
            {
                self.EnterContion_1_Text.GetComponent<Text>().text = "普通模式通关副本";
                self.EnterContion_1_OK.SetActive(fubenPassInfo != null && fubenPassInfo.Difficulty >= 1);
                self.ErrorString = (!self.EnterContion_1_OK.activeSelf) ? "请先通关普通模式副本！" : "";
                selectParent = self.Nandu2_Button.transform.parent.gameObject;
            }
            if (self.SelectDifficulty == FubenDifficulty.DiYu)
            {
                self.EnterContion_1_Text.GetComponent<Text>().text = "挑战模式通关副本";
                self.EnterContion_1_OK.SetActive(fubenPassInfo != null && fubenPassInfo.Difficulty >= 2);
                self.ErrorString = (!self.EnterContion_1_OK.activeSelf) ? "请先通关挑战模式副本！" : "";
                selectParent = self.Nandu3_Button.transform.parent.gameObject;
            }

            UICommonHelper.SetImageGray(self.Nandu1_Button, self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv < chapterConfig.EnterLv);
            UICommonHelper.SetImageGray(self.Nandu2_Button, fubenPassInfo == null || fubenPassInfo.Difficulty < (int)FubenDifficulty.Normal); 
            UICommonHelper.SetImageGray(self.Nandu3_Button, fubenPassInfo == null || fubenPassInfo.Difficulty < (int)FubenDifficulty.TianZhan);

            UICommonHelper.SetParent(self.NanDuSelect_1, selectParent);
            self.NanDuSelect_1.transform.SetAsFirstSibling();
        }

        public static void OnCloseChapter(this UICellDungeonSelectComponent self)
        {
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UICellChapterSelect);
            if (uI != null)
            {
                uI.GetComponent<UICellChapterSelectComponent>().OnChapterReturn();
            }

            UIHelper.Remove(self.ZoneScene(), UIType.UICellDungeonSelect).Coroutine();
        }

        public static void OnInitData(this UICellDungeonSelectComponent self, int chapterId)
        {
            self.UpdateLevelList(chapterId).Coroutine();
        }

        public static async ETTask UpdateLevelList(this UICellDungeonSelectComponent self, int chapterid)
        {
            self.ChapterSectionId = chapterid;
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Chapter/UILevelItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            ChapterSectionConfig chapterSectionConfig = ChapterSectionConfigCategory.Instance.Get(chapterid);
            self.chapterSectionConfig1 = chapterSectionConfig;

            int number = 0;
            for (int i = 0; i < chapterSectionConfig.RandomArea.Length; i++)
            {
                //只显示满足进入等级的关卡
                ChapterConfig chapterCof = ChapterConfigCategory.Instance.Get(chapterSectionConfig.RandomArea[i]);
                if (userInfo.Lv < chapterCof.EnterLv) {
                    break;
                }

                UI uiitem = null;
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

                    uiitem = self.AddChild<UI, string, GameObject>( "LevelItem_" + chapterSectionConfig.RandomArea[i], go);
                    UICellDungeonItemComponent uILeveltemComponent = uiitem.AddComponent<UICellDungeonItemComponent>();
                    uILeveltemComponent.OnInitData(i, chapterSectionConfig.RandomArea[i]);
                    uILeveltemComponent.SetClickHandler((int cid) => { self.OnClickHandler(cid); });
                    self.LevelListUI.Add(uiitem);
                }
                number++;

                self.Lab_OpenNumShow.GetComponent<Text>().text = "(" + GameSettingLanguge.LoadLocalization("冒险进度") +"：" + (i + 1).ToString() + "/"+ chapterSectionConfig.RandomArea.Length.ToString() + ")";
                //默认点击第一个
                if (i == 0)
                {
                    self.OnClickHandler(chapterSectionConfig.RandomArea[i]);
                }
            }

            self.TotalTime = self.LevelListUI.Count * UICellDungeonSelectComponent.OneMoveTime;
        }
    }

}
