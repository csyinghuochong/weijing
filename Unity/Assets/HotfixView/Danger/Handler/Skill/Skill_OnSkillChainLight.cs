
namespace ET
{
    public class Skill_OnSkillChainLight : AEventClass<EventType.SkillChainLight>
    {
        protected override void Run(object numerice)
        {
            EventType.SkillChainLight args = numerice as EventType.SkillChainLight;
            Unit Unit = args.ZoneScene.CurrentScene().GetComponent<UnitComponent>().Get(args.M2C_ChainLightning.UnitId);
            if (Unit == null)
            {
                return;
            }

            EffectData playEffectBuffData = new EffectData();
            playEffectBuffData.TargetID = args.M2C_ChainLightning.TargetID;
            playEffectBuffData.SkillConfig = SkillConfigCategory.Instance.Get(args.M2C_ChainLightning.SkillID);                   //技能相关配置
            playEffectBuffData.EffectConfig = EffectConfigCategory.Instance.Get(playEffectBuffData.SkillConfig.SkillEffectID[0]);                 //特效相关配置
            playEffectBuffData.EffectPosition = new UnityEngine.Vector3(args.M2C_ChainLightning.PosX, args.M2C_ChainLightning.PosY, args.M2C_ChainLightning.PosZ);           //技能目标点
            playEffectBuffData.TargetAngle = 0;         //技能角度
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;              //特效类型
            Unit.GetComponent<EffectViewComponent>()?.EffectFactory(playEffectBuffData);
        }
    }
}
