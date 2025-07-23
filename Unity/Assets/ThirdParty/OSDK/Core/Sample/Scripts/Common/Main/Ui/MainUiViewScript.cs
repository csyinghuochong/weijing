using System.Collections.Generic;
using UnityEngine;

namespace Douyin.Game
{
    // 首页UiView 脚本
    public class MainUiViewScript : BaseUi
    {
        [Header("主页面一级列表，ListView")] [SerializeField]
        private GameObject primaryListView;

        // 所有一级页面的脚本
        private List<BaseUi> _primaryBaseUi = new List<BaseUi>();

        // header layout script 
        private MainHeaderLayoutScript _mainHeaderLayoutScript;

        public string mainListJsonPath;

        // 初始化首页布局
        public void InitListViewData()
        {
            // 先加载头部布局
            this.InitHeaderView();

            // 首页数据对象
            var mainListEntity = MainListDataManager.Instance.GetMainListEntity();
            Debug.Log("mainListEntity : " + mainListEntity);

            // 一级列表数据
            var primaryLevelList = mainListEntity.PrimaryLevelFunctionsEntities;
            this.InitMainUiListView(primaryLevelList);
        }

        // 加载HeaderView
        private void InitHeaderView()
        {
            // header prefab
            var headerPrefab = Instantiate(PrefabLoader.LoadMainHeaderLayoutPrefab(), this.primaryListView.transform,
                true);
            headerPrefab.transform.localScale = new Vector2(1, 1);
            headerPrefab.transform.SetAsLastSibling();
            
            UiUtil.ResetPosZTo0(headerPrefab);
            
            // header layout script 
            var mainHeaderLayoutScript = headerPrefab.GetComponent<MainHeaderLayoutScript>();

            // save main header layout script
            this._mainHeaderLayoutScript = mainHeaderLayoutScript;

            // 初始化Header 布局
            mainHeaderLayoutScript.Init(this.LanguageSwitchListener, this.ReloadView);
        }

        // 初始化一级列表View
        private void InitMainUiListView(List<PrimaryLevelFunctionsEntity> primaryLevelList)
        {
            if (primaryLevelList == null)
            {
                Debug.LogError("primaryLevelList is null");
                return;
            }

            var count = primaryLevelList.Count;
            for (var i = 0; i < count; i++)
            {
                this.InitMainUiItemView(primaryLevelList[i]);
            }
        }

        // 创建一级列表ItemView
        private void InitMainUiItemView(PrimaryLevelFunctionsEntity primaryLevel)
        {
            if (primaryLevel == null)
            {
                Debug.LogError("primaryLevel is null...");
                return;
            }

            // 1. 加载出主UI的prefab
            // 2. 将加载出的prefab 加载到主页列表ListView中
            var mainItemPrefab = Instantiate(PrefabLoader.LoadMainItemPrefab(), this.primaryListView.transform, true);
            mainItemPrefab.transform.localScale = new Vector2(1, 1);
            mainItemPrefab.transform.SetAsLastSibling();

            UiUtil.ResetPosZTo0(mainItemPrefab);

            // 一级Item脚本对象 
            var primaryLevelItemScript = mainItemPrefab.GetComponent<PrimaryLevelItemScript>();

            // 保存一级页面的脚本
            this._primaryBaseUi.Add(primaryLevelItemScript);

            // 开始初始化一级列表数据
            primaryLevelItemScript.InitSecondLevelData(primaryLevel);
        }

        // 语言切换监听
        private void LanguageSwitchListener(bool isChinese)
        {
            // 刷新header中的UI
            this._mainHeaderLayoutScript.OnRefreshUi();

            // 刷新所有UI
            this.OnRefreshUi();
        }

        // 重新加载view
        private void ReloadView()
        {
            // 资源释放
            this.OnRelease();

            // 资源销毁
            foreach (Transform child in this.primaryListView.transform)
            {
                GameObject.Destroy(child.gameObject);
            }

            // 重新加载
            this.InitListViewData();
        }

        // 刷新UI
        public override void OnRefreshUi()
        {
            foreach (var baseUi in this._primaryBaseUi)
            {
                baseUi.OnRefreshUi();
            }
        }

        // 资源释放
        public override void OnRelease()
        {
            // 释放一级页面UI
            foreach (var baseUi in this._primaryBaseUi)
            {
                baseUi.OnRelease();
            }

            this._primaryBaseUi.Clear();
        }
    }
}