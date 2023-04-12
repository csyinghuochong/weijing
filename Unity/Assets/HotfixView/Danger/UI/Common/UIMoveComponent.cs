using UnityEngine;

namespace ET
{

    public class UIMoveComponent : Entity, IAwake, IUpdate
    {
        public GameObject GameObject;

        public Vector3 startVec;
        public Vector3 endVec;
        public float moveTime;
        public float passTime;
        public bool enterMove;
    }


    public class UIMoveComponentAwakeSystem : AwakeSystem<UIMoveComponent>
    {
        public override void Awake(UIMoveComponent self)
        {
            self.GameObject = self.GetParent<UI>().GameObject;
        }
    }


    public class UIMoveComponentUpdateSystem : UpdateSystem<UIMoveComponent>
    {
        public override void Update(UIMoveComponent self)
        {
            if (!self.enterMove)
                return;

            self.passTime += Time.deltaTime;
            Vector3 vector3 = self.startVec + (self.endVec - self.startVec) * ( self.passTime / self.moveTime );
            self.GameObject.transform.localPosition = vector3;

            if (self.passTime >= self.moveTime)
            {
                self.enterMove = false;
                self.GameObject.transform.localPosition = self.endVec;
            }
        }
    }

    public static class UIMoveComponentSystem
    {

        public static void SetMovePosition(this UIMoveComponent self, Vector3 v1, Vector3 v2, float moveTime)
        {
            self.startVec = v1;
            self.endVec = v2;

            self.passTime = 0;
            self.moveTime = moveTime;
            self.enterMove = true;
            self.GameObject.transform.localPosition = v1;
        }

    }
}
