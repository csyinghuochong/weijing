namespace Douyin.Game
{
    public class EventListenerResult
    {
        /// <summary>
        /// 事件名
        /// </summary>
        public string EventName { private set; get; }
        
        /// <summary>
        /// 事件状态
        /// 0 成功，-1 未知，-2 阻塞上报 -3 云游戏环境直接阻塞上报
        /// </summary>
        public int EventStatus { private set; get; }
        
        /// <summary>
        /// 错误信息
        /// </summary>
        public string Message { private set; get; }
        
        public EventListenerResult(string eventName, int eventStatus, string message)
        {
            EventName = eventName;
            EventStatus = eventStatus;
            Message = message;
        }
        
        
    }
}