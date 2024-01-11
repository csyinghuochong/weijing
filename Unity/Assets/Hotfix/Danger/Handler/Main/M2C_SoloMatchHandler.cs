using System;

namespace ET
{
    [MessageHandler]
    public class M2C_SoloMatchHandler : AMHandler<M2C_SoloMatchResult>
    {
        protected override void Run(Session session, M2C_SoloMatchResult message)
        {
            //移除匹配状态
            session.ZoneScene().GetComponent<BattleMessageComponent>().SoloPiPeiStartTime = 0;

            //移除界面
            //EventType.UISoloQuit.Instance.m2C_SoloMatch = message;
            EventType.UISoloQuit.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.UISoloQuit.Instance);

            //发送消息,服务器接受消息
            //Log.Debug("收到服务器消息需要传送进竞技场地图....");
            EventType.UISoloEnter.Instance.ZoneScene = session.ZoneScene();
            EventType.UISoloEnter.Instance.m2C_SoloMatch = message;
            EventSystem.Instance.PublishClass(EventType.UISoloEnter.Instance);

        }
    }
}
