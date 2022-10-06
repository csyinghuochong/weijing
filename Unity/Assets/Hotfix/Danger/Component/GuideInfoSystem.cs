namespace ET
{

    [ObjectSystem]
    public class GuideInfoAwakeSystem : AwakeSystem<GuideInfo, int>
    {
        public override void Awake(GuideInfo self, int guideId)
        {
            self.GuideId = guideId;
            self.Step = 0;
            self.Ids.Clear();
        }
    }

    public static class GuideInfoSystem
    {

        public static bool IsDone(this GuideInfo self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            return userInfoComponent.UserInfo.CompleteGuideIds.Contains(self.GuideId);
        }

        public static void OnUpdate(this GuideInfo self)
        {
            if (self.Step >= self.Ids.Count)
            {
                Log.Error($"{self.Step }_{self.Ids.Count}");
                return;
            }
            int guideId = self.Ids[self.Step];
            EventType.ShowGuide.Instance.ZoneScene = self.ZoneScene();
            EventType.ShowGuide.Instance.GroupId = self.GuideId;
            EventType.ShowGuide.Instance.GuideId = guideId;
            Game.EventSystem.PublishClass(EventType.ShowGuide.Instance);
        }

        public static void OnNext(this GuideInfo self)
        {
            self.Step++;
            if (self.Step >= self.Ids.Count)
            {
                //发协议给后端记录
                self.ZoneScene().GetComponent<GuideComponent>().SendUpdateGuide(self.GuideId).Coroutine();
                return;
            }

            self.OnUpdate();
        }

    }

}
