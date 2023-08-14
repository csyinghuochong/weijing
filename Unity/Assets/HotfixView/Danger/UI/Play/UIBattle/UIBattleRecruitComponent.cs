using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIBattleRecruitComponent: Entity, IAwake
    {
        public GameObject BattltRecruitListNode;
        public GameObject Img_button;
        public GameObject CurrentNumberText;

        public Dictionary<int, UIBattleRecruitItemComponent> UIBattltRecruitItemComponents = new Dictionary<int, UIBattleRecruitItemComponent>();
        public List<BattleSummonInfo> BattleSummonInfos = new List<BattleSummonInfo>();
    }

    public class UIBattltRecruitComponentAwakeSystem: AwakeSystem<UIBattleRecruitComponent>
    {
        public override void Awake(UIBattleRecruitComponent self)
        {
            self.Awake();
        }
    }

    public static class UIBattleRecruitComponentSystem
    {
        public static void Awake(this UIBattleRecruitComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BattltRecruitListNode = rc.Get<GameObject>("BattltRecruitListNode");
            self.Img_button = rc.Get<GameObject>("Img_button");
            self.CurrentNumberText = rc.Get<GameObject>("CurrentNumberText");

            self.Img_button.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIBattleRecruit); });

            self.InitUI().Coroutine();
        }

        public static async ETTask InitUI(this UIBattleRecruitComponent self)
        {
            // 向服务端获取目前的招募数据
            long instanceId = self.InstanceId;
            C2M_BattleSummonRecord request = new C2M_BattleSummonRecord();
            M2C_BattleSummonRecord response =
                    await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request) as M2C_BattleSummonRecord;
            if (response.BattleSummonList == null)
            {
                return;
            }

            if (instanceId != self.InstanceId)
            {
                return;
            }

            self.BattleSummonInfos = response.BattleSummonList;
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            int sceneId = mapComponent.SceneId;

            // 读取配置表，生成招募列表
            List<BattleSummonConfig> battleSummonInfos = BattleSummonConfigCategory.Instance.GetAll().Values.ToList();
            var path = ABPathHelper.GetUGUIPath("BattleDungeon/UIBattleRecruitItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < battleSummonInfos.Count; i++)
            {
                if (sceneId != battleSummonInfos[i].SceneId)
                {
                    continue;
                }

                GameObject go = GameObject.Instantiate(bundleGameObject);
                UIBattleRecruitItemComponent uiBattleRecruitItemComponent = self.AddChild<UIBattleRecruitItemComponent, GameObject>(go);
                self.UIBattltRecruitItemComponents.Add(battleSummonInfos[i].Id, uiBattleRecruitItemComponent);
                uiBattleRecruitItemComponent.OnRecruitAction = (i1, i2) => { self.OnRecruit(i1, i2).Coroutine(); };
                uiBattleRecruitItemComponent.InitUI(battleSummonInfos[i]);
                UICommonHelper.SetParent(go, self.BattltRecruitListNode);
            }

            // 根据招募数据更新一下列表
            for (int i = 0; i < response.BattleSummonList.Count; i++)
            {
                if (self.UIBattltRecruitItemComponents.Keys.Contains(response.BattleSummonList[i].SummonId))
                {
                    self.UIBattltRecruitItemComponents[response.BattleSummonList[i].SummonId].UpdateDate(response.BattleSummonList[i].SummonTime);
                }
            }

            self.CurrentNumberText.GetComponent<Text>().text =
                    $"当前召唤人口:{BattleHelper.GetSummonNumber(response.BattleSummonList)}/{int.Parse(GlobalValueConfigCategory.Instance.Get(91).Value)}";

            // 开启定时刷新
            self.UpdateUI().Coroutine();

            await ETTask.CompletedTask;
        }

        /// <summary>
        /// 刷新UI
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask UpdateUI(this UIBattleRecruitComponent self)
        {
            while (!self.IsDisposed)
            {
                long nowTime = TimeHelper.ClientNow();
                foreach (UIBattleRecruitItemComponent component in self.UIBattltRecruitItemComponents.Values)
                {
                    component.UpdateUI(nowTime);
                }

                await TimerComponent.Instance.WaitAsync(1000);
                if (self.IsDisposed)
                {
                    break;
                }
            }

            await ETTask.CompletedTask;
        }

        /// <summary>
        /// 发送招募请求
        /// </summary>
        /// <param name="self"></param>
        /// <param name="battleSummonConfigId"></param>
        /// <param name="costgold"></param>
        public static async ETTask OnRecruit(this UIBattleRecruitComponent self, int battleSummonConfigId, int costgold)
        {
            // 判断人口是否足够
            int cursummonnumber = BattleHelper.GetSummonNumber(self.BattleSummonInfos);
            BattleSummonConfig battleSummonConfig = BattleSummonConfigCategory.Instance.Get(battleSummonConfigId);
            if (cursummonnumber + battleSummonConfig.MonsterNumber > int.Parse(GlobalValueConfigCategory.Instance.Get(91).Value))
            {
                FloatTipManager.Instance.ShowFloatTip("人口不足！");
                return;
            }

            // 判断道具是否足够
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.Gold < costgold)
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足！");
                return;
            }

            C2M_BattleSummonRequest request = new C2M_BattleSummonRequest() { SummonId = battleSummonConfigId };
            M2C_BattleSummonResponse response =
                    await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request) as M2C_BattleSummonResponse;

            if (response.Error == ErrorCode.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTip($"召唤{battleSummonConfig.ItemName}成功!");
            }
            
            self.CurrentNumberText.GetComponent<Text>().text =
                    $"当前召唤人口:{BattleHelper.GetSummonNumber(response.BattleSummonList)}/{int.Parse(GlobalValueConfigCategory.Instance.Get(91).Value)}";

            for (int i = 0; i < response.BattleSummonList.Count; i++)
            {
                if (self.UIBattltRecruitItemComponents.Keys.Contains(response.BattleSummonList[i].SummonId))
                {
                    self.UIBattltRecruitItemComponents[response.BattleSummonList[i].SummonId].UpdateDate(response.BattleSummonList[i].SummonTime);
                }
            }

            await ETTask.CompletedTask;
        }
    }
}