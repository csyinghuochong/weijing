

namespace ET
{
    [MessageHandler]
    public class M2C_TaskUpdateHandler : AMHandler<M2C_TaskUpdate>
    {

        protected override void  Run(Session session, M2C_TaskUpdate message)
        {
            session.ZoneScene().GetComponent<TaskComponent>().OnRecvTaskUpdate( message );
        }

    }
}
