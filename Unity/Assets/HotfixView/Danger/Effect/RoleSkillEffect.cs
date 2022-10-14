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
            this.EffectEndTime = EffectData.mEffectConfig.SkillEffectLiveTime * 0.001f;
            this.EffectDelayTime = (float)EffectData.mEffectConfig.SkillEffectDelayTime;

            this.OnUpdate();
        }

        /// <summary>
        /// 实例化特效
        /// </summary>
        public async ETTask PlayEffect()
        {
            if (this.EffectData == null)
            {
                return;
            }
            string effectFileName = "";
            switch (EffectData.mEffectConfig.EffectType) 
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

            string effectNamePath  = effectFileName + EffectData.mEffectConfig.EffectName;
            EffectPath = ABPathHelper.GetEffetPath(effectNamePath);
            EffectObj = await GameObjectPoolComponent.Instance.GetExternalAsync(EffectPath);

            if (EffectObj == null)
            {
                this.EffectState = BuffState.Finished;
                Log.Error($"EffectObj == null {effectNamePath}");
            }
            if (this.EffectData == null)
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
            if (this.TheUnitBelongto.GetComponent<HeroTransformComponent>() == null)
            {
                this.EffectState = BuffState.Finished;
            }
            if (this.EffectState == BuffState.Finished)
            {
                this.OnFinished();
                return;
            }
            if (EffectData.mSkillConfig!=null)
            {
                int rangeType = EffectData.mSkillConfig.DamgeRangeType;       //技能范围类型
                float[] rangeValue = FunctionHelp.Instance.DoubleArrToFloatArr(EffectData.mSkillConfig.DamgeRange);          //技能范围
                this.AddCollider(EffectObj, rangeType, rangeValue);
            }
            EffectObj.SetActive(true);
            int skillParentID = EffectData.mEffectConfig.SkillParent;
            switch (skillParentID)
            {
                //跟随玩家
                case 0:
                    Transform tParent = this.TheUnitBelongto.GetComponent<HeroTransformComponent>().GetTranform((PosType)Enum.Parse(typeof(PosType), EffectData.mEffectConfig.SkillParentPosition));
                    EffectObj.transform.SetParent(tParent);
                    EffectObj.transform.localPosition = Vector3.zero;
                    EffectObj.transform.localScale = Vector3.one;
                    EffectObj.transform.localRotation = Quaternion.Euler(Vector3.zero);
                    break;
                //不跟随玩家
                case 1:
                    this.EffectObj.transform.SetParent(GlobalComponent.Instance.Unit);
                    if (this.EffectData.mSkillConfig != null)
                    {
                        switch (EffectData.mSkillConfig.SkillTargetType)
                        {
                            case (int)SkillTargetType.SelfOnly:
                                EffectObj.transform.position = TheUnitBelongto.Position;
                                break;
                            case (int)SkillTargetType.TargetOnly:
                                Unit unit = TheUnitBelongto.DomainScene().GetComponent<UnitComponent>().Get(EffectData.TargetID);
                                if (unit != null)
                                {
                                    EffectObj.transform.position = unit.Position;
                                }
                                else
                                {
                                    EffectObj.transform.position = TheUnitBelongto.Position;
                                }
                                break;
                            default:
                                EffectObj.transform.position = EffectData.TargetPosition;
                                break;
                        }
                    }

                    EffectObj.transform.localScale = Vector3.one;
                    EffectObj.transform.localRotation =  Quaternion.Euler(0, EffectData.TargetAngle, 0);
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
                        chainLightningComponent.EndPosition = this.EffectData.TargetPosition;
                        chainLightningComponent.OnUpdate();
                    }
                    break;
            }
        }

        public override void OnUpdate()
        {
            //只有不是永久Buff的情况下才会执行Update判断
            base.OnUpdate();

            if (this.EffectDelayTime >= 0f && this.PassTime > this.EffectDelayTime)
            {
                this.EffectDelayTime = -1f;
                this.PlayEffect().Coroutine();
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
            int skillParentID = EffectData.mEffectConfig.SkillParent;
            if (skillParentID == 4)//闪电链
            {
                if (EffectData.TargetID != 0 && null == this.TheUnitBelongto.DomainScene().GetComponent<UnitComponent>().Get(EffectData.TargetID))
                {
                    this.EffectState = BuffState.Finished;
                    return;
                }
            }

            if (EffectData.mEffectConfig.HideTime > 0)
            {
                HideObjTime += Time.deltaTime;
                if (HideObjTime >= EffectData.mEffectConfig.HideTime)
                {
                    HideObjTime = 0;
                    if (EffectObj != null)
                    {
                        EffectObj.SetActive(false);
                        EffectObj.SetActive(true);
                    }
                }
            }
        }

        public override void OnFinished()
        {
            this.EffectData = null;
            if (this.EffectObj != null)
            {
                GameObjectPoolComponent.Instance.InternalPut(this.EffectPath, this.EffectObj);
                this.EffectObj.SetActive(false);
                this.EffectObj = null;
            }
        }

    }
}