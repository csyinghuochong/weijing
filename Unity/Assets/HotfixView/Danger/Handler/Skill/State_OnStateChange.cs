using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class State_OnStateChange : AEventClass<EventType.StateChange>
    {
        protected override void Run(object numerice)
        {
            EventType.StateChange args = numerice as EventType.StateChange;
            M2C_UnitStateUpdate message = args.m2C_UnitStateUpdate;

            FsmComponent fsmComponent = args.Unit.GetComponent<FsmComponent>();
            if (fsmComponent == null)
            {
                return;
            }
            if (message.StateType == StateTypeEnum.Singing && message.StateOperateType == 1)
            {
                EventType.DataUpdate.Instance.DataType = DataType.UpdateSing;
                EventType.DataUpdate.Instance.DataParamString = $"{args.Unit.Id}_1_{message.StateValue}";
                Game.EventSystem.PublishClass(EventType.DataUpdate.Instance);
                fsmComponent.ChangeState(FsmStateEnum.FsmSinging, message.StateValue);

                if (args.Unit.Type == UnitType.Monster)
                {
                    SkillInfo skillInfo = new SkillInfo();
                    skillInfo.PosX = args.Unit.Position.x;
                    skillInfo.PosY = args.Unit.Position.y;
                    skillInfo.PosZ = args.Unit.Position.z;
                    skillInfo.TargetAngle = int.Parse(message.StateValue.Split('_')[1]);
                    skillInfo.WeaponSkillID = int.Parse(message.StateValue.Split('_')[0]);
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillInfo.WeaponSkillID);
                    args.Unit.GetComponent<SkillYujingComponent>()?.ShowMonsterSkillYujin(skillInfo, skillConfig.SkillFrontSingTime, true);
                }
            }
            if (message.StateType == StateTypeEnum.Singing && message.StateOperateType == 2)
            {
                EventType.DataUpdate.Instance.DataType = DataType.UpdateSing;
                EventType.DataUpdate.Instance.DataParamString = $"{args.Unit.Id}_2_0";
                Game.EventSystem.PublishClass(EventType.DataUpdate.Instance);
                fsmComponent.ChangeState(FsmStateEnum.FsmIdleState, message.StateValue);
            }
            if (message.StateType == StateTypeEnum.OpenBox && message.StateOperateType == 1)
            {
                fsmComponent.ChangeState(FsmStateEnum.FsmOpenBox, message.StateValue);
            }
            if (message.StateType == StateTypeEnum.OpenBox && message.StateOperateType == 2)
            {
                fsmComponent.ChangeState(FsmStateEnum.FsmIdleState, message.StateValue);
            }
            
            // 隐身功能 实现思路应该要优化
            if (message.StateType == StateTypeEnum.Stealth && message.StateOperateType == 1)
            {
                float alpha = 1f;
                // 对自己半透明
                if (args.Unit.Id == UnitHelper.GetMyUnitId(args.Unit.ZoneScene()))
                {
                    alpha = 0.3f;
                }
                // 对别人透明
                else
                {
                    alpha = 0f;
                }

                // 身体隐形
                args.Unit.GetComponent<GameObjectComponent>().Material.shader = GlobalHelp.Find(StringBuilderHelper.SimpleAlpha);
                args.Unit.GetComponent<GameObjectComponent>().Material.SetFloat("_Alpha", alpha);
                // 武器隐形
                MeshRenderer[] meshRenderers = args.Unit.GetComponent<GameObjectComponent>().GameObject.GetComponent<ReferenceCollector>()
                        .Get<GameObject>("Wuqi001").GetComponentsInChildren<MeshRenderer>();
                foreach (MeshRenderer meshRenderer in meshRenderers)
                {
                    meshRenderer.material.shader = GlobalHelp.Find(StringBuilderHelper.SimpleAlpha);
                    meshRenderer.material.SetFloat("_Alpha", alpha);
                }

                // 脚底阴影隐形
                GameObject di = args.Unit.GetComponent<GameObjectComponent>().GameObject.transform.Find("fake shadow (5)").gameObject;
                Color oldColorDi = di.GetComponent<MeshRenderer>().material.color;
                di.GetComponent<MeshRenderer>().material.color = new Color(oldColorDi.r, oldColorDi.g, oldColorDi.b, alpha);
                // 脚底Buff隐形
                foreach (AEffectHandler aEffectHandler in args.Unit.GetComponent<EffectViewComponent>().Effects)
                {
                    ParticleSystem[] particleSystem = aEffectHandler.EffectObj.GetComponentsInChildren<ParticleSystem>();
                    if (particleSystem.Length>0 && particleSystem[0] != null)
                    {
                        Color oldColor = particleSystem[0].GetComponent<Renderer>().material.GetColor("_TintColor");
                        oldColor.a = alpha;
                        particleSystem[0].GetComponent<Renderer>().material.SetColor("_TintColor",oldColor);
                    }
                }

                // 血条隐形
                Image[] hpImages = args.Unit.GetComponent<UIUnitHpComponent>().GameObject.GetComponentsInChildren<Image>();
                foreach (Image image in hpImages)
                {
                    Color oldColor = image.color;
                    image.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
                }

                TextMeshProUGUI[] hpTextMeshPros = args.Unit.GetComponent<UIUnitHpComponent>().GameObject.GetComponentsInChildren<TextMeshProUGUI>();
                foreach (TextMeshProUGUI textMeshPro in hpTextMeshPros)
                {
                    Color oldColor = textMeshPro.color;
                    textMeshPro.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
                }

                // 名称隐形
                Image[] nameImages = args.Unit.GetComponent<UIUnitHpComponent>().UIPlayerHpText.GetComponentsInChildren<Image>();
                foreach (Image image in nameImages)
                {
                    Color oldColor = image.color;
                    image.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
                }

                TextMeshProUGUI[] nameTextMeshPros =
                        args.Unit.GetComponent<UIUnitHpComponent>().UIPlayerHpText.GetComponentsInChildren<TextMeshProUGUI>();
                foreach (TextMeshProUGUI textMeshPro in nameTextMeshPros)
                {
                    Color oldColor = textMeshPro.color;
                    textMeshPro.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
                }

            }
            if (message.StateType == StateTypeEnum.Stealth && message.StateOperateType == 2)
            {
                //退出隐身
                float alpha = 1f;
                args.Unit.GetComponent<GameObjectComponent>().Material.shader =
                        GlobalHelp.Find(args.Unit.GetComponent<GameObjectComponent>().OldShader);
                // 武器恢复
                MeshRenderer[] meshRenderers = args.Unit.GetComponent<GameObjectComponent>().GameObject.GetComponent<ReferenceCollector>()
                        .Get<GameObject>("Wuqi001").GetComponentsInChildren<MeshRenderer>();
                foreach (MeshRenderer meshRenderer in meshRenderers)
                {
                    meshRenderer.material.shader = GlobalHelp.Find(StringBuilderHelper.ToonBasicOutline);
                }

                // 脚底阴影恢复
                GameObject di = args.Unit.GetComponent<GameObjectComponent>().GameObject.transform.Find("fake shadow (5)").gameObject;
                Color oldColorDi = di.GetComponent<MeshRenderer>().material.color;
                di.GetComponent<MeshRenderer>().material.color = new Color(oldColorDi.r, oldColorDi.g, oldColorDi.b, 0.5f);
                // 脚底Buff恢复
                foreach (AEffectHandler aEffectHandler in args.Unit.GetComponent<EffectViewComponent>().Effects)
                {
                    ParticleSystem[] particleSystem = aEffectHandler.EffectObj.GetComponentsInChildren<ParticleSystem>();
                    if (particleSystem.Length>0 && particleSystem[0] != null)
                    {
                        Color oldColor = particleSystem[0].GetComponent<Renderer>().material.GetColor("_TintColor");
                        oldColor.a = 0.5f;
                        particleSystem[0].GetComponent<Renderer>().material.SetColor("_TintColor",oldColor);
                    }
                }
                // 血条恢复
                Image[] hpImages = args.Unit.GetComponent<UIUnitHpComponent>().GameObject.GetComponentsInChildren<Image>();
                foreach (Image image in hpImages)
                {
                    Color oldColor = image.color;
                    image.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
                }

                TextMeshProUGUI[] hpTextMeshPros = args.Unit.GetComponent<UIUnitHpComponent>().GameObject.GetComponentsInChildren<TextMeshProUGUI>();
                foreach (TextMeshProUGUI textMeshPro in hpTextMeshPros)
                {
                    Color oldColor = textMeshPro.color;
                    textMeshPro.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
                }

                // 名称恢复
                Image[] nameImages = args.Unit.GetComponent<UIUnitHpComponent>().UIPlayerHpText.GetComponentsInChildren<Image>();
                foreach (Image image in nameImages)
                {
                    Color oldColor = image.color;
                    image.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
                }

                TextMeshProUGUI[] nameTextMeshPros =
                        args.Unit.GetComponent<UIUnitHpComponent>().UIPlayerHpText.GetComponentsInChildren<TextMeshProUGUI>();
                foreach (TextMeshProUGUI textMeshPro in nameTextMeshPros)
                {
                    Color oldColor = textMeshPro.color;
                    textMeshPro.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
                }
            }
        }
    }
}
