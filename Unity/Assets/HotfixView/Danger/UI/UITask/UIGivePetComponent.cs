using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIGivePetComponent: Entity, IAwake
    {
        public GameObject UIPetInfoShow;
        public GameObject PetListNode;
        public GameObject UIPetListItem;
        public GameObject PetNumText;
        public GameObject TaskDesText;
        public GameObject GiveBtn;
        public GameObject CloseBtn;

        public int TaskId;
        public int PetSkinId;
        public UIPetInfoShowComponent UIPetInfoShowComponent;
        public PetComponent PetComponent;
        public RolePetInfo LastSelectItem;
        public List<UIPetListItemComponent> PetUIList = new List<UIPetListItemComponent>();

        public Action OnGiveAction;
    }

    public class UIGivePetComponentAwakeSystem: AwakeSystem<UIGivePetComponent>
    {
        public override void Awake(UIGivePetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIPetInfoShow = rc.Get<GameObject>("UIPetInfoShow");
            self.PetListNode = rc.Get<GameObject>("PetListNode");
            self.UIPetListItem = rc.Get<GameObject>("UIPetListItem");
            self.PetNumText = rc.Get<GameObject>("PetNumText");
            self.TaskDesText = rc.Get<GameObject>("TaskDesText");
            self.GiveBtn = rc.Get<GameObject>("GiveBtn");
            self.CloseBtn = rc.Get<GameObject>("CloseBtn");

            self.UIPetInfoShow.SetActive(false);
            self.UIPetListItem.SetActive(false);
            self.PetComponent = self.ZoneScene().GetComponent<PetComponent>();
            self.UIPetInfoShowComponent = self.AddChild<UIPetInfoShowComponent, GameObject>(self.UIPetInfoShow);

            self.CloseBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseBtn(); });
            self.GiveBtn.GetComponent<Button>().onClick.AddListener(() => self.OnGiveBtn());
        }
    }

    public static class UIGivePetComponentSystem
    {
        public static void InitTask(this UIGivePetComponent self, int TaskId)
        {
            self.TaskId = TaskId;
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(TaskId);
            self.TaskDesText.GetComponent<Text>().text = taskConfig.TaskDes;
        }

        public static void OnCloseBtn(this UIGivePetComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIGivePet);
        }
        
        public static void OnUpdateUI(this UIGivePetComponent self)
        {
            self.PetSkinId = 0;
            self.LastSelectItem = null;

            self.OnInitPetList();
        }

        public static  void OnInitPetList(this UIGivePetComponent self)
        {
            List<RolePetInfo> rolePetInfos = self.PetComponent.RolePetInfos;
            List<RolePetInfo> showList = new List<RolePetInfo>();
            for (int i = 0; i < rolePetInfos.Count; i++)
            {
                if (rolePetInfos[i].PetStatus != 3)
                {
                    showList.Add(rolePetInfos[i]);
                }
            }

            int nextLv = self.NextPetNumber();
            if (nextLv > 0)
            {
                showList.Add(null);
            }

            for (int i = 0; i < showList.Count; i++)
            {
                UIPetListItemComponent ui_pet = null;
                if (i < self.PetUIList.Count)
                {
                    ui_pet = self.PetUIList[i];
                    ui_pet.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.UIPetListItem);
                    go.SetActive(true);
                    UICommonHelper.SetParent(go, self.PetListNode);
                    ui_pet = self.AddChild<UIPetListItemComponent, GameObject>(go);
                    ui_pet.SetClickHandler((petId) => { self.OnClickPetHandler(petId); });
                    self.PetUIList.Add(ui_pet);
                }

                ui_pet.OnInitData(showList[i], nextLv);
            }

            for (int i = showList.Count; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].GameObject.SetActive(false);
            }

            if (self.PetUIList.Count > 0)
            {
                self.UIPetInfoShow.SetActive(true);
                self.PetUIList[0].OnClickPetItem();
            }
            else
            {
                self.UIPetInfoShow.SetActive(false);
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            int maxNum = ComHelp.GetPetMaxNumber(unit, userInfo.Lv);
            self.PetNumText.GetComponent<Text>().text = $"携带宠物数量:{PetHelper.GetBagPetNum(rolePetInfos)}/{maxNum}";
        }

        public static int NextPetNumber(this UIGivePetComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int level = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            int curNumber = PetHelper.GetBagPetNum(self.ZoneScene().GetComponent<PetComponent>().RolePetInfos);
            if (curNumber < ComHelp.GetPetMaxNumber(unit, level))
            {
                return 0;
            }

            string[] petInfos = GlobalValueConfigCategory.Instance.Get(34).Value.Split('@');
            for (int i = 0; i < petInfos.Length; i++)
            {
                string[] petNumber = petInfos[i].Split(';');
                if (level < int.Parse(petNumber[0]))
                {
                    return int.Parse(petNumber[0]);
                }
            }

            return 0;
        }

        public static void OnClickPetHandler(this UIGivePetComponent self, long petId)
        {
            if (self.PetComponent.GetPetInfoByID(petId) == null)
            {
                return;
            }

            self.PetSkinId = 0;
            self.LastSelectItem = self.PetComponent.GetPetInfoByID(petId);
            self.UpdatePetSelected(self.LastSelectItem);
            self.UIPetInfoShowComponent.OnInitData(self.LastSelectItem);
        }

        public static void UpdatePetSelected(this UIGivePetComponent self, RolePetInfo rolePetItem)
        {
            for (int i = 0; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].OnSelectUI(rolePetItem);
            }
        }

        public static void OnGiveBtn(this UIGivePetComponent self)
        {
            if (self.LastSelectItem == null)
            {
                FloatTipManager.Instance.ShowFloatTip("未选择宠物！");
                return;
            }

            if (self.LastSelectItem.IsProtect)
            {
                FloatTipManager.Instance.ShowFloatTip("宠物已锁定！");
                return;
            }

            if (self.LastSelectItem.PetStatus == 1)
            {
                FloatTipManager.Instance.ShowFloatTip("出战宠物不能提交！");
                return;
            }

            if (self.LastSelectItem.PetStatus == 2)
            {
                FloatTipManager.Instance.ShowFloatTip("请先停止家园散步！");
                return;
            }

            if (self.LastSelectItem.PetStatus == 3)
            {
                FloatTipManager.Instance.ShowFloatTip("请先从仓库取出！");
                return;
            }

            if (self.PetComponent.TeamPetList.Contains(self.LastSelectItem.Id))
            {
                FloatTipManager.Instance.ShowFloatTip("当前宠物存在于宠物天梯上阵中,不能提交！");
                return;
            }

            if (self.PetComponent.PetFormations.Contains(self.LastSelectItem.Id))
            {
                FloatTipManager.Instance.ShowFloatTip("当前宠物存在于宠物副本上阵中,不能提交！");
                return;
            }

            if (self.PetComponent.PetMingList.Contains(self.LastSelectItem.Id))
            {
                FloatTipManager.Instance.ShowFloatTip("当前宠物存在于宠物矿场队伍中,不能提交！");
                return;
            }

            if (!TaskHelper.IsTaskGivePet(self.TaskId, self.LastSelectItem))
            {
                FloatTipManager.Instance.ShowFloatTip("宠物不符合任务要求！");
                return;
            }

            if (TaskHelper.IsTaskGivePet(self.TaskId, self.LastSelectItem))
            {
                PopupTipHelp.OpenPopupTip(self.DomainScene(), "提交宠物任务", GameSettingLanguge.LoadLocalization("确定提交宠物?"),
                    async () =>
                    {
                        TaskPro taskPro = self.ZoneScene().GetComponent<TaskComponent>().GetTaskById(self.TaskId);
                        taskPro.taskStatus = (int)TaskStatuEnum.Completed; // 手动修改
                        int errorCode = await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTask(self.TaskId, self.LastSelectItem.Id);
                        if (errorCode == ErrorCode.ERR_Success)
                        {
                            FloatTipManager.Instance.ShowFloatTip("完成任务");
                            self.OnGiveAction?.Invoke();
                            UIHelper.Remove(self.ZoneScene(), UIType.UIGivePet);
                        }
                    },
                    null).Coroutine();
            }
        }
    }
}