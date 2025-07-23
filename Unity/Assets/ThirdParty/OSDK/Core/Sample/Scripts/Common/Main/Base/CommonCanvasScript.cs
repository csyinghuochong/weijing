using UnityEngine;

namespace Douyin.Game
{
    public class CommonCanvasScript<T> : MonoSingletonBase<T>
        where T : MonoBehaviour
    {
        private const string CommonCanvasName = "CommonCanvas(Clone)";

        // 通用canvas 的 transform
        protected Transform _commonCanvasTransform;

        private void Awake()
        {
            var commonCanvas = GameObject.Find(CommonCanvasName);
            if (commonCanvas == null)
            {
                // 加载一个不销毁的通用canvas
                this._commonCanvasTransform = Instantiate(PrefabLoader.LoadCommonCanvasPrefab(), null).transform;
                DontDestroyOnLoad(this._commonCanvasTransform.gameObject);
            }
            else
            {
                this._commonCanvasTransform = commonCanvas.transform;
            }
        }
    }
}