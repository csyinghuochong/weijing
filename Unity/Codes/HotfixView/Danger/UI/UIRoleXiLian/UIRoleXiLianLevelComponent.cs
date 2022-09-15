using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [Timer(TimerType.RoleXiLianLevel)]
    public class RoleXiLianLevelTimer : ATimer<UIRoleXiLianLevelComponent>
    {
        public override void Run(UIRoleXiLianLevelComponent self)
        {
            try
            {
                self.OnUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIRoleXiLianLevelComponent : Entity, IAwake,IDestroy
    {
        public GameObject LevelListNode;
        public GameObject Button_Right;
        public GameObject Button_Left;

        public List<UIRoleXiLianLevelItemComponent> UIRoleXiLianLevels = new List<UIRoleXiLianLevelItemComponent>();
        public int EquipXilianId;
        public long Timer;

        public float ItemWidth = 1400f;
        public float MoveSpeed = 30f;
    }

    [ObjectSystem]
    public class UIRoleXiLianLevelItemComponentDestroySystem : DestroySystem<UIRoleXiLianLevelComponent>
    {
        public override void Destroy(UIRoleXiLianLevelComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [ObjectSystem]
    public class UIRoleXiLianLevelComponentAwakeSystem : AwakeSystem<UIRoleXiLianLevelComponent>
    {
        public override void Awake(UIRoleXiLianLevelComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;

            self.UIRoleXiLianLevels.Clear();
            self.LevelListNode = rc.Get<GameObject>("LevelListNode");

            self.Button_Right = rc.Get<GameObject>("Button_Right");
            self.Button_Right.GetComponent<Button>().onClick.AddListener(self.OnButton_Right);
            self.Button_Left = rc.Get<GameObject>("Button_Left");
            self.Button_Left.GetComponent<Button>().onClick.AddListener(self.OnButton_Left);

            self.InitItemUIList();
        }
    }

    public static class UIRoleXiLianLevelComponentSystem
    {
        public static void OnUpdateUI(this UIRoleXiLianLevelComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int xiliandu = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.ItemXiLianDu);
            int xilianLevel = XiLianHelper.GetXiLianId(xiliandu);
            xilianLevel = xilianLevel != 0 ? xilianLevel : EquipXiLianConfigCategory.Instance.EquipXiLianLevelList[0].Id;
            self.OnUpdateButton(xilianLevel);
            self.UIRoleXiLianLevels[1].OnUpdateUI(xilianLevel);
        }

        public static void InitItemUIList(this UIRoleXiLianLevelComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/RoleXiLian/UIRoleXiLianLevelItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            for (int i = 0; i < 3; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.LevelListNode);
                UIRoleXiLianLevelItemComponent uIRoleXiLianLevel = self.AddChild<UIRoleXiLianLevelItemComponent, GameObject>(go);
                go.transform.localPosition = new Vector3( (i - 1) * self.ItemWidth, 0f,  0f);
                self.UIRoleXiLianLevels.Add(uIRoleXiLianLevel);
            }

        }

        public static void SetPosition(this UIRoleXiLianLevelComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.UIRoleXiLianLevels[0].PostionY = self.ItemWidth * -1f;
            self.UIRoleXiLianLevels[1].PostionY = 0f;
            self.UIRoleXiLianLevels[2].PostionY = self.ItemWidth;
            float offset = self.UIRoleXiLianLevels[1].GameObject.transform.localPosition.x;
            if (Mathf.Abs(offset) < self.MoveSpeed + 1f)
            {
                self.UIRoleXiLianLevels[0].GameObject.transform.localPosition = new Vector3(self.ItemWidth * -1f, 0f, 0f);
                self.UIRoleXiLianLevels[1].GameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
                self.UIRoleXiLianLevels[2].GameObject.transform.localPosition = new Vector3(self.ItemWidth, 0f, 0f);
            }
            else
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.RoleXiLianLevel, self);
            }
        }

        public static void MoveToPositon(this UIRoleXiLianLevelComponent self, GameObject gameObject, float movedis)
        {
            gameObject.transform.localPosition = new Vector3(
              gameObject.transform.localPosition.x + movedis,
              gameObject.transform.localPosition.y,
              gameObject.transform.localPosition.z
              );
        }

        public static void OnUpdate(this UIRoleXiLianLevelComponent self)
        {
            float offset = self.UIRoleXiLianLevels[1].GameObject.transform.localPosition.x;
            float movedis = offset < 0 ? self.MoveSpeed : -self.MoveSpeed;

            self.MoveToPositon(self.UIRoleXiLianLevels[0].GameObject, movedis);
            self.MoveToPositon(self.UIRoleXiLianLevels[1].GameObject, movedis);
            self.MoveToPositon(self.UIRoleXiLianLevels[2].GameObject, movedis);

            if (Mathf.Abs(offset) < self.MoveSpeed +1f)
            {
                self.UIRoleXiLianLevels[0].GameObject.transform.localPosition = new Vector3(self.ItemWidth * -1f, 0f, 0f);
                self.UIRoleXiLianLevels[1].GameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
                self.UIRoleXiLianLevels[2].GameObject.transform.localPosition = new Vector3(self.ItemWidth, 0f, 0f);
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
        }

        public static void OnButton_Left(this UIRoleXiLianLevelComponent self)
        {
            if (self.Timer != 0)
            {
                return;
            }
            UIRoleXiLianLevelItemComponent uIRoleXiLianLevelItemComponent = self.UIRoleXiLianLevels[2];
            self.UIRoleXiLianLevels.RemoveAt(2);
            self.UIRoleXiLianLevels.Insert(0, uIRoleXiLianLevelItemComponent);

            self.UIRoleXiLianLevels[1].OnUpdateUI(self.EquipXilianId - 1);
            self.OnUpdateButton(self.EquipXilianId - 1);
            self.SetPosition();
        }

        public static void OnButton_Right(this UIRoleXiLianLevelComponent self)
        {
            if (self.Timer != 0)
            {
                return;
            }
            UIRoleXiLianLevelItemComponent uIRoleXiLianLevelItemComponent = self.UIRoleXiLianLevels[0];
            self.UIRoleXiLianLevels.RemoveAt(0);
            self.UIRoleXiLianLevels.Add(uIRoleXiLianLevelItemComponent);

            self.UIRoleXiLianLevels[1].OnUpdateUI(self.EquipXilianId + 1);
            self.OnUpdateButton(self.EquipXilianId + 1);
            self.SetPosition();
        }

        public static void OnUpdateButton(this UIRoleXiLianLevelComponent self, int xilianLevel)
        {
            self.EquipXilianId = xilianLevel;

            List<EquipXiLianConfig> equipXiLianConfigs = EquipXiLianConfigCategory.Instance.EquipXiLianLevelList;
            self.Button_Left.SetActive(xilianLevel != equipXiLianConfigs[0].Id);
            self.Button_Right.SetActive(xilianLevel != equipXiLianConfigs[equipXiLianConfigs.Count - 1].Id);
        }
    }
}
