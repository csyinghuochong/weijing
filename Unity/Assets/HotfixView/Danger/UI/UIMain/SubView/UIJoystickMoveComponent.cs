using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
        public GameObject YaoGanDiMove;
        public GameObject YaoGanDiFix;

        public Vector2 OldPoint;
        public Vector2 NewPoint;
        public float Distance = 110;
        public float lastSendTime;
        public float checkTime;

        public int direction;
        public int lastDirection;

        public Camera UICamera;
        public Camera MainCamera;
        public float LastShowTip;

        public Unit MainUnit;
        public NumericComponent NumericComponent;
        public AttackComponent AttackComponent;
       
        public GameObject GameObject;

        public int ObstructLayer;
        public int BuildingLayer;
        public long Timer;

        public int OperateMode;

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

            ButtonHelp.AddEventTriggers(self.YaoGanDiMove, (PointerEventData pdata) => { self.PointerDown(pdata); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.YaoGanDiMove, (PointerEventData pdata) => { self.BeginDrag(pdata); }, EventTriggerType.BeginDrag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiMove, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiMove, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.EndDrag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiMove, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.YaoGanDiFix, (PointerEventData pdata) => { self.PointerDown(pdata); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.YaoGanDiFix, (PointerEventData pdata) => { self.BeginDrag(pdata); }, EventTriggerType.BeginDrag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiFix, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiFix, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.EndDrag);
            ButtonHelp.AddEventTriggers(self.YaoGanDiFix, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.PointerUp);


            self.UICamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            self.MainCamera = self.DomainScene().GetComponent<UIComponent>().MainCamera;
            self.AttackComponent = self.ZoneScene().GetComponent<AttackComponent>();

            self.ObstructLayer = (1 << LayerMask.NameToLayer(LayerEnum.Obstruct.ToString()));
            self.BuildingLayer = (1 << LayerMask.NameToLayer(LayerEnum.Building.ToString()));

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
            self.YaoGanDiFix.SetActive( operateMode == 0 );
            self.YaoGanDiMove.SetActive(operateMode == 1 );

            //self.CenterShow.SetActive(self.OperateMode == 0);
            //self.Thumb.SetActive(self.OperateMode == 0);

            self.CenterShow.transform.localPosition = Vector3.zero;
            self.Thumb.transform.localPosition = Vector3.zero;
        }

        public static void PointerDown(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            RectTransform canvas = self.GetYaoGanDi().transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out self.OldPoint);

            self.YaoGanDiFix.SetActive(true);
            if (self.OperateMode == 0)
            {
                self.CenterShow.transform.localPosition = Vector3.zero;
                self.Thumb.transform.localPosition = Vector3.zero;
                self.OldPoint = Vector2.zero;
            }
            else
            {
                self.CenterShow.transform.localPosition = new Vector3(self.OldPoint.x, self.OldPoint.y, 0f);
                self.Thumb.transform.localPosition = new Vector3(self.OldPoint.x, self.OldPoint.y, 0f);
            }
        }

        public static void BeginDrag(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            Unit unit = self.MainUnit;
            if (unit == null || unit.IsDisposed)
            {
                return;
            }
            self.lastSendTime = 0f;
            self.SendMove(self.GetDirection(pdata));
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.JoystickTimer, self);
        }

        public static GameObject GetYaoGanDi(this UIJoystickMoveComponent self)
        {
            return self.OperateMode == 0 ? self.YaoGanDiFix : self.YaoGanDiMove;
        }

        public static int GetDirection(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            RectTransform canvas = self.GetYaoGanDi().transform.parent.GetComponent<RectTransform>();
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

        public static void SendMove(this UIJoystickMoveComponent self, int direction)
        {
            if (Time.time - self.lastSendTime < 0.1f)
            {
                return;
            }
            if (TimeHelper.ClientNow() - self.AttackComponent.MoveAttackTime < 200)
            {
                return;
            }
            if (self.lastDirection == direction && Time.time - self.lastSendTime < self.checkTime)
            {
                return;
            }

            Unit unit = self.MainUnit;
            Quaternion rotation = Quaternion.Euler(0, direction, 0);

            float distance = self.CanMoveDistance(unit, rotation);
            distance = Mathf.Max(distance, 2f);
            float speed = self.NumericComponent.GetAsFloat(NumericType.Now_Speed);
            speed = Mathf.Max(speed, 4f);
            Vector3 newv3 = unit.Position + rotation * Vector3.forward * distance;
            self.checkTime = 0.2f; /// distance / speed - 0.4f;

            //self.checkTime = 0.2f; //// distance / speed - 0.2f;
            //self.checkTime = distance / speed - 0.2f;

            //检测光墙
            int obstruct = self.CheckObstruct(unit, unit.Position + rotation * Vector3.forward * 2f);
            if (obstruct!= 0)
            {
                unit.GetComponent<StateComponent>().ObstructStatus = 1;
                self.ShowObstructTip(obstruct);
                return;
            }
            EventType.DataUpdate.Instance.DataType = DataType.BeforeMove;
            Game.EventSystem.PublishClass(EventType.DataUpdate.Instance);
            unit.MoveByYaoGan(newv3,direction, distance, null).Coroutine();
            self.lastSendTime = Time.time;
            self.lastDirection = direction;
        }

        public static void ShowObstructTip(this UIJoystickMoveComponent self, int monsterId)
        {
            if (Time.time - self.LastShowTip < 1f)
            {
                return;
            }
            self.LastShowTip = Time.time;
            string monsterName = MonsterConfigCategory.Instance.Get(monsterId).MonsterName;
            FloatTipManager.Instance.ShowFloatTip($"请先消灭{monsterName}");
        }


        /// <summary>
        /// </summary>
        /// <param name="self"></param>
        /// <param name="unit"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public static float CanMoveDistance(this UIJoystickMoveComponent self, Unit unit, Quaternion rotation)
        {
            float intveral = 1f;   //每次寻的长度
            int distance = 2;
            int maxnumber = 5;     //最多寻多少次
            for (int i = distance; i <= maxnumber; i++)
            {
                Vector3 target = unit.Position + rotation * Vector3.forward * i * intveral;
                RaycastHit hit;
                //Physics.Raycast(target + new Vector3(0f, 10f, 0f), Vector3.down, out hit, 100, self.ObstructLayer);
                //if (mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon && i <= 3 && hit.collider != null)
                //{
                //    return -1;
                //}
                distance = i;
                Physics.Raycast(target + new Vector3(0f, 10f, 0f), Vector3.down, out hit, 100, self.BuildingLayer);
                if (hit.collider != null)
                {
                    Log.Debug($" hit.collider != null: i : {i}   x: {target.x}  z:{target.z} ");
                    break;
                }
            }

            return distance * intveral;
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
                Physics.Raycast(start + new Vector3(0f,10f,0f), Vector3.down, out hit, 100, mapMask);

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
            if (self.OperateMode == 0)
            {
                self.CenterShow.transform.localPosition = Vector3.zero; 
                self.Thumb.transform.localPosition = Vector3.zero;
            }
            else
            {
                //self.CenterShow.SetActive(false);
                //self.Thumb.SetActive(false);
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
        }

        public static void EndDrag(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            if (!self.CenterShow.activeSelf)
            {
                return;
            }

            self.ResetUI();
            Unit unit = self.MainUnit;  
            if (unit == null || unit.IsDisposed)
            {
                return;
            }
            if (ErrorCore.ERR_Success != unit.GetComponent<StateComponent>().CanMove())
            {
                return;
            }
            if (unit.GetComponent<MoveComponent>().IsArrived())
            {
                return;
            }
            self.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
        }
    }
}
