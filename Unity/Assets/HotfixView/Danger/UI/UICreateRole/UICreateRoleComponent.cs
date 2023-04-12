using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{
    public class UICreateRoleComponent : Entity, IAwake
    {
        public GameObject ImageButton;
        public GameObject ButtonRight;
        public GameObject ButtonLeft;
        public GameObject Text_Desc;
        public GameObject BtnRandomName;
        public GameObject SkillListNode;
        public GameObject FunctionSetBtn;
        public GameObject BtnCreateRole;
        public GameObject InputCreateRoleName;
        public GameObject OccShow_ZhanShi;
        public GameObject OccShow_FaShi;

        public int Occ;
        public UI uIPageView;
        public List<int> OccList;
        public float LastCrateRoleTime;

        public UI UIModelShowComponent;
        public ETCancellationToken eTCancellation = null;
        public List<UICommonSkillItemComponent> SkillUIList = new List<UICommonSkillItemComponent>();
    }


    public class UICreateRoleComponentAwakeSystem : AwakeSystem<UICreateRoleComponent>
    {

        public override void Awake(UICreateRoleComponent self)
        {
            self.LastCrateRoleTime = 0;
            self.OccList = new List<int>() { 1 , 2 };
            self.SkillUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickImageButton().Coroutine(); });
            self.ButtonRight = rc.Get<GameObject>("ButtonRight");
            self.ButtonLeft = rc.Get<GameObject>("ButtonLeft");
            self.ButtonRight.GetComponent<Button>().onClick.AddListener(() => { self.OnClickSelectButton(1); });
            self.ButtonLeft.GetComponent<Button>().onClick.AddListener(() => { self.OnClickSelectButton(-1); });

            self.OccShow_ZhanShi = rc.Get<GameObject>("OccShow_ZhanShi");
            self.OccShow_FaShi = rc.Get<GameObject>("OccShow_FaShi");

            self.Text_Desc = rc.Get<GameObject>("Text_Desc");
            self.BtnRandomName = rc.Get<GameObject>("BtnRandomName");
            self.BtnRandomName.GetComponent<Button>().onClick.AddListener(() => { self.OnClickRandomName(); });

            self.SkillListNode = rc.Get<GameObject>("SkillListNode");
            self.InputCreateRoleName = rc.Get<GameObject>("InputCreateRoleName");
            self.InputCreateRoleName.GetComponent<InputField>().onValueChanged.AddListener((string text) => { self.CheckSensitiveWords(); });


            self.BtnCreateRole = rc.Get<GameObject>("BtnCreateRole");
            ButtonHelp.AddListenerEx(self.BtnCreateRole, () => { self.OnBtnCreateRole().Coroutine(); });

            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiJoystick = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", BtnItemTypeSet);

            //ios适配
            IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(200f, 298f));


            self.uIPageView = uiJoystick;
            UIPageButtonComponent uIPageViewComponent = uiJoystick.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageViewComponent.OnSelectIndex(0);

            self.OnClickRandomName();
        }
    }

    public static class UICreateRoleComponentSystem
    {
        public static void ShowHeroSelect(this UICreateRoleComponent self, int occ)
        {
            self.eTCancellation?.Cancel();
            self.eTCancellation = new ETCancellationToken();
            UICommonHelper.ShowHeroSelect(1, 0, self.eTCancellation).Coroutine();
            GameObject go = GameObject.Find("HeroPosition");
            go.transform.localPosition = Vector3.zero;
        }

        public static void CheckSensitiveWords(this UICreateRoleComponent self)
        {
            string text_new = "";
            string text_old = self.InputCreateRoleName.GetComponent<InputField>().text;
            MaskWordHelper.Instance.IsContainSensitiveWords(ref text_old, out text_new);
            self.InputCreateRoleName.GetComponent<InputField>().text = text_old;
        }

        public static async ETTask OnClickImageButton(this UICreateRoleComponent self)
        {
            await UIHelper.Create(self.DomainScene(), UIType.UILobby);
            UIHelper.Remove(  self.DomainScene(), UIType.UICreateRole );
        }

        public static async ETTask OnBtnCreateRole(this UICreateRoleComponent self)
        {
            string createName = self.InputCreateRoleName.GetComponent<InputField>().text;

            if (Time.time - self.LastCrateRoleTime < 3f)
            {
                return;
            }
            if (createName.Contains("*") 
                || !StringHelper.IsSpecialChar(createName))
            {
                FloatTipManager.Instance.ShowFloatTip("名字不合法!");
                return;
            }
            Session session = self.ZoneScene().GetComponent<SessionComponent>().Session;
            if (session == null || session.IsDisposed)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("已掉线，请重新连接!"));
                return;
            }

            A2C_CreateRoleData g2cCreateRole = await LoginHelper.CreateRole(self.DomainScene(), self.Occ, createName);
            if (g2cCreateRole == null || g2cCreateRole.Error != 0)
            {
                return;
            }

            self.DomainScene().GetComponent<AccountInfoComponent>().CreateRoleList.Add(g2cCreateRole.createRoleInfo);
            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UILobby);
            uI.GetComponent<UILobbyComponent>().OnCreateRoleData(g2cCreateRole.createRoleInfo);

            UIHelper.Remove(self.DomainScene(), UIType.UICreateRole);
        }

        public static void OnClickRandomName(this UICreateRoleComponent self)
        {
            string randomNameStr = "";
            int xingXuHaoMax = GameSettingLanguge.Instance.randomName_xing.Length - 1;
            int nameXuHaoMax = GameSettingLanguge.Instance.randomName_name.Length - 1;
            int xingXuHao = FunctionUI.GetInstance().ReturnRamdomValueInt(0, xingXuHaoMax);
            int nameXuHao = FunctionUI.GetInstance().ReturnRamdomValueInt(0, nameXuHaoMax);
            randomNameStr = GameSettingLanguge.Instance.randomName_xing[xingXuHao] + GameSettingLanguge.Instance.randomName_name[nameXuHao];

            if (randomNameStr != "")
            {
                self.InputCreateRoleName.GetComponent<InputField>().text = randomNameStr;
            }
        }

        public static void OnClickPageButton(this UICreateRoleComponent self, int page)
        {
            self.Occ = page + 1;
            self.ShowHeroSelect(self.Occ);
            self.OnUpdateOccInfo().Coroutine();
        }

        public static async ETTask OnUpdateOccInfo(this UICreateRoleComponent self)
        {
            long instanceid = self.InstanceId;
            self.eTCancellation?.Cancel();
            self.eTCancellation = new ETCancellationToken();
            UICommonHelper.ShowHeroSelect(self.Occ, 0, self.eTCancellation).Coroutine();
            OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(self.Occ);
            string path = ABPathHelper.GetUGUIPath("CreateRole/UICreateRoleSkillItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            for (int i = 0; i < occupationConfig.InitSkillID.Length; i++)
            {
                UICommonSkillItemComponent ui_1;
                if (occupationConfig.InitSkillID[i] == 0)
                {
                    continue;
                }
                if (i < self.SkillUIList.Count)
                {
                    ui_1 = self.SkillUIList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.SkillListNode);
                    ui_1 = self.AddChild<UICommonSkillItemComponent, GameObject>(taskTypeItem);
                    self.SkillUIList.Add(ui_1);
                }
                ui_1.OnUpdateUI(occupationConfig.InitSkillID[i]);
            }
            for (int i = occupationConfig.InitSkillID.Length; i < self.SkillUIList.Count; i++)
            {
                self.SkillUIList[i].GameObject.SetActive(false);
            }

            //显示职业介绍
            self.OccShow_ZhanShi.SetActive(false);
            self.OccShow_FaShi.SetActive(false);
            Log.Info("self.Occ = " + self.Occ);
            if (self.Occ == 1) 
            {
                self.OccShow_ZhanShi.SetActive(true);
            }

            if (self.Occ == 2)
            {
                self.OccShow_FaShi.SetActive(true);
            }
        }

        public static void OnClickSelectButton(this UICreateRoleComponent self, int direction)
        {
            int occ = self.Occ + direction;

            if (occ > self.OccList.Count)
                occ = occ % self.OccList.Count;
            if (occ <= 0)
                occ = self.OccList.Count;

            self.uIPageView.GetComponent<UIPageButtonComponent>().OnSelectIndex(occ - 1);
        }

    }
}
