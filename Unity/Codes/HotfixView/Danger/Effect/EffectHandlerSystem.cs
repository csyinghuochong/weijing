using UnityEngine;

namespace ET
{
    public static class EffectHandlerSystem
    {

        /// <summary>
        /// 添加服务器的碰撞范围,显示作用
        /// </summary>
        /// <param name="effect"></param>
        /// <param name="rangeType"></param>
        /// <param name="rangeValue"></param>
        public static void AddCollider(this AEffectHandler self, GameObject effect,int rangeType,  float[] rangeValue )
        {
            if (rangeType == 1 && effect.GetComponent<SphereCollider>() == null)
            {
                SphereCollider collider = effect.AddComponent<SphereCollider>();
                collider.radius = rangeValue[0];
            }
            if (rangeType == 2 && effect.GetComponent<BoxCollider>() == null)
            {
                BoxCollider collider = effect.AddComponent<BoxCollider>();
                collider.center = new Vector3(0,0, rangeValue[1]*0.5f);
                collider.size = new Vector3(rangeValue[0], 1, rangeValue[1]);
            }
        }

        public static void Clear(this AEffectHandler self)
        {
            self.EffectState = BuffState.Waiting;
            self.EffectEndTime = 0;
            self.PassTime = 0;
            self.EffectData = null;
            self.TheUnitBelongto = null;
        }

        /// <summary>
        /// 实时更新当前特效位置
        /// </summary>
        
        public static void UpdateEffectPosition(this AEffectHandler self, Vector3 vec3)
        {
            if (self.EffectObj != null)
            {
                self.EffectObj.transform.position = vec3;
            }
        }
        
    }
}