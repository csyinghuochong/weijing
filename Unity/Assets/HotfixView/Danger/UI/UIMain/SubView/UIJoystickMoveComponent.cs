using System;
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

    public class UIJoystickMoveComponent : Entity, IAwake, IDestroy
    {
        public GameObject CenterShow;
        public GameObject YaoGanDi;
        public GameObject Thumb;

        public Vector2 OldPoint;
        public Vector2 NewPoint;
        public float Distance = 110;
        public float lastSendTime;

        public int direction;
        public int lastDirection;

        public Camera UICamera;
        public Camera MainCamera;
        public float LastShowTip;

        public long Timer;

        public Unit MainUnit;
        public NumericComponent NumericComponent;
        public AttackComponent AttackComponent;
    }

    [ObjectSystem]
    public class UIJoystickMoveComponentDestroy : DestroySystem<UIJoystickMoveComponent>
    {
        public override void Destroy(UIJoystickMoveComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [ObjectSystem]
    public class UIJoystickMoveComponentAwake : AwakeSystem<UIJoystickMoveComponent>
    {
        public override void Awake(UIJoystickMoveComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.direction = 0;
            self.lastDirection = 0;
            self.CenterShow = rc.Get<GameObject>("CenterShow");
            self.YaoGanDi = rc.Get<GameObject>("YaoGanDi");
            self.Thumb = rc.Get<GameObject>("Thumb");

            ButtonHelp.AddEventTriggers(self.YaoGanDi, (PointerEventData pdata) => { self.PointerDown(pdata); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.YaoGanDi, (PointerEventData pdata) => { self.BeginDrag(pdata); }, EventTriggerType.BeginDrag);
            ButtonHelp.AddEventTriggers(self.YaoGanDi, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.YaoGanDi, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.EndDrag);
            ButtonHelp.AddEventTriggers(self.YaoGanDi, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.PointerUp);

            self.UICamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            self.MainCamera = self.DomainScene().GetComponent<UIComponent>().MainCamera;
            self.AttackComponent = self.ZoneScene().GetComponent<AttackComponent>();

            self.CenterShow.SetActive(false);
            self.Thumb.SetActive(false);
            self.AfterEnterScene();
        }
    }

    public static class UIJoystickMoveComponentSystem
    {
        public static void PointerDown(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            RectTransform canvas = self.YaoGanDi.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out self.OldPoint);

            self.CenterShow.SetActive(true);
            self.Thumb.SetActive(true);
            self.CenterShow.transform.localPosition = new Vector3(self.OldPoint.x, self.OldPoint.y, 0f);
            self.Thumb.transform.localPosition = new Vector3(self.OldPoint.x, self.OldPoint.y, 0f);
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

        public static int GetDirection(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
            RectTransform canvas = self.YaoGanDi.transform.parent.GetComponent<RectTransform>();
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
            int obstruct = self.CheckObstruct(newv3);
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
            if (self.lastDirection == direction && Time.time - self.lastSendTime < 0.2f)
            {
                return;
            }
            //if (TimeHelper.ClientNow() - self.AttackComponent.MoveAttackTime < 200)
            //{
            //    return;
            //}

            Unit unit = self.MainUnit;
            float speed = self.NumericComponent.GetAsFloat(NumericType.Now_Speed);
            speed = Mathf.Max(speed, 4f);
            Quaternion rotation = Quaternion.Euler(0, direction, 0);
            Vector3 newv3 = unit.Position + rotation * Vector3.forward * 2f * (speed / 4f);
            int obstruct = self.CheckObstruct(newv3);
            if (obstruct!= 0)
            {
                unit.GetComponent<StateComponent>().ObstructStatus = 1;
                self.ShowObstructTip(obstruct);
                return;
            }
            EventType.BeforeMove.Instance.ZoneScene = unit.ZoneScene();
            Game.EventSystem.PublishClass(EventType.BeforeMove.Instance);
            unit.MoveToAsync2(newv3, true).Coroutine();
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

        public static int CheckObstruct(this UIJoystickMoveComponent self,  Vector3 target)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.TeamDungeon)
            {
                return 0;
            }
            RaycastHit hit;
            int mapMask = (1 << LayerMask.NameToLayer(LayerEnum.Obstruct.ToString()));
            Physics.Raycast(target + new Vector3(0f, 10f, 0f), Vector3.down, out hit, 100, mapMask);
            if (hit.collider == null)
            {
                return 0;
            }
            return int.Parse(hit.collider.gameObject.name);
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
            self.CenterShow.SetActive(false);
            self.Thumb.SetActive(false);
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void AfterEnterScene(this UIJoystickMoveComponent self)
        {
            self.MainUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.NumericComponent = self.MainUnit.GetComponent<NumericComponent>();
        }

        public static void EndDrag(this UIJoystickMoveComponent self, PointerEventData pdata)
        {
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
