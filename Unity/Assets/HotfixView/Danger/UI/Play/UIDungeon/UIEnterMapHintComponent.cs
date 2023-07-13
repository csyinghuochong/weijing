using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIEnterMapHintComponent : Entity, IAwake
    {
        public GameObject titleText;
        public GameObject ShenYuanSet;
        public GameObject JingLingShowSet;

        public GameObject Left;
    }


    public class UIEnterMapHintComponentAwake : AwakeSystem<UIEnterMapHintComponent>
    {
        public override void Awake(UIEnterMapHintComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.titleText = rc.Get<GameObject>("titleText");
            self.ShenYuanSet = rc.Get<GameObject>("ShenYuanSet");
            self.Left = rc.Get<GameObject>("Left");
            self.JingLingShowSet = rc.Get<GameObject>("JingLingShowSet");
            UICommonHelper.CrossFadeAlpha(self.Left.transform, 0f, 0.1f);
            self.OnInitUI().Coroutine();
        }
    }

    public static class UIEnterMapHintComponentSystem
    {

        public static async ETTask OnInitUI(this UIEnterMapHintComponent self)
        {
            C2M_FindJingLingRequest c2M_FindJingLing = new C2M_FindJingLingRequest();
            M2C_FindJingLingResponse m2C_FindJingLingResponse = (M2C_FindJingLingResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_FindJingLing);
            if (m2C_FindJingLingResponse.MonsterID != 0)
            {
                ///找到精灵
                self.JingLingShowSet.SetActive(true);
            }
            else{
                ///找到精灵
                self.JingLingShowSet.SetActive(false);
            }

            Scene zoneScene = self.ZoneScene();
            UICommonHelper.CrossFadeAlpha(self.Left.transform, 1f, 1f);
            UICommonHelper.DOLocalMove(self.Left.transform, Vector3.zero, 0.75f).Coroutine();

            int dungeonId = zoneScene.GetComponent<MapComponent>().SceneId;
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.LocalDungeon)
            {
                int fubenType = mapComponent.FubenDifficulty;
                if (fubenType == FubenDifficulty.DiYu)
                {
                    //地狱难度
                }
                self.titleText.GetComponent<Text>().text = DungeonConfigCategory.Instance.Get(dungeonId).ChapterName;
            }
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                int fubenType = mapComponent.FubenDifficulty;
                if (fubenType == TeamFubenType.ShenYuan)
                {
                    //深渊模式
                    self.ShenYuanSet.SetActive(true);
                    
                }
                self.titleText.GetComponent<Text>().text = SceneConfigCategory.Instance.Get(dungeonId).Name;
            }

            long instanceId = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(2000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            UICommonHelper.CrossFadeAlpha(self.Left.transform, 0f, 1f);
            UICommonHelper.DOLocalMove(self.Left.transform, new Vector3(2000, 0, 0), 0.75f).Coroutine();

            await TimerComponent.Instance.WaitAsync(1000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            UIHelper.Remove(zoneScene, UIType.UIEnterMapHint);
        }
    }
}
