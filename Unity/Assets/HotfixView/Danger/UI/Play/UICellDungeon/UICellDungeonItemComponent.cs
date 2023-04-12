
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UICellDungeonItemComponent : Entity, IAwake
    {
        public GameObject ImageBossIcon;
        public GameObject Lab_EnterLevel;
        public GameObject ImageSelect;
        public GameObject ImageKunnan;
        public GameObject ImageTiaozhan;
        public GameObject ImagePutong;
        public GameObject ImageButton;
        public GameObject PostionSet;
        public GameObject RightPositionSet;
        public GameObject Lab_ChapSonNameOut;

        public int LevelIndex;
        public int ChapterId;
        public float StartPosX;
        public Action<int> ClickHandler;
        public Vector3 CurPosition;
    }


    public class UICellDungeonItemComponentAwakeSystem : AwakeSystem<UICellDungeonItemComponent>
    {
        public override void Awake(UICellDungeonItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.LevelIndex = 0;
            self.CurPosition = Vector3.one;
            self.ImageBossIcon = rc.Get<GameObject>("ImageBossIcon");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.PostionSet = rc.Get<GameObject>("PostionSet");
            self.RightPositionSet = rc.Get<GameObject>("RightPositionSet");
            self.StartPosX = self.PostionSet.transform.localPosition.x;
            self.Lab_ChapSonNameOut = rc.Get<GameObject>("Lab_ChapSonNameOut");
            self.Lab_EnterLevel = rc.Get<GameObject>("Lab_EnterLevel");
            self.ImageSelect = rc.Get<GameObject>("ImageSelect");

            self.ImageKunnan = rc.Get<GameObject>("ImageKunnan");
            self.ImageTiaozhan = rc.Get<GameObject>("ImageTiaozhan");
            self.ImagePutong = rc.Get<GameObject>("ImagePutong");

            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClikButton(); });
        }
    }

    public static class UICellDungeonItemComponentSystem
    {

        public static void SetSelected(this UICellDungeonItemComponent self, bool value)
        {
            self.ImageSelect.SetActive(value);
        }

        public static void OnClikButton(this UICellDungeonItemComponent self)
        {
            self.ClickHandler(self.ChapterId);
        }

        public static void SetClickHandler(this UICellDungeonItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void OnInitData(this UICellDungeonItemComponent self, int index, int levelId)
        {
            self.LevelIndex = index;
            self.ChapterId = levelId;
            ChapterConfig chapterConfig = ChapterConfigCategory.Instance.Get(levelId);
            self.Lab_ChapSonNameOut.GetComponent<Text>().text = chapterConfig.ChapterName;
            self.Lab_EnterLevel.GetComponent<Text>().text = "挑战等级:" + chapterConfig.EnterLv.ToString(); 


            FubenPassInfo fubenPassInfo = self.ZoneScene().GetComponent<UserInfoComponent>().GetPassInfoByID(levelId);
            self.ImagePutong.SetActive(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv >= chapterConfig.EnterLv);
            self.ImageTiaozhan.SetActive(fubenPassInfo != null && fubenPassInfo.Difficulty >= (int)FubenDifficulty.Normal);
            self.ImageKunnan.SetActive(fubenPassInfo != null && fubenPassInfo.Difficulty >= (int)FubenDifficulty.TiaoZhan);

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.MonsterIcon, chapterConfig.BossIcon.ToString());
            self.ImageBossIcon.GetComponent<Image>().sprite = sp;
        }

        public static void UpdatePostion(this UICellDungeonItemComponent self, float passTime)
        {
            self.CurPosition.x = self.StartPosX + (0f - self.StartPosX) * (passTime/ UICellDungeonSelectComponent.OneMoveTime);
            self.CurPosition.y = 0f;
            self.CurPosition.z = 0f;
            self.PostionSet.transform.localPosition = self.CurPosition;
        }
    }
}
