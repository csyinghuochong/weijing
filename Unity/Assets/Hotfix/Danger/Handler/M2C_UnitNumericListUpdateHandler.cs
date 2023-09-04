using ET;

namespace ET
{

    //接受属性改变消息
    [MessageHandler]
    public class M2C_UnitNumericListUpdateHandler : AMHandler<M2C_UnitNumericListUpdate>
    {
        protected override void Run(Session session, M2C_UnitNumericListUpdate message)
        {
            //Log.Info("获取最新的属性...");
            //同步我当前的属性
            Scene zongScene = session.ZoneScene();
            Scene currentScene = zongScene.CurrentScene();
            if (currentScene == null)
            {
                return;
            }
            Unit nowNunt = currentScene.GetComponent<UnitComponent>().Get(message.UnitID);
            if (nowNunt == null)
            {
                return;
            }

            NumericComponent numericComponent = nowNunt.GetComponent<NumericComponent>();
            for (int i = 0; i < message.Vs.Count; i++)
            {
                numericComponent.Set(message.Ks[i], message.Vs[i], false);
            }

            //自己的属性派发时间更新属性界面
            HintHelp.GetInstance().DataUpdate(DataType.UpdateRoleProper);
        }
    }
}
