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
            Log.Debug($"GuideComponentzzz :RunAsync");
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
                    Log.Debug($"GuideComponent Button11  {guideConfig.ActionTarget}");
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
                            gameObject = gameObject.transform.GetChild(0).gameObject;
                            rc = gameObject.GetComponent<ReferenceCollector>();
                        }
                    }
                    Log.Debug($"GuideComponentgameButton2222 {gameObject}");
                    if (gameObject == null)
                    {
                        return;
                    }

                    UI ui = await UIHelper.Create(args.ZoneScene, UIType.UIGuide);
                    ui.GetComponent<UIGuideComponent>().guidCof = guideConfig;
                    ui.GetComponent<UIGuideComponent>().SetPosition(gameObject);

                    void OnClickGuide()
                    {
                        Log.Debug($"GuideComponentButton3333 {gameObject}");
                        UIHelper.Remove(args.ZoneScene, UIType.UIGuide);
                        gameObject.GetComponent<Button>().onClick.RemoveListener(OnClickGuide);
                        args.ZoneScene.GetComponent<GuideComponent>().OnNext();
                        PlayerPrefsHelp.SetInt(PlayerPrefsHelp.LastGuide , args.GuideId);
                    }
                    gameObject.GetComponent<Button>().onClick.AddListener(OnClickGuide);
                    break;
                case GuideActionType.NpcTalk:
                    Log.Debug($"GuideComponent NpcTalk  {guideConfig.ActionTarget}");
                    args.ZoneScene.CurrentScene().GetComponent<OperaComponent>().OnClickNpc(int.Parse(guideConfig.ActionTarget));
                    args.ZoneScene.GetComponent<GuideComponent>().OnNext();
                    PlayerPrefsHelp.SetInt(PlayerPrefsHelp.LastGuide, args.GuideId);
                    break;

            }
        }
    }
}
