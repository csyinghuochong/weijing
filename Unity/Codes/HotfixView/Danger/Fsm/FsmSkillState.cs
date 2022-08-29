using UnityEngine;

namespace ET
{

    [FsmHandler]
    public class FsmSkillState : AFsmHandler
    {

        public override void OnInit()
        {
        }

        public override void OnEnter(string paramss = "")
        {
            this.ClearnAnimator();
            this.PlayAnimation(paramss);
        }

        public void PlayAnimation(string paramss = "")
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(int.Parse(paramss));
            AnimatorComponent acomponent = this.FsmComponent.Parent.GetComponent<AnimatorComponent>();
            this.FsmComponent.SkillMoveTime = (skillConfig.Id >= 61012201 && skillConfig.Id <= 61012206) ? skillConfig.SkillLiveTime + TimeHelper.ClientNow() : 0;

            acomponent.PlayAnimation(skillConfig.SkillAnimation);
            this.WaitSkillMove((long)(skillConfig.SkillRigidity * 1000), (float)skillConfig.SkillSingTime).Coroutine();
            if (skillConfig.SkillSingTime > 0f)
            {
                //this.AnimationLoop(skillConfig.SkillAnimation, skillConfig.SkillLiveTime).Coroutine();
                this.AnimationLoop(skillConfig.SkillAnimation, (float)skillConfig.SkillSingTime).Coroutine();
            }
        }

        public async ETTask AnimationLoop(string animation, float skillTime)
        {
            //for (int i = 0; i < skillTime / 1000; i++)
            //{
            //    bool ret = await TimerComponent.Instance.WaitAsync(1000, this.CancellationToken);
            //    if (!ret)
            //    {
            //        return;
            //    }
            //    AnimatorComponent acomponent = this.FsmComponent.Parent.GetComponent<AnimatorComponent>();
            //    acomponent.PlayAnimation(animation);
            //}
            bool ret = await TimerComponent.Instance.WaitAsync((long)skillTime * 1000, this.CancellationToken);
            if (!ret)
            {
                return;
            }
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.SetBoolValue(MotionType.Idle, true);
        }

        public async ETTask WaitSkillMove(long rigidityTime, float singTime)
        {
            this.OnRemoveTimer();
            bool  ret =  await TimerComponent.Instance.WaitAsync(rigidityTime, this.CancellationToken);
            if (!ret)
            {
                return;
            }
            //非旋风斩类型的技能, 僵直之后就切回Idle
            if (this.FsmComponent.SkillMoveTime == 0 && singTime == 0f)
            {
                AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
                acomponent.SetBoolValue(MotionType.Idle, true);
            }
        }

        public override void OnReEnter(string paramss = "")
        {
            this.PlayAnimation(paramss);
        }

        public override void OnExit()
        {
            this.OnRemoveTimer();
            this.ClearnAnimator();
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.SetBoolValue(MotionType.Idle, true);
        }

    }
}