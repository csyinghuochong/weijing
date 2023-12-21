using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetXiLianLockSkillComponent: Entity, IAwake
    {
        public GameObject LockBtn;
        public GameObject PetSkillNode;
        public GameObject Btn_Close;

        public RolePetInfo RolePetInfo;
        public BagInfo CostItemInfo;
        public int SkillId;
        public List<UICommonSkillItemComponent> PetSkillUIList = new List<UICommonSkillItemComponent>();
    }

    public class UIPetXiLianLockSkillComponentAwakeSystem: AwakeSystem<UIPetXiLianLockSkillComponent>
    {
        public override void Awake(UIPetXiLianLockSkillComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.LockBtn = rc.Get<GameObject>("LockBtn");
            self.PetSkillNode = rc.Get<GameObject>("PetSkillNode");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");

            self.LockBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnLockBtn().Coroutine(); });
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
        }
    }

    public static class UIPetXiLianLockSkillComponentSystem
    {
        public static async ETTask UpdateSkillList(this UIPetXiLianLockSkillComponent self, RolePetInfo rolePetInfo, BagInfo bagInfo)
        {
            self.RolePetInfo = rolePetInfo;
            self.CostItemInfo = bagInfo;

            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            // PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            List<int> zhuanzhuids = new List<int>();
            // string[] zhuanzhuskills = petConfig.ZhuanZhuSkillID.Split(';');
            // for (int i = 0; i < zhuanzhuskills.Length; i++)
            // {
            //     if (zhuanzhuskills[i].Length > 1)
            //     {
            //         zhuanzhuids.Add(int.Parse(zhuanzhuskills[i]));
            //     }
            // }

            List<int> skills = new List<int>();
            for (int i = 0; i < rolePetInfo.PetSkill.Count; i++)
            {
                if (zhuanzhuids.Contains(rolePetInfo.PetSkill[i]))
                {
                    skills.Insert(0, rolePetInfo.PetSkill[i]);
                }
                else
                {
                    skills.Add(rolePetInfo.PetSkill[i]);
                }
            }

            for (int i = 0; i < skills.Count; i++)
            {
                UICommonSkillItemComponent ui_item = null;
                if (i < self.PetSkillUIList.Count)
                {
                    ui_item = self.PetSkillUIList[i];
                    ui_item.GameObject.SetActive(true);
                }
                else
                {
                    GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(bagSpace, self.PetSkillNode);
                    ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>(bagSpace);
                    ui_item.SelectAction = self.OnSelectSkill;
                    self.PetSkillUIList.Add(ui_item);
                }

                ui_item.OnUpdateUI(skills[i], ABAtlasTypes.PetSkillIcon,rolePetInfo.LockSkill.Contains(skills[i]));
            }

            for (int i = skills.Count; i < self.PetSkillUIList.Count; i++)
            {
                self.PetSkillUIList[i].GameObject.SetActive(false);
            }
        }

        public static void OnSelectSkill(this UIPetXiLianLockSkillComponent self, int skillId)
        {
            self.SkillId = skillId;
            foreach (UICommonSkillItemComponent component in self.PetSkillUIList)
            {
                component.BorderImg.SetActive(component.SkillId == self.SkillId);
            }
        }

        public static async ETTask OnLockBtn(this UIPetXiLianLockSkillComponent self)
        {
            if (self.RolePetInfo.PetSkill.Count < 2)
            {
                FloatTipManager.Instance.ShowFloatTip("宠物技能数量小于2不能使用次道具！");
                return;
            }

            if (self.SkillId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择需要锁定的技能！");
                return;
            }

            C2M_RolePetXiLian request = new C2M_RolePetXiLian()
            {
                PetInfoId = self.RolePetInfo.Id, BagInfoID = self.CostItemInfo.BagInfoID, CostItemNum = 1, ParamInfo = self.SkillId.ToString()
            };
            M2C_RolePetXiLian response = (M2C_RolePetXiLian)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            for (int i = 0; i < petComponent.RolePetInfos.Count; i++)
            {
                if (petComponent.RolePetInfos[i].Id == response.rolePetInfo.Id)
                {
                    petComponent.RolePetInfos[i] = response.rolePetInfo;
                    break;
                }
            }
            UI ui = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet).GetComponent<UIPetComponent>().UIPageView.UISubViewList[(int)PetPageEnum.PetXiLian];
            RolePetInfo rolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(response.rolePetInfo.Id);
            ui.GetComponent<UIPetXiLianComponent>().OnXiLianSelect(rolePetInfo);
            
            UIHelper.Remove(self.ZoneScene(), UIType.UIPetXiLianLockSkill);
        }

        public static void OnBtn_Close(this UIPetXiLianLockSkillComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIPetXiLianLockSkill);
        }
    }
}