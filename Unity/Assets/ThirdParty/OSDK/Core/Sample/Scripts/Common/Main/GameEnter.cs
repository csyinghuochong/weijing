using UnityEngine;

namespace Douyin.Game
{
    public class GameEnter : MonoBehaviour
    {
        [Header("摄像机")] [SerializeField] private Camera _camera;
        private void Awake()
        {
            // 加载主页面
            var mainDeskTopUi = Instantiate(PrefabLoader.LoadMainDeskTopPrefab(), null).transform;
            
            // 指定摄像机
            mainDeskTopUi.GetComponent<Canvas>().worldCamera = this._camera;
            var sample = mainDeskTopUi.GetComponent<Sample>();
            sample.mainUiViewScript.InitListViewData();
            // 主页面不销毁
            DontDestroyOnLoad(mainDeskTopUi.gameObject);
        }
    }
}