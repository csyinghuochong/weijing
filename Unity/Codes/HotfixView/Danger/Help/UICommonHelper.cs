using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public static class UICommonHelper
    {

        public static async ETTask AfterPetCreate(Unit unit)
        {
            int skinId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Pet_Skin);
            int configId = unit.GetComponent<UnitInfoComponent>().UnitCondigID;
            PetConfig petConfig = PetConfigCategory.Instance.Get(configId);
            if (skinId == 0)
            {
                skinId = petConfig.Skin[0];
            }
            PetSkinConfig petSkinConfig = PetSkinConfigCategory.Instance.Get(skinId);
            var path = ABPathHelper.GetUnitPath("Pet/" + petSkinConfig.SkinID.ToString());
            GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            go.transform.localPosition = unit.Position;
            go.transform.localRotation = unit.Rotation;
            go.transform.name = unit.Id.ToString();
            unit.AddComponent<EffectViewComponent>();            //添加特效组建
            unit.AddComponent<GameObjectComponent>().GameObject = go;
            unit.AddComponent<AnimatorComponent>();
            unit.AddComponent<HeroTransformComponent>();       //获取角色绑点组件
            unit.AddComponent<FsmComponent>();                 //当前状态组建
            unit.UpdateUIType = HeadBarType.HeroHeadBar;
            unit.AddComponent<HeroHeadBarComponent>();         //血条UI组件
        }

        public static string GetNeedItemDesc(string needitems)
        {
            string itemDesc = "";
            string[] needList = needitems.Split('@');

            for (int i = 0; i < needList.Length; i++)
            {
                string[] itemInfo = needList[i].Split(';');
                int itemId = int.Parse(itemInfo[0]);
                int itemNum = int.Parse(itemInfo[1]);
                ItemConfig itemConfig= ItemConfigCategory.Instance.Get(itemId);
                itemDesc += $"{itemConfig.ItemName} x {itemNum} ";
            }
            return itemDesc;
        }

        public static bool ShowBigMap(int sceneType)
        {
            return sceneType == (int)SceneTypeEnum.MainCityScene
                || sceneType == (int)SceneTypeEnum.TeamDungeon
                 || sceneType == (int)SceneTypeEnum.YeWaiScene
                 || sceneType == (int)SceneTypeEnum.Tower
                  || sceneType == (int)SceneTypeEnum.LocalDungeon;
        }

        public static void ShowOccIcon(GameObject go, int occ)
        {
            occ = occ == 0 ? 1 : occ;
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PlayerIcon, occ.ToString());
            go.GetComponent<Image>().sprite = sp;
        }

        public static void ShowHeroSelect(int occ)
        {
            GameObject parent = GameObject.Find("HeroPosition");
            GameObject hero = null;
            for (int i = 0; i < parent.transform.childCount; i++)
            {
                GameObject gameObject = parent.transform.GetChild(i).gameObject;
                if (occ == (i + 1))
                {
                    hero = gameObject;
                    gameObject.SetActive(true);
                }
                else
                {
                    gameObject.SetActive(false);
                }
            }

            //UIComponent.Instance.MainCamera.fieldOfView += 1;
            //UIComponent.Instance.MainCamera.fieldOfView -= 1;
            int mask = UIComponent.Instance.MainCamera.cullingMask;
            UIComponent.Instance.MainCamera.cullingMask = mask;
            Log.ILog.Debug("cullingMask_1");

            Animator animator = hero.GetComponentInChildren<Animator>();
            if (animator != null)
            {
                animator.Play("ShowSelect");
            }
        }
        public static void UpdateAllNpcBar(Unit self)
        {
            float curTime = Time.time;
            List<Unit> units = self.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                if (curTime <= unit.UpdateUITime)
                {
                    continue;
                }
                if (unit.UpdateUIType != HeadBarType.NpcHeadBarUI)
                {
                    continue;
                }
                unit.UpdateUITime = curTime;
                NpcHeadBarComponent npcHeadBarComponent = unit.GetComponent<NpcHeadBarComponent>();
                npcHeadBarComponent?.OnUpdateNpcTalk(self);
                continue;
            }
        }

        //public static void UpdaterAllHeadBar(Unit self)
        //{
        //    float curTime = Time.time;
        //    Entity[] units = self.GetParent<UnitComponent>().GetAll();
        //    for (int i = 0; i < units.Length; i++)
        //    {
        //        Unit unit = units[i] as Unit;
        //        if (curTime <= unit.UpdateUITime)
        //        {
        //            continue;
        //        }
        //        unit.UpdateUITime = curTime;
        //        if (unit.UpdateUIType == HeadBarType.TransferUI)
        //        { 
        //            TransferUIComponent transferUIComponent = units[i].GetComponent<TransferUIComponent>();
        //            transferUIComponent.LateUpdate();
        //            continue;
        //        }
        //        if (unit.UpdateUIType == HeadBarType.NpcHeadBarUI)
        //        {
        //            NpcHeadBarComponent npcHeadBarComponent = unit.GetComponent<NpcHeadBarComponent>();
        //            npcHeadBarComponent.LateUpdate();
        //            continue;
        //        }
        //        if (unit.UpdateUIType == HeadBarType.DropUI)
        //        {
        //            DropUIComponent dropUIComponent = unit.GetComponent<DropUIComponent>();
        //            dropUIComponent.LateUpdate();
        //            continue;
        //        }
        //        if (unit.UpdateUIType == HeadBarType.HeroHeadBar)
        //        {
        //            HeroHeadBarComponent heroHeadBarComponent = unit.GetComponent<HeroHeadBarComponent>();
        //            heroHeadBarComponent.LateUpdate();
        //            continue;
        //        }
        //        if (unit.UpdateUIType == HeadBarType.SceneItemUI)
        //        {
        //            UISceneItemComponent uISceneItemComponent = unit.GetComponent<UISceneItemComponent>();
        //            uISceneItemComponent.LateUpdate();
        //            continue;
        //        }
        //    }
        //}

        public static void ShowItemList(List<RewardItem> itemList, GameObject itemNodeList, Entity entity, float scale = 1f, bool showNumber = true)
        {
            string iteminfos = "";
            for (int i = 0; i < itemList.Count; i++)
            {
                iteminfos += $"{itemList[i].ItemID};{itemList[i].ItemNum}@";
            }
            if (iteminfos.Length > 0)
            {
                iteminfos = iteminfos.Substring(0, iteminfos.Length - 1);
            }
            ShowItemList(iteminfos, itemNodeList, entity, scale, showNumber).Coroutine();
        }

        public static async ETTask ShowItemList(string itemList, GameObject itemNodeList, Entity entity, float scale = 1f, bool showNumber = true)
        {
            if (string.IsNullOrEmpty(itemList))
            {
                return;
            }
            long instanceid = entity.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != entity.InstanceId)
            {
                return;
            }
            string[] rewardItems = itemList.Split('@');
            for (int i = 0; i < rewardItems.Length; i++)
            {
                string[] itemInfo = rewardItems[i].Split(';');
                GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(itemSpace, itemNodeList);
                UI ui_2 = entity.AddChild<UI, string, GameObject>("UICommonItem_" + i, itemSpace);
                UIItemComponent uIItemComponent = ui_2.AddComponent<UIItemComponent>();
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = int.Parse(itemInfo[0]), ItemNum = int.Parse(itemInfo[1]) }, ItemOperateEnum.None);
                uIItemComponent.Label_ItemName.SetActive(false);
                uIItemComponent.Label_ItemNum.SetActive(showNumber);
                itemSpace.transform.localScale = Vector3.one * scale;
            }
        }


        public static async ETTask ShowCostItemList(string itemList, GameObject itemNodeList, Entity entity, float scale = 1f)
        {
            if (string.IsNullOrEmpty(itemList))
            {
                return;
            }
            long instanceid = entity.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonCostItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != entity.InstanceId)
            {
                return;
            }
            string[] rewardItems = itemList.Split('@');
            for (int i = 0; i < rewardItems.Length; i++)
            {
                string[] itemInfo = rewardItems[i].Split(';');
                GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(itemSpace, itemNodeList);
                UICommonCostItemComponent uIItemComponent = entity.AddChild<UICommonCostItemComponent, GameObject>(itemSpace);
                uIItemComponent.UpdateItem(int.Parse(itemInfo[0]), int.Parse(itemInfo[1]));
                itemSpace.transform.localScale = Vector3.one * scale;
            }
        }

        public static void ShowAttributeItemList(string itemList, GameObject itemNodeList, GameObject attributeItem )
        {
            string[] attributeinfos = itemList.Split('@');
            for (int i = 0; i < attributeinfos.Length; i++)
            {
                if (string.IsNullOrEmpty(attributeinfos[i]))
                {
                    continue;
                }
                string[] attributeInfo = attributeinfos[i].Split(';');
                int numberType = int.Parse(attributeInfo[0]);
                float numberValue = float.Parse(attributeInfo[1]);
                GameObject gameObject = GameObject.Instantiate(attributeItem);
                gameObject.SetActive(true);
                SetParent(gameObject, itemNodeList);
                Sprite sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PropertyIcon, ItemViewHelp.GetAttributeIcon(numberType));
                gameObject.transform.Find("Img_Icon").GetComponent<Image>().sprite = sprite;

                int showType = NumericHelp.GetNumericValueType(numberType);
                string attribute;
                if (showType == 2)
                {
                    attribute = $"{ItemViewHelp.GetAttributeName(numberType)} + {numberValue*100}%";
                }
                else {
                    attribute = $"{ItemViewHelp.GetAttributeName(numberType)} + {numberValue}";
                }

                gameObject.transform.Find("Lab_ProTypeValue").GetComponent<Text>().text = attribute;
            }
        }

        public static void SetParent( GameObject son, GameObject parent )
        {
            if (son == null || parent == null)
                return;
            son.transform.SetParent(parent.transform);
            son.transform.localPosition = Vector3.zero;
            son.transform.localScale = Vector3.one;
        }

        public static void DestoryChild(GameObject go)
        {
            if (go == null)
                return;

            for (int i = go.transform.childCount - 1; i >= 0; i--)
            {
                GameObject.Destroy(go.transform.GetChild(i).gameObject);
            }
        }

        public static void SetImageGray(GameObject obj, bool val)
        {
            if (val)
            {
                Material mat = ResourcesComponent.Instance.LoadAsset<Material>(ABPathHelper.GetMaterialPath("UI_Hui"));
                obj.GetComponent<Image>().material = mat;
            }
            else
            {
                obj.GetComponent<Image>().material = null;
            }
        }

        //传入值显示名称
        public static string GetProName(int proID) {

            if (proID >= 10000) {
                proID = (int)(proID / 100);
            }

            string returnName = "";

            switch (proID) {

                case 1002:
                    returnName = "血量";
                    break;
                case 1003:
                    returnName = "最低攻击";
                    break;
                case 1004:
                    returnName = "最高攻击";
                    break;
                case 1005:
                    returnName = "最低防御";
                    break;
                case 1006:
                    returnName = "最高防御";
                    break;
                case 1007:
                    returnName = "最低魔防";
                    break;
                case 1008:
                    returnName = "最高魔防";
                    break;

                case 1051:
                    returnName = "力量";
                    break;

                case 1052:
                    returnName = "敏捷";
                    break;

                case 1053:
                    returnName = "智力";
                    break;

                case 1054:
                    returnName = "耐力";
                    break;

                case 1055:
                    returnName = "体质";
                    break;
            }
            return returnName;

        }

        //传入宠物品质显示文字
        public static string GetPetQualityName(int quality) {

            switch (quality) {

                case 1:
                    return "大众";
                    //break;
                case 2:
                    return "优秀";
                    //break;
                case 3:
                    return "百里挑一";
                    //break;
                case 4:
                    return "千载难逢";
                    //break;
                case 5:
                    return "万众瞩目";
                    //break;
            }

            return "";

        }

        //根据品质返回一个Color
        public static Color QualityReturnColor(int ItenQuality)
        {
            Color color = new Color(1, 1, 1);
            switch (ItenQuality)
            {
                case 1:
                    color = new Color(1, 1, 1);
                    break;

                case 2:
                    color = new Color(0, 1, 0);
                    break;
                case 3:
                    color = new Color(0.047f, 0.76f, 0.847f);
                    break;

                case 4:
                    color = new Color(0.937f, 0.5f, 1.0f);
                    break;
                case 5:
                    color = new Color(1, 0.49f, 0);
                    break;
                case 6:
                    color = new Color(0.80f, 0.49f, 0.19f);
                    break;
            }
            return color;
        }

    }
}
