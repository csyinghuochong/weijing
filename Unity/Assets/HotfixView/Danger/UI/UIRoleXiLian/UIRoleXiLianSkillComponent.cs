using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class UIRoleXiLianSkillComponent : Entity, IAwake
    {
        public GameObject ItemListNode;
        public List<UIRoleXiLianSkillItemComponent> uIRoleXiLianSkills = new List<UIRoleXiLianSkillItemComponent>();
    }

    [ObjectSystem]
    public class UIRoleXiLianSkillComponentAwakeSystem : AwakeSystem<UIRoleXiLianSkillComponent>
    {
        public override void Awake(UIRoleXiLianSkillComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.uIRoleXiLianSkills.Clear();

            self.OnInitUI().Coroutine();
            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
        }
    }

    public static class UIRoleXiLianSkillComponentSystem
    {
        public static int GetXiLianLevel(this UIRoleXiLianSkillComponent self, Unit unit)
        {
            int xiliandu = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.ItemXiLianDu);
            int xilianLevel = XiLianHelper.GetXiLianId(xiliandu);
            xilianLevel = xilianLevel != 0 ? EquipXiLianConfigCategory.Instance.Get(xilianLevel).XiLianLevel : 0;
            return xilianLevel;
        }

        public static async ETTask OnInitUI(this UIRoleXiLianSkillComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/RoleXiLian/UIRoleXiLianSkillItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            List<EquipXiLianConfig> shouJiConfigs = EquipXiLianConfigCategory.Instance.GetAll().Values.ToList();
            long instanceId = self.InstanceId;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int xilianLevel = self.GetXiLianLevel(unit);

            for (int i = 0; i < shouJiConfigs.Count; i++)
            {
                if (instanceId != self.InstanceId)
                {
                    return;
                }
                if (XiLianHelper.GetLevelSkill(i+1).Count == 0)
                {
                    continue;
                }
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.ItemListNode);
                UIRoleXiLianSkillItemComponent uIRoleXiLian = self.AddChild<UIRoleXiLianSkillItemComponent, GameObject>(go);
                uIRoleXiLian.OnInitUI(shouJiConfigs[i]);
                uIRoleXiLian.OnUpdateUI(xilianLevel);
                self.uIRoleXiLianSkills.Add(uIRoleXiLian);
                await TimerComponent.Instance.WaitFrameAsync();
            }

            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIRoleXiLianSkillComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int xilianLevel = self.GetXiLianLevel(unit);
            for(int i = 0; i < self.uIRoleXiLianSkills.Count; i++)
            {
                self.uIRoleXiLianSkills[i].OnUpdateUI(xilianLevel);
            }
        }
    }
}