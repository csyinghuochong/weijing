using ET;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [ObjectSystem]
    public class SceneItemUIComponentDestroySystem : DestroySystem<SceneItemUIComponent>
    {
        public override void Destroy(SceneItemUIComponent self)
        {
            if (self.HeadBar != null)
            {
                GameObject.Destroy(self.HeadBar);
                self.HeadBar = null;
            }
        }
    }

    [ObjectSystem]
    public class SceneItemUIComponentAwakeSystem : AwakeSystem<SceneItemUIComponent>
    {
        public override void Awake(SceneItemUIComponent self)
        {
            self.HeadBar = null;
            self.MyUnit = self.GetParent<Unit>();
            self.UICamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
            self.MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();

            self.OnInitUI().Coroutine();
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
                path = ABPathHelper.GetUGUIPath("Battle/UIEnergyTable");
                self.UIPosition = self.MyUnit.GetComponent<GameObjectComponent>().GameObject.transform.Find("UIPosition");
            }
            else if (monsterConfig.MonsterSonType == 54 || self.MyUnit.IsChest())
            {
                path = ABPathHelper.GetUGUIPath("Battle/UISceneItem");
                self.UIPosition = self.MyUnit.GetComponent<GameObjectComponent>().GameObject.transform.Find("UIPosition");
            }
            else if (monsterConfig.MonsterSonType == 58 || monsterConfig.MonsterSonType == 59)
            {
                path = ABPathHelper.GetUGUIPath("Battle/UIEnergyTable");
                self.UIPosition = self.MyUnit.GetComponent<GameObjectComponent>().GameObject.transform.Find("RoleBoneSet/Head");
            }
            GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            self.HeadBar = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            self.HeadBar.transform.SetParent(UIEventComponent.Instance.UILayers[(int)UILayer.Blood]);
            self.HeadBar.transform.localScale = Vector3.one;
            
            if (self.HeadBar.GetComponent<HeadBarUI>() == null)
            {
                self.HeadBar.AddComponent<HeadBarUI>();
            }
            self.HeadBarUI = self.HeadBar.GetComponent<HeadBarUI>();
            self.HeadBarUI.HeadPos = self.UIPosition;
            self.HeadBarUI.HeadBar = self.HeadBar;

            switch (monsterConfig.MonsterSonType)
            {
                case 52:
                    self.InitTableData(self.MyUnit.GetComponent<UnitInfoComponent>().EnergySkillId);
                    break;
                case 54:
                case 55:
                case 56:
                case 57:
                    self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<Text>().text = monsterConfig.MonsterName;
                    break;
                case 58:
                    self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<TextMeshProUGUI>().text = monsterConfig.MonsterName;
                    self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = UIHelper.ZhuaPuProToStr(monsterConfig.Parameter[1]);
                    self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<TextMeshProUGUI>().color = new Color(184f / 255f, 255f / 255f, 66f / 255f);
                    break;
                case 59:
                    self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<TextMeshProUGUI>().text = monsterConfig.MonsterName;
                    self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = UIHelper.ZhuaPuProToStr(monsterConfig.Parameter[1]);
                    self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<TextMeshProUGUI>().color = new Color(255f / 255f, 199f / 255f, 66f / 255f);
                    //self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = "抓捕难度：容易";
                    break;
                default:
                    break;
            }
        }

        public static  void InitTableData(this SceneItemUIComponent self, int skillId)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);

            self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<TextMeshProUGUI>().text = skillConfig.SkillName;
            self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = skillConfig.SkillDescribe;
        }

        public static void LateUpdate(this SceneItemUIComponent self)
        {
            if (self.HeadBar == null)
            {
                return;
            }
            if (self.LastTime == Time.time)
            {
                return;
            }
            self.LastTime = Time.time;
            Transform UIPosition = self.UIPosition;
            Vector2 OldPosition = WorldPosiToUIPos.WorldPosiToUIPosition(UIPosition.position, self.HeadBar, self.UICamera, self.MainCamera);

            Vector3 NewPosition = Vector3.zero;
            NewPosition.x = OldPosition.x;
            NewPosition.y = OldPosition.y;
            self.HeadBar.transform.localPosition = NewPosition;
        }

    }

}
