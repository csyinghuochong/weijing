using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UISkillTianFuComponent : Entity, IAwake
    {

        public GameObject Btn_TianFu_2;
        public GameObject Btn_TianFu_1;
        public GameObject DescListNode;
        public GameObject ImageSelect;
        public GameObject Text_NeedLv;
        public GameObject Lab_SkillName;
        public GameObject TianfuListNode;
        public GameObject Btn_ActiveTianFu;
        public GameObject TianFuIcon;
        public GameObject TextDesc1;

        public List<UI> TianItemListUI = new List<UI>();
        public int TianFuId;
    }

    [ObjectSystem]
    public class UISkillTianFuComponentAwakeSystem : AwakeSystem<UISkillTianFuComponent>
    {
        public override void Awake(UISkillTianFuComponent self)
        {
            self.TianItemListUI.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_NeedLv = rc.Get<GameObject>("Text_NeedLv");
            self.Lab_SkillName = rc.Get<GameObject>("Lab_SkillName");
            self.TianfuListNode = rc.Get<GameObject>("TianfuListNode");
            self.TianFuIcon = rc.Get<GameObject>("TianFuIcon");
            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.DescListNode = rc.Get<GameObject>("DescListNode");

            self.Btn_TianFu_2 = rc.Get<GameObject>("Btn_TianFu_2");
            self.Btn_TianFu_1 = rc.Get<GameObject>("Btn_TianFu_1");
            ButtonHelp.AddListenerEx(self.Btn_TianFu_2, () => { self.OnBtn_TianFuPlan(1).Coroutine(); });
            ButtonHelp.AddListenerEx(self.Btn_TianFu_1, () => { self.OnBtn_TianFuPlan(0).Coroutine(); });

            self.TextDesc1 = rc.Get<GameObject>("TextDesc1");
            self.TextDesc1.SetActive(false);

            self.Btn_ActiveTianFu = rc.Get<GameObject>("Btn_ActiveTianFu");
            self.Btn_ActiveTianFu.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ActiveTianFu(); });

            self.InitTianFuList().Coroutine();
        }
    }

    public static class UISkillTianFuComponentSystem
    {

        public static async ETTask OnBtn_TianFuPlan(this UISkillTianFuComponent self, int plan)
        {
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            if (skillSetComponent.TianFuPlan == plan)
            {
                return;
            }

            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv < 35) {

                FloatTipManager.Instance.ShowFloatTip("35级开启天赋方案,可自由切换天赋!");
                return;
            }

            C2M_TianFuPlanRequest  request = new C2M_TianFuPlanRequest() { TianFuPlan = plan };
            M2C_TianFuPlanResponse response = (M2C_TianFuPlanResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            skillSetComponent.UpdateTianFuPlan ( plan);

            self.OnActiveTianFu();
            self.UpdatePlanButton();

            FloatTipManager.Instance.ShowFloatTip("已切换为当前天赋!");

        }

        public static void UpdatePlanButton(this UISkillTianFuComponent self)
        {
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            self.Btn_TianFu_1.transform.Find("Image").gameObject.SetActive(skillSetComponent.TianFuPlan == 0);
            self.Btn_TianFu_2.transform.Find("Image").gameObject.SetActive(skillSetComponent.TianFuPlan == 1);
        }

        public static async ETTask InitTianFuList(this UISkillTianFuComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            int occTwo = userInfo.OccTwo;
            if (occTwo == 0)
            {
                //战士天赋
                occTwo = 101;

                //法师天赋
                if (userInfo.Occ == 2) {
                    occTwo = 201;
                }
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
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

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
            self.OnActiveTianFu();
            self.UpdatePlanButton();

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

            string[] descList = talentConfig.talentDes.Split(';');
            UICommonHelper.DestoryChild(self.DescListNode);
            for (int i = 0; i < descList.Length; i++)
            {
                if (string.IsNullOrEmpty(descList[i]))
                {
                    continue;
                }
                GameObject gameObject = GameObject.Instantiate(self.TextDesc1);
                UICommonHelper.SetParent( gameObject, self.DescListNode );
                gameObject.SetActive(true);
                gameObject.GetComponent<Text>().text = descList[i];
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(600f, gameObject.GetComponent<Text>().preferredHeight);
            }

            self.Lab_SkillName.GetComponent<Text>().text = talentConfig.Name;
            self.Text_NeedLv.GetComponent<Text>().text = talentConfig.LearnRoseLv.ToString();

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, talentConfig.Icon.ToString());
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
