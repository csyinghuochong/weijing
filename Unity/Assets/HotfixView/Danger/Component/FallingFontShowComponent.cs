using ET;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class FallingFontShowComponent : Entity, IAwake, IDestroy
    {
        public Transform Transform;
        public GameObject GameObject;
        public GameObject ObjFlyText;
        public float DamgeFlyTimeSum = 0;
        public float TargetValue;
        public int FontType;
        public Unit Unit;
    }

    [ObjectSystem]
    public class FallingFontShowComponentAwakeSystem : AwakeSystem<FallingFontShowComponent>
    {
        public override void Awake(FallingFontShowComponent self)
        {
            self.Transform = null;
            self.GameObject = null;
            self.DamgeFlyTimeSum = 0;
        }
    }

    [ObjectSystem]
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
 
            ReferenceCollector rc = FlyFontObj.GetComponent<ReferenceCollector>();
            rc.Get<GameObject>("FlyText_Self").SetActive(false);
            rc.Get<GameObject>("FlyText_Add").SetActive(false);
            rc.Get<GameObject>("FlyText_Target").SetActive(false);
            string uIBattleFly = ABPathHelper.GetUGUIPath("Battle/UIBattleFly");
            GameObjectPoolComponent.Instance.RecoverGameObject(uIBattleFly, FlyFontObj, true);
            FlyFontObj.transform.localPosition = new Vector2(0f,2000f);               
        }

        public static void OnLoadGameObject(this FallingFontShowComponent self, GameObject FlyFontObj, long formId)
        {
            Unit unit = self.Unit;
            if (self.IsDisposed || formId != self.InstanceId || unit.IsDisposed)
            {
                self.RecoveryGameObject(FlyFontObj);
                return;    
            }
            int type = self.FontType;
            float targetValue = self.TargetValue;
            self.GameObject = FlyFontObj;
            self.Transform = FlyFontObj.transform;
            ReferenceCollector rc = FlyFontObj.GetComponent<ReferenceCollector>();
            GameObject ObjFlyText = rc.Get<GameObject>("FlyText_Target");
            //根据目标Unit设定飘字字体
            string selfNull = "";
            if (unit.MainHero)
            {
                //设置字体
                ObjFlyText = rc.Get<GameObject>("FlyText_Self");
                selfNull = " ";
            }
            //恢复血量
            if (type == 2 || targetValue > 0)
            {
                //设置字体
                ObjFlyText = rc.Get<GameObject>("FlyText_Add");
            }
            //设置值
            ObjFlyText.SetActive(true);

            string addStr = "";
            if (targetValue >= 0 && type == 2)
            {
                addStr = "+";
            }

            if (type == 1)
            {
                //addStr = "AJ";  //暴击
                addStr = "暴击";  //暴击
            }
            if (type != 2 && targetValue == 0)
            {
                //addStr = "SB";  //闪避
                addStr = "闪避";  //闪避
                ObjFlyText.GetComponent<Text>().text = addStr;
            }
            else
            {
                ObjFlyText.GetComponent<Text>().text = addStr + selfNull + targetValue.ToString();
            }
            self.ObjFlyText = ObjFlyText;
            FlyFontObj.transform.SetParent(unit.GetComponent<HeroHeadBarComponent>().HeadBar.transform);
            FlyFontObj.transform.localScale = Vector3.one;
            FlyFontObj.transform.localPosition = new Vector3(0, 30, 0);
        }

        public static void  OnInitData(this FallingFontShowComponent self, float targetValue, Unit unit, int type)
        {
            self.Unit = unit;
            self.FontType = type;
            self.TargetValue = targetValue;
            string uIBattleFly = ABPathHelper.GetUGUIPath("Battle/UIBattleFly");
            GameObjectPoolComponent.Instance.AddLoadQueue(uIBattleFly, self.InstanceId, self.OnLoadGameObject);
        }

        public static bool LateUpdate(this FallingFontShowComponent self)
        {
            self.DamgeFlyTimeSum = self.DamgeFlyTimeSum + Time.deltaTime;
            if (self.Transform != null)
            {
                if (self.DamgeFlyTimeSum < 0.15f)
                {
                    self.Transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                    if (self.DamgeFlyTimeSum < 0.03f)
                    {
                        self.Transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
                    }
                }
                else
                {
                    self.Transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
                }

                self.Transform.localPosition = new Vector3(self.Transform.localPosition.x, self.Transform.localPosition.y + 2f, self.Transform.localPosition.z);
            }

            return self.DamgeFlyTimeSum >= 0.3f;
        }
    }
}