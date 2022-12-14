using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace ET
{
    public static class UICommonHelper
    {

        /// <summary>
        /// 保留两位小数
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ShowFloatValue(float value)
        {
            string svalue = value.ToString("0.##");
            return svalue;
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

        public static void ShowOccIcon(GameObject go, int occ)
        {
            occ = occ == 0 ? 1 : occ;
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PlayerIcon, occ.ToString());
            go.GetComponent<Image>().sprite = sp;
        }

        public static void ShowWeapon(GameObject hero, int occ,  int weaponId)
        {
            GameObject unitModel = hero;
            string weaponPath = "";
            if (weaponId != 0)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(weaponId);
                weaponPath = itemConfig.ItemModelID;
            }
            Transform weaponParent = unitModel.Get<GameObject>("Wuqi001").transform;
            UICommonHelper.DestoryChild(weaponParent.gameObject);
            if (weaponPath == "" || weaponPath == "0")
            {
                //战士武器
                if (occ == 1)
                {
                    weaponPath = "14100002";
                }

                //法师武器
                if (occ == 2)
                {
                    weaponPath = "14100101";
                }
            }
            var path = ABPathHelper.GetItemPath(weaponPath);
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            go.SetActive(true);
            go.transform.parent = weaponParent;
            go.transform.localRotation = Quaternion.Euler(-180, 90, 90);
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
        }

        public static async ETTask ShowHeroSelect(int occ, int weaponId, ETCancellationToken eTCancellation)
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
            Animator animator = hero.GetComponentInChildren<Animator>();
            if (animator != null)
            {
                animator.Play("ShowSelect");
            }
            int delayShowWeapon = 2000;  //毫秒
            if (delayShowWeapon == 0)
            {
                ShowWeapon(hero, occ, weaponId);
                return;
            }
            Transform weaponParent = hero.Get<GameObject>("Wuqi001").transform;
            UICommonHelper.DestoryChild(weaponParent.gameObject);
            bool result = await TimerComponent.Instance.WaitAsync(delayShowWeapon, eTCancellation);
            if (result && hero != null)
            {
                ShowWeapon(hero, occ, weaponId);
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

        public static void ShowItemList(List<RewardItem> rewardItems, GameObject itemNodeList, Entity entity, float scale = 1f, bool showNumber = true, bool showName = false)
        {
            rewardItems.Sort(delegate (RewardItem a, RewardItem b)
            {
                int itemIda = a.ItemID;
                int itemIdb = b.ItemID;
                int quliatya = ItemConfigCategory.Instance.Get(itemIda).ItemQuality;
                int quliatyb = ItemConfigCategory.Instance.Get(itemIdb).ItemQuality;
                if (quliatya == quliatyb)
                {
                    if (itemIda == itemIdb)
                        return b.ItemNum - a.ItemNum;
                    else
                        return itemIda - itemIdb;
                }
                else
                {
                    return quliatyb - quliatya;
                }
            });

            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < rewardItems.Count; i++)
            {
                GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(itemSpace, itemNodeList);
                UI ui_2 = entity.AddChild<UI, string, GameObject>("UICommonItem_" + i, itemSpace);
                UIItemComponent uIItemComponent = ui_2.AddComponent<UIItemComponent>();
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = rewardItems[i].ItemID, ItemNum = rewardItems[i].ItemNum }, ItemOperateEnum.None);
                uIItemComponent.Label_ItemName.SetActive(showName);
                uIItemComponent.Label_ItemNum.SetActive(showNumber);
                itemSpace.transform.localScale = Vector3.one * scale;
            }
        }

        public static void ShowItemList(string itemList, GameObject itemNodeList, Entity entity, float scale = 1f, bool showNumber = true)
        {
            if (string.IsNullOrEmpty(itemList))
            {
                return;
            }
            ShowItemList(ItemHelper.GetRewardItems(itemList), itemNodeList,entity, scale,showNumber);
        }

        public static  void ShowCostItemList(string itemList, GameObject itemNodeList, Entity entity, float scale = 1f)
        {
            if (string.IsNullOrEmpty(itemList))
            {
                return;
            }
            long instanceid = entity.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonCostItem");
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

        public static void ShowSkillItem(GameObject itemObj, GameObject itemParent, Entity entity, int[] skills, ABAtlasTypes aBAtlas)
        {
            for (int i = 0; i < skills.Length; i++)
            {
                GameObject skillItem = GameObject.Instantiate(itemObj);
                UICommonHelper.SetParent(skillItem, itemParent);
                UICommonSkillItemComponent ui_item = entity.AddChild<UICommonSkillItemComponent, GameObject>(skillItem);
                ui_item.OnUpdateUI(skills[i], aBAtlas);
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
                string icon = UIItemHelp.GetAttributeIcon(numberType);
                if (!string.IsNullOrEmpty(icon))
                {
                    Sprite sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PropertyIcon, icon);
                    gameObject.transform.Find("Img_Icon").GetComponent<Image>().sprite = sprite;
                }
                int showType = NumericHelp.GetNumericValueType(numberType);
                string attribute;
                if (showType == 2)
                {
                    attribute = $"{UIItemHelp.GetAttributeName(numberType)} + {numberValue*100}%";
                }
                else {
                    attribute = $"{UIItemHelp.GetAttributeName(numberType)} + {numberValue}";
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

        public static void DOScale(Transform transform, Vector3 vector3, float time)
        {
            //transform.DOScale(new Vector3(1f, 1f, 1f), time / 2).SetEase(Ease.OutCubic).SetDelay(time / 2);
            transform.DOScale(vector3, time).SetEase(Ease.OutCubic);  //.SetDelay(time / 2);
        }

        public static  void DOLocalMove2(Transform transform, Vector3 vector3, float totalTime)
        {
            transform.DOLocalMove(vector3, totalTime).SetEase(Ease.OutCubic);
        }

        public static async ETTask DOLocalMove(Transform transform, Vector3 vector3, float totalTime)
        {
            Vector3 oldPostition = transform.localPosition;
            float passTime = 0;
            float starTime = Time.time;
            while(passTime < totalTime)
            {
                passTime = Time.time - starTime;
                float rate = passTime / totalTime ;
                Vector3 curPostion = rate * (vector3 - oldPostition) + oldPostition;
                transform.transform.localPosition = curPostion;
                await TimerComponent.Instance.WaitFrameAsync();
                if (transform == null)
                {
                    break;
                }
            }
        }

        public static void CrossFadeAlpha(Transform transform, float alpha, float duration)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Transform child = transform.GetChild(i);
                if (child.GetComponent<Text>()!=null)
                {
                    child.GetComponent<Text>().CrossFadeAlpha(alpha, duration, false);
                }
                if (transform.GetComponent<Image>() != null)
                {
                    child.GetComponent<Image>().CrossFadeAlpha(alpha, duration, false);
                }
            }
        }

        //数字转换万
        public static string NumToWString(long num) {

            //超过10万才显示
            if (num >= 100000)
            {
                if (num % 10000 == 0)
                {
                    return (num / 10000).ToString() + "万";
                }
                else {
                    return ((float)num / 10000f).ToString("F2") + "万";
                }
            }
            else {
                return num.ToString();
            }

        }


    }
}
