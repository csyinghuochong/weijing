using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Douyin.Game
{
    // 详情页面Ui
    public class DetailUiViewScript : BaseUi
    {
        [Header("详情页，返回按钮")] [SerializeField] private Button backBtn;

        [Header("详情页，文本标题")] [SerializeField] private Text titleText;

        [Header("详情页listView")] [SerializeField]
        private GameObject listView;

        // 所有详情页itemView
        private List<GameObject> _allDetailItemView = new List<GameObject>();

        // 返回按钮监听器
        public Action _backListener;

        private void Start()
        {
            this.backBtn.onClick.AddListener(() =>
            {
                // 返回按钮点击事件
                if (this._backListener != null)
                {
                    this._backListener.Invoke();
                }
            });
        }

        // 初始化详情页数据
        public void Init(
            SecondLevelFunctionsEntity secondLevelFunctionsEntity,
            ThirdLevelFunctionsEntity thirdLevelFunctionsEntity,
            List<FourLevelFunctionsEntity> fourLevelFunctionsEntities)
        {
            // 处理特殊字符串
            var title = thirdLevelFunctionsEntity == null ? string.Empty : thirdLevelFunctionsEntity.GetContent();
            var contentArray = title == null ? null : title.Split('#');
            if (contentArray != null && contentArray.Length > 1)
            {
                title = contentArray[0] + "\n" + "<color=#8F8F93><size=36>" + contentArray[1] + "</size></color>";
            }

            // 设置标题信息
            this.titleText.text = title;

            // 进来先释放一下资源
            this.OnRelease();

            if (fourLevelFunctionsEntities == null)
            {
                Debug.LogError("fourLevelFunctionsEntities is null...");
                return;
            }

            var count = fourLevelFunctionsEntities.Count;
            for (var i = 0; i < count; i++)
            {
                this.InitItemView(secondLevelFunctionsEntity, fourLevelFunctionsEntities[i], count == (i + 1));
            }
        }

        // 初始化但换个item view
        private void InitItemView(
            SecondLevelFunctionsEntity secondLevelFunctionsEntity,
            FourLevelFunctionsEntity fourLevelFunctionsEntity,
            bool isLastItem)
        {
            if (fourLevelFunctionsEntity == null)
            {
                Debug.LogError("fourLevelFunctionsEntity is null...");
                return;
            }

            // 详情页 item prefab
            var prefab = PrefabLoader.LoadDetailItemViewPrefab();
            if (fourLevelFunctionsEntity.GetItemType() == ItemTypeEnum.Select) {
                prefab = PrefabLoader.LoadDetailSelectItemViewPrefab();
            } 

            var detailItemPrefab = Instantiate(prefab, this.listView.transform, true);
            detailItemPrefab.transform.localScale = new Vector2(1, 1);
            detailItemPrefab.transform.SetAsLastSibling();
            UiUtil.ResetPosZTo0(detailItemPrefab);

            this._allDetailItemView.Add(detailItemPrefab);

            // 详情页item 脚本
            if (fourLevelFunctionsEntity.GetItemType() == ItemTypeEnum.Select) {
                var detailSelectItemViewScript = detailItemPrefab.GetComponent<DetailSelectItemViewScript>();
                detailSelectItemViewScript.Init(secondLevelFunctionsEntity, fourLevelFunctionsEntity);
                // 检查是否需要隐藏分割线
                if (isLastItem)
                {
                    detailSelectItemViewScript.HideDividerViewLayout();
                }
            } else {
                var detailItemViewScript = detailItemPrefab.GetComponent<DetailItemViewScript>();
                detailItemViewScript.Init(secondLevelFunctionsEntity, fourLevelFunctionsEntity);
                // 检查是否需要隐藏分割线
                if (isLastItem)
                {
                    detailItemViewScript.HideDividerViewLayout();
                }
            }
        }

        public override void OnRefreshUi()
        {
        }

        // 释放资源
        public override void OnRelease()
        {
            // 销毁所有Item
            foreach (var o in this._allDetailItemView)
            {
                Destroy(o);
            }

            this._allDetailItemView.Clear();
        }
    }
}