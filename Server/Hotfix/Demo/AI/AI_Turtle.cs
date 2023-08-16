namespace ET
{

    /// <summary>
    /// 小龟大赛AI
    /// </summary>
    [AIHandler]
    public class AI_Turtle : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            return true;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            while (true)
            {
                bool move = RandomHelper.RandFloat01() >= 0.5f;

                if (move)
                {
                    unit.FindPathMoveToAsync(aiComponent.TargetPoint[0], cancellationToken, true).Coroutine();
                }
                else
                {
                    unit.Stop(0);
                }

                bool timeRet = await TimerComponent.Instance.WaitAsync(10000, cancellationToken);
                if (!timeRet)
                {
                    //Log.Debug("AI_Turtle被打断！！" );
                    return;
                }
            }
        }
    }
}
