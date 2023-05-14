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

            switch (guideConfig.ActionType)
            {
                case GuideActionType.Button:

                    //AdventureBtn
                    //ChapterContent;0@ButtonEnter
                    //UIMainTask@TaskShowList;0@ButtonTask
                   
                    GameObject gameObject = UIHelper.GetUI(args.ZoneScene, guideConfig.ActionTarget).GameObject;
                    ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
                    string[] childPaths = guideConfig.ActionParams.Split('@');
                    for (int i = 0; i < childPaths.Length; i++)
                    {
                        // ChapterContent; 0
                        string[] pathinfos = childPaths[i].Split(';');

                        if (pathinfos.Length == 1)
                        {
                            gameObject = rc.Get<GameObject>(pathinfos[0]);
                            rc = gameObject.GetComponent<ReferenceCollector>();
                        }
                        if (pathinfos.Length == 2)
                        {
                            gameObject = rc.Get<GameObject>(pathinfos[0]);
                            gameObject = gameObject.transform.GetChild(int.Parse(pathinfos[1])).gameObject;
                            rc = gameObject.GetComponent<ReferenceCollector>();
                        }
                        if (rc == null)
                        {
                            break;
                        }
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

                        UserInfo userInfo = args.ZoneScene.GetComponent<UserInfoComponent>().UserInfo;
                        PlayerPrefsHelp.SetInt($"{PlayerPrefsHelp.LastGuide}_{userInfo.UserId}", args.GuideId);
                    }
                    if (gameObject.GetComponent<Button>() == null)
                    {
                        gameObject.AddComponent<Button>();
                    }
                    gameObject.GetComponent<Button>().onClick.AddListener(OnClickGuide);
                    break;
                case GuideActionType.NpcTalk:
                    
                    args.ZoneScene.CurrentScene().GetComponent<OperaComponent>().OnClickNpc(int.Parse(guideConfig.ActionTarget)).Coroutine();
                    args.ZoneScene.GetComponent<GuideComponent>().OnNext(args.GroupId);

                    UserInfo userInfo = args.ZoneScene.GetComponent<UserInfoComponent>().UserInfo;
                    PlayerPrefsHelp.SetInt($"{PlayerPrefsHelp.LastGuide}_{userInfo.UserId}", args.GuideId);
                    break;

            }
        }
    }
}
