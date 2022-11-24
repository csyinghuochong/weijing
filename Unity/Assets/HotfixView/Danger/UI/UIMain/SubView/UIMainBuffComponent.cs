using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [Timer(TimerType.MainBuffTimer)]
    public class MainBuffTimer : ATimer<UIMainBuffComponent>
    {
        public override void Run(UIMainBuffComponent self)
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

    public class UIMainBuffComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public GameObject UIMainBuffItem;
        public List<UIMainBuffItemComponent> MainBuffUIList = new List<UIMainBuffItemComponent>();
        public List<UIMainBuffItemComponent> CacheUIList = new List<UIMainBuffItemComponent>();
    }

    [ObjectSystem]
    public class UIMainBuffComponentAwakeSystem : AwakeSystem<UIMainBuffComponent>
    {
        public override void Awake(UIMainBuffComponent self)
        {
            self.MainBuffUIList.Clear();
            self.CacheUIList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.UIMainBuffItem = rc.Get<GameObject>("UIMainBuffItem");
            self.UIMainBuffItem.SetActive(false);

            self.OnInitBuff();
            DataUpdateComponent.Instance.AddListener(DataType.BuffUpdate, self);
        }
    }

    [ObjectSystem]
    public class UIMainBuffComponentDestroySystem : DestroySystem<UIMainBuffComponent>
    {
        public override void Destroy(UIMainBuffComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BuffUpdate, self);
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UIMainBuffComponentSystem
    {

        public static void OnUpdate(this UIMainBuffComponent self)
        {
            for (int i = self.MainBuffUIList.Count - 1; i >= 0; i--)
            {
                UIMainBuffItemComponent uIMainBuffItemComponent = self.MainBuffUIList[i];
                bool update = uIMainBuffItemComponent.OnUpdate();
                if (!update)
                {
                    uIMainBuffItemComponent.BuffID = 0;
                    self.MainBuffUIList[i].GameObject.SetActive(false);
                    self.CacheUIList.Add(self.MainBuffUIList[i]);
                    self.MainBuffUIList.RemoveAt(i);
                }
            }
            if (self.MainBuffUIList.Count == 0)
            { 
                TimerComponent.Instance.Remove(ref self.Timer);
            }
        }

        public static void OnBuffUpdate(this UIMainBuffComponent self, string dataParams)
        {
            //1添加  2移除 3重置
            string[] operateParams = dataParams.Split('@');
            switch (int.Parse(operateParams[1]))
            {
                case 1:
                    self.OnAddBuff(int.Parse(operateParams[0]), long.Parse(operateParams[2]));
                    break;
                case 2:
                    self.OnRemoveBuff(int.Parse(operateParams[0]));
                    break;
                case 3:
                    self.OnResetBuff(int.Parse(operateParams[0]));
                    break;
            }
        }

        public static void ResetUI(this UIMainBuffComponent self)
        {
            for (int i = 0; i < self.MainBuffUIList.Count; i++)
            {
                self.MainBuffUIList[i].BuffID = 0;
                self.MainBuffUIList[i].GameObject.SetActive(false);
                self.CacheUIList.Add(self.MainBuffUIList[i]);
            }
            self.MainBuffUIList.Clear();
            if (self.MainBuffUIList.Count == 0)
            {
                TimerComponent.Instance.Remove(ref self.Timer);
            }
        }

        public static void OnInitBuff(this UIMainBuffComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            List<ABuffHandler> aBuffs = unit.GetComponent<BuffManagerComponent>().m_Buffs;
            for (int i = 0; i < aBuffs.Count; i++)
            {
                ABuffHandler buffHandler = aBuffs[i];
                if (buffHandler.mSkillBuffConf.IfShowIconTips == 0)
                {
                    return;
                }
                self.OnAddBuff(buffHandler.mSkillBuffConf.Id, buffHandler.BuffEndTime);
            }
        }

        public static void OnAddBuff(this UIMainBuffComponent self, int buffID, long endTime)
        {
            UIMainBuffItemComponent ui_buff = self.CacheUIList.Count > 0 ? self.CacheUIList[0] : null ;
            if (ui_buff == null)
            {
                ui_buff = self.AddChild<UIMainBuffItemComponent, GameObject>(GameObject.Instantiate(self.UIMainBuffItem));
            }
            else
            {
                self.CacheUIList.RemoveAt(0);    
            }
            self.MainBuffUIList.Add(ui_buff);
            ui_buff.GameObject.SetActive(true);
            ui_buff.OnAddBuff(buffID, endTime);
            UICommonHelper.SetParent(ui_buff.GameObject, self.GetParent<UI>().GameObject);
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewRepeatedTimer(500, TimerType.MainBuffTimer, self);
            }
        }

        public static void OnResetBuff(this UIMainBuffComponent self, int buffID)
        {
            for (int i = 0; i < self.MainBuffUIList.Count; i++)
            {
                UIMainBuffItemComponent uIMainBuffItemComponent = self.MainBuffUIList[i];
                if (uIMainBuffItemComponent.BuffID == buffID)
                {
                    uIMainBuffItemComponent.OnResetBuff();
                }
            }
        }

        public static void OnRemoveBuff(this UIMainBuffComponent self, int buffID)
        {
            for (int i = self.MainBuffUIList.Count - 1; i >= 0; i--)
            {
                UIMainBuffItemComponent uIMainBuffItemComponent = self.MainBuffUIList[i];
                if (uIMainBuffItemComponent.BuffID == buffID)
                {
                    uIMainBuffItemComponent.BuffID = 0;
                    uIMainBuffItemComponent.EndTime = 0;
                }
            }
        }
    }

}
