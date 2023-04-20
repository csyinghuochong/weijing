using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIMainSkillComponent : Entity, IAwake, IDestroy
    {

        public GameObject Btn_SkilPositionReset;
        public GameObject Btn_SkilPositionCancel;
        public GameObject SkillIconItemCopy;
        public GameObject SkillPositionSet;
        public GameObject Btn_SkilPositionSave;
        public GameObject Btn_NpcDuiHua;
        public GameObject Btn_JingLing;
        public GameObject Button_ZhuaPu;
        public GameObject shiquButton;
        public GameObject Btn_Target;
        public GameObject Btn_CancleSkill;
        public GameObject UI_MainRose_attack;
        public GameObject UI_MainRose_FanGun;

        public UIAttackGridComponent UIAttackGrid;
        public UIFangunSkillComponent UIFangunComponet;
        public List<UISkillGridComponent> UISkillGirdList = new List<UISkillGridComponent>();
        public List<UISkillDragComponent> UISkillDragList = new List<UISkillDragComponent>();
        public SkillManagerComponent SkillManagerComponent;

        public float LastLockTime;
        public float LastPickTime;

        public int CurDragIndex;
        public List<Vector2> SkillPositionList = new List<Vector2>();
        public List<Vector2> InitPositionList = new List<Vector2>();
        public List<Vector2> TempPositionList = new List<Vector2>();
    }


    public class UIMainSkillComponentDestroySystem : DestroySystem<UIMainSkillComponent>
    {
        public override void Destroy(UIMainSkillComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillCDUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillBeging, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.SkillFinish, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.JingLingButton, self);
        }
    }


    public class UIMainSkillComponentAwakeSystem : AwakeSystem<UIMainSkillComponent>
    {
        public override void Awake(UIMainSkillComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.UISkillGirdList.Clear();
            self.UI_MainRose_FanGun = rc.Get<GameObject>("UI_MainRose_FanGun");
            self.Btn_CancleSkill = rc.Get<GameObject>("Btn_CancleSkill");
            self.UI_MainRose_attack = rc.Get<GameObject>("UI_MainRose_attack");

            self.SkillPositionSet = rc.Get<GameObject>("ImageSkillPositionSet");
            self.SkillPositionSet.SetActive(false);

            self.Btn_SkilPositionReset = rc.Get<GameObject>("Btn_SkilPositionReset");
            self.Btn_SkilPositionReset.GetComponent<Button>().onClick.AddListener(self.OnBtn_SkilPositionReset);

            self.Btn_SkilPositionCancel = rc.Get<GameObject>("Btn_SkilPositionCancel");
            self.Btn_SkilPositionCancel.GetComponent<Button>().onClick.AddListener(self.OnBtn_SkilPositionCancel);

            self.Btn_SkilPositionSave = rc.Get<GameObject>("Btn_SkilPositionSave");
            self.Btn_SkilPositionSave.GetComponent<Button>().onClick.AddListener( self.OnBtn_SkilPositionSave);

            self.Btn_Target = rc.Get<GameObject>("Btn_Target");
            self.Btn_Target.GetComponent<Button>().onClick.AddListener(() => { self.OnLockTargetUnit(); });

            self.shiquButton = rc.Get<GameObject>("Btn_ShiQu");
            ButtonHelp.AddListenerEx(self.shiquButton, self.OnShiquItem);

            self.Btn_NpcDuiHua = rc.Get<GameObject>("Btn_NpcDuiHua");
            ButtonHelp.AddListenerEx(self.Btn_NpcDuiHua, self.OnBtn_NpcDuiHua);

            self.Button_ZhuaPu = rc.Get<GameObject>("Button_ZhuaPu");
            ButtonHelp.AddListenerEx(self.Button_ZhuaPu, self.OnButton_ZhuaPu);
            self.Button_ZhuaPu.SetActive(false);

            self.Btn_CancleSkill.SetActive(false);
            ButtonHelp.AddEventTriggers(self.Btn_CancleSkill, (PointerEventData pdata) => { self.OnEnterCancelButton(); }, EventTriggerType.PointerEnter);

            self.Btn_JingLing = rc.Get<GameObject>("Btn_JingLing");
            ButtonHelp.AddListenerEx(self.Btn_JingLing, () => { self.OnBtn_JingLing().Coroutine(); });

            self.SkillPositionList.Clear();
            //获取玩家携带的技能
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < 10; i++)
            {
                GameObject go = rc.Get<GameObject>($"UI_MainRoseSkill_item_{i}");
                UISkillGridComponent skillgrid = self.AddChild<UISkillGridComponent, GameObject>(go);
                skillgrid.SkillCancelHandler = self.ShowCancelButton;
                self.UISkillGirdList.Add(skillgrid);

                self.AddSkillDragItem(i, go);
            }

            //普通攻击
            OccupationConfig occConfig = OccupationConfigCategory.Instance.Get(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ);
            self.UIAttackGrid = self.AddChild<UIAttackGridComponent, GameObject>(self.UI_MainRose_attack);
            self.AddSkillDragItem(10, self.UI_MainRose_attack);

            //翻滚技能
            self.UIFangunComponet = self.AddChild<UIFangunSkillComponent, GameObject>(self.UI_MainRose_FanGun);
            self.SkillPositionList.Add(self.UI_MainRose_FanGun.transform.localPosition);
            self.AddSkillDragItem(11, self.UI_MainRose_FanGun);

            self.Init_SkilPositionSet();

            self.TempPositionList.Clear();
            for (int i = 0; i < self.SkillPositionList.Count; i++)
            {
                self.TempPositionList.Add(self.SkillPositionList[i]);
            }
            self.UpdateSkillPosition();
            DataUpdateComponent.Instance.AddListener(DataType.SkillCDUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.SkillBeging, self);
            DataUpdateComponent.Instance.AddListener(DataType.SkillFinish, self);
            DataUpdateComponent.Instance.AddListener(DataType.JingLingButton, self);
        }
    }

    public static class UIMainSkillComponentSystem
    {

        public static void AddSkillDragItem(this UIMainSkillComponent self, int i, GameObject go)
        {
            UISkillDragComponent uISkillDrag = self.AddChild<UISkillDragComponent, int, GameObject>(i, go);
            uISkillDrag.BeginDrag_TriggerHandler = self.OnBeginDrag_TriggerHandler;
            uISkillDrag.Drag_TriggerHandler = self.OnDrag_TriggerHandler;
            uISkillDrag.EndDrag_TriggerHandler = self.OnEndDrag_TriggerHandler;
            uISkillDrag.OnCancel_TriggerHandler = self.OnOnCancel_TriggerHandler;
            self.UISkillDragList.Add(uISkillDrag);
            self.SkillPositionList.Add(go.transform.localPosition);
            self.InitPositionList.Add(go.transform.localPosition);
        }

        public static void ShowSkillPositionSet(this UIMainSkillComponent self)
        {
            self.SkillPositionSet.SetActive(true);

            for (int i = 0; i < self.UISkillDragList.Count; i++)
            {
                self.UISkillDragList[i].Img_EventTrigger.SetActive(true);
            }
        }

        public static void Init_SkilPositionSet(this UIMainSkillComponent self)
        {
            long userid = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            string positonlist =  PlayerPrefsHelp.GetString($"PlayerPrefsHelp.SkillPostion_{userid}");
            if (ComHelp.IfNull(positonlist))
            {
                return;
            }
            string[] vector2list = positonlist.Split('@');
            if (vector2list.Length != 12)
            {
                return;
            }

            self.SkillPositionList.Clear();
            for (int i = 0; i < vector2list.Length; i++)
            {
                string[] vectorinfo = vector2list[i].Split(';');
                self.SkillPositionList.Add( new Vector2() {  x = float.Parse(vectorinfo[0]), y = float.Parse(vectorinfo[1]) } );
            }
        }

        public static void UpdateSkillPosition(this UIMainSkillComponent self)
        {
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                self.UISkillGirdList[i].GameObject.transform.localPosition = self.TempPositionList[i];
            }

            self.UIAttackGrid.GameObject.transform.localPosition = self.TempPositionList[10];
            self.UIFangunComponet.GameObject.transform.localPosition = self.TempPositionList[11];
        }

        public static void OnBtn_SkilPositionReset(this UIMainSkillComponent self)
        {
            self.TempPositionList.Clear();
            self.SkillPositionList.Clear();
            for (int i = 0;i < self.InitPositionList.Count; i++)
            {
                self.TempPositionList.Add(self.InitPositionList[i]);
                self.SkillPositionList.Add(self.InitPositionList[i]);
            }

            self.UpdateSkillPosition();
            self.OnBtn_SkilPositionSave();

            self.SkillPositionSet.SetActive(false);
            for (int i = 0; i < self.UISkillDragList.Count; i++)
            {
                self.UISkillDragList[i].Img_EventTrigger.SetActive(false);
            }
        }

        public static void OnBtn_SkilPositionCancel(this UIMainSkillComponent self)
        {
            self.TempPositionList.Clear();
            for (int i = 0; i < self.SkillPositionList.Count; i++)
            {
                self.TempPositionList.Add(self.SkillPositionList[i]);
            }
            self.UpdateSkillPosition();

            self.SkillPositionSet.SetActive(false);

            for (int i = 0; i < self.UISkillDragList.Count; i++)
            {
                self.UISkillDragList[i].Img_EventTrigger.SetActive(false);
            }
        }

        public static void OnBtn_SkilPositionSave(this UIMainSkillComponent self)
        {
            string positonlist = string.Empty;
            self.SkillPositionList.Clear();
            for (int i = 0; i < self.TempPositionList.Count; i++)
            {
                self.SkillPositionList.Add(self.TempPositionList[i]);
            }
            for (int i = 0; i < self.SkillPositionList.Count; i++)
            {
                Vector2 vector2 = self.SkillPositionList[i];    
                positonlist += $"{vector2.x};{vector2.y}@";
            }
            positonlist = positonlist.Substring(0, positonlist.Length - 1);
            long userid = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            PlayerPrefsHelp.SetString($"PlayerPrefsHelp.SkillPostion_{userid}", positonlist);

            self.SkillPositionSet.SetActive(false);

            for (int i = 0; i < self.UISkillDragList.Count; i++)
            {
                self.UISkillDragList[i].Img_EventTrigger.SetActive(false);
            }
        }

        public static void OnBeginDrag_TriggerHandler(this UIMainSkillComponent self, int skillIndex)
        {
            Log.Debug($"OnDraging_TriggerHandler :   {skillIndex}");
            self.CurDragIndex = skillIndex;
            
            self.SkillIconItemCopy = GameObject.Instantiate(self.UISkillDragList[skillIndex].GameObject);
            self.SkillIconItemCopy.SetActive(true);
            UICommonHelper.SetParent(self.SkillIconItemCopy, UIEventComponent.Instance.UILayers[(int)UILayer.Low].gameObject);
        }

        public static void OnDrag_TriggerHandler(this UIMainSkillComponent self, PointerEventData pdata)
        {
            Vector2 localPoint = Vector2.zero;
            RectTransform canvas = self.SkillIconItemCopy.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);

            self.SkillIconItemCopy.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
        }

        public static void OnEndDrag_TriggerHandler(this UIMainSkillComponent self, PointerEventData pdata)
        {
            self.OnOnCancel_TriggerHandler(pdata);
        }

        public static void OnOnCancel_TriggerHandler(this UIMainSkillComponent self, PointerEventData pdata)
        {
            RectTransform canvas = self.SkillIconItemCopy.transform.parent.GetComponent<RectTransform>();
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pdata, results);

            for (int i = 0; i < results.Count; i++)
            {
                string name = results[i].gameObject.name;
                if (!name.Contains("ImageSkillPositionSet"))
                {
                    continue;
                }
               
                Camera UiCamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
                Camera MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
               
                Vector3 uiPos_2 = Vector3.one;
                RectTransformUtility.ScreenPointToWorldPointInRectangle(results[i].gameObject.transform as RectTransform,
                            Input.mousePosition, MainCamera, out uiPos_2);

                Vector2 OldPosition = WorldPosiToUIPos.WorldPosiToUIPosition(uiPos_2, results[i].gameObject, UiCamera, MainCamera, false);
                self.TempPositionList[self.CurDragIndex] = OldPosition;

                self.UpdateSkillPosition();
                break;
            }

            if (self.SkillIconItemCopy != null)
            {
                GameObject.Destroy(self.SkillIconItemCopy);
                self.SkillIconItemCopy = null;
            }
        }

        public static void CheckJingLingFunction(this UIMainSkillComponent self)
        {
            self.Btn_JingLing.SetActive(false);
            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            if (chengJiuComponent.JingLingId == 0)
            {
                return;
            }
            bool showButton = false;
            JingLingConfig jingLingConfig = JingLingConfigCategory.Instance.Get(chengJiuComponent.JingLingId);
            switch (jingLingConfig.FunctionType)
            {
                case 1:
                    showButton = chengJiuComponent.RandomDrop == 0;
                    break;
                case 7:
                    showButton = true;
                    break;
                default:
                    showButton = false;
                    break;
            }
            self.Btn_JingLing.SetActive(showButton);
        }

        public static async ETTask OnBtn_JingLing(this UIMainSkillComponent self)
        {
            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            if (chengJiuComponent.JingLingId == 0)
            {
                return;
            }
            JingLingConfig jingLingConfig = JingLingConfigCategory.Instance.Get(chengJiuComponent.JingLingId);
            switch (jingLingConfig.FunctionType)
            {
                case 1:
                    if (chengJiuComponent.RandomDrop == 1)
                    {
                        FloatTipManager.Instance.ShowFloatTip("每日只能获取一次奖励！");
                        return;
                    }
                    C2M_JingLingDropRequest  request = new C2M_JingLingDropRequest();
                    M2C_JingLingDropResponse response = (M2C_JingLingDropResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                    chengJiuComponent.RandomDrop = 1;
                    self.CheckJingLingFunction();
                    break;
                case 7:
                    int functionId = int.Parse(jingLingConfig.FunctionValue);
                    FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(functionId);
                    string uipath = FunctionUI.GetInstance().GetUIPath(funtionConfig.Name);
                    UIHelper.Create(self.ZoneScene(), uipath).Coroutine();
                    break;
                default:
                    break;
            }

        }

        public static void OnLockUnit(this UIMainSkillComponent self, Unit unitlock)
        {
            if (unitlock == null || unitlock.Type != UnitType.Monster)
            {
                self.Button_ZhuaPu.SetActive(false);
                return;
            }
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unitlock.ConfigId);
            self.Button_ZhuaPu.SetActive(monsterConfig.MonsterSonType == 58 || monsterConfig.MonsterSonType == 59);
        }

        public static void OnButton_ZhuaPu(this UIMainSkillComponent self)
        {
            long lockTargetId = self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId;
            if (lockTargetId == 0)
            {
                return;
            }
            Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            Unit target = main.GetParent<UnitComponent>().Get(lockTargetId);
            if (target == null)
            {
                return;
            }
            if (PositionHelper.Distance2D(main, target) <= 3)
            {
                self.OnArriveNpc(target);
                return;
            }

            Vector3 dir = (main.Position - target.Position).normalized;
            Vector3 position = target.Position + dir * 2f;
            self.MoveToNpc(target, position).Coroutine();
        }

        public static void OnArriveNpc(this UIMainSkillComponent self, Unit target)
        {
            if (target == null || target.IsDisposed)
            {
                return;
            }

            UIHelper.CurrentNpcId = target.ConfigId;
            UIHelper.CurrentNpcUI = UIType.UIZhuaPu;
            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().JoystickMove.SetActive(false);
            CameraComponent cameraComponent = self.ZoneScene().CurrentScene().GetComponent<CameraComponent>();
            cameraComponent.SetBuildEnter(target, () => { self.OnBuildEnter().Coroutine(); });
        }

        public static async ETTask MoveToNpc(this UIMainSkillComponent self, Unit target, Vector3 position)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (ErrorCore.ERR_Success != unit.GetComponent<StateComponent>().CanMove())
                return;

            int ret = await unit.MoveToAsync2(position, true);
            if (ret != 0)
            {
                return;
            }
            if (PositionHelper.Distance2D(unit.Position, position) > 3f)
            {
                return;
            }
            self.OnArriveNpc(target);
        }

        public static async ETTask OnBuildEnter(this UIMainSkillComponent self)
        {
            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().JoystickMove.SetActive(true);
            long lockTargetId = self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId;
            if (lockTargetId == 0)
            {
                return;
            }
            Unit unit = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(lockTargetId);
            if (unit == null || unit.Type!=UnitType.Monster)
            {
                return;
            }

            //创建UI
            UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UIZhuaPu);
            ui.GetComponent<UIZhuaPuComponent>().OnInitUI(unit);
        }

        public static void OnBtn_NpcDuiHua(this UIMainSkillComponent self)
        {
            DuiHuaHelper.MoveToNpcDialog(self.ZoneScene());
        }

        public static void OnShiquItem(this UIMainSkillComponent self)
        {
            if (self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace() <= 0)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_BagIsFull);
                return;
            }
            Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (main.GetComponent<SkillManagerComponent>().IsSkillMoveTime())
            {
                return;
            }
            List<DropInfo> ids = MapHelper.GetCanShiQu(self.ZoneScene());
            if (ids.Count > 0)
            {
                self.RequestShiQu(ids).Coroutine();
                return;
            }
            else
            {
                Unit unit = MapHelper.GetNearItem(self.ZoneScene());
                if (unit != null)
                {
                    Vector3 dir = (main.Position - unit.Position).normalized;
                    Vector3 tar = unit.Position + dir * 1f;
                    self.MoveToShiQu(tar).Coroutine();
                    return;
                }
            }

            long chestId = MapHelper.GetChestBox(self.ZoneScene());
            if (chestId != 0)
            {
                self.ZoneScene().CurrentScene().GetComponent<OperaComponent>().OnClickChest(chestId);
            }
        }

        public static async ETTask RequestShiQu(this UIMainSkillComponent self, List<DropInfo> ids)
        {
            if (Time.time - self.LastPickTime < 1f)
            {
                return;
            }

            self.LastPickTime = Time.time;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (!unit.GetComponent<MoveComponent>().IsArrived())
            {
                self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
            }

            unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmShiQuItem);
            MapHelper.SendShiquItem(self.ZoneScene(), ids).Coroutine();

            unit.GetComponent<StateComponent>().SetNetWaitEndTime(TimeHelper.ClientNow() + 200);
            await TimerComponent.Instance.WaitAsync(200);
            unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmIdleState);
        }

        public static async ETTask MoveToShiQu(this UIMainSkillComponent self, Vector3 position)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int value = await unit.MoveToAsync2(position, true);
            List<DropInfo> ids = MapHelper.GetCanShiQu(self.ZoneScene());
            if (value == 0 && ids.Count > 0)
            {
                self.RequestShiQu(ids).Coroutine();
            }
        }


        public static void OnSkillBeging(this UIMainSkillComponent self, string dataParams)
        { 
            int skillId = int.Parse(dataParams);
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                if (self.UISkillGirdList[i].SkillPro==null)
                {
                    continue;
                }
                if (self.UISkillGirdList[i].SkillPro.SkillID == skillId)
                {
                    self.UISkillGirdList[i].Button_Cancle.SetActive(true);
                }
            }
        }

        public static void OnSkillFinish(this UIMainSkillComponent self, string dataParams)
        {
            int skillId = int.Parse(dataParams);
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                if (self.UISkillGirdList[i].SkillPro == null)
                {
                    continue;
                }
                if (self.UISkillGirdList[i].SkillPro.SkillID == skillId)
                {
                    self.UISkillGirdList[i].Button_Cancle.SetActive(false);
                }
            }
        }

        public static void OnSkillCDUpdate(this UIMainSkillComponent self)
        {
            if (self.SkillManagerComponent == null)
            {
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                self.SkillManagerComponent = unit.GetComponent<SkillManagerComponent>();
            }
            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                UISkillGridComponent uISkillGridComponent = self.UISkillGirdList[i];
                uISkillGridComponent.OnUpdate(self.SkillManagerComponent.GetCdTime(uISkillGridComponent.GetSkillId(), serverTime), 
                                              self.SkillManagerComponent.SkillPublicCDTime - serverTime);
            }
            self.UIFangunComponet.OnUpdate(self.SkillManagerComponent.GetCdTime(self.UIFangunComponet.SkillId, serverTime));
        }

        public static void OnEnterScene(this UIMainSkillComponent self, Unit unit, int sceneType)
        {
            self.SkillManagerComponent = unit.GetComponent<SkillManagerComponent>();
            self.OnSkillCDUpdate();
            self.CheckJingLingFunction();
        }

        public static void ResetUI(this UIMainSkillComponent self)
        {
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                UISkillGridComponent uISkillGridComponent = self.UISkillGirdList[i];
                uISkillGridComponent.OnUpdate(0,0);
                uISkillGridComponent.UseSkill = false;
            }
            self.UIFangunComponet.OnUpdate(0);
        }

        public static void OnLockTargetUnit(this UIMainSkillComponent self)
        {
            LockTargetComponent lockTargetComponent = self.ZoneScene().GetComponent<LockTargetComponent>();
            if (Time.time - self.LastLockTime > 5)
            {
                lockTargetComponent.LastLockId = 0;
                lockTargetComponent.LockTargetUnit(true);
                self.LastLockTime = Time.time;
            }
            else
            {
                lockTargetComponent.LockTargetUnit();
            }
        }

        public static void ShowCancelButton(this UIMainSkillComponent self, bool show)
        {
            self.Btn_CancleSkill.SetActive(show);
        }

        public static void OnEnterCancelButton(this UIMainSkillComponent self)
        {
            FloatTipManager.Instance.ShowFloatTip("取消技能施法");

            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                self.UISkillGirdList[i].OnEnterCancelButton();
            }
        }

        public static void OnBagItemUpdate(this UIMainSkillComponent self)
        {
            for (int i = 0; i < self.UISkillGirdList.Count; i++)
            {
                self.UISkillGirdList[i].UpdateItemNumber();
            }
        }

        public static void OnSkillSetUpdate(this UIMainSkillComponent self)
        {
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < 10; i++)
            {
                UISkillGridComponent skillgrid = self.UISkillGirdList[i];
                SkillPro skillid = skillSetComponent.GetByPosition(i + 1);
                skillgrid.UpdateSkillInfo(skillid);
            }
        }
    }
}
