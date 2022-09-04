using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UISkillTianFuComponent : Entity, IAwake
    {
        public GameObject ImageSelect;
        public GameObject Text_NeedLv;
        public GameObject Lab_SkillName;
        public GameObject TianfuListNode;
        public GameObject Btn_ActiveTianFu;
        public GameObject TianFuIcon;
        public GameObject TextDesc4;
        public GameObject TextDesc3;
        public GameObject TextDesc2;
        public GameObject TextDesc1;

        public List<GameObject> TextDescList = new List<GameObject>();
        public List<UI> TianItemListUI = new List<UI>();
        public int TianFuId;
    }

    [ObjectSystem]
    public class UISkillTianFuComponentAwakeSystem : AwakeSystem<UISkillTianFuComponent>
    {
        public override void Awake(UISkillTianFuComponent self)
        {
            self.TextDescList.Clear();
            self.TianItemListUI.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_NeedLv = rc.Get<GameObject>("Text_NeedLv");
            self.Lab_SkillName = rc.Get<GameObject>("Lab_SkillName");
            self.TianfuListNode = rc.Get<GameObject>("TianfuListNode");
            self.TianFuIcon = rc.Get<GameObject>("TianFuIcon");
            self.ImageSelect = rc.Get<GameObject>("ImageSelect");

            self.TextDesc4 = rc.Get<GameObject>("TextDesc4");
            self.TextDesc3 = rc.Get<GameObject>("TextDesc3");
            self.TextDesc2 = rc.Get<GameObject>("TextDesc2");
            self.TextDesc1 = rc.Get<GameObject>("TextDesc1");
            self.TextDescList.Add(self.TextDesc1);
            self.TextDescList.Add(self.TextDesc2);
            self.TextDescList.Add(self.TextDesc3);
            self.TextDescList.Add(self.TextDesc4);

            self.Btn_ActiveTianFu = rc.Get<GameObject>("Btn_ActiveTianFu");
            self.Btn_ActiveTianFu.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ActiveTianFu(); });

            self.InitTianFuList().Coroutine();

        }
    }

    public static class UISkillTianFuComponentSystem
    {

        public static async ETTask InitTianFuList(this UISkillTianFuComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            int occTwo = userInfo.OccTwo;
            if (occTwo == 0)
            {
                occTwo = 101;
            }

            Dictionary<int, List<int>> TianFuToLevel = new Dictionary<int, List<int>>();
            int[] TalentList = OccupationTwoConfigCategory.Instance.Get(occTwo).Talent;
            for (int i = 0; i < TalentList.Length; i++)
            {
                int talentId = TalentList[i];
                TalentConfig talentConfig = TalentConfigCategory.Instance.Get(talentId);
                if (!TianFuToLevel.ContainsKey(talentConfig.LearnRoseLv))
                {
                    TianFuToLevel.Add(talentConfig.LearnRoseLv, new List<int>());
                }
                TianFuToLevel[talentConfig.LearnRoseLv].Add(talentId);
            }

            string path = ABPathHelper.GetUGUIPath("Main/Skill/UISkillTianFuItem");
            await ETTask.CompletedTask;
            GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            foreach (var item in TianFuToLevel)
            {
                GameObject skillItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(skillItem, self.TianfuListNode);

                UI ui_1 = self.AddChild<UI, string, GameObject>( "skillItem_" + item.Key.ToString(), skillItem);
                UISkillTianFuItemComponent uIItemComponent = ui_1.AddComponent<UISkillTianFuItemComponent>();
                uIItemComponent.SetClickHanlder(( int tid ) => { self.OnClickTianFuItem(tid); });
                uIItemComponent.InitTianFuList(item.Value);
                self.TianItemListUI.Add(ui_1);
            }

            self.TianItemListUI[0].GetComponent<UISkillTianFuItemComponent>().OnClickTianFu(0);
        }

        public static void OnActiveTianFu(this UISkillTianFuComponent self)
        {
            for (int i = 0; i < self.TianItemListUI.Count; i++)
            {
                self.TianItemListUI[i].GetComponent<UISkillTianFuItemComponent>().OnActiveTianFu();
            }
        }

        public static void OnClickTianFuItem(this UISkillTianFuComponent self, int tianfuId)
        {
            self.TianFuId = tianfuId;

            TalentConfig talentConfig = TalentConfigCategory.Instance.Get(tianfuId);
            self.Lab_SkillName.GetComponent<Text>().text = talentConfig.Name;
            self.Text_NeedLv.GetComponent<Text>().text = talentConfig.LearnRoseLv.ToString();

            TalentConfig skillConfig = TalentConfigCategory.Instance.Get(tianfuId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, skillConfig.Icon.ToString());
            self.TianFuIcon.GetComponent<Image>().sprite = sp;

            for (int i = 0; i < self.TianItemListUI.Count; i++)
            {
                UISkillTianFuItemComponent uISkillTianFuItem = self.TianItemListUI[i].GetComponent<UISkillTianFuItemComponent>();
                List<int> TianFuList = uISkillTianFuItem.TianFuList;
                int index = TianFuList.IndexOf(tianfuId);
                if (index >= 0)
                {
                    self.ImageSelect.SetActive(true);
                    UICommonHelper.SetParent(self.ImageSelect, uISkillTianFuItem.GetKuangByIndex(index));
                }
            }

            string[] descList = skillConfig.talentDes.Split(';');
            for (int i = 0; i < self.TextDescList.Count; i++)
            {
                GameObject gameObject = self.TextDescList[i];

                if (i < descList.Length)
                {
                    gameObject.SetActive(true);
                    gameObject.GetComponent<Text>().text = descList[i];
                    gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(600f, gameObject.GetComponent<Text>().preferredHeight);
                }
                else
                {
                    gameObject.SetActive(false);
                }
            }
            self.TextDescList[0].transform.parent.gameObject.SetActive(false);
            self.TextDescList[0].transform.parent.gameObject.SetActive(true);
        }

        public static void OnBtn_ActiveTianFu(this UISkillTianFuComponent self)
        {
            int playerLv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            TalentConfig talentConfig = TalentConfigCategory.Instance.Get(self.TianFuId);
            if (playerLv < talentConfig.LearnRoseLv)
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！");
                return;
            }

            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            int oldId = skillSetComponent.HaveSameTianFu(self.TianFuId);
            if (oldId!=0 && oldId!= self.TianFuId)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(48);
                string itemdesc = UICommonHelper.GetNeedItemDesc(globalValueConfig.Value);
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "重置专精",
               $"是否花费{itemdesc}重置专精",
               () =>
               {
                   skillSetComponent.ActiveTianFu(self.TianFuId).Coroutine();
               }).Coroutine();
                return;
            }

            skillSetComponent.ActiveTianFu(self.TianFuId).Coroutine();
        }

    }

}
