using UnityEngine;

namespace Douyin.Game
{
    // 基础UI抽象
    public abstract class BaseUi : MonoBehaviour
    {
        // 刷新UI
        public abstract void OnRefreshUi();

        // 资源释放
        public abstract void OnRelease();
    }
}