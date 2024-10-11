using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public enum FallingFontType
    {
        Normal = 0,
        Self = 1,
        Target = 2,
        Add = 3,
        Special = 4
    }
    
    public class FallingFontShowComponent : Entity, IAwake, IDestroy
    {
        public Unit Unit;
        public string ShowText;
        public FallingFontType FontType;
        public Vector3 StartScale;
        
        public Transform Transform;
        public GameObject GameObject;
        public GameObject ObjFlyText;
        public float DamgeFlyTimeSum = 0;
        public GameObject HeadBar;
    }

    public class FallingFontShowComponentAwakeSystem : AwakeSystem<FallingFontShowComponent>
    {
        public override void Awake(FallingFontShowComponent self)
        {
            self.Transform = null;
            self.GameObject = null;
            self.DamgeFlyTimeSum = 0;
        }
    }

    public class FallingFontShowComponentDestroySystem : DestroySystem<FallingFontShowComponent>
    {
        public override void Destroy(FallingFontShowComponent self)
        {
            self.RecoveryGameObject(self.GameObject);
        }
    }

    public static class FallingFontShowComponentSystem
    {
        public static void RecoveryGameObject(this FallingFontShowComponent self, GameObject FlyFontObj)
        {
            if (FlyFontObj == null)
            {
                return;
            }
            
            if (self.ObjFlyText!=null)
            {
                self.ObjFlyText.transform.localPosition = new Vector3(-5000f, 0f, 0f);
            }
            string uIBattleFly =  StringBuilderHelper.UIBattleFly;
            GameObjectPoolComponent.Instance.RecoverGameObject(uIBattleFly, FlyFontObj, true);
            FlyFontObj.transform.localPosition = new Vector2(-2000f,-2000f);               
        }

        public static void OnLoadGameObject(this FallingFontShowComponent self, GameObject FlyFontObj, long formId)
        {
            if (self.IsDisposed || formId != self.InstanceId || self.Unit.IsDisposed)
            {
                self.RecoveryGameObject(FlyFontObj);
                return;
            }

            self.GameObject = FlyFontObj;
            self.Transform = FlyFontObj.transform;
            ReferenceCollector rc = FlyFontObj.GetComponent<ReferenceCollector>();
            GameObject ObjFlyText = self.FontType switch
            {
                FallingFontType.Normal => rc.Get<GameObject>("FlyText"),
                FallingFontType.Self => rc.Get<GameObject>("FlyText_Self"),
                FallingFontType.Target => rc.Get<GameObject>("FlyText_Target"),
                FallingFontType.Add => rc.Get<GameObject>("FlyText_Add"),
                FallingFontType.Special => rc.Get<GameObject>("FlyText_Special"),
                _ => null
            };

            ObjFlyText.GetComponent<Text>().text = self.ShowText;
            
            //初始化,因为是对象池所有之前可能有不同大小的缓存
            ObjFlyText.GetComponent<Text>().transform.localScale = self.StartScale;

            ObjFlyText.SetActive(true);
            self.ObjFlyText = ObjFlyText;
            ObjFlyText.transform.localPosition = Vector3.zero;
            ObjFlyText.transform.localPosition = new Vector3(Random.value * 150f - 50f, 0f, 0);
            FlyFontObj.transform.SetParent(UIEventComponent.Instance.BloodText.transform);
            FlyFontObj.transform.localScale = Vector3.one;
            FlyFontObj.transform.localPosition = self.HeadBar.transform.localPosition + new Vector3(0f, 80f, 0);
        }

        public static void OnInitData(this FallingFontShowComponent self, GameObject HeadBar, Unit unit, string showText, FallingFontType fontType,
        Vector3 startScale)
        {
            self.HeadBar = HeadBar;
            self.Unit = unit;
            self.ShowText = showText;
            self.FontType = fontType;
            self.StartScale = startScale;
            string uIBattleFly = StringBuilderHelper.UIBattleFly;
            GameObjectPoolComponent.Instance.AddLoadQueue(uIBattleFly, self.InstanceId, self.OnLoadGameObject);
        }


        public static bool LateUpdate(this FallingFontShowComponent self)
        {
            self.DamgeFlyTimeSum = self.DamgeFlyTimeSum + Time.deltaTime;
            if (self.Transform != null && self.HeadBar!= null)
            {
                if (self.DamgeFlyTimeSum < 0.15f)   
                {
                    self.Transform.localScale = self.DamgeFlyTimeSum < 0.03f ? new Vector3(0.8f, 0.8f, 0.8f) : new Vector3(1.5f, 1.5f, 1.5f);
                }
                else
                {
                    self.Transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
                }

                self.Transform.localPosition = self.HeadBar.transform.localPosition +  new Vector3(0, 80f +  self.DamgeFlyTimeSum * 10f, 0);
            }

            return self.DamgeFlyTimeSum >= 0.5f || !self.HeadBar.activeSelf;
        }
    }
}