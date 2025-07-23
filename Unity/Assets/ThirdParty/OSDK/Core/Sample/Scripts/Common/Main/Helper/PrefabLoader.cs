using UnityEngine;

namespace Douyin.Game
{
    public static class PrefabLoader
    {
        #region 主页面Item prefab路径

        // 主页面一级列表布局
        private const string MainItemPath = "Prefabs/PrimaryLevelItem";

        // 主页面二级列表布局
        private const string SecondLevelItemPath = "Prefabs/SecondLevelItem";

        // 主页面三级列表布局
        private const string ThirdLevelTextItemPath = "Prefabs/ThirdLevelItem";

        // 输入框类型的三级列表
        private const string ThirdLevelInputItemPath = "Prefabs/ThirdLevelInputItem";
        
        //红点文本类型的三级列表
        private const string ThirdLevelRedPointTextItemPath = "Prefabs/ThirdLevelRedPointTextItem";

        // 首页顶部布局路径
        private const string MainHeaderLayoutPath = "Prefabs/MainHeaderLayout";

        #endregion

        // 详情页面布局路径
        private const string DetailItemViewPath = "Prefabs/DetailItemView";

        // 下拉选择详情页面布局路径
        private const string DetailSelectItemViewPath = "Prefabs/DetailSelectItemView";

        // toast 布局路径
        private const string ToastLayoutPath = "Prefabs/ToastLayout";
        private const string DialogPath = "Prefabs/Dialog";

        // 公用的Canvas
        private const string CommonCanvasPath = "Prefabs/CommonCanvas";

        // 主桌面
        private const string MainDeskTopPath = "Prefabs/MainUICanvas";

        // demo中提醒布局
        private const string PromptPath = "Prefabs/PromptLayout";

        // 邮件系统
        private const string MailUiPath = "Prefabs/MailUIPrefab";

        // 邮件列表Item
        private const string MailListItem = "Prefabs/MailListItemLayout";

        // 邮件详情页，游戏工具Item
        private const string MailGameToolsItem = "Prefabs/GameToolsItem";

        public static GameObject LoadMailGameToolsItem()
        {
            return LoadPrefabGameObjectByResource(MailGameToolsItem);
        }

        public static GameObject LoadMailListItem()
        {
            return LoadPrefabGameObjectByResource(MailListItem);
        }

        public static GameObject LoadMailUiPrefab()
        {
            return LoadPrefabGameObjectByResource(MailUiPath);
        }

        public static GameObject LoadPromptPrefab()
        {
            return LoadPrefabGameObjectByResource(PromptPath);
        }

        // 加载主页面
        public static GameObject LoadMainDeskTopPrefab()
        {
            return LoadPrefabGameObjectByResource(MainDeskTopPath);
        }

        // 加载主页面Item 的prefab
        public static GameObject LoadMainItemPrefab()
        {
            return LoadPrefabGameObjectByResource(MainItemPath);
        }


        // 加载主页面二级列表Item的 prefab
        public static GameObject LoadSecondItemPrefab()
        {
            return LoadPrefabGameObjectByResource(SecondLevelItemPath);
        }

        // 加载主页面三级列表红点文本类型Item的 prefab
        public static GameObject LoadThirdRedPointTextItemPrefab()
        {
            return LoadPrefabGameObjectByResource(ThirdLevelRedPointTextItemPath);
        }
        
        // 加载主页面三级列表文本类型Item的 prefab
        public static GameObject LoadThirdTextItemPrefab()
        {
            return LoadPrefabGameObjectByResource(ThirdLevelTextItemPath);
        }

        // 加载输入框类型三级列表输入框类型Item的 prefab
        public static GameObject LoadThirdInputItemPrefab()
        {
            return LoadPrefabGameObjectByResource(ThirdLevelInputItemPath);
        }

        // 首页头部布局的 prefab
        public static GameObject LoadMainHeaderLayoutPrefab()
        {
            return LoadPrefabGameObjectByResource(MainHeaderLayoutPath);
        }

        // 加载详情页itemView的 prefab
        public static GameObject LoadDetailItemViewPrefab()
        {
            return LoadPrefabGameObjectByResource(DetailItemViewPath);
        }

        // 加载详情页selectItemView的 prefab
        public static GameObject LoadDetailSelectItemViewPrefab()
        {
            return LoadPrefabGameObjectByResource(DetailSelectItemViewPath);
        }

        // 加载toast布局的prefab
        public static GameObject LoadToastLayoutPrefab()
        {
            return LoadPrefabGameObjectByResource(ToastLayoutPath);
        }
        
        // 加载dialog布局的prefab
        public static GameObject LoadDialogPrefab()
        {
            return LoadPrefabGameObjectByResource(DialogPath);
        }

        // 加载通用canvas 的prefab
        public static GameObject LoadCommonCanvasPrefab()
        {
            return LoadPrefabGameObjectByResource(CommonCanvasPath);
        }

        // 通过Resource 加载prefab的GameObject
        private static GameObject LoadPrefabGameObjectByResource(string path)
        {
            return Resources.Load<GameObject>(path);
        }
    }
}