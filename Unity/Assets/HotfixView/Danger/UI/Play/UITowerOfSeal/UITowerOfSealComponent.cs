using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITowerOfSealComponent: Entity, IAwake, IDestroy
    {
        public GameObject Text_Name;
        public GameObject Text_Tip;
        public GameObject Btn_Enter;
    }

    public class UITowerOfSealComponentAwkeSystem: AwakeSystem<UITowerOfSealComponent>
    {
        public override void Awake(UITowerOfSealComponent self)
        {
            self.Awake();
        }
    }

    public class UITowerOfSealComponentDestroySystem : DestroySystem<UITowerOfSealComponent>
    {
        public override void Destroy(UITowerOfSealComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    
    public static class UITowerOfSealComponentSystem
    {
        public static void Awake(this UITowerOfSealComponent self)
        {
            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Text_Tip = rc.Get<GameObject>("Text_Tip");
            self.Btn_Enter = rc.Get<GameObject>("Btn_Enter");
            ButtonHelp.AddListenerEx(self.Btn_Enter, () => { self.OnBtn_Enter().Coroutine(); });
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }

        public static void OnLanguageUpdate(this UITowerOfSealComponent self)
        {
            self.Text_Name.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 60 : 36;
            self.Text_Tip.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 30;
        }
        
        public static async ETTask OnBtn_Enter(this UITowerOfSealComponent self)
        {
            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            // 获取今日已经到达的封印之地的层数，如果没有则重置为0
            int finished = myUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.TowerOfSealFinished);
            // 判断是否到达100层
            if (finished >= 100)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("今日已经达到塔顶,请明天再来挑战哦!"));
                return;
            }

            // 还未到达100层，可以继续闯塔
            int errorCode = await EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.TowerOfSeal,
                BattleHelper.GetSceneIdByType(SceneTypeEnum.TowerOfSeal), 0, "0");
            if (errorCode == ErrorCode.ERR_Success)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UITowerOfSeal);
            }
        }
    }
}