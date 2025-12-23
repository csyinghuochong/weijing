using UnityEngine;

public class NetworkChangeDetector : MonoBehaviour
{
    // 存储上一次检测到的网络状态
    private NetworkReachability _lastReachability;

    // 网络状态发生变化时触发的事件
    public System.Action<NetworkReachability> OnNetworkChanged;
    public System.Action OnNetworkChanged_2;

    void Start()
    {
        // 初始化，记录启动时的网络状态
        _lastReachability = Application.internetReachability;
        Debug.Log($"初始网络状态: {_lastReachability}");
    }

    void Update()
    {
        // 获取当前网络状态
        NetworkReachability currentReachability = Application.internetReachability;

        // 如果状态发生变化
        if (currentReachability != _lastReachability)
        {
            Debug.Log($"网络状态发生变化！从 {_lastReachability} 切换到 {currentReachability}");

            // 触发事件，通知其他脚本
            OnNetworkChanged?.Invoke(currentReachability);
            OnNetworkChanged_2?.Invoke();

            // 根据新的状态执行具体操作（示例）
            HandleNetworkSwitch(currentReachability);

            // 更新记录的状态
            _lastReachability = currentReachability;
        }
    }

    /// <summary>
    /// 处理网络切换的具体逻辑
    /// </summary>
    /// <param name="newStatus">新的网络状态</param>
    private void HandleNetworkSwitch(NetworkReachability newStatus)
    {
        switch (newStatus)
        {
            case NetworkReachability.ReachableViaLocalAreaNetwork:
                Debug.Log("已切换到WiFi/局域网。建议恢复高频率数据同步。");
                // 例如：重新连接服务器，或恢复游戏内的高频率数据更新[citation:9]
                break;
            case NetworkReachability.ReachableViaCarrierDataNetwork:
                Debug.Log("已切换到蜂窝数据网络(4G/5G等)。请注意流量消耗，可考虑降低非关键数据更新频率。");
                // 例如：提示用户可能产生流量，或降低非必要的心跳包频率[citation:9]
                break;
            case NetworkReachability.NotReachable:
                Debug.LogWarning("网络连接已断开。");
                // 例如：显示离线UI，尝试断线重连
                break;
        }
    }
}