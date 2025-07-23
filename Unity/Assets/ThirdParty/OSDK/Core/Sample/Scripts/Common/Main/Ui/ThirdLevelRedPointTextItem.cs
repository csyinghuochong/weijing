using UnityEngine;
using UnityEngine.UI;

namespace Douyin.Game
{
    public class ThirdLevelRedPointTextItem: BaseUi
    {
        [Header("三级列表Item的文本框")] [SerializeField] private Text textContent;

        [Header("整体布局按钮")] [SerializeField] private Button itemButton;

        [Header("红点")] [SerializeField]private Image redPoint;

        [Header("分割线布局")] [SerializeField] private GameObject divideViewLayout;

        // 而级列表实体类
        private SecondLevelFunctionsEntity _secondLevelFunctionsEntity;

        // 三级列表实体类
        private ThirdLevelFunctionsEntity _thirdLevelFunctionsEntity;
        
        private void Start()
        {
            // 三级列表的点击事件
            this.itemButton.onClick.AddListener(() =>
            {
                // 三级页面点击事件
                ItemClickDelegate.OnItemClick(
                    this._secondLevelFunctionsEntity,
                    this._thirdLevelFunctionsEntity);
            });
        }
        
        // 初始化三级列表数据内容
        public void InitThirdItemData(
            SecondLevelFunctionsEntity secondLevelFunctionsEntity,
            ThirdLevelFunctionsEntity thirdLevelFunctionsEntity)
        {
            this._secondLevelFunctionsEntity = secondLevelFunctionsEntity;
            this._thirdLevelFunctionsEntity = thirdLevelFunctionsEntity;
            this.OnRefreshUi();
        }

        // 隐藏分割线
        public void HideDividerViewLayout()
        {
            if (this.divideViewLayout != null && this.divideViewLayout.gameObject != null)
            {
                this.divideViewLayout.gameObject.SetActive(false);
            }
        }

        // 刷新UI
        public override void OnRefreshUi()
        {
            // 处理特殊字符串
            var content = this._thirdLevelFunctionsEntity == null
                ? string.Empty
                : this._thirdLevelFunctionsEntity.GetContent();
            var contentArray = content?.Split('#');
            if (contentArray != null && contentArray.Length > 1)
            {
                content = contentArray[0] + " " + "<color=#8F8F93>" + contentArray[1] + "</color>";
            }

            this.textContent.text = content;
        }

        // 资源释放
        public override void OnRelease()
        {
        }
    }
}