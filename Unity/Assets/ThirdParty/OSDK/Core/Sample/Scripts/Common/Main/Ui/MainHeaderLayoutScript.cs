using System;
using UnityEngine;
using UnityEngine.UI;

namespace Douyin.Game
{
    // header Layout
    public class MainHeaderLayoutScript : BaseUi
    {
        [Header("版本号文本框")] [SerializeField] private Text appVersionText;

        [Header("首页app描述文本")] [SerializeField] private Text appDescriptionText;

        // [Header("国际化切换按钮")] [SerializeField] private Button internationalizationSwitchButton;

        [Header("首页Logo")] [SerializeField] private Button logoImage;

        private MultipleClickDelegate multipleClickDelegate;

        // 初始化
        public void Init(Action<bool> internationalizationSwitchButtonListener, Action reloadViewListener)
        {
            this.OnRefreshUi();
        }

        // 刷新Ui
        public override void OnRefreshUi()
        {
            this.appVersionText.text = AppStringText.SdkVersion;
            this.appDescriptionText.text = AppStringText.SdkDescription;
        }

        // 资源释放
        public override void OnRelease()
        {
        }
    }
}