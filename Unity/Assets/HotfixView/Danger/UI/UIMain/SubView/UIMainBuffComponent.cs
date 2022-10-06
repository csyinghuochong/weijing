using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIMainBuffComponent : Entity, IAwake, IDestroy
    {
        public GameObject UIMainBuffItem;
        public List<UI> MainBuffUIList = new List<UI>();
        public List<UI> CacheUIList = new List<UI>();
    }

    [ObjectSystem]
    public class UIMainBuffComponentAwakeSystem : AwakeSystem<UIMainBuffComponent>
    {

        public override void Awake(UIMainBuffComponent self)
        {;
            self.MainBuffUIList.Clear();

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
        }
    }

    public static class UIMainBuffComponentSystem
    {

        public static void OnUpdate(this UIMainBuffComponent self)
        {
            for (int i = self.MainBuffUIList.Count - 1; i >= 0; i--)
            {
                UIMainBuffItemComponent uIMainBuffItemComponent = self.MainBuffUIList[i].GetComponent<UIMainBuffItemComponent>();
                bool update = uIMainBuffItemComponent.OnUpdate();
                if (!update)
                {
                    uIMainBuffItemComponent.BuffID = 0;
                    self.MainBuffUIList[i].GameObject.SetActive(false);
                    self.CacheUIList.Add(self.MainBuffUIList[i]);
                    self.MainBuffUIList.RemoveAt(i);
                }
            }
        }

        public static void SetEnable(this UIMainBuffComponent self, bool enabled)
        {
            self.GetParent<UI>().GameObject.SetActive(enabled);
            if (!enabled)
            {
                self.ResetUI();
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
                self.MainBuffUIList[i].GetComponent<UIMainBuffItemComponent>().BuffID = 0;
                self.MainBuffUIList[i].GameObject.SetActive(false);
                self.CacheUIList.Add(self.MainBuffUIList[i]);
            }
            self.MainBuffUIList.Clear();
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
            UI ui_buff = self.CacheUIList.Count > 0 ? self.CacheUIList[0] : null ;
            if (ui_buff == null)
            {
                ui_buff = self.AddChild<UI, string, GameObject>("UIMainBuffItemComponent", GameObject.Instantiate<GameObject>(self.UIMainBuffItem));
                ui_buff.AddComponent<UIMainBuffItemComponent>();
            }
            else
            {
                self.CacheUIList.RemoveAt(0);    
            }
            self.MainBuffUIList.Add(ui_buff);
            ui_buff.GameObject.SetActive(true);
            ui_buff.GetComponent<UIMainBuffItemComponent>().OnAddBuff(buffID, endTime);
            UICommonHelper.SetParent(ui_buff.GameObject, self.GetParent<UI>().GameObject);
        }

        public static void OnResetBuff(this UIMainBuffComponent self, int buffID)
        {
            for (int i = 0; i < self.MainBuffUIList.Count; i++)
            {
                UIMainBuffItemComponent uIMainBuffItemComponent = self.MainBuffUIList[i].GetComponent<UIMainBuffItemComponent>();
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
                UIMainBuffItemComponent uIMainBuffItemComponent = self.MainBuffUIList[i].GetComponent<UIMainBuffItemComponent>();
                if (uIMainBuffItemComponent.BuffID == buffID)
                {
                    uIMainBuffItemComponent.BuffID = 0;
                    uIMainBuffItemComponent.EndTime = 0;
                }
            }
        }
    }

}
