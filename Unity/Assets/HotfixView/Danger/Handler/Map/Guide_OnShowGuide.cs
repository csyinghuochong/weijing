using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class Guide_OnShowGuide : AEventClass<EventType.ShowGuide>
    {

        protected override void Run(object args)
        {
            RunAsync(args as EventType.ShowGuide).Coroutine();
        }
        public async ETTask RunAsync(EventType.ShowGuide args)
        {

            if (UIHelper.WaitUI.Contains(UIType.UIGuide)
                || UIHelper.GetUI(args.ZoneScene,UIType.UIGuide)!=null)
            {
                return;
            }

            GuideConfig guideConfig = GuideConfigCategory.Instance.Get(args.GuideId);
            GameObject gameObject = null ;
            for (int i= 0; i < 100; i++)
            {
                gameObject = GameObject.Find(guideConfig.Button);
                if (gameObject != null)
                {
                    continue;
                }
                await TimerComponent.Instance.WaitAsync(1);
            }

            if (gameObject == null)
            {
                return;
            }
            
            UI ui = await UIHelper.Create(args.ZoneScene, UIType.UIGuide);
            ui.GetComponent<UIGuideComponent>().guidCof = guideConfig;
            ui.GetComponent<UIGuideComponent>().SetPosition(gameObject);

            void OnClickGuide()
            {
                UIHelper.Remove(args.ZoneScene, UIType.UIGuide);
                gameObject.GetComponent<Button>().onClick.RemoveListener(OnClickGuide);
                args.ZoneScene.GetComponent<GuideComponent>().OnNext(args.GroupId);
            }
            gameObject.GetComponent<Button>().onClick.AddListener(OnClickGuide);

        }
    }
}
