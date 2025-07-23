using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Douyin.Game
{
    // Demo 首页 主Item布局脚本
    public class PrimaryLevelItemScript : BaseUi
    {
        [Header("一级标题文本框")] [SerializeField] private Text titleText;

        [Header("二级列表垂直布局")] [SerializeField] private GameObject secondLevelListView;

        // 一级列表数据
        private PrimaryLevelFunctionsEntity _primaryLevel;

        // 所有二级列表UI
        private List<BaseUi> _secondLevelBaseUi = new List<BaseUi>();

        // 初始化一级列表布局显示内容
        public void InitSecondLevelData(PrimaryLevelFunctionsEntity primaryLevel)
        {
            this._primaryLevel = primaryLevel;

            // 刷新一级列表,UI
            if (this._primaryLevel != null && this._primaryLevel.GetContent() != null)
            {
                this.titleText.text = this._primaryLevel.GetContent().ToUpper();
            }

            if (primaryLevel != null)
            {
                this.InitSecondLevelListView(primaryLevel.SecondLevelFunctionsEntities);
            }
        }


        // 初始化二级列表数据
        private void InitSecondLevelListView(List<SecondLevelFunctionsEntity> secondLevelFunctionsEntities)
        {
            if (secondLevelFunctionsEntities == null)
            {
                Debug.LogError("secondLevelFunctionsEntities is null...");
                return;
            }

            var count = secondLevelFunctionsEntities.Count;
            for (var i = 0; i < count; i++)
            {
                this.InitSecondLevelItemView(secondLevelFunctionsEntities[i], count == (i + 1));
            }
        }

        // 初始化二级列表ItemView
        private void InitSecondLevelItemView(SecondLevelFunctionsEntity secondLevelFunctionsEntity, bool isLastItem)
        {
            if (secondLevelFunctionsEntity == null)
            {
                Debug.LogError("secondLevelFunctionsEntity is null ...");
                return;
            }

            // 二级列表的prefab
            var secondLevelItemPrefab =
                Instantiate(PrefabLoader.LoadSecondItemPrefab(), this.secondLevelListView.transform, true);
            secondLevelItemPrefab.transform.localScale = new Vector2(1, 1);
            secondLevelItemPrefab.transform.SetAsLastSibling();

            UiUtil.ResetPosZTo0(secondLevelItemPrefab);

            // 二级列表Item的脚本
            var secondLevelItemScript = secondLevelItemPrefab.GetComponent<SecondLevelItemScript>();

            // 存储二级列表的脚本
            this._secondLevelBaseUi.Add(secondLevelItemScript);

            // 初始化二级列表的数据
            secondLevelItemScript.InitSecondLevelData(secondLevelFunctionsEntity);

            // 检查是否需要隐藏分割线
            if (isLastItem)
            {
                secondLevelItemScript.HideDividerViewLayout();
            }
        }

        // 刷新UI
        public override void OnRefreshUi()
        {
            // 刷新一级列表,UI
            if (this._primaryLevel != null && this._primaryLevel.GetContent() != null)
            {
                this.titleText.text = this._primaryLevel.GetContent().ToUpper();
            }

            // 刷新二级列表中的所有UI
            foreach (var baseUi in this._secondLevelBaseUi)
            {
                baseUi.OnRefreshUi();
            }
        }

        // 资源释放
        public override void OnRelease()
        {
            foreach (var baseUi in this._secondLevelBaseUi)
            {
                baseUi.OnRelease();
            }

            this._secondLevelBaseUi.Clear();
        }
    }
}