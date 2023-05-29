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

            //发送消息,服务器接受消息
            Log.Debug("收到服务器消息需要传送进竞技场地图....");
            EnterFubenHelp.RequestTransfer(session.ZoneScene(), SceneTypeEnum.Solo, 7000001, 0, message.FubenInstanceId.ToString()).Coroutine();
        }
    }
}
