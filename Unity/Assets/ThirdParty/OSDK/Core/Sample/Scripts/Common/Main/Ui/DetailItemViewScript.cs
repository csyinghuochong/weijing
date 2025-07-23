using UnityEngine;
using UnityEngine.UI;

namespace Douyin.Game
{
    // 详情页面Item
    public class DetailItemViewScript : BaseUi
    {
        [Header("描述文本")] [SerializeField] private Text contentText;

        [Header("item 按钮")] [SerializeField] private Button itemButton;

        [Header("分割线布局")] [SerializeField] private GameObject divideViewLayout;

        // 二级列表实体类
        private SecondLevelFunctionsEntity _secondLevelFunctionsEntity;

        // 详情页数据结构
        private FourLevelFunctionsEntity _fourLevelFunctionsEntity;

        private void Start()
        {
            // item 点击事件
            this.itemButton.onClick.AddListener(() =>
            {
                ItemClickDelegate.OnItemClick(this._secondLevelFunctionsEntity, this._fourLevelFunctionsEntity);
            });
        }

        // 初始化
        public void Init(
            SecondLevelFunctionsEntity secondLevelFunctionsEntity,
            FourLevelFunctionsEntity fourLevelFunctionsEntity)
        {
            this._secondLevelFunctionsEntity = secondLevelFunctionsEntity;
            this._fourLevelFunctionsEntity = fourLevelFunctionsEntity;
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
            this.contentText.text = this._fourLevelFunctionsEntity == null
                ? string.Empty
                : this._fourLevelFunctionsEntity.GetContent();
        }

        // 释放资源
        public override void OnRelease()
        {
        }
    }
}