using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    [ObjectSystem]
    public class JiaYuanViewComponentAwake : AwakeSystem<JiaYuanViewComponent>
    {
        public override void Awake(JiaYuanViewComponent self)
        {
            self.CellIndex = -1;
            self.LastCellIndex = -1; 
            self.JianYuanPlanUIs.Clear();
            self.JiaYuanPlanLocks.Clear();
        }
    }

    [ObjectSystem]
    public class JiaYuanViewComponentDestroy : DestroySystem<JiaYuanViewComponent>
    {
        public override void Destroy(JiaYuanViewComponent self)
        {
            if (self.SelectEffect != null)
            { 
                GameObject.Destroy(self.SelectEffect.gameObject);
                self.SelectEffect = null;
            }
        }
    }

    public static class JiaYuanViewComponentSystem
    {

        public static async ETTask<int> LockTargetPasture(this JiaYuanViewComponent self)
        {
            float distance = 10f;

            Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            List<Unit> units = main.GetParent<UnitComponent>().GetAll();
            ListComponent<UnitLockRange> UnitLockRanges = new ListComponent<UnitLockRange>();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                if (!unit.IsPasture())
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(main, unit);
                if (dd < distance)
                {
                    UnitLockRanges.Add(new UnitLockRange() { Id = unit.Id, Range = (int)(dd * 100) });
                }
            }

            if (UnitLockRanges.Count == 0)
            {
                //取消锁定
                return -1;
            }

            UnitLockRanges.Sort(delegate (UnitLockRange a, UnitLockRange b)
            {
                return a.Range - b.Range;
            });

            self.LastPasureIndex++;
            if (self.LastPasureIndex >= UnitLockRanges.Count)
            {
                self.LastPasureIndex = 0;
            }
            UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIJiaYuanMenu);
            Unit targetUnit = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(UnitLockRanges[self.LastPasureIndex].Id);
            self.ZoneScene().GetComponent<LockTargetComponent>().LockTargetUnitId(targetUnit.Id);
            uI.GetComponent<UIJiaYuanMenuComponent>().OnUpdatePasture(targetUnit);
            return self.LastPasureIndex;
        }

        public static async ETTask LockTargetUnit(this JiaYuanViewComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIJiaYuanMenu);
            int lastTarget = await self.LockTargetPasture();
            if (lastTarget != -1)
            {
                return;
            }

            //植物
            float distance = 2f;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            List<UnitLockRange> UnitLockRanges = new ListComponent<UnitLockRange>();
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            for (int i = 0; i < self.JianYuanPlanUIs.Count; i++)
            {
                float dd = Vector3.Distance(unit.Position, self.JianYuanPlanUIs[i].transform.position);
                if (dd < distance && jiaYuanComponent.PlanOpenList_7.Contains(i))
                {
                    UnitLockRanges.Add(new UnitLockRange() { Id = i, Range = (int)(dd * 100) });
                }
            }
            if (UnitLockRanges.Count == 0)
            {
                return;
            }
            UnitLockRanges.Sort(delegate (UnitLockRange a, UnitLockRange b)
            {
                return a.Range - b.Range;
            });
            self.LastCellIndex++;
            if (self.LastCellIndex >= UnitLockRanges.Count)
            {
                self.LastCellIndex = 0;
            }
            self.OnClickPlanItem((int)UnitLockRanges[self.LastCellIndex].Id).Coroutine();
        }

        public static async ETTask RequestPlanOpen(this JiaYuanViewComponent self, int index)
        {
            C2M_JiaYuanPlanOpenRequest request = new C2M_JiaYuanPlanOpenRequest() { CellIndex = index };
            M2C_JiaYuanPlanOpenResponse response = (M2C_JiaYuanPlanOpenResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }
            self.ZoneScene().GetComponent<JiaYuanComponent>().PlanOpenList_7 = response.PlanOpenList;
            EventType.JiaYuanOpen.Instance.CellIndex = index;
            EventType.JiaYuanOpen.Instance.ZoneScene = self.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.JiaYuanOpen.Instance);
        }

        public static async ETTask OnClickPlanItem(this JiaYuanViewComponent self, int index)
        {
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            if (jiaYuanComponent.PlanOpenList_7.Contains(index))
            {
                self.OnSelectCell(index);
                UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIJiaYuanMenu);
                uI.GetComponent<UIJiaYuanMenuComponent>().OnUpdatePlan();
                return;
            }

            int costnumber = ConfigHelper.JiaYuanFarmOpen[index];
            string consttip = UICommonHelper.GetNeedItemDesc($"13;{costnumber}");
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "系统提示", $"是否花费 {consttip} 开启一块土地", () =>
            {
                self.RequestPlanOpen(index).Coroutine();
            }, null).Coroutine();
            return;
        }


        public static void OnOpenPlan(this JiaYuanViewComponent self, int index)
        {
            JiaYuanPlanLockComponent jiaYuanPlanLockComponent = null;
            self.JiaYuanPlanLocks.TryGetValue(index, out jiaYuanPlanLockComponent);
            if (jiaYuanPlanLockComponent == null)
            {
                return;
            }
            jiaYuanPlanLockComponent.SetOpenState(index, true);
        }

        public static void OnInitUI(this JiaYuanViewComponent self)
        {
            self.OnInitPlan();
            self.InitEffect();
            self.UpdateName();
        }

        public static void UpdateName(this JiaYuanViewComponent self)
        {
            Unit npc = TaskHelper.GetNpcByConfigId(self.ZoneScene(), 30000004);
            if (npc == null )
            {
                return;
            }
            GameObjectComponent gameObjectComponent = npc.GetComponent<GameObjectComponent>();
            if (gameObjectComponent == null || gameObjectComponent.GameObject == null)
            {
                return;
            }
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            GameObject gameObject = gameObjectComponent.GameObject;
            TextMesh textMesh = gameObject.Get<GameObject>("NewNameText").GetComponent<TextMesh>();
            textMesh.text = userInfoComponent.UserInfo.Name;
        }

        public static void InitEffect(this JiaYuanViewComponent self)
        {
            string path = ABPathHelper.GetEffetPath("ScenceEffect/Eff_JiaYuan_Select");
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            self.SelectEffect = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            self.SelectEffect.SetActive(false);
        }

        public static void OnInitPlan(this JiaYuanViewComponent self)
        {
            int jiayuanid = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.JiaYuanLv;
            //JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(jiayuanid);
            //int openCell = jiaYuanConfig.FarmNumMax;
           
            self.JianYuanPlanUIs.Clear();
            GameObject NongChangSet = GameObject.Find("NongChangSet");
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            for (int i = 0; i < NongChangSet.transform.childCount; i++)
            {
                GameObject item = NongChangSet.transform.GetChild(i).gameObject;
                item.SetActive(true);
                JiaYuanPlanLockComponent jiaYuanPlanLock = self.AddChild<JiaYuanPlanLockComponent, GameObject>(item);
                self.JiaYuanPlanLocks.Add(i, jiaYuanPlanLock);
                jiaYuanPlanLock.SetOpenState(i, jiaYuanComponent.PlanOpenList_7.Contains(i));
                self.JianYuanPlanUIs.Add(i, item);
            }
        }

        public static void OnSelectCell(this JiaYuanViewComponent self, int cell)
        {
            UICommonHelper.SetParent( self.SelectEffect, self.JianYuanPlanUIs[cell]);
            self.CellIndex = cell;
            self.SelectEffect.SetActive(true);
            self.SelectEffect.transform.localPosition = new Vector3(0f, 0.2f, 0f);
        }

        public static void OnSelectCancel(this JiaYuanViewComponent self)
        {
            self.SelectEffect?.SetActive(false);
        }
    }
}
