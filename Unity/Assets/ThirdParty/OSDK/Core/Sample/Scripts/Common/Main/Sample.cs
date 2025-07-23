using System.Collections.Generic;
using UnityEngine;

namespace Douyin.Game
{
    // demo main script
    public class Sample : MonoBehaviour
    {
        [Header("主页UIView")] [SerializeField] private GameObject mainUiView;

        [Header("详情页UIView")] [SerializeField] private GameObject detailUiView;

        // Main UI view script 
        public MainUiViewScript mainUiViewScript;

        // Detail UI View Script
        private DetailUiViewScript _detailUiViewScript;

        private void Awake()
        {
            // 主页面
            this.mainUiViewScript = this.mainUiView.GetComponent<MainUiViewScript>();
            
            // 详情页
            this._detailUiViewScript = this.detailUiView.GetComponent<DetailUiViewScript>();
            this._detailUiViewScript._backListener = this.DetailBackBtnListener;
        }

        private void Start()
        {
            // 设置目标平台的帧率，防止卡顿情况出现
            Application.targetFrameRate = 60;

            // 设置屏幕自动旋转
            Screen.orientation = ScreenOrientation.AutoRotation;

            // 监听进入详情页面的事件
            ItemClickDelegate.toDetailOnClickListener = null;
            ItemClickDelegate.toDetailOnClickListener = this.ToDetailCLickListener;
        }


        // 进入详情页
        private void ToDetailCLickListener(
            SecondLevelFunctionsEntity secondLevelFunctionsEntity,
            ThirdLevelFunctionsEntity thirdLevelFunctionsEntity,
            List<FourLevelFunctionsEntity> fourLevelFunctionsEntities)
        {
            this._detailUiViewScript.Init(
                secondLevelFunctionsEntity,
                thirdLevelFunctionsEntity,
                fourLevelFunctionsEntities);
            this.detailUiView.gameObject.SetActive(true);
        }

        // 详情页返回按钮监听
        private void DetailBackBtnListener()
        {
            this.detailUiView.gameObject.SetActive(false);
        }
        
        private void Update()
        {
            // 监听android返回键
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // 检测详情页是否打开
                if (this.DetailViewIsShowing())
                {
                    DetailBackBtnListener();
                }
            }
        }


        // 检测详情页面是否展示
        private bool DetailViewIsShowing()
        {
            if (this.detailUiView == null || this.detailUiView.gameObject == null)
            {
                Debug.LogError("detailUiView or detailUiView.gameObject is null...");
                return false;
            }

            return this.detailUiView.gameObject.activeSelf;
        }
    }
}