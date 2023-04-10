using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    /// <summary>
    /// 家园事件分发。  
    /// </summary>
    public class UIJiaYuanMainComponent : Entity, IAwake, IDestroy
    {

        public GameObject Btn_ShouSuo;
        public GameObject ButtonReturn;
        public GameObject GameObject;

        public int CellIndex;

        public int LastPasureIndex;
        public int LastCellIndex;

        public GameObject SelectEffect;

        public GameObject ButtonGather;
        public GameObject ButtonTalk;
        public GameObject ButtonTarget;

        public GameObject RenKouText;
        public GameObject GengDiText;

        public long GatherTime;

        public UIJiaYuanVisitComponent UIJiaYuaVisitComponent;
        public Dictionary<int, GameObject> JianYuanPlanUIs = new Dictionary<int, GameObject>();
        public Dictionary<int, JiaYuanPlanLockComponent> JiaYuanPlanLocks = new Dictionary<int, JiaYuanPlanLockComponent>();

        public bool MyJiaYuan;
        public int JiaYuanLv;
    }

    [ObjectSystem]
    public class UIJiaYuanMainComponentAwake : AwakeSystem<UIJiaYuanMainComponent>
    {
        public override void Awake(UIJiaYuanMainComponent self)
        {
            self.GameObject = self.GetParent<UI>().GameObject;

            self.CellIndex = -1;
            self.LastCellIndex = -1;
            self.JianYuanPlanUIs.Clear();
            self.JiaYuanPlanLocks.Clear();

            ReferenceCollector rc = self.GameObject.GetComponent<ReferenceCollector>();
            self.ButtonGather = rc.Get<GameObject>("ButtonGather");
            self.ButtonTalk = rc.Get<GameObject>("ButtonTalk");
            self.ButtonTarget = rc.Get<GameObject>("ButtonTarget");

            self.ButtonReturn = rc.Get<GameObject>("ButtonReturn");
            ButtonHelp.AddListenerEx(self.ButtonReturn, () => { self.OnButtonReturn(); });

            self.RenKouText = rc.Get<GameObject>("RenKouText");
            self.GengDiText = rc.Get<GameObject>("GengDiText");

            GameObject Right = rc.Get<GameObject>("Right");
            Right.SetActive(true);
            self.UIJiaYuaVisitComponent = self.AddChild<UIJiaYuanVisitComponent, GameObject>(Right);

            self.Btn_ShouSuo = rc.Get<GameObject>("Btn_ShouSuo");
            self.Btn_ShouSuo.GetComponent<Button>().onClick.AddListener(self.OnBtn_ShouSuo);

            ButtonHelp.AddListenerEx(self.ButtonGather, () => { self.OnButtonGather().Coroutine(); });
            ButtonHelp.AddListenerEx(self.ButtonTalk, () => { self.OnButtonTalk(); });
            ButtonHelp.AddListenerEx(self.ButtonTarget, () => { self.OnButtonTarget(); });

            DataUpdateComponent.Instance.AddListener(DataType.BeforeMove, self);

            self.OnInit().Coroutine();
        }
    }

    public class UIJiaYuanMainComponentDestroy : DestroySystem<UIJiaYuanMainComponent>
    {
        public override void Destroy(UIJiaYuanMainComponent self)
        {
            if (self.SelectEffect != null)
            {
                GameObject.Destroy(self.SelectEffect.gameObject);
                self.SelectEffect = null;
            }

            DataUpdateComponent.Instance.RemoveListener(DataType.BeforeMove, self);
        }
    }

    public static class UIJiaYuanMainComponentSystem
    {

        public static void OnBtn_ShouSuo(this UIJiaYuanMainComponent self)
        {
            bool activeSelf = self.UIJiaYuaVisitComponent.GameObject.activeSelf;
            self.UIJiaYuaVisitComponent.GameObject.SetActive(!activeSelf);

            self.Btn_ShouSuo.transform.localPosition = activeSelf ? new Vector3(-51f, -142f, 0f) : new Vector3(-551f, -142f, 0f);

        }

        public static void OnButtonReturn(this UIJiaYuanMainComponent self)
        {
            Scene zoneScene = self.ZoneScene();
            string tipStr = "确定返回主城？";
            PopupTipHelp.OpenPopupTip(self.DomainScene(), "", GameSettingLanguge.LoadLocalization(tipStr),
                () =>
                {
                    EnterFubenHelp.RequestQuitFuben(self.ZoneScene());
                },
                null).Coroutine();
        }

        public static async  ETTask LockTargetUnitId(this UIJiaYuanMainComponent self, long unitid)
        { 
            RolePetInfo rolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(unitid);
            if (rolePetInfo == null)
            {
                return;
            }
            JiaYuanPet jiaYuanPet = self.ZoneScene().GetComponent<JiaYuanComponent>().GetJiaYuanPet(unitid);
            UI uI = await UIHelper.Create( self.ZoneScene(), UIType.UIJiaYuanPetFeed );
            uI.GetComponent<UIJiaYuanPetFeedComponent>().OnInitUI(jiaYuanPet);
        }

        public static async ETTask OnInit(this UIJiaYuanMainComponent self)
        {
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
           
            C2M_JiaYuanInitRequest request = new C2M_JiaYuanInitRequest() { MasterId = jiaYuanComponent.MasterId };
            M2C_JiaYuanInitResponse response = (M2C_JiaYuanInitResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            jiaYuanComponent.PlanOpenList_7 = response.PlanOpenList;
            jiaYuanComponent.PurchaseItemList_7 = response.PurchaseItemList;
            jiaYuanComponent.LearnMakeIds_7 = response.LearnMakeIds;
            jiaYuanComponent.JiaYuanPastureList_7 = response.JiaYuanPastureList;
            jiaYuanComponent.JiaYuanProList_7 = response.JiaYuanProList;
            jiaYuanComponent.JiaYuanDaShiTime_1 = response.JiaYuanDaShiTime;
            jiaYuanComponent.JiaYuanPetList_2 = response.JiaYuanPetList;
            if (self.IsDisposed)
            {
                return;
            }

            self.MyJiaYuan = jiaYuanComponent.MasterId == userInfoComponent.UserInfo.UserId;
            self.JiaYuanLv = self.MyJiaYuan ?  userInfoComponent.UserInfo.JiaYuanLv : response.JiaYuanLv;
            JiaYuanConfig jiayuanCof = JiaYuanConfigCategory.Instance.Get(self.JiaYuanLv);

            self.RenKouText.GetComponent<Text>().text = jiaYuanComponent.GetPeopleNumber() + "/" + jiayuanCof.PeopleNumMax;
            self.GengDiText.GetComponent<Text>().text = jiaYuanComponent.GetOpenPlanNumber() + "/" + jiayuanCof.FarmNumMax;

            self.OnInitPlan();
            self.InitEffect();
            self.UpdateName(response.MasterName);

            self.UIJiaYuaVisitComponent.OnInitUI(0).Coroutine();
        }

        public static async ETTask OnButtonGather(this UIJiaYuanMainComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (!self.ZoneScene().GetComponent<JiaYuanComponent>().IsMyJiaYuan(unit.Id))
            {
                return;
            }
            if (TimeHelper.ClientNow() - self.GatherTime < 2000)
            {
                return;
            }

            int gatherNumber = 0;
            long instanceid = self.InstanceId;
            self.GatherTime = TimeHelper.ClientNow();
            List<Unit> planlist = UnitHelper.GetUnitList(self.ZoneScene().CurrentScene(), UnitType.Plant);
            for (int i = planlist.Count - 1; i >= 0; i--)
            {
                if (PositionHelper.Distance2D(unit, planlist[i]) > 5f)
                {
                    continue;
                }
                NumericComponent numericComponent = planlist[i].GetComponent<NumericComponent>();
                long StartTime = numericComponent.GetAsLong(NumericType.StartTime);
                int GatherNumber = numericComponent.GetAsInt(NumericType.GatherNumber);
                long LastGameTime = numericComponent.GetAsLong(NumericType.GatherLastTime);
                int cellIndex = numericComponent.GetAsInt(NumericType.CellIndex);
                int getcode = JiaYuanHelper.GetPlanShouHuoItem(planlist[i].ConfigId, StartTime, GatherNumber, LastGameTime);
                if (getcode == ErrorCore.ERR_Success)
                {
                    gatherNumber++;
                    C2M_JiaYuanGatherRequest request = new C2M_JiaYuanGatherRequest() { CellIndex = cellIndex, UnitId = planlist[i].Id, OperateType = 1 };
                    M2C_JiaYuanGatherResponse response = (M2C_JiaYuanGatherResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                }
                if (instanceid != self.InstanceId)
                {
                    return;
                }
            }

            List<Unit> pasturelist = UnitHelper.GetUnitList(self.ZoneScene().CurrentScene(), UnitType.Pasture);
            for (int i = pasturelist.Count - 1; i >= 0; i--)
            {
                if (PositionHelper.Distance2D(unit, pasturelist[i]) > 5f)
                {
                    continue;
                }
                NumericComponent numericComponent = pasturelist[i].GetComponent<NumericComponent>();
                long StartTime = numericComponent.GetAsLong(NumericType.StartTime);
                int GatherNumber = numericComponent.GetAsInt(NumericType.GatherNumber);
                long LastGameTime = numericComponent.GetAsLong(NumericType.GatherLastTime);

                int getcode = JiaYuanHelper.GetPastureShouHuoItem(pasturelist[i].ConfigId, StartTime, GatherNumber, LastGameTime);
                if (getcode == ErrorCore.ERR_Success)
                {
                    gatherNumber++;
                    C2M_JiaYuanGatherRequest request = new C2M_JiaYuanGatherRequest() { UnitId = pasturelist[i].Id, OperateType = 2 };
                    M2C_JiaYuanGatherResponse response = (M2C_JiaYuanGatherResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                }
                if (instanceid != self.InstanceId)
                {
                    return;
                }
            }

            if (gatherNumber == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("附近没有可收获的道具！");
            }
        }

        public static void OnButtonTalk(this UIJiaYuanMainComponent self)
        {
            Unit main = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            List<Unit> units = main.GetParent<UnitComponent>().GetAll();

            float mindis = -1f;
            long rubshid = 0;
            for (int i = 0; i  < units.Count; i++)
            {
                if (units[i].Type != UnitType.Monster)
                {
                    continue;
                }
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(units[i].ConfigId);
                if (monsterConfig.MonsterSonType != 60)
                {
                    continue;
                }
                float t_distance = PositionHelper.Distance2D(main, units[i]);
                if (mindis <= 0f || t_distance < mindis)
                {
                    rubshid = units[i].Id;
                    mindis = t_distance;
                }
            }
            if (rubshid > 0)
            {
                self.ZoneScene().CurrentScene().GetComponent<OperaComponent>().OnClickChest(rubshid);
            }
            else
            {
                DuiHuaHelper.MoveToNpcDialog(self.ZoneScene());
            }
        }

        public static void OnButtonTarget(this UIJiaYuanMainComponent self)
        {
            self.LockTargetUnit().Coroutine();
        }

        public static async ETTask<int> LockTargetPasture(this UIJiaYuanMainComponent self)
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

        public static async ETTask LockTargetUnit(this UIJiaYuanMainComponent self)
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

        public static async ETTask RequestPlanOpen(this UIJiaYuanMainComponent self, int index)
        {
            C2M_JiaYuanPlanOpenRequest request = new C2M_JiaYuanPlanOpenRequest() { CellIndex = index };
            M2C_JiaYuanPlanOpenResponse response = (M2C_JiaYuanPlanOpenResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }
            self.ZoneScene().GetComponent<JiaYuanComponent>().PlanOpenList_7 = response.PlanOpenList;

            self.OnOpenPlan(index);
        }

        public static async ETTask OnClickPlanItem(this UIJiaYuanMainComponent self, int index)
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

        public static void OnOpenPlan(this UIJiaYuanMainComponent self, int index)
        {
            JiaYuanPlanLockComponent jiaYuanPlanLockComponent = null;
            self.JiaYuanPlanLocks.TryGetValue(index, out jiaYuanPlanLockComponent);
            if (jiaYuanPlanLockComponent == null)
            {
                return;
            }
            jiaYuanPlanLockComponent.SetOpenState(index, true);
        }


        public static void CopyBuffer(this UIJiaYuanMainComponent self)
        {
            UnityEngine.GUIUtility.systemCopyBuffer = "Target String";
        }

        public static void UpdateName(this UIJiaYuanMainComponent self, string mastername)
        {
            if (GlobalHelp.IsEditorMode)
            {
                Unit npc = TaskHelper.GetNpcByConfigId(self.ZoneScene(), 30000004);
                if (npc == null)
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
                textMesh.text = mastername;
            }
        }

        public static void InitEffect(this UIJiaYuanMainComponent self)
        {
            string path = ABPathHelper.GetEffetPath("ScenceEffect/Eff_JiaYuan_Select");
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            self.SelectEffect = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            self.SelectEffect.SetActive(false);
        }

        public static void OnInitPlan(this UIJiaYuanMainComponent self)
        {
            int jiayuanid = self.JiaYuanLv;
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

        public static void OnSelectCell(this UIJiaYuanMainComponent self, int cell)
        {
            UICommonHelper.SetParent(self.SelectEffect, self.JianYuanPlanUIs[cell]);
            self.CellIndex = cell;
            self.SelectEffect.SetActive(true);
            self.SelectEffect.transform.localPosition = new Vector3(0f, 0.2f, 0f);
        }

        public static void OnSelectCancel(this UIJiaYuanMainComponent self)
        {
            self.SelectEffect?.SetActive(false);
        }
    }
}