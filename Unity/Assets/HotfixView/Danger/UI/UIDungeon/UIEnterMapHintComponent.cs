using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIEnterMapHintComponent : Entity, IAwake
    {
        public GameObject titleText;
        public GameObject ShenYuanSet;

        public GameObject Left;
    }

    [ObjectSystem]
    public class UIEnterMapHintComponentAwake : AwakeSystem<UIEnterMapHintComponent>
    {
        public override void Awake(UIEnterMapHintComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.titleText = rc.Get<GameObject>("titleText");
            self.ShenYuanSet = rc.Get<GameObject>("ShenYuanSet");
            self.Left = rc.Get<GameObject>("Left");
            UICommonHelper.CrossFadeAlpha(self.Left.transform, 0f, 0f);
            self.OnInitUI().Coroutine();
        }
    }

    public static class UIEnterMapHintComponentSystem
    {

        public static async ETTask OnInitUI(this UIEnterMapHintComponent self)
        {
            UICommonHelper.CrossFadeAlpha(self.Left.transform, 1f, 1f);
            UICommonHelper.DOLocalMove(self.Left.transform, Vector3.zero, 1f);

            await TimerComponent.Instance.WaitAsync(2000);

            UICommonHelper.CrossFadeAlpha(self.Left.transform, 0f, 1f);
            UICommonHelper.DOLocalMove(self.Left.transform, new Vector3(2000, 0, 0), 1f);

            int dungeonId = self.ZoneScene().GetComponent<MapComponent>().SceneId;

            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.LocalDungeon)
            {
                int fubenType = mapComponent.FubenDifficulty;
                if (fubenType == FubenDifficulty.DiYu)
                { 
                    //地狱难度
                }
                self.titleText.GetComponent<Text>().text = DungeonConfigCategory.Instance.Get(dungeonId).ChapterName;
            }
            if(mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                int fubenType = mapComponent.FubenDifficulty;
                if (fubenType == TeamFubenType.ShenYuan)
                {
                    //深渊模式
                    self.ShenYuanSet.SetActive(true);
                }
            }

            long instanceId = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(1000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            UIHelper.Remove(self.ZoneScene(), UIType.UIEnterMapHint);
        }
    }
}
