using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{
    public class UIJoystickComponent : Entity, IAwake
    {
        public GameObject Thumb;
        public bool draging;
        public int direction;
        public float lastSendTime;
    }

    [ObjectSystem]
    public class UIJoystickComponentAwakeSystem : AwakeSystem<UIJoystickComponent>
    {
        public override void Awake(UIJoystickComponent self)
        {
            self.Awake();
        }
    }

    public static class UIJoystickComponentSystem
    {

        public static void Awake(this UIJoystickComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            ScrollCircle scrollCircle = self.GetParent<UI>().GameObject.GetComponent<ScrollCircle>();
            scrollCircle.BeginDragAction = ()=>{ self.OnBegingDrag(); };
            scrollCircle.EndDragAction = () => { self.OnEndDrag(); };
            scrollCircle.DragingAction = (PointerEventData eventData) => { self.OnDraging(eventData); };
            self.draging = false;
            self.Thumb = rc.Get<GameObject>("Thumb");
        }

        public static void OnUpdate(this UIJoystickComponent self)
        {
            if (!self.draging)
            {
                return;
            }
            if (Time.time - self.lastSendTime < 0.1f)
            {
                return;
            }
            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            Quaternion rotation = Quaternion.Euler(0, self.direction, 0); //按照Z轴旋转30度的Quaterion
            Vector3 newv3 = myUnit.Position + rotation * Vector3.forward * 2f;

            myUnit.MoveToAsync2(newv3, true).Coroutine();
            self.lastSendTime = Time.time;
        }

        public static void OnBegingDrag(this UIJoystickComponent self)
        {
            self.draging = true;
        }

        public static void OnEndDrag(this UIJoystickComponent self)
        {
            self.draging = false;
            self.DomainScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
        }

        public static void OnDraging(this UIJoystickComponent self, PointerEventData eventData)
        {
            Vector2 indicator = self.Thumb.transform.localPosition;
            int angle = 90 - (int)(Mathf.Atan2(indicator.y, indicator.x) * Mathf.Rad2Deg);
            self.direction = angle;
        }

    }

}
