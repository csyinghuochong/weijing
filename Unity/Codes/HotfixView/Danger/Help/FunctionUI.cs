

using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

namespace ET
{
    //UI通用脚本
    public class FunctionUI
    {

        public bool SkillMoveStatus;
        public string SkillMoveValue_Initial;
        public string SkillMoveValue_End;
        public Scene ZoneScene;

        //实例化自身
        private static FunctionUI _instance;
        public static FunctionUI GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FunctionUI();
            }
            return _instance;
        }


        //传入随机范围,生成一个随机数(平均概率)
        public int ReturnRamdomValueInt(int randomMinValue, int randomMaxValue)
        {

            int randomChaValue = randomMaxValue - randomMinValue;
            float randomRangeValue_Now = UnityEngine.Random.value;

            //System.Math.Round
            //计算最终值
            int retunrnValue = (int)(System.Math.Round(randomMinValue + randomChaValue * randomRangeValue_Now));
            return retunrnValue;
        }

        public string GetUIPath(string uitype)
        {
            string uipath;
            //不需要bindingflags了.这都是public.
            //FieldInfo[] allFieldInfo = (typeof(UIType)).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Static);
            //for (int i = 0; i < allFieldInfo.Length; i++)
            //{
            //    if (allFieldInfo[i].Name == uitype)
            //    {
            //        return allFieldInfo[i].GetValue(null).ToString();
            //    }
            //}

            UIType.keyValuePairs.TryGetValue(uitype, out uipath);
            return uipath;
        }


        public bool OpenFunctionUI(Scene zoneScene, int npcid, int functionid)
        {
            if (functionid < 10)
            {
                return false;
            }

            FuntionConfig funtionOpenConfig = FuntionConfigCategory.Instance.Get(functionid);
            bool functionOn = FunctionHelp.Instance.CheckFuncitonOn(zoneScene, funtionOpenConfig);
            if (!functionOn)
            {
                Log.Debug("功能未开启： " + functionid);
                return false;
            }

            string uipath = GetUIPath(funtionOpenConfig.Name);
            if (uipath == "")
            {
                Log.Debug("UIType未配置正确： " + functionid);
                return false;
            }
            //if (functionid != 1003 && functionid != 1004)
            //{
            //    await UIHelper.Create(zoneScene, uipath);
            //    return true;
            //}

            //npc商店
            ZoneScene = zoneScene;
            UnitComponent unitComponent = zoneScene.CurrentScene().GetComponent<UnitComponent>();
            CameraComponent cameraComponent = zoneScene.CurrentScene().GetComponent<CameraComponent>();

            UI uimain = UIHelper.GetUI(zoneScene, UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().JoystickMove.SetActive(false);
            cameraComponent.SetBuildEnter(TaskHelper.GetNpcByConfigId(zoneScene, npcid), () => { OnBuildEnter(npcid).Coroutine(); });
            return true;
        }

        public int GetFunctionID(string uitype)
        {
            List<FuntionConfig> funtionConfigs = FuntionConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < funtionConfigs.Count; i++)
            {
                if (funtionConfigs[i].Name == uitype)
                {
                    return funtionConfigs[i].Id;
                }
            }
            return 0;
        }

        //打开对应功能
        public async ETTask OnBuildEnter(int npcid)
        {
            int FunctionId = NpcConfigCategory.Instance.Get(npcid).NpcType;
            FuntionConfig funtionOpenConfig = FuntionConfigCategory.Instance.Get(FunctionId);

            UI uimain = UIHelper.GetUI(ZoneScene, UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().JoystickMove.SetActive(true);

            UIHelper.CurrentNpc = npcid;
            UIHelper.CurrentUI = GetUIPath(funtionOpenConfig.Name);
            //创建UI
            await UIHelper.Create(ZoneScene, GetUIPath(funtionOpenConfig.Name));
        }

        //传入X值返回实际X值
        public float ReturnScreen_X(float Value_X)
        {
            Value_X = Value_X / 1366 * Screen.width;
            return Value_X;
        }

        //传入屏幕的百分比位置，显示当前对应的位置
        public Vector3 RetrunScreenV2(Vector3 v3)
        {
            //获取当前屏幕的坐标
            int screen_X = Screen.width;
            int screen_Y = Screen.height;
            //Debug.Log("screen_X = " + screen_X + ";" + screen_Y);
            Vector3 UI_V3 = new Vector3();

            UI_V3.x = v3.x * 1366 - 0.5f * screen_X;
            UI_V3.y = v3.y * 1366 * screen_Y / screen_X - 0.5f * screen_Y;
            return UI_V3;
        }

        //传入Y值返回实际X值
        public float ReturnScreen_Y(float Value_Y)
        {
            //int screen_X = Screen.width;
            //int screen_Y = Screen.height;
            //Value_Y = Value_Y / 1366 * screen_Y / screen_X * Screen.height;
            Value_Y = Value_Y / 768 * Screen.height;
            return Value_Y;
        }

        public Vector3 UIMoveIconPosition(float x, float y)
        {
            x = x / Screen.width * 1366;
            int screen_X = Screen.width;
            int screen_Y = Screen.height;
            y = y / Screen.height * 1366 * screen_Y / screen_X;
            //y = y / Screen.height * 768;
            Vector2 v3 = new Vector3(x, y, 0);
            //Debug.Log("Screen.width = " + Screen.width + "Screen.height = " + Screen.height);
            return v3;
        }

        /// <summary>
        /// 世界坐标转换成当前坐标
        /// </summary>
        /// <returns></returns>
        public Vector3 WorldPosiToUIPosi(Vector3 worldVec3, Camera uiCamera)
        {
            Vector3 vv = new Vector3(worldVec3.x, worldVec3.y, worldVec3.z);
            Vector3 screenPos = Camera.main.WorldToScreenPoint(vv);
            Vector3 position = uiCamera.ScreenToWorldPoint(screenPos);
            return position;
        }

        //判定道具是否移入到技能栏中  moveType(0:表示道具类型  1：表示技能类型)   ifExchange 表示检测到技能栏有相同ID是否交换,如果不交换则后者替换前者后,前者清空
        public bool UI_MoveToMainSkill(string moveType, bool ifExchange = true)
        {
            if (SkillMoveStatus)
            {
                bool moveStatus = true;
                //判定交换失败条件
                if (SkillMoveValue_Initial == "0" && SkillMoveValue_Initial == "")
                {
                    moveStatus = false;
                }

                if (SkillMoveValue_End == "")
                {
                    moveStatus = false;
                }

                //Debug.Log("Game_PublicClassVar.Get_game_PositionVar.SkillMoveValue_Initial = " + Game_PublicClassVar.Get_game_PositionVar.SkillMoveValue_Initial);
                if (SkillMoveValue_Initial == "0")
                {
                    moveStatus = false;
                    //清空值
                    SkillMoveStatus = false;
                    SkillMoveValue_Initial = "";
                    SkillMoveValue_End = "";
                    return false;
                }

                //UIMain uimain = Game.Scene.GetComponent<UIComponent>().Get(UIDef.UIMain.Name) as UIMain;
                //for (int i = 1; i <= 8; i++)
                //{
                //    GameObject skillObj = uimain.m_roseSkillSet.transform.Find("UI_MainRoseSkill_" + i).gameObject;
                //    string endSkillID = "0";
                //    if (GamePositionVar.GetInstance().SkillMoveValue_End != ""
                //        && GamePositionVar.GetInstance().SkillMoveValue_End != "0"
                //        && GamePositionVar.GetInstance().SkillMoveValue_End != null)
                //    {
                //        endSkillID = RoleSkillController.Instance.GetSkillIdByPosition(int.Parse(GamePositionVar.GetInstance().SkillMoveValue_End)).ToString();
                //    }
                //    //Game_PublicClassVar.Get_function_DataSet.DataSet_ReadData("MainSkillUI_" + Game_PublicClassVar.Get_game_PositionVar.SkillMoveValue_End, "ID", Game_PublicClassVar.Get_wwwSet.RoseID, "RoseConfig");

                //    UIRoleSkillGrid skillGrid = skillObj.GetComponent<ILMonoBehaviour>().GetScript<UIRoleSkillGrid>();
                //    if (skillGrid.SkillID == GamePositionVar.GetInstance().SkillMoveValue_Initial || skillGrid.SkillID == endSkillID)
                //    {
                //        //获取技能是否有CD
                //        if (skillGrid.skillCDStatus)
                //        {
                //            moveStatus = false;
                //            //Game_PublicClassVar.Get_function_UI.GameHint("技能CD中,不能移动技能");
                //            string langStrHint = Game_PublicClassVar.Get_gameSettingLanguge.LoadLocalizationHint("hint_402");
                //            Game_PublicClassVar.Get_function_UI.GameGirdHint_Front(langStrHint);
                //        }
                //    }
                //}

                switch (moveType)
                {
                    //判定道具是否为消耗品
                    case "0":
                        ItemConfig itemConf = ItemConfigCategory.Instance.Get(int.Parse(SkillMoveValue_Initial));
                        string itemType = itemConf.ItemType.ToString();
                        if (itemType != "1")
                        {
                            moveStatus = false;
                        }
                        //判定是否有技能
                        string itemSkillID = itemConf.SkillID;
                        if (itemSkillID == "0")
                        {
                            moveStatus = false;
                        }
                        break;

                    //技能,不做处理（后期需要判定是否为被动技能）
                    case "1":

                        break;
                }

                //写入快捷键的值
                if (moveStatus)
                {
                    //SkillSetComponent.SetSkillIdByPosition(int.Parse(SkillMoveValue_End), int.Parse(SkillMoveValue_Initial));
                }
            }

            //清空值
            SkillMoveStatus = false;
            SkillMoveValue_Initial = "";
            SkillMoveValue_End = "";
            return true;
        }

        //显示属性名称
        public string GetProName(string proType)
        {

            string proName = "";

            switch (proType)
            {
                case "10":
                    proName = "生命值";
                    break;
                case "11":
                    proName = "物理攻击";
                    break;
                case "14":
                    proName = "魔法攻击";
                    break;
                case "17":
                    proName = "物理防御";
                    break;
                case "20":
                    proName = "魔法防御";
                    break;
                case "30":
                    proName = "暴击";
                    break;
                case "31":
                    proName = "命中";
                    break;
                case "32":
                    proName = "闪避";
                    break;
                case "33":
                    proName = "物理免伤";
                    break;
                case "34":
                    proName = "魔法免伤";
                    break;
                case "35":
                    proName = "移动速度";
                    break;
                case "36":
                    proName = "伤害减免";
                    break;
                case "50":
                    proName = "血量百分比";
                    break;
                case "51":
                    proName = "物攻百分比";
                    break;
                case "52":
                    proName = "魔攻百分比";
                    break;
                case "53":
                    proName = "物防百分比";
                    break;
                case "54":
                    proName = "魔防百分比";
                    break;
                case "101":
                    proName = "格挡值";
                    break;
                case "111":
                    proName = "重击概率";
                    break;
                case "112":
                    proName = "重击附加伤害值";
                    break;
                case "121":
                    proName = "每次普通攻击附加的伤害值";
                    break;
                case "131":
                    proName = "忽视目标防御值";
                    break;
                case "132":
                    proName = "忽视目标魔防值";
                    break;
                case "133":
                    proName = "忽视目标百分比防御值";
                    break;
                case "134":
                    proName = "忽视目标百分比魔防值";
                    break;
                case "141":
                    proName = "吸血概率";
                    break;
                case "151":
                    proName = "法术反击";
                    break;
                case "152":
                    proName = "攻击反击";
                    break;
                case "161":
                    proName = "韧性";
                    break;
                case "201":
                    proName = "初始暴击等级";
                    break;
                case "202":
                    proName = "初始韧性等级";
                    break;
                case "203":
                    proName = "初始命中等级";
                    break;
                case "204":
                    proName = "初始闪避等级";
                    break;
                case "301":
                    proName = "光抗性";
                    break;
                case "302":
                    proName = "暗抗性";
                    break;
                case "303":
                    proName = "火抗性";
                    break;
                case "304":
                    proName = "水抗性";
                    break;
                case "305":
                    proName = "电抗性";
                    break;
                case "321":
                    proName = "野兽攻击抗性";
                    break;
                case "322":
                    proName = "人物攻击抗性";
                    break;
                case "323":
                    proName = "恶魔攻击抗性";
                    break;
                case "401":
                    proName = "经验加成";
                    break;
                case "402":
                    proName = "金币加成";
                    break;
                case "403":
                    proName = "洗炼极品掉落";
                    break;
                case "404":
                    proName = "隐藏属性出现概率";
                    break;
                case "405":
                    proName = "装备上的宝石槽位出现概率";
                    break;

            }
            return proName;
        }

        //在一个父节点循环创建子物体（创建的物体,创建的父节点,需要生成的道具列表）
        public void Common_2_CreateSonObj(GameObject createObj, GameObject parObj, string itemStr, string itemShowType = "1")
        {
            string[] itemList = itemStr.Split(';');
            if (itemList[0] != "" && itemList[0] != "0")
            {
                for (int i = 0; i < itemList.Length; i++)
                {
                    string itemID = itemList[i].Split(',')[0];
                    string itemNum = itemList[i].Split(',')[1];

                    GameObject huishouObj = (GameObject)MonoBehaviour.Instantiate(createObj);
                    //huishouObj.GetComponent<UI_Common_ItemIcon_2>().ItemID = itemID;
                    //huishouObj.GetComponent<UI_Common_ItemIcon_2>().NeedItemNum = int.Parse(itemNum);
                    //huishouObj.GetComponent<UI_Common_ItemIcon_2>().ItemShowType = itemShowType;
                    huishouObj.transform.SetParent(parObj.transform);
                    huishouObj.transform.localScale = new Vector3(1, 1, 1);
                }
            }
        }

        //传入值获取属性名称
        public string ReturnEquipNeedPropertyName(string proprety)
        {

            string propertyName = "";
            switch (proprety)
            {

                case "1":
                    propertyName = "攻击";
                    break;

                case "2":
                    propertyName = "物防";
                    break;

                case "3":
                    propertyName = "魔防";
                    break;
            }
            return propertyName;
        }

        //获取当前分辨率小界面的缩放比
        public float ReturnScreenScalePro()
        {

            //获取当前屏幕的坐标
            float screen_X = Screen.width;
            float screen_Y = Screen.height;
            //Debug.Log("screen_X = " + screen_X + "; screen_Y = " + screen_Y);

            float scale_Y = screen_Y / 768;
            //Debug.Log("scale_Y = " + scale_Y);

            float scaleValue_X = 1366 * scale_Y;
            float scalePro = scaleValue_X / screen_X;
            //Debug.Log("scalePro = " + scalePro + "scaleValue_X = " + scaleValue_X);
            return scalePro;

        }

        //根据品质返回一个Color
        public Color QualityReturnColor(int ItenQuality)
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

        public BagInfo GetEquipByPositon(int weizhi)
        {
            List<BagInfo> equiplist = new List<BagInfo>();
            if (equiplist == null)
                return null;
            for (int i = 0; i < equiplist.Count; i++)
            {
                int itemid = equiplist[i].ItemID;
                ItemConfig itemconf = ItemConfigCategory.Instance.Get(itemid);

                int position = this.ReturnEquipSpaceNum(itemconf.ItemSubType);
                if (weizhi == position)
                {
                    return equiplist[i];
                }
            }
            return null;
        }

        //传入UI坐标值,显示当前装备在左边还是右边
        public Vector3 UITipsScreen_DuiBi(Vector3 v2)
        {

            Vector3 vec3 = new Vector3();
            float v3_X = v2.x;
            float v3_Y = v2.y;
            if (v2.x >= (Screen.width / 2))
            {
                v3_X = v3_X - 550.0f * Screen.width / 1366;
            }
            else
            {
                v3_X = v3_X + 550.0f * Screen.width / 1366;
            }
            v3_X = v3_X / Screen.width * 1366;
            int screen_X = Screen.width;
            int screen_Y = Screen.height;
            v3_Y = v3_Y / Screen.height * 1366 * screen_Y / screen_X;
            //v3_Y = v3_Y / Screen.height * 768;
            vec3 = new Vector3(v3_X, v3_Y, 0);
            //vec3 = RetrunScreenV2(vec3);
            return vec3;

        }

        //传入装备类型返回对应的角色装备格子
        public int ReturnEquipSpaceNum(int equipType)
        {
            int equipSpaceNum = 0;
            switch (equipType)
            {
                //武器
                case 1:
                    equipSpaceNum = 1;
                    break;
                //衣服
                case 2:
                    equipSpaceNum = 2;
                    break;
                //护符
                case 3:
                    equipSpaceNum = 3;
                    break;
                //灵石
                case 4:
                    equipSpaceNum = 4;
                    break;
                //饰品
                case 5:
                    equipSpaceNum = 5;
                    break;
                //鞋子
                case 6:
                    equipSpaceNum = 8;
                    break;
                //裤子
                case 7:
                    equipSpaceNum = 9;
                    break;
                //腰带
                case 8:
                    equipSpaceNum = 10;
                    break;
                //手镯
                case 9:
                    equipSpaceNum = 11;
                    break;
                //头盔
                case 10:
                    equipSpaceNum = 12;
                    break;
                //项链
                case 11:
                    equipSpaceNum = 13;
                    break;

            }
            return equipSpaceNum;
        }

        //检测字符内是否有特殊字符
        public bool IfSpecialStr(string str)
        {

            bool bl_exist = false;
            foreach (char c in str)
            {
                if ((!char.IsLetter(c)) && (!char.IsNumber(c))) //既不是字母又不是数字的就认为是特殊字符
                { bl_exist = true; }
            }

            if (bl_exist)
            {
                Debug.Log("存在特殊字符");
            }
            return bl_exist;
        }

        //循环删除目标物体下的所有Obj
        public void DestoryTargetObj(GameObject targetObj)
        {

            for (int i = 0; i < targetObj.transform.childCount; i++)
            {
                GameObject go = targetObj.transform.GetChild(i).gameObject;
                MonoBehaviour.Destroy(go);
            }
        }

        public string ItemQualityLine(int ItemQuality)
        {
            return $"QuaDiline_{ItemQuality}";
        }

        public string ItemQualityBack(int ItemQuality)
        {
            return $"QuaDi_{ItemQuality}";
        }

        //根据品质返回品质字符串
        //根据道具品质返回对应的品质框
        //ItemQuality  道具品质
        public string ItemQualiytoPath(int ItemQuality)
        {
            string path = "";
            switch (ItemQuality)
            {
                case 1:
                    path = "ItemQuality_1";
                    break;
                case 2:
                    path = "ItemQuality_2";
                    break;
                case 3:
                    path = "ItemQuality_3";
                    break;
                case 4:
                    path = "ItemQuality_4";
                    break;
                case 5:
                    path = "ItemQuality_5";
                    break;
                case 6:
                    path = "ItemQuality_6";
                    break;
            }

            return path;
        }

        //传入道具ID显示名称及品质颜色
        public void ItemObjShowName(GameObject itemObj, int itemID)
        {
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(itemID);
            itemObj.GetComponent<Text>().text = itemCof.ItemName;
            itemObj.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemCof.ItemQuality);
        }

        //传入道具ID显示道具图标
        public async ETTask ItemShowIcon(GameObject itemShowPar,ET.UI parUI,BagInfo bagInfo,ItemOperateEnum itemOperateEnum, bool ifShowName = true,float size = 1) {

            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            GameObject go = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(go, itemShowPar);
            UI ItemUI = parUI.AddChild<UI, string, GameObject>( "XiLianItem", go);
            ItemUI.AddComponent<UIItemComponent>();
            ItemUI.GetComponent<UIItemComponent>().Label_ItemName.SetActive(ifShowName);
            ItemUI.GameObject.transform.localScale = Vector3.one * size;
            ItemUI.GetComponent<UIItemComponent>().UpdateItem(bagInfo, itemOperateEnum);
        }

    }
}
