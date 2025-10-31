using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    [Timer(TimerType.JoystickTimer)]
    public class JoystickTimer : ATimer<UIJoystickMoveComponent>
    {
        public override void Run(UIJoystickMoveComponent self)
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

    public class UIJoystickMoveComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Thumb;
        public GameObject CenterShow;

        public Image ThumbImage;
        public Image CenterShowImage;

        public GameObject YaoGanDiMove;
        public GameObject YaoGanDiFix;

        public Vector2 OldPoint;
        public Vector2 NewPoint;
        public float Distance = 110;
        public long lastSendTime;
        public long checkTime;
        public long noCheckTime;

        public int direction;
        public int lastDirection;

        public Camera UICamera;
        public Camera MainCamera;
        public float LastShowTip;

        public Unit MainUnit;
        public NumericComponent NumericComponent;
        public AttackComponent AttackComponent;
        public MoveComponent MoveComponent;
        public BattleMessageComponent BattleMessageComponent;
        public GameObject GameObject;

        public int ObstructLayer;
        public int BuildingLayer;
        public int MapLayer;
        public long Timer;

        public int OperateMode;
        public int SceneTypeEnum;

        public bool IsDrag;// 当一直拖拽摇杆时，场景进行切换后松开鼠标不会触发取消拖拽的回调，会一直处于拖拽中状态，且一直触发拖拽中回调，只有重新点击再松开才行。
                           // 试着清空EventTrigger.triggers后再从新添加回调，仍然会一直触发拖拽中回调。可能是UGUI的Bug??，所以此变量用来处理这种情况。

    }

    public class UIJoystickMoveComponentDestroy : DestroySystem<UIJoystickMoveComponent>
    {
        public override void Destroy(UIJoystickMoveComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public class UIJoystickMoveComponentAwake : AwakeSystem<UIJoystickMoveComponent, GameObject>
    {
        public override void Awake(UIJoystickMoveComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.direction = 0;
            self.lastDirection = 0;
            self.CenterShow = rc.Get<GameObject>("CenterShow");

            self.YaoGanDiMove = rc.Get<GameObject>("YaoGanDiMove");
            self.YaoGanDiFix = rc.Get<GameObject>("YaoGanDiFix");

            self.Thumb = rc.Get<GameObject>("Thumb");

            self.ThumbImage = rc.Get<GameObject>("Thumb").GetComponent<Image>();

            self.CenterShowImage = rc.Get<GameObject>("Thumb").GetComponent<Image>();

            ButtonHelp.AddEventTriggers(self.YaoGanDiMove, (PointerEventData pdata) => { self.PointerDown_Move(pdata); },
                EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.YaoGanDiMove, (PointerEventData pdata) => { self.BeginDrag(pdata); }, EventTriggerType.BeginDrag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiMove, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiMove, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.EndDrag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiMove, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.YaoGanDiFix, (PointerEventData pdata) => { self.PointerDown_Fix(pdata); }, EventTriggerType.PointerDown);
            //ButtonHelp.AddEventTriggers(self.YaoGanDiFix, (PointerEventData pdata) => { self.BeginDrag(pdata); }, EventTriggerType.BeginDrag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiFix, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiFix, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.EndDrag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiFix, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.PointerUp);

            self.UICamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            self.MainCamera = self.DomainScene().GetComponent<UIComponent>().MainCamera;
            self.AttackComponent = self.ZoneScene().GetComponent<AttackComponent>();
            self.BattleMessageComponent = self.ZoneScene().GetComponent<BattleMessageComponent>();
            self.ObstructLayer = (1 << LayerMask.NameToLayer(LayerEnum.Obstruct.ToString()));
            self.BuildingLayer = (1 << LayerMask.NameToLayer(LayerEnum.Building.ToString()));
            self.MapLayer = (1 << LayerMask.NameToLayer(LayerEnum.Map.ToString()));

            self.ResetUI();
            self.AfterEnterScene();
        }
    }

    public static class UIJoystickMoveComponentSystem
    {
        public static void UpdateOperateMode(this UIJoystickMoveComponent self, int operateMode)
        {
            self.OperateMode = operateMode;

            // 0固定 1移动
            self.YaoGanDiFix.SetActive(operateMode == 0);
            self.YaoGanDiMove.SetActive(operateMode == 1);

            //self.YaoGanDiFix.transform.localPosition = new Vector3 (434, 376, 0 );

            self.CenterShow.transform.SetParent(operateMode == 0 ? self.YaoGanDiFix.transform : self.YaoGanDiMove.transform);
            self.Thumb.transform.transform.SetParent(operateMode == 0 ? self.YaoGanDiFix.transform : self.YaoGanDiMove.transform);

            self.CenterShow.SetActive(self.OperateMode == 0);
            self.Thumb.SetActive(self.OperateMode == 0);

            self.SetAlpha(0.3f);

            self.CenterShow.transform.localPosition = Vector3.zero;
            self.Thumb.transform.localPosition = Vector3.zero;
        }

        public static void SetAlpha(this UIJoystickMoveComponent self, float value)
        {
            Color color_1 = new Color(1f, 1f, 1f);
            color_1.a = value;
            self.CenterShowImage.color = color_1;
            self.ThumbImage.color = color_1;
        }

        public static void PointerDown_Move(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            RectTransform canvas = self.GetYaoGanDi().GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out self.OldPoint);
            self.SetAlpha(1f);
            if (self.OperateMode == 0)
            {
                self.YaoGanDiFix.SetActive(true);
                self.CenterShow.transform.localPosition = Vector3.zero;
                self.Thumb.transform.localPosition = Vector3.zero;
                self.OldPoint = Vector2.zero;
            }
            else
            {
                self.YaoGanDiFix.SetActive(true);
                self.CenterShow.SetActive(true);
                self.Thumb.SetActive(true);
                self.CenterShow.transform.localPosition = new Vector3(self.OldPoint.x, self.OldPoint.y, 0f);
                self.Thumb.transform.localPosition = new Vector3(self.OldPoint.x, self.OldPoint.y, 0f);
            }

            //MapHelper.LogMoveInfo($"移动摇杆按下: {TimeHelper.ServerNow()}");
        }

        /// <summary>
        /// 按下就移动
        /// </summary>
        /// <param name="self"></param>
        /// <param name="pdata"></param>
        public static void PointerDown_Fix(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            RectTransform canvas = self.GetYaoGanDi().GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out self.OldPoint);
            self.SetAlpha(1f);
            if (self.OperateMode == 0)
            {
                self.YaoGanDiFix.SetActive(true);
                self.CenterShow.transform.localPosition = Vector3.zero;
                self.Thumb.transform.localPosition = Vector3.zero;
                self.OldPoint = Vector2.zero;
            }
            else
            {
                self.YaoGanDiFix.SetActive(true);
                self.CenterShow.SetActive(true);
                self.Thumb.SetActive(true);
                self.CenterShow.transform.localPosition = new Vector3(self.OldPoint.x, self.OldPoint.y, 0f);
                self.Thumb.transform.localPosition = new Vector3(self.OldPoint.x, self.OldPoint.y, 0f);
            }

            //MapHelper.LogMoveInfo($"移动摇杆按下: {TimeHelper.ServerNow()}");
            TimerComponent.Instance.Remove(ref self.Timer);
            self.BeginDrag(pdata);
        }

        public static void BeginDrag(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            Unit unit = self.MainUnit;
            if (unit == null || unit.IsDisposed)
            {
                return;
            }

            //MapHelper.LogMoveInfo($"移动摇杆拖动: {TimeHelper.ServerNow()}");
            self.lastSendTime = 0;
            self.direction = self.GetDirection(pdata);
            self.MoveComponent.LastRecvTime = TimeHelper.ClientNow();
            int canmove = self.SendMove(self.direction);
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.JoystickTimer, self);

            if (!SettingHelper.ClintFindPath && canmove!=-1)
            {
                SkillManagerComponent skillManagerComponent = unit.GetComponent<SkillManagerComponent>();
                if (TimeHelper.ClientNow() < skillManagerComponent.SkillMoveTime)
                {
                    return;
                }
                if (skillManagerComponent.HaveSkillType(SkillHelp.Skill_Other_ChongJi_1))
                {
                    return;
                }
                //EventType.PlayAnimator.Instance.Unit = unit;
                //EventType.PlayAnimator.Instance.Animator = "Run";
                //Game.EventSystem.PublishClass(EventType.PlayAnimator.Instance);

                EventType.MoveStart.Instance.Unit = self.MainUnit;
                Game.EventSystem.PublishClass(EventType.MoveStart.Instance);
            }
        }

        public static GameObject GetYaoGanDi(this UIJoystickMoveComponent self)
        {
            return self.OperateMode == 0 ? self.YaoGanDiFix : self.YaoGanDiMove;
        }

        public static int GetDirection(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            RectTransform canvas = self.GetYaoGanDi().GetComponent<RectTransform>();
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, self.UICamera, out self.NewPoint);

            Vector3 vector3 = new Vector3(self.NewPoint.x, self.NewPoint.y, 0f);
            float maxDistance = Vector2.Distance(self.OldPoint, self.NewPoint);
            if (maxDistance < self.Distance)
            {
                self.Thumb.transform.localPosition = vector3;
            }
            else
            {
                self.NewPoint = self.OldPoint + (self.NewPoint - self.OldPoint).normalized * self.Distance;
                vector3.x = self.NewPoint.x;
                vector3.y = self.NewPoint.y;
                self.Thumb.transform.localPosition = vector3;
            }

            Vector2 indicator = self.NewPoint - self.OldPoint;
            int angle = 90 - (int)(Mathf.Atan2(indicator.y, indicator.x) * Mathf.Rad2Deg) + (int)self.MainCamera.transform.eulerAngles.y;
            //angle = (angle - angle % 2);
            return angle;
        }

        public static void Draging(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            self.direction = self.GetDirection(pdata);
        }

        public static void OnUpdate(this UIJoystickMoveComponent self)
        {
            self.SendMove(self.direction);
        }

        public static void OnMainHeroMove(this UIJoystickMoveComponent self)
        {
            Unit unit = self.MainUnit;
            Vector3 newv3 = unit.Position + unit.Rotation * Vector3.forward * 3f;
            int obstruct = self.CheckObstruct(unit, newv3);
            if (obstruct == 0)
            {
                return;
            }

            if (unit.GetComponent<MoveComponent>().IsArrived())
            {
                return;
            }

            self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
        }

        public static int SendMove(this UIJoystickMoveComponent self, int direction)
        {
            long clientNow = TimeHelper.ClientNow();

            if (SettingHelper.ClintFindPath && self.BattleMessageComponent.TransferMap)
            {
                return -1;
            }
            if (clientNow - self.lastSendTime < 30)
            {
                return -1;
            }

            Unit unit = self.MainUnit;
            Quaternion rotation = Quaternion.Euler(0, direction, 0);

            if (clientNow - self.AttackComponent.MoveAttackTime < 200)
            {
                return -1;
            }

            if (self.lastDirection == direction && clientNow - self.lastSendTime < self.checkTime)
            {
                return -1;
            }

            int errorCode = MoveHelper.IfCanMove(unit);
            if (errorCode == ErrorCode.ERR_CanNotMove_Rigidity)
            {
                SkillManagerComponent skillManager = unit.GetComponent<SkillManagerComponent>();
                if (skillManager.HaveSkillType(SkillHelp.Skill_XuanZhuan_Attack_2))
                {
                    self.checkTime = 100;
                    self.lastSendTime = clientNow;
                    self.lastDirection = direction;
                    NetHelper.RequestSkillXuanZhuan(self.ZoneScene(), direction).Coroutine();
                    return -1;
                }
            }

            if (errorCode != ErrorCode.ERR_Success)
            {
                HintHelp.GetInstance().ShowHintError(errorCode, self.ZoneScene());
                return -1;
            }

            if (self.SceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                //检测光墙
                int obstruct = self.CheckObstruct(unit, unit.Position + rotation * Vector3.forward * 2f);
                if (obstruct != 0)
                {
                    self.ShowObstructTip(obstruct);
                    if (SettingHelper.ClintFindPath)
                    {
                        EventType.MoveStart.Instance.Unit = unit;
                        Game.EventSystem.PublishClass(EventType.MoveStart.Instance);
                        unit.Rotation = Quaternion.Euler(0, self.direction, 0);
                        unit.StopResult();
                    }
                    else
                    {
                        unit.Stop();
                    }

                    return -1;
                }
            }

            Vector3 newv3;
            float distance;
            float speed = self.NumericComponent.GetAsFloat(NumericType.Now_Speed);
            speed = Mathf.Max(speed, 4f);
            if (SettingHelper.ClintFindPath)
            {
                List<Vector3> pathfind = new List<Vector3>();
                self.CanMovePositionList(unit, speed, rotation, pathfind);
                if (pathfind.Count < 2)
                {
                    EventType.MoveStart.Instance.Unit = unit;
                    Game.EventSystem.PublishClass(EventType.MoveStart.Instance);
                    unit.Rotation = Quaternion.Euler(0, self.direction, 0);
                    return -1;
                }

                newv3 = pathfind[pathfind.Count - 1];
                distance = Vector3.Distance(newv3, unit.Position);
                float needTime = distance / speed;
                self.checkTime = (long)(1000 * needTime);
                self.checkTime = Math.Min(200, self.checkTime);

                long passTime = clientNow - self.MoveComponent.LastRecvTime;

                float c2sdisc = self.MoveComponent.C2SDistance;
                if (c2sdisc > 3f || passTime > 300)
                {
                    speed *= 0.2f;
                    //Log.ILog.Debug($" self.MoveComponent.c2sdisc :  {c2sdisc}   passTime:{passTime}");
                }

                unit.MoveResultToAsync(pathfind, null).Coroutine();
                self.MoveComponent.MoveToAsync(pathfind, speed).Coroutine();
            }
            else
            {
                newv3 = self.CanMovePosition(unit, direction, rotation);
                int speedrate = 0;
                //int speedRate = 50;  //移动速度 10是原始速度1/10 100是原始速度
                if (newv3.Equals(unit.Position))
                {
                    Log.Debug($"不能移动，靠墙移动：{unit.Position}  {newv3}！");
                    newv3 = self.MoveSlowly(direction);
                    speedrate = 50;
                }
                else
                {
                    speedrate = 100; 
                    Log.Debug($"可以移动，目标位置：{unit.Position}  {newv3}！");
                }

                if (newv3.Equals(unit.Position))
                {
                    Log.Debug($"靠墙蹭动：也不能移动！");
                    return -2;
                }
                //distance = Mathf.Max(distance, 1f);
                distance = Vector3.Distance(unit.Position, newv3);
                if (self.noCheckTime < clientNow)
                {
                    float needtime = distance / speed;
                    self.checkTime = (int)(1000 * needtime) - 200;
                }
                else
                {
                    self.checkTime = 100;
                }

                //Log.Debug($"distance: {distance}   newv3:{newv3}");

                unit.MoveByYaoGan(newv3, direction, distance, null, speedrate).Coroutine();
            }

            self.lastSendTime = clientNow;
            self.lastDirection = direction;
            return 0;
        }

        public static void ShowObstructTip(this UIJoystickMoveComponent self, int monsterId)
        {
            if (Time.time - self.LastShowTip < 1f)
            {
                return;
            }

            self.LastShowTip = Time.time;
            string monsterName = MonsterConfigCategory.Instance.Get(monsterId).GetMonsterName();
            FloatTipManager.Instance.ShowFloatTip(string.Format(GameSettingLanguge.LoadLocalization("请先消灭{0}"), monsterName));
        }

        public static void CanMovePositionList(this UIJoystickMoveComponent self, Unit unit, float speed, Quaternion rotation, List<Vector3> pathfind)
        {
            unit.GetComponent<PathfindingComponent>().Find(unit.Position, unit.Position + rotation * Vector3.forward * speed * 0.5f, pathfind);
            //Vector3 targetPosi = unit.Position;
            //for (int i = 0; i < 30; i++)
            //{
            //    targetPosi = targetPosi + rotation * Vector3.forward * 0.2f;
            //    RaycastHit hit;

            //    Physics.Raycast(targetPosi + new Vector3(0f, 2f, 0f), Vector3.down, out hit, 20, self.BuildingLayer);
            //    if (hit.collider != null)
            //    {
            //        break;
            //    }

            //    Physics.Raycast(targetPosi + new Vector3(0f, 2f, 0f), Vector3.down, out hit, 20, self.MapLayer);
            //    if (hit.collider == null)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        if (Mathf.Abs(hit.point.y - targetPosi.y) > 0.4f)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            targetPosi = hit.point;
            //            pathfind.Add(targetPosi);
            //        }
            //    }
            //}

            //return targetPosi;
        }

        /// <summary>
        /// </summary>
        /// <param name="self"></param>
        /// <param name="unit"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public static Vector3 CanMovePosition(this UIJoystickMoveComponent self, Unit unit, int direction , Quaternion rotation)
        {
            float intveral = 0.2f; //每次寻的长度
            int distance = 0;
            int maxnumber = 20; //最多寻多少次

            Vector3 newv3 = unit.Position; // + rotation * Vector3.forward * (distance * intveral);

            for (int i = distance; i <= maxnumber; i++)
            {
                Vector3 target = unit.Position + rotation * Vector3.forward * i * intveral;
                RaycastHit hit;
                //Physics.Raycast(target + new Vector3(0f, 2f, 0f), Vector3.down, out hit, 100, self.ObstructLayer);
                //if (mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon && i <= 3 && hit.collider != null)
                //{
                //    return -1;
                //}

                Physics.Raycast(target + new Vector3(0f, 6f, 0f), Vector3.down, out hit, 100, self.ObstructLayer);
                if (hit.collider != null)
                {
                    //Log.ILog.Debug($" hit.collider != null: {hit.collider.name} ");
                    break;
                }

                Physics.Raycast(target + new Vector3(0f, 6f, 0f), Vector3.down, out hit, 100, self.BuildingLayer);
                if (hit.collider != null && !hit.collider.name.Contains("C_PlankPlanterLow_1x1m"))
                {
                    //Log.ILog.Debug($" hit.collider != null: {hit.collider.name} ");
                    break;
                }

                distance = i;
            }

            if (distance * intveral > 0.8f)
            {
                newv3 = unit.Position + rotation * Vector3.forward * (distance * intveral);
            }
            return newv3;
        }

        //靠墙慢慢往前蹭
        public static Vector3 MoveSlowly(this UIJoystickMoveComponent self, int direction)
        {
            Unit unit = self.MainUnit;
            Vector3 vector3result = unit.Position;
            unit.GetComponent<GameObjectComponent>().UpdateRotation(Quaternion.Euler(0, direction, 0));

            bool sendmove = false;
            for (int i = 0; i < 80; i++)    //左右80度范围寻找可以移动的点
            {
                Quaternion rotation_1 = Quaternion.Euler(0, direction + i, 0);
                Vector3 newv3_1 =  self.CanMovePosition(unit, direction, rotation_1);

                if (newv3_1.Equals(unit.Position))
                {
                    Quaternion rotation_2 = Quaternion.Euler(0, direction - i, 0);
                    newv3_1 =  self.CanMovePosition(unit, direction,    rotation_2);
                }

                if (!newv3_1.Equals(unit.Position))
                {
                    sendmove = true;
                    vector3result = newv3_1;
                    Log.Debug($"靠墙移动 移动位置：{i} {vector3result}");
                    //unit.MoveResultToAsync(pathfind, null, speedRate).Coroutine();
                    // unit.GetComponent<MoveComponent>().MoveToAsync(pathfind, speed).Coroutine();
                    break;
                }
            }

            if (!sendmove)
            {
                //doto
            }

            return vector3result;
        }


        public static int CheckObstruct(this UIJoystickMoveComponent self, Unit unit, Vector3 target)
        {
            RaycastHit hit;
            Physics.Raycast(target + new Vector3(0f, 10f, 0f), Vector3.down, out hit, 100, self.ObstructLayer);
            if (hit.collider == null)
            {
                return 0;
            }

            int monsterid = int.Parse(hit.collider.gameObject.name);
            List<Unit> units = UnitHelper.GetUnitList(unit.DomainScene(), UnitType.Monster);
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].ConfigId == monsterid)
                {
                    return monsterid;
                }
            }

            return 0;
        }

        public static Vector3 GetCanReachPath(this UIJoystickMoveComponent self, Vector3 start, Vector3 target)
        {
            Vector3 dir = (target - start).normalized;

            while (true)
            {
                RaycastHit hit;
                int mapMask = (1 << LayerMask.NameToLayer(LayerEnum.Map.ToString()));
                Physics.Raycast(start + new Vector3(0f, 10f, 0f), Vector3.down, out hit, 100, mapMask);

                if (hit.collider == null)
                {
                    break;
                }

                if (Vector3.Distance(start, target) < 0.2f)
                {
                    break;
                }

                start = start + (0.2f * dir);
            }

            return start;
        }

        public static void ResetUI(this UIJoystickMoveComponent self)
        {
            self.SetAlpha(0.3f);
            if (self.OperateMode == 0)
            {
                self.CenterShow.transform.localPosition = Vector3.zero;
                self.Thumb.transform.localPosition = Vector3.zero;
            }
            else
            {
                self.CenterShow.SetActive(false);
                self.Thumb.SetActive(false);
                self.YaoGanDiFix.SetActive(false);
            }
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void ShowUI(this UIJoystickMoveComponent self)
        {

        }

        public static void AfterEnterScene(this UIJoystickMoveComponent self)
        {
            self.MainUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.NumericComponent = self.MainUnit.GetComponent<NumericComponent>();
            self.MoveComponent = self.MainUnit.GetComponent<MoveComponent>();
            self.SceneTypeEnum = self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum;
            self.BattleMessageComponent.TransferMap = false;
        }

        public static void EndDrag(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            Unit unit = self.MainUnit;
            if (unit == null || unit.IsDisposed)
            {
                return;
            }

            if (SettingHelper.ClintFindPath)
            {
                EventType.MoveStop.Instance.Unit = unit;
                Game.EventSystem.PublishClass(EventType.MoveStop.Instance);
            }

            long lastTimer = self.Timer;
            self.ResetUI();
            if (lastTimer == 0)
            {
                return;
            }

            if (ErrorCode.ERR_Success != unit.GetComponent<StateComponent>().CanMove())
            {
                return;
            }

            //MapHelper.LogMoveInfo($"移动摇杆停止: {TimeHelper.ServerNow()}");
            if (SettingHelper.ClintFindPath)
            {
                if (self.BattleMessageComponent.TransferMap)
                {
                    return;
                }

                unit.StopResult();
            }
            else
            {
                unit.Stop();
            }
        }
    }
}