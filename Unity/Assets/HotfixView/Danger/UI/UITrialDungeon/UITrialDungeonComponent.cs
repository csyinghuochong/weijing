using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{
    public class UITrialDungeonComponent : Entity, IAwake
    {
        public GameObject UIListNode;
        public GameObject Btn_Enter;

        public int TowerId;
    }

    [ObjectSystem]
    public class UITrialDungeonComponentAwake : AwakeSystem<UITrialDungeonComponent>
    {
        public override void Awake(UITrialDungeonComponent self)
        {
            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.UIListNode = rc.Get<GameObject>("UIListNode");

            self.Btn_Enter = rc.Get<GameObject>("Btn_Enter");
            ButtonHelp.AddListenerEx(self.Btn_Enter, () => { self.OnBtn_Enter().Coroutine(); });

            self.OnInitUI().Coroutine();
        }
    }

    public static class UITrialDungeonComponentSystem
    {

        public static async ETTask OnInitUI(this UITrialDungeonComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("TrialDungeon/UITrialDungeonItem");
            var bundleGameObject =await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            List<TowerConfig> towerConfigs = TowerConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < towerConfigs.Count; i++)
            { 
                TowerConfig towerConfig = towerConfigs[i];
                if (towerConfig.MapType != SceneTypeEnum.TrialDungeon)
                {
                    continue;
                }

                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.UIListNode);
                UITrialDungeonItemComponent uiitem = self.AddChild<UITrialDungeonItemComponent>();
                uiitem.OnInitUI(go, towerConfig, self.OnSelectDungeonItem);
            }
        }

        public static void OnSelectDungeonItem(this UITrialDungeonComponent self, int towerId)
        {
            self.TowerId = towerId;
            List<Entity> entities = self.Children.Values.ToList();
            for (int i = 0; i < entities.Count; i++)
            {
                (entities[i] as UITrialDungeonItemComponent).OnSelected(towerId);
            }
        }

        public static async ETTask OnBtn_Enter(this UITrialDungeonComponent self)
        {
            if (self.TowerId == 0)
            {
                return;
            }
            int errorCode = await EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.TrialDungeon, BattleHelper.GetSceneIdByType(SceneTypeEnum.TrialDungeon),0, self.TowerId.ToString());
            if (errorCode == ErrorCore.ERR_Success)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UITrialDungeon);

            }
        }
    }
}
