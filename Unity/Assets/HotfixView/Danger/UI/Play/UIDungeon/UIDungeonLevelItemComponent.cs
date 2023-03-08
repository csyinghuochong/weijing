using System;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIDungeonLevelItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Lab_ChapIndex;
        public GameObject ImageBossIcon;
        public GameObject Lab_EnterLevel;
        public GameObject ImageSelect;
        public GameObject PostionSet;
        public GameObject RightPositionSet;
        public GameObject Lab_ChapSonNameOut;
        public GameObject ButtonEnter;

        public int LevelIndex;
        public int ChapterId;
        public float StartPosX;
        public Action<int> ClickHandler;
        public Vector3 CurPosition;
        public float SendTime;
    }


    [ObjectSystem]
    public class UIDungeonLevelItemComponentAwakeSystem : AwakeSystem<UIDungeonLevelItemComponent, GameObject>
    {
        public override void Awake(UIDungeonLevelItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.SendTime = 0f;
            self.LevelIndex = 0;
            self.CurPosition = Vector3.one;
            self.Lab_ChapIndex = rc.Get<GameObject>("Lab_ChapIndex");
            self.ImageBossIcon = rc.Get<GameObject>("ImageBossIcon");
            self.PostionSet = rc.Get<GameObject>("PostionSet");
            self.RightPositionSet = rc.Get<GameObject>("RightPositionSet");
            self.StartPosX = self.PostionSet.transform.localPosition.x;
            self.Lab_ChapSonNameOut = rc.Get<GameObject>("Lab_ChapSonNameOut");
            self.Lab_EnterLevel = rc.Get<GameObject>("Lab_EnterLevel");
            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.ButtonEnter = rc.Get<GameObject>("ButtonEnter");

            ButtonHelp.AddListenerEx(self.ButtonEnter, () =>
            {
                self.OnEnterChapter().Coroutine();
            });
            //self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClikButton(); });
        }
    }

    public static class UIDungeonLevelItemComponentSystem
    {
        public static void SetSelected(this UIDungeonLevelItemComponent self, bool value)
        {
            self.ImageSelect.SetActive(value);
        }

        public static void OnClikButton(this UIDungeonLevelItemComponent self)
        {
            self.ClickHandler(self.ChapterId);
        }

        public static void SetClickHandler(this UIDungeonLevelItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static async ETTask OnEnterChapter(this UIDungeonLevelItemComponent self)
        {
            try
            {
                if (Time.time - self.SendTime < 2f)
                {
                    return;
                }
                self.SendTime = Time.time;
                UIDungeonLevelComponent uIDungeonLevel = UIHelper.GetUI( self.ZoneScene(), UIType.UIDungeonLevel ).GetComponent<UIDungeonLevelComponent>();
                int errorCode = await EnterFubenHelp.RequestTransfer(self.ZoneScene(), (int)SceneTypeEnum.LocalDungeon, self.ChapterId, uIDungeonLevel.Difficulty);
                if (errorCode != ErrorCore.ERR_Success)
                {
                    ErrorHelp.Instance.ErrorHint(errorCode);
                    return;
                }
                if (self.IsDisposed)
                {
                    return;
                }

                UIHelper.Remove(self.DomainScene(), UIType.UIDungeonLevel);
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
        }


        public static void OnInitData(this UIDungeonLevelItemComponent self, int ChapterIndex, int levelIndex, int levelId)
        {
            self.LevelIndex = levelIndex;
            self.ChapterId = levelId;
            DungeonConfig chapterConfig = DungeonConfigCategory.Instance.Get(levelId);
            self.Lab_ChapSonNameOut.GetComponent<Text>().text = chapterConfig.ChapterName;
            //self.Lab_ChapIndex.GetComponent<Text>().text = $"第{ChapterIndex}章 第{levelIndex+1}关";
            self.Lab_ChapIndex.GetComponent<Text>().text = $"第{levelIndex + 1}关";
            self.Lab_EnterLevel.GetComponent<Text>().text = "挑战等级:" + chapterConfig.EnterLv.ToString();

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.MonsterIcon, chapterConfig.BossIcon.ToString());
            self.ImageBossIcon.GetComponent<Image>().sprite = sp;
        }
    }

}
