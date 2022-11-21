using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITowerDungeonComponent : Entity, IAwake
    {
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
        }

        public static async ETTask OnBtn_Enter(this UITowerDungeonComponent self)
        {
            int sceneId = BattleHelper.GetSceneIdByType(SceneTypeEnum.Tower);
            int errorCode = await EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.Tower, sceneId,  self.FubenDifficulty);
            if (errorCode == ErrorCore.ERR_Success)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UITower);
            }
        }
    }
}
