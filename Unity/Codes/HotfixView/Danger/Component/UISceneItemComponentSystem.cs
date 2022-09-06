using ET;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [ObjectSystem]
    public class UISceneItemComponentDestroySystem : DestroySystem<UISceneItemComponent>
    {
        public override void Destroy(UISceneItemComponent self)
        {
            if (self.HeadBar != null)
            {
                GameObject.Destroy(self.HeadBar);
                self.HeadBar = null;
            }
        }
    }

    [ObjectSystem]
    public class UISceneItemComponentAwakeSystem : AwakeSystem<UISceneItemComponent>
    {
        public override void Awake(UISceneItemComponent self)
        {
            self.HeadBar = null;
            self.MyUnit = self.GetParent<Unit>();
            self.UICamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
            self.MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
        }
    }

    public static class UISceneItemComponentSystem
    {

        public static async ETTask OnInitUI(this UISceneItemComponent self)
        {
            int configId = self.MyUnit.GetComponent<UnitInfoComponent>().UnitCondigID;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(configId);

            //51 场景怪 有AI 不显示名称
            //52 能量台子 无AI
            //54 场景怪 有AI 显示名称
            //55 宝箱类 无AI
            var path = "";
            if (monsterConfig.MonsterSonType == 52)
            {
                path = ABPathHelper.GetUGUIPath("Battle/UIEnergyTable");
            }
            else if (monsterConfig.MonsterSonType == 54 || monsterConfig.MonsterSonType == 55)
            {
                path = ABPathHelper.GetUGUIPath("Battle/UISceneItem");
            }
            GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            self.HeadBar = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            self.HeadBar.transform.SetParent(UIEventComponent.Instance.UILayers[(int)UILayer.Low]);
            self.HeadBar.transform.localScale = Vector3.one;
            self.UIPosition = self.MyUnit.GetComponent<GameObjectComponent>().GameObject.transform.Find("UIPosition");

            if (self.HeadBar.GetComponent<HeadBarUI>() == null)
            {
                self.HeadBar.AddComponent<HeadBarUI>();
            }
            self.HeadBarUI = self.HeadBar.GetComponent<HeadBarUI>();
            self.HeadBarUI.HeadPos = self.UIPosition;
            self.HeadBarUI.HeadBar = self.HeadBar;
            //self.LateUpdate();
        }

        public static async ETTask InitTableData(this UISceneItemComponent self, int skillId)
        {
            await self.OnInitUI();

            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);

            self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<TextMeshProUGUI>().text = skillConfig.SkillName;
            self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = skillConfig.SkillDescribe;
        }

        public static async ETTask InitSceneData(this UISceneItemComponent self)
        {
            await self.OnInitUI();

            int configId = self.GetParent<Unit>().GetComponent<UnitInfoComponent>().UnitCondigID;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(configId);
            self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<Text>().text = monsterConfig.MonsterName;
        }

        public static void LateUpdate(this UISceneItemComponent self)
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
