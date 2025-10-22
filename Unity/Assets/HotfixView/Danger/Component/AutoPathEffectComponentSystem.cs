using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class AutoPathEffectComponentAwake : AwakeSystem<AutoPathEffectComponent>
    {
        public override void Awake(AutoPathEffectComponent self)
        {
            self.EffectPath = ABPathHelper.GetEffetPath("ScenceEffect/Eff_AutoPath");
            self.IfAutoPath = false;
        }
    }


    public class AutoPathEffectComponentDestroy : DestroySystem<AutoPathEffectComponent>
    {
        public override void Destroy(AutoPathEffectComponent self)
        {
            if(self.pathPoint!=null)
            {
                GameObject.DestroyImmediate(self.pathPoint);
            }
            foreach(GameObject go in self.PathPointList)
            {
                GameObject.DestroyImmediate(go);
            }

            self.pathPoint = null;
            self.PathPointList = null;
        }
    }

    public static class AutoPathEffectComponentSystem
    {

        public static void OnEnterScene(this AutoPathEffectComponent self, GameObject uimain)
        {
            self.MoveComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<MoveComponent>();

            if (self.pathPoint == null)
            {
                GameObjectPoolComponent.Instance.AddLoadQueue(self.EffectPath, self.InstanceId, self.OnLoadGameObject);
            }
            self.UIAutoPath = uimain.transform.Find("UIAutoPath").gameObject;
            self.TextDistance = uimain.transform.Find("UIAutoPath/TextDistance").GetComponent<Text>();
            self.UIAutoPath.SetActive(false);
        }

        public static GameObject GetPathPointObj(this AutoPathEffectComponent self, int index)
        {
            if (self.PathPointList.Count > index)
            {
                return self.PathPointList[index];
            }
            GameObject go = UnityEngine.Object.Instantiate(self.pathPoint, self.pathPoint.transform.parent, true);
            go.SetActive(true);
            go.transform.localScale = Vector3.one;
            self.PathPointList.Add(go);
            return go;
        }

        /// <summary>
        /// BeforeMove,  有些移动没有派发这个事件
        /// </summary>
        /// <param name="self"></param>
        public static void OnMoveStart(this AutoPathEffectComponent self, string dataParams)
        {
            if (dataParams == "1")
            {
                self.IfAutoPath = true;
                self.UIAutoPath.SetActive(true);
            }
            else
            {
                self.HideEffect();
            }
        }

        private static void HideEffect(this AutoPathEffectComponent self)
        {
            self.IfAutoPath = false;
            self.TextDistance.text = string.Empty;

            self.UIAutoPath.SetActive(false);
            for (int i = 0; i < self.PathPointList.Count; i++)
            {
                self.PathPointList[i].transform.localPosition = self.InvisiblePosition;
            }
        }

        public static void OnMoveStop(this AutoPathEffectComponent self)
        {
            self.HideEffect();
        }

        public static void UpdatePathPoint(this AutoPathEffectComponent self)
        {
            //if (!self.MoveComponent.WaitMode)
            if (!self.IfAutoPath)
            {
                //self.HideEffect();
                return;
            }
           
            int N = self.MoveComponent.N;
            List<Vector3> target = self.MoveComponent.Targets;

            if (N >= target.Count)
            {
                self.HideEffect();
                return;
            }

            int showNumber = 0;
            float ditance = 0f;
            Vector3 lastVector = self.InvisiblePosition;
            
            for (int i = target.Count - 1; i >= N; i--)
            {
                Vector3 vector31 = target[i];
                float neardis = Vector3.Distance(vector31, target[i-1]);
                ditance += neardis; 

                //2米显示一个特效
                if (Vector3.Distance(vector31, lastVector) > 2f)
                {
                    GameObject go = self.GetPathPointObj(showNumber);
                    go.transform.localPosition = vector31;
                    lastVector = vector31;
                    showNumber++;
                }
            }
            for (int i = showNumber; i < self.PathPointList.Count; i++)
            {
                self.PathPointList[i].transform.localPosition = self.InvisiblePosition;
            }
           
            self.TextDistance.text = string.Format(GameSettingLanguge.LoadLocalization("距离目标{0}米"), Mathf.FloorToInt(ditance));
        }

        public static void OnMainHeroMove(this AutoPathEffectComponent self)
        {
            self.UpdatePathPoint();
        }

        private static void OnLoadGameObject(this AutoPathEffectComponent self, GameObject gameObject, long formId)
        {
            if (self.IsDisposed || formId != self.InstanceId)
            {
                UnityEngine.Object.Destroy(gameObject);
                return;
            }

            self.pathPoint = gameObject;
            self.pathPoint.transform.SetParent(GlobalComponent.Instance.UnitEffect);
            self.pathPoint.gameObject.SetActive(false);
        }
    }
}
