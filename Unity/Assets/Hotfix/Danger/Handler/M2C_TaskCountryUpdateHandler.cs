namespace ET
{
    [MessageHandler]
    public class M2C_TaskCountryUpdateHandler : AMHandler<M2C_TaskCountryUpdate>
    {
        protected override  void Run(Session session, M2C_TaskCountryUpdate message)
        {
            session.ZoneScene().GetComponent<TaskComponent>().OnRecvTaskCountryUpdate(message);
        }
    }
}
