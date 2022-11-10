using System;
using UnityEngine;

namespace ET
{
     
    [EffectHandler]
    public class RoleSkillEffect: AEffectHandler
    {
        public override void OnInit(EffectData effectData, Unit theUnitBelongto)
        {
            this.EffectPath = "";
            this.EffectObj = null;
            this.PassTime = 0f;
            this.EffectData = effectData;
            this.EffectState = BuffState.Running;
            this.TheUnitBelongto = theUnitBelongto;
            this.EffectEndTime = EffectData.EffectConfig.SkillEffectLiveTime * 0.001f;
            this.EffectDelayTime = (float)EffectData.EffectConfig.SkillEffectDelayTime;

            this.OnUpdate();
        }

        public void OnLoadGameObject(GameObject gameObject, long instanceId)
        {
            this.EffectObj = gameObject;
            if (this.EffectData == null || gameObject == null)
            {
                this.EffectState = BuffState.Finished;
            }
            if (this.TheUnitBelongto == null || this.TheUnitBelongto.IsDisposed)
            {
                this.EffectState = BuffState.Finished;
            }
            if (this.EffectState == BuffState.Finished)
            {
                this.OnFinished();
                return;
            }
            int skillParentID = EffectData.EffectConfig != null ? EffectData.EffectConfig.SkillParent : 0;
            if (this.EffectData.SkillConfig != null)
            {
                int rangeType = EffectData.SkillConfig.DamgeRangeType;       //技能范围类型
                float[] rangeValue = FunctionHelp.DoubleArrToFloatArr(EffectData.SkillConfig.DamgeRange);          //技能范围
                this.AddCollider(this.EffectObj, rangeType, rangeValue);
            }
            switch (skillParentID)
            {
                //跟随玩家
                case 0:
                    Transform tParent = this.TheUnitBelongto.GetComponent<HeroTransformComponent>().GetTranform((PosType)Enum.Parse(typeof(PosType), EffectData.EffectConfig.SkillParentPosition));
                    EffectObj.transform.SetParent(tParent);
                    EffectObj.transform.localPosition = Vector3.zero;
                    EffectObj.transform.localScale = Vector3.one;
                    EffectObj.transform.localRotation = Quaternion.Euler(Vector3.zero);
                    break;
                //不跟随玩家
                case 1:
                    this.EffectObj.transform.SetParent(GlobalComponent.Instance.Unit);
                    EffectObj.transform.position = EffectData.EffectPosition;
                    EffectObj.transform.localScale = Vector3.one;
                    EffectObj.transform.localRotation = Quaternion.Euler(0, EffectData.TargetAngle, 0);
                    break;
                //实时跟随玩家位置,但是不跟随旋转
                case 2:
                    EffectObj.transform.SetParent(GlobalComponent.Instance.Unit);
                    EffectObj.transform.position = this.TheUnitBelongto.Position;
                    EffectObj.transform.localScale = Vector3.one;
                    EffectObj.transform.localRotation = Quaternion.Euler(0, EffectData.TargetAngle, 0);
                    break;
                //实时跟随位置,无指定绑点
                case 3:
                    EffectObj.transform.SetParent(GlobalComponent.Instance.Unit);
                    EffectObj.transform.position = this.TheUnitBelongto.Position;
                    EffectObj.transform.localScale = Vector3.one;
                    EffectObj.transform.localRotation = Quaternion.Euler(0, EffectData.TargetAngle, 0);
                    break;
                //闪电链特效
                case 4:
                    Unit unitTarget = null;
                    ChainLightningComponent chainLightningComponent = this.AddComponent<ChainLightningComponent, GameObject>(EffectObj);
                    chainLightningComponent.Start = this.TheUnitBelongto.GetComponent<HeroTransformComponent>().GetTranform(PosType.Center);
                    if (EffectData.TargetID != 0)
                    {
                        unitTarget = this.TheUnitBelongto.DomainScene().GetComponent<UnitComponent>().Get(EffectData.TargetID);

                        if (unitTarget == null)
                        {
                            this.EffectState = BuffState.Finished;
                            this.OnFinished();
                            return;
                        }
                        chainLightningComponent.UsePosition = false;
                        chainLightningComponent.End = unitTarget.GetComponent<HeroTransformComponent>().GetTranform(PosType.Center);
                        chainLightningComponent.OnUpdate();
                    }
                    else
                    {
                        chainLightningComponent.UsePosition = true;
                        chainLightningComponent.EndPosition = this.EffectData.EffectPosition;
                        chainLightningComponent.OnUpdate();
                    }
                    break;
            }

            //this.EffectObj = 
            this.EffectObj.SetActive(true);
        }

        /// <summary>
        /// 实例化特效
        /// </summary>
        public  void PlayEffect()
        {
            if (this.EffectData == null)
            {
                return;
            }
            string effectFileName = "";
            switch (EffectData.EffectConfig.EffectType) 
            {
                //技能特效
                case 1:
                    effectFileName = "SkillEffect/";
                    break;
                //受击特效
                case 2:
                    effectFileName = "SkillHitEffect/";
                    break;
                //技能特效
                case 3:
                    effectFileName = "SkillEffect/";
                    break;
            }

            string effectNamePath  = effectFileName + EffectData.EffectConfig.EffectName;
            EffectPath = ABPathHelper.GetEffetPath(effectNamePath);
            GameObjectPoolComponent.Instance.AddLoadQueue(EffectPath, this.InstanceId, this.OnLoadGameObject);
        }

        public override void OnUpdate()
        {
            //只有不是永久Buff的情况下才会执行Update判断
            base.OnUpdate();

            if (this.EffectDelayTime >= 0f && this.PassTime > this.EffectDelayTime)
            {
                this.EffectDelayTime = -1f;
               
                this.PlayEffect();
            }
            if (this.PassTime > this.EffectEndTime)
            {
                this.EffectState = BuffState.Finished;
                return;
            }
            if (this.TheUnitBelongto == null || this.TheUnitBelongto.IsDisposed || this.EffectData == null)
            {
                this.EffectState = BuffState.Finished;
                return;
            }
            int skillParentID = EffectData.EffectConfig.SkillParent;
            if (skillParentID == 4)//闪电链
            {
                if (EffectData.TargetID != 0 && null == this.TheUnitBelongto.DomainScene().GetComponent<UnitComponent>().Get(EffectData.TargetID))
                {
                    this.EffectState = BuffState.Finished;
                    return;
                }
            }

            if (EffectData.EffectConfig.HideTime > 0 && EffectObj!=null)
            {
                HideObjTime += Time.deltaTime;
                if (HideObjTime >= EffectData.EffectConfig.HideTime)
                {
                    HideObjTime = 0;
                    EffectObj.SetActive(false);
                    EffectObj.SetActive(true);
                }
            }
        }

        public override void OnFinished()
        {
            this.EffectData = null;
            GameObjectPoolComponent.Instance.RecoverGameObject(this.EffectPath, this.EffectObj);
        }

    }
}