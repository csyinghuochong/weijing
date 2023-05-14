using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetFubenResultComponent : Entity, IAwake
    {
        public GameObject Img_Star_1;
        public GameObject Img_Star_2;
        public GameObject Img_Star_3;
        public GameObject TextResult;
        public GameObject Button_exit;
        public GameObject ItemListNode;
        public GameObject Button_next;
    }

    public class UIPetFubenResultComponentAwakeSystem : AwakeSystem<UIPetFubenResultComponent>
    {
        public override void Awake(UIPetFubenResultComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Img_Star_1 = rc.Get<GameObject>("Img_Star_1");
            self.Img_Star_2 = rc.Get<GameObject>("Img_Star_2");
            self.Img_Star_3 = rc.Get<GameObject>("Img_Star_3");

            self.TextResult = rc.Get<GameObject>("TextResult");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.Button_exit = rc.Get<GameObject>("Button_exit");
            self.Button_exit.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_exit(); });

            self.Button_next = rc.Get<GameObject>("Button_next");
            self.Button_next.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_next(); });
            self.Button_next.SetActive(false);
        }
    }

    public static class UIPetFubenResultComponentSystem
    {

        public static void OnUpdateUI(this UIPetFubenResultComponent self, M2C_FubenSettlement message)
        {
            //  1胜利 2失败
            self.TextResult.GetComponent<Text>().text = message.BattleResult == CombatResultEnum.Fail ? "挑战失败" : "挑战胜利";

            self.Img_Star_1.gameObject.SetActive(message.StarInfos[0] == 1);
            self.Img_Star_2.gameObject.SetActive(message.StarInfos[1] == 1);
            self.Img_Star_3.gameObject.SetActive(message.StarInfos[2] == 1);
           
            if (self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum == SceneTypeEnum.PetDungeon && message.BattleResult == CombatResultEnum.Win)
            {
                self.Button_next.SetActive(true);
            }

            UICommonHelper.ShowItemList(message.ReardList, self.ItemListNode, self);
        }

        public static void OnButton_exit(this UIPetFubenResultComponent self)
        {
            EnterFubenHelp.RequestQuitFuben(self.ZoneScene());
            UIHelper.Remove( self.ZoneScene(), UIType.UIPetFubenResult );
        }

        public static void OnButton_next(this UIPetFubenResultComponent self)
        {
            int sonsceneid = self.ZoneScene().GetComponent<MapComponent>().SonSceneId + 1;
            if (!PetFubenConfigCategory.Instance.Contain(sonsceneid))
            {
                FloatTipManager.Instance.ShowFloatTip("已通关！");
                return;
            }
            EnterFubenHelp.RequestTransfer(self.ZoneScene(), (int)SceneTypeEnum.PetDungeon, BattleHelper.GetSceneIdByType(SceneTypeEnum.PetDungeon), 0, sonsceneid.ToString()).Coroutine();

            UIHelper.Remove(self.ZoneScene(), UIType.UIPetFubenResult);
        }
    }
}
