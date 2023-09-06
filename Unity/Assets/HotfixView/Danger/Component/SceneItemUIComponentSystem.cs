using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class SceneItemUIComponentAwakeSystem : AwakeSystem<SceneItemUIComponent>
    {
        public override void Awake(SceneItemUIComponent self)
        {
            self.GameObject = null;
            self.MyUnit = self.GetParent<Unit>();
            self.OnInitUI().Coroutine();
        }
    }


    public class SceneItemUIComponentDestroySystem : DestroySystem<SceneItemUIComponent>
    {
        public override void Destroy(SceneItemUIComponent self)
        {
            if (self.GameObject != null)
            {
                GameObject.Destroy(self.GameObject);
                self.GameObject = null;
            }
        }
    }


    public static class SceneItemUIComponentSystem
    {

        public static async ETTask OnInitUI(this SceneItemUIComponent self)
        {
            int configId = self.MyUnit.ConfigId;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(configId);

            //51 场景怪 有AI 不显示名称
            //52 能量台子 无AI
            //54 场景怪 有AI 显示名称
            //55 宝箱类 无AI
            var path = "";
            if (monsterConfig.MonsterSonType == 52)
            {
                path = ABPathHelper.GetUGUIPath("BaBloodttle/UIEnergyTable");
                self.UIPosition = self.MyUnit.GetComponent<GameObjectComponent>().GameObject.transform.Find("UIPosition");
            }
            else if (monsterConfig.MonsterSonType == 54 || monsterConfig.MonsterSonType == 60 || self.MyUnit.IsChest())
            {
                path = ABPathHelper.GetUGUIPath("Blood/UISceneItem");
                self.UIPosition = self.MyUnit.GetComponent<GameObjectComponent>().GameObject.transform.Find("UIPosition");
            }
            else if (monsterConfig.MonsterSonType == 58 || monsterConfig.MonsterSonType == 59 || monsterConfig.MonsterSonType == 61)
            {
                path = ABPathHelper.GetUGUIPath("Blood/UIEnergyTable");
                self.UIPosition = self.MyUnit.GetComponent<GameObjectComponent>().GameObject.transform.Find("RoleBoneSet/Head");
            }
            GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            self.GameObject = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            self.GameObject.transform.SetParent(UIEventComponent.Instance.BloodText.transform);
            self.GameObject.transform.localScale = Vector3.one;
            
            self.HeadBarUI = self.GameObject.GetComponent<HeadBarUI>();
            self.HeadBarUI.enabled = true;
            self.HeadBarUI.HeadPos = self.UIPosition;
            self.HeadBarUI.HeadBar = self.GameObject;
            self.GameObject.transform.SetAsFirstSibling();
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            //self.GameObject.Get<GameObject>("ImageDi").SetActive(mapComponent.SceneTypeEnum == SceneTypeEnum.LocalDungeon);
            switch (monsterConfig.MonsterSonType)
            {
                case 52:
                    self.InitTableData(self.MyUnit.GetComponent<UnitInfoComponent>().EnergySkillId);
                    break;
                case 54:
                case 55:
                case 56:
                case 57:
                case 60:
                    self.GameObject.Get<GameObject>("Lal_Name").GetComponent<Text>().text = monsterConfig.MonsterName;
                    break;
                case 58:
                    self.GameObject.Get<GameObject>("Lal_Name").GetComponent<Text>().text = monsterConfig.MonsterName;
                    self.GameObject.Get<GameObject>("Lal_Desc").GetComponent<Text>().text = UIHelper.ZhuaPuProToStr(monsterConfig.Parameter[1]);
                    self.GameObject.Get<GameObject>("Lal_Name").GetComponent<Text>().color = new Color(184f / 255f, 255f / 255f, 66f / 255f);
                    break;
                case 59:
                    self.GameObject.Get<GameObject>("Lal_Name").GetComponent<Text>().text = monsterConfig.MonsterName;
                    self.GameObject.Get<GameObject>("Lal_Desc").GetComponent<Text>().text = UIHelper.ZhuaPuProToStr(monsterConfig.Parameter[1]);
                    self.GameObject.Get<GameObject>("Lal_Name").GetComponent<Text>().color = new Color(255f / 255f, 199f / 255f, 66f / 255f);
                    break;
                case 61:
                    self.GameObject.Get<GameObject>("Lal_Name").GetComponent<Text>().text = monsterConfig.MonsterName;
                    self.GameObject.Get<GameObject>("Lal_Desc").GetComponent<Text>().text = string.Empty;
                    break;
                default:
                    break;
            }
        }

        public static void UpdateTurtleAI(this SceneItemUIComponent self)
        {
            //小龟状态切换
        }

        public static  void InitTableData(this SceneItemUIComponent self, int skillId)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);

            self.GameObject.Get<GameObject>("Lal_Name").GetComponent<Text>().text = skillConfig.SkillName;
            self.GameObject.Get<GameObject>("Lal_Desc").GetComponent<Text>().text = skillConfig.SkillDescribe;
        }
    }

}
