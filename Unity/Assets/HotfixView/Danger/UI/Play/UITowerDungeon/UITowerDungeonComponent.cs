using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITowerDungeonComponent : Entity, IAwake
    {
        public GameObject TextLevelJianyi_3;
        public GameObject TextLevelJianyi_2;
        public GameObject TextLevelJianyi_1;
        public GameObject ButtonSelect_3;
        public GameObject ButtonSelect_2;
        public GameObject ButtonSelect_1;
        public GameObject ItemListNode;
        public GameObject Btn_Enter;
        public int FubenDifficulty;
    }

    [ObjectSystem]
    public class UITowerDungeonComponentAwake : AwakeSystem<UITowerDungeonComponent>
    {
        public override void Awake(UITowerDungeonComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonSelect_3 = rc.Get<GameObject>("ButtonSelect_3");
            self.ButtonSelect_2 = rc.Get<GameObject>("ButtonSelect_2");
            self.ButtonSelect_1 = rc.Get<GameObject>("ButtonSelect_1");
            self.ButtonSelect_3.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonSelect(FubenDifficulty.DiYu); });
            self.ButtonSelect_2.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonSelect(FubenDifficulty.TiaoZhan); });
            self.ButtonSelect_1.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonSelect(FubenDifficulty.Normal); });
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.Btn_Enter = rc.Get<GameObject>("Btn_Enter");
            ButtonHelp.AddListenerEx( self.Btn_Enter, () => { self.OnBtn_Enter().Coroutine();  } );
            self.TextLevelJianyi_3 = rc.Get<GameObject>("TextLevelJianyi_3");
            self.TextLevelJianyi_2 = rc.Get<GameObject>("TextLevelJianyi_2");
            self.TextLevelJianyi_1 = rc.Get<GameObject>("TextLevelJianyi_1");
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(63);
            string[] jianyiLevel = globalValueConfig.Value.Split(';');
            self.TextLevelJianyi_1.GetComponent<Text>().text = $"建议等级达到{jianyiLevel[0]}级后进行挑战";
            self.TextLevelJianyi_2.GetComponent<Text>().text = $"建议等级达到{jianyiLevel[1]}级后进行挑战";
            self.TextLevelJianyi_3.GetComponent<Text>().text = $"建议等级达到{jianyiLevel[2]}级后进行挑战";

            globalValueConfig = GlobalValueConfigCategory.Instance.Get(61);
            UICommonHelper.ShowItemList(globalValueConfig.Value, self.ItemListNode, self,1, false);
            self.OnButtonSelect(FubenDifficulty.Normal);
        }
    }

    public static class UITowerDungeonComponentSystem
    {
        public static void OnButtonSelect(this UITowerDungeonComponent self, int difficulty)
        {
            Color color_1 = new Color(255, 255, 255, 150);
            Color color_2 = new Color(255, 255, 255, 0);
            self.ButtonSelect_3.GetComponent<Image>().color = difficulty == FubenDifficulty.DiYu ? color_1 : color_2;
            self.ButtonSelect_2.GetComponent<Image>().color = difficulty == FubenDifficulty.TiaoZhan ? color_1 : color_2;
            self.ButtonSelect_1.GetComponent<Image>().color = difficulty == FubenDifficulty.Normal ? color_1 : color_2;
            self.FubenDifficulty = difficulty;
        }

        public static async ETTask OnBtn_Enter(this UITowerDungeonComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>(); 
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(62);
            string[] jianyiLevel = globalValueConfig.Value.Split(';');
            if (userInfoComponent.UserInfo.Lv < int.Parse(jianyiLevel[self.FubenDifficulty - 1]))
            {
                FloatTipManager.Instance.ShowFloatTip($"{jianyiLevel[self.FubenDifficulty - 1]}级进入！");
                return;
            }

            int sceneId = BattleHelper.GetSceneIdByType(SceneTypeEnum.Tower);
            int errorCode = await EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.Tower, sceneId,  self.FubenDifficulty);
            if (errorCode == ErrorCore.ERR_Success)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UITower);
            }
        }
    }
}
