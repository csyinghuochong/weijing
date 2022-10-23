using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public class UIBattleEnterComponent : Entity, IAwake
    {
        public GameObject ButtonEnter;
        public GameObject ItemListNode;
    }

    [ObjectSystem]
    public class UIBattleEnterComponentAwakeSystem : AwakeSystem<UIBattleEnterComponent>
    {
        public override void Awake(UIBattleEnterComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonEnter = rc.Get<GameObject>("ButtonEnter");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            ButtonHelp.AddListenerEx(self.ButtonEnter, () => { self.OnButtonEnter().Coroutine(); } );
        }
    }

    public static class UIBattleEnterComponentSystem
    {
        public static int GetBattFubenId(this UIBattleEnterComponent self)
        {
            List<SceneConfig> sceneConfigs = SceneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < sceneConfigs.Count; i++)
            {
                if (sceneConfigs[i].MapType == SceneTypeEnum.Battle)
                {
                    return sceneConfigs[i].Id;
                }
            }
            return 0;
        }

        public static async ETTask OnButtonEnter(this UIBattleEnterComponent self)
        {
            int sceneId = self.GetBattFubenId();
            if (sceneId == 0)
            {
                return; 
            }
            int errorCode = await EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.Battle, sceneId);
            if (errorCode == ErrorCore.ERR_Success)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UIBattle);
            }
        }
    }
}