using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Douyin.Game
{
    public class SecondLevelItemScript : BaseUi
    {
        [Header("左侧Icon")] [SerializeField] private Image leftIcon;

        [Header("文本框显示的内容")] [SerializeField] private Text textContent;

        [Header("标题右侧按钮")] [SerializeField] private GameObject rightImageGameobj;

        [Header("第三级列表的ListView")] [SerializeField]
        private GameObject thirdLevelListView;

        [Header("标题按钮")] [SerializeField] private Button titleLayoutButton;

        [Header("分割线布局")] [SerializeField] private GameObject divideViewLayout;

        // 二级列表数据
        private SecondLevelFunctionsEntity _secondLevelFunctionsEntity;

        // 三级页面UI
        private List<BaseUi> _thirdLevelUi = new List<BaseUi>();

        // 是否展开
        private bool _isExtend;

        private void Start()
        {
            // 展开按钮点击
            this.titleLayoutButton.onClick.AddListener(() =>
            {
                // 改变状态
                this._isExtend = !this._isExtend;

                // 先做图片旋转
                this.rightImageGameobj.GetComponent<RectTransform>()
                    .Rotate(new Vector3(0, 0, this._isExtend ? 180 : -180));

                // 检查是否隐藏三级列表
                this.thirdLevelListView.gameObject.SetActive(this._isExtend);

                // 二级列表点击事件
                ItemClickDelegate.OnItemClick(
                    this._secondLevelFunctionsEntity,
                    this._secondLevelFunctionsEntity);
            });
        }

        // 初始化二级列表数据
        public void InitSecondLevelData(SecondLevelFunctionsEntity secondLevelFunctionsEntity)
        {
            this._secondLevelFunctionsEntity = secondLevelFunctionsEntity;

            // 检查三级列表是否是展开状态
            this.thirdLevelListView.gameObject.SetActive(this._isExtend);

            this.OnRefreshUi();
            this.InitThirdListView(secondLevelFunctionsEntity.ThirdLevelFunctionsEntities);
        }

        // 初始化三级listView 数据
        private void InitThirdListView(List<ThirdLevelFunctionsEntity> thirdLevelFunctionsEntities)
        {
            if (thirdLevelFunctionsEntities == null)
            {
                Debug.LogError("thirdLevelFunctionsEntities is null...");
                return;
            }

            var count = thirdLevelFunctionsEntities.Count;
            for (var i = 0; i < count; i++)
            {
                this.InitThirdItemView(thirdLevelFunctionsEntities[i], count == (i + 1));
            }
        }


        // 初始化三级列表ItemView
        private void InitThirdItemView(ThirdLevelFunctionsEntity thirdLevelFunctionsEntity, bool isLastItem)
        {
            if (thirdLevelFunctionsEntity == null)
            {
                Debug.LogError("thirdLevelFunctionsEntity is null...");
                return;
            }

            switch (thirdLevelFunctionsEntity.GetItemType())
            {
                case ItemTypeEnum.Input:
                    InitInputItem(thirdLevelFunctionsEntity, isLastItem);
                    break;
                case ItemTypeEnum.Text:
                    InitTextItem(thirdLevelFunctionsEntity, isLastItem);
                    break;
                case ItemTypeEnum.RedPointText:
                    InitRedPointTextItem(thirdLevelFunctionsEntity, isLastItem);
                    break;
                default:
                    throw new Exception("没有正确匹配的类型");
            }
        }

        
        // 初始化输入类型的Item
        private void InitInputItem(ThirdLevelFunctionsEntity thirdLevelFunctionsEntity, bool isLastItem)
        {
            // 三级列表Item的Prefab
            var thirdLevelInputItemPrefab =
                Instantiate(PrefabLoader.LoadThirdInputItemPrefab(), this.thirdLevelListView.transform, true);
            thirdLevelInputItemPrefab.transform.localScale = new Vector2(1, 1);
            thirdLevelInputItemPrefab.transform.SetAsLastSibling();

            UiUtil.ResetPosZTo0(thirdLevelInputItemPrefab);

            // 三级列表Item 绑定的脚本
            var thirdLevelInputItemScript = thirdLevelInputItemPrefab.GetComponent<ThirdLevelInputItemScript>();

            // 保存三级页面UI脚本
            this._thirdLevelUi.Add(thirdLevelInputItemScript);

            // 初始化三级列表Item数据
            thirdLevelInputItemScript.InitThirdItemData(this._secondLevelFunctionsEntity, thirdLevelFunctionsEntity);

            // 检查是否需要隐藏分割线
            if (isLastItem)
            {
                thirdLevelInputItemScript.HideDividerViewLayout();
            }
        }

        // 初始化文本类型的Item
        private void InitTextItem(ThirdLevelFunctionsEntity thirdLevelFunctionsEntity, bool isLastItem)
        {
            // 三级列表Item的Prefab
            var thirdLevelItemPrefab =
                Instantiate(PrefabLoader.LoadThirdTextItemPrefab(), this.thirdLevelListView.transform, true);
            thirdLevelItemPrefab.transform.localScale = new Vector2(1, 1);
            thirdLevelItemPrefab.transform.SetAsLastSibling();

            UiUtil.ResetPosZTo0(thirdLevelItemPrefab);

            // 三级列表Item 绑定的脚本
            var thirdLevelItemScript = thirdLevelItemPrefab.GetComponent<ThirdLevelItemScript>();

            // 保存三级页面UI脚本
            this._thirdLevelUi.Add(thirdLevelItemScript);

            // 初始化三级列表Item数据
            thirdLevelItemScript.InitThirdItemData(this._secondLevelFunctionsEntity, thirdLevelFunctionsEntity);

            // 检查是否需要隐藏分割线
            if (isLastItem)
            {
                thirdLevelItemScript.HideDividerViewLayout();
            }
        }
        
        //初始化带有红点提示的Item
        private void InitRedPointTextItem(ThirdLevelFunctionsEntity thirdLevelFunctionsEntity, bool isLastItem)
        {
            // 三级列表Item的Prefab
            var thirdLevelItemPrefab =
                Instantiate(PrefabLoader.LoadThirdRedPointTextItemPrefab(), this.thirdLevelListView.transform, true);
            thirdLevelItemPrefab.transform.localScale = new Vector2(1, 1);
            thirdLevelItemPrefab.transform.SetAsLastSibling();

            UiUtil.ResetPosZTo0(thirdLevelItemPrefab);

            // 三级列表Item 绑定的脚本
            var thirdLevelItemScript = thirdLevelItemPrefab.GetComponent<ThirdLevelRedPointTextItem>();

            // 保存三级页面UI脚本
            this._thirdLevelUi.Add(thirdLevelItemScript);

            // 初始化三级列表Item数据
            thirdLevelItemScript.InitThirdItemData(this._secondLevelFunctionsEntity, thirdLevelFunctionsEntity);

            // 检查是否需要隐藏分割线
            if (isLastItem)
            {
                thirdLevelItemScript.HideDividerViewLayout();
            }
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
            // 刷新二级页面的UI
            this.textContent.text = this._secondLevelFunctionsEntity == null
                ? string.Empty
                : this._secondLevelFunctionsEntity.GetContent();

            this.leftIcon.sprite = LocalImageLoader.LoadMainIconById(this._secondLevelFunctionsEntity == null
                ? string.Empty
                : this._secondLevelFunctionsEntity.NameId);

            // 刷新三级页面的UI
            foreach (var baseUi in this._thirdLevelUi)
            {
                baseUi.OnRefreshUi();
            }
        }

        // 资源释放
        public override void OnRelease()
        {
            // 释放三级列表的资源
            foreach (var baseUi in this._thirdLevelUi)
            {
                baseUi.OnRelease();
            }

            this._thirdLevelUi.Clear();
        }
    }
}