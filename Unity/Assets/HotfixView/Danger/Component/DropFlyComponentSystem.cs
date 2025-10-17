using UnityEngine;

namespace ET
{

    public class DropFlyComponentAwake : AwakeSystem<DropFlyComponent>
    {
        public override void Awake(DropFlyComponent self)
        {
            self.MyUnit = self.GetParent<Unit>();
            self.TargetUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.EffectPath = ABPathHelper.GetEffetPath("ScenceEffect/SceneEffect_DropFly");
        }
    }

    public class DropFlyComponentUpdate : UpdateSystem<DropFlyComponent>
    {
        public override void Update(DropFlyComponent self)
        {
            self.Update();
        }
    }

    public class DropFlyComponentDestroy : DestroySystem<DropFlyComponent>
    {
        public override void Destroy(DropFlyComponent self)
        {
            self.RecoveryGameObject(self.EffectGameObject);
        }
    }

    public static partial class DropFlyComponentSystem
    {
        public static void Update(this DropFlyComponent self)
        {
            if (self.Send)
            {
                return;
            }

            if (self.MyUnit == null || self.MyUnit.IsDisposed)
            {
                return;
            }

            if (self.TargetUnit == null || self.TargetUnit.IsDisposed)
            {
                self.Dispose();
                return;
            }

            if (!self.IsPlayEffect)
            {
                self.IsPlayEffect = true;
                GameObjectPoolComponent.Instance.AddLoadQueue(self.EffectPath, self.InstanceId, self.OnLoadGameObject);
            }

            if (!self.Send && Vector3.Distance(self.MyUnit.Position, self.TargetUnit.Position) < self.Distance)
            {
                self.Send = true;

                // 只要靠近了就销毁拾取特效 不等消息返回
                self.MyUnit.GetParent<UnitComponent>().Remove(self.MyUnit.Id);

                //self.ZoneScene().GetComponent<PickItemsComponent>().SendPick(self.MyUnit);
                //self.Dispose();
                return;
            }

            if (self.StartPosition == Vector3.zero)
            {
                self.StartPosition = self.MyUnit.Position;
            }

            self.MyUnit.Position = Vector3.MoveTowards(self.MyUnit.Position, self.TargetUnit.Position, self.Speed * Time.deltaTime);
            if (self.EffectGameObject != null)
            {
                Vector3 direction = self.TargetUnit.Position - self.MyUnit.Position;
                if (direction == Vector3.zero)
                {
                    return;
                }

                self.EffectGameObject.transform.rotation = Quaternion.LookRotation(direction, Vector3.forward);
            }
        }


        private static void OnLoadGameObject(this DropFlyComponent self, GameObject gameObject, long formId)
        {
            if (self.IsDisposed || formId != self.InstanceId || self.MyUnit.IsDisposed || self.TargetUnit.IsDisposed)
            {
                UnityEngine.Object.Destroy(gameObject);
                return;
            }

            gameObject.SetActive(true);
            self.EffectGameObject = gameObject;
            self.EffectGameObject.transform.SetParent(self.MyUnit.GetComponent<GameObjectComponent>().GameObject.transform);
            self.EffectGameObject.transform.localPosition = Vector3.zero;
            self.EffectGameObject.transform.localScale = Vector3.one;
            self.EffectGameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        public static void RecoveryGameObject(this DropFlyComponent self, GameObject gameObject)
        {
            if (gameObject == null)
            {
                return;
            }

            GameObjectPoolComponent.Instance.RecoverGameObject(self.EffectPath, gameObject, false);
        }
    }
}