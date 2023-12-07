
namespace ET
{
    public class Skill_OnSkillChainLight : AEventClass<EventType.SkillChainLight>
    {
        protected override void Run(object numerice)
        {
            EventType.SkillChainLight args = numerice as EventType.SkillChainLight;
            UnitComponent unitComponent = args.ZoneScene.CurrentScene().GetComponent<UnitComponent>();
            Unit start = unitComponent.Get(args.M2C_ChainLightning.UnitId);
            if (start == null)
            {
                return;
            }
            Unit target = unitComponent.Get(args.M2C_ChainLightning.TargetID);
            if (target == null)
            {
                return;
            }

            switch (args.M2C_ChainLightning.Type)
            {
                case 0:
                {
                    EffectData playEffectBuffData = new EffectData();
                    playEffectBuffData.TargetID = args.M2C_ChainLightning.TargetID;
                    playEffectBuffData.SkillId = args.M2C_ChainLightning.SkillID; //技能相关配置
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(playEffectBuffData.SkillId);
                    playEffectBuffData.EffectId = skillConfig.SkillEffectID[0]; //特效相关配置
                    playEffectBuffData.EffectPosition =
                            new UnityEngine.Vector3(args.M2C_ChainLightning.PosX, args.M2C_ChainLightning.PosY, args.M2C_ChainLightning.PosZ); //技能目标点
                    playEffectBuffData.TargetAngle = 0; //技能角度
                    playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect; //特效类型
                    playEffectBuffData.InstanceId = target.InstanceId;
                    start.GetComponent<EffectViewComponent>()?.EffectFactory(playEffectBuffData);
                    break;
                }
                case 3:
                {
                    Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(args.ZoneScene);
                    EffectViewComponent effectViewComponent = myUnit.GetComponent<EffectViewComponent>();
                    if (effectViewComponent == null)
                    {
                        return;
                    }
                    AEffectHandler aEffectHandler = effectViewComponent.GetEffect(args.M2C_ChainLightning.InstanceId);

                    if (aEffectHandler == null)
                    {
                        EffectData playEffectBuffData = new EffectData();
                        playEffectBuffData.TargetID = args.M2C_ChainLightning.TargetID;
                        playEffectBuffData.SkillId = args.M2C_ChainLightning.SkillID; //技能相关配置
                        SkillConfig skillConfig = SkillConfigCategory.Instance.Get(playEffectBuffData.SkillId);
                        playEffectBuffData.EffectId = skillConfig.SkillEffectID[0]; //特效相关配置
                        playEffectBuffData.EffectPosition =
                                new UnityEngine.Vector3(args.M2C_ChainLightning.PosX, args.M2C_ChainLightning.PosY, args.M2C_ChainLightning.PosZ); //技能目标点
                        playEffectBuffData.TargetAngle = 0; //技能角度
                        playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect; //特效类型
                        playEffectBuffData.InstanceId = args.M2C_ChainLightning.InstanceId;
                        myUnit.GetComponent<EffectViewComponent>()?.EffectFactory(playEffectBuffData);
                    }
                    else
                    {
                        aEffectHandler.GetComponent<ChainLightningComponent>().Start = start.GetComponent<HeroTransformComponent>().GetTranform(PosType.Center);
                        aEffectHandler.GetComponent<ChainLightningComponent>().End = target.GetComponent<HeroTransformComponent>().GetTranform(PosType.Center);
                    }

                    break;
                }
            }
        }
    }
}
