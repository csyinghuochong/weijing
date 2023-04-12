using UnityEngine;

namespace ET
{

    public class UIRotateComponent : Entity, IAwake, IUpdate
    {
        public bool Start;
        public int Speed = 90;
        public float PassTime;
        public GameObject GameObject;
    }


    public class UIRotateComponentAwakeSystem : AwakeSystem<UIRotateComponent>
    {
        public override void Awake(UIRotateComponent self)
        {
            self.Start = false;
            self.PassTime = 0;
            self.GameObject = self.GetParent<UI>().GameObject;
        }
    }


    public class UIRotateComponentUpdateSystem : UpdateSystem<UIRotateComponent>
    {
        public override void Update(UIRotateComponent self)
        {
            if (!self.Start)
            {
                return;
            }
            self.PassTime += Time.deltaTime;
            self.GameObject.transform.localRotation = Quaternion.Euler(0f, 0f, self.PassTime * self.Speed);
        }
    }

    public static class UIRotateComponentSystem
    {
        public static void StartRotate(this UIRotateComponent self, bool start)
        {
            self.Start = start;
        }
    }
}
