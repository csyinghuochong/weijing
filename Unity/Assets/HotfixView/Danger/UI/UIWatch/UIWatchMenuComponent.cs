using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

namespace ET
{

    public enum MenuEnumType
    { 
        Main = 1,
        Team = 2,
        Union = 3,
    }

    public static class MenuOperation
    {
        public const int Watch = 1;
        public const int InviteTeam = 2;
        public const int AddFriend = 3;
        public const int KickTeam = 4;
        public const int LeaveTeam = 5;
        public const int ApplyTeam = 6;
        public const int InviteUnion = 7;
        public const int KickUnion = 8;
        public const int BlackAdd = 9;
        public const int BlackRemove = 10;
        public const int TransUnion = 11;
        public const int UnionAider = 12;   
        public const int UnionElde = 13;
    }

    public class UIWatchMenuComponent : Entity, IAwake
    {
        public GameObject ImageDi;
        public GameObject ImageBg;
        public GameObject Button_BlackRemove;
        public GameObject Button_BlackAdd;
        public GameObject Button_InviteUnion;
        public GameObject Button_KickUnion;
        public GameObject Button_ApplyTeam;
        public GameObject Button_LeaveTeam;
        public GameObject Button_KickTeam;
        public GameObject Button_AddFriend;
        public GameObject Button_InviteTeam;
        public GameObject Button_UnionTransfer;
        public GameObject Button_UnionAider;        //任命副族长
        public GameObject Button_UnionElder;        //任命长老
        public GameObject Button_Watch;
        public GameObject PositionSet;

        public long UserId;
        public long TeamId;
        public F2C_WatchPlayerResponse f2C_WatchPlayerResponse;
    }


    public class UIWatchMenuComponentAwakeSystem : AwakeSystem<UIWatchMenuComponent>
    {
        public override void Awake(UIWatchMenuComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageDi = rc.Get<GameObject>("ImageDi");

            self.ImageBg = rc.Get<GameObject>("ImageBg");
            self.ImageBg.GetComponent<Button>().onClick.AddListener(() => { self.OnClickImageBg(); });

            self.Button_InviteUnion = rc.Get<GameObject>("Button_InviteUnion");
            self.Button_InviteUnion.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_InviteUnion(); });

            self.Button_KickUnion = rc.Get<GameObject>("Button_KickUnion");
            self.Button_KickUnion.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_KickUnion(); });

            self.Button_LeaveTeam = rc.Get<GameObject>("Button_LeaveTeam");
            self.Button_LeaveTeam.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Leave(); });

            self.Button_KickTeam = rc.Get<GameObject>("Button_KickTeam");
            self.Button_KickTeam.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_KickOut(); });

            self.Button_AddFriend = rc.Get<GameObject>("Button_AddFriend");
            self.Button_AddFriend.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_AddFriend().Coroutine(); });

            self.Button_Watch = rc.Get<GameObject>("Button_Watch");
            self.Button_Watch.GetComponent<Button>().onClick.AddListener(() => { self.OnClickButton_Watch().Coroutine();  });

            self.Button_InviteTeam = rc.Get<GameObject>("Button_InviteTeam");
            self.Button_InviteTeam.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_InviteTeam().Coroutine(); });

            self.Button_ApplyTeam = rc.Get<GameObject>("Button_ApplyTeam");
            self.Button_ApplyTeam.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_ApplyTeam(); });

            self.Button_BlackRemove = rc.Get<GameObject>("Button_BlackRemove");
            self.Button_BlackRemove.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_BlackRemove().Coroutine(); });

            self.Button_BlackAdd = rc.Get<GameObject>("Button_BlackAdd");
            self.Button_BlackAdd.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_BlackAdd().Coroutine(); });

            self.Button_UnionTransfer = rc.Get<GameObject>("Button_UnionTransfer");
            self.Button_UnionTransfer.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_UnionTransfer().Coroutine(); });

            self.Button_UnionAider = rc.Get<GameObject>("Button_UnionAider");  //任命副族长
            self.Button_UnionAider.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_UnionOperate(2).Coroutine();  } );
            self.Button_UnionElder = rc.Get<GameObject>("Button_UnionElder");  //任命长老
            self.Button_UnionElder.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_UnionOperate(3).Coroutine(); });

            self.Button_Watch.SetActive(false);
            self.Button_ApplyTeam.SetActive(false);
            self.Button_LeaveTeam.SetActive(false);
            self.Button_KickTeam.SetActive(false);
            self.Button_AddFriend.SetActive(false);
            self.Button_InviteTeam.SetActive(false);
            self.Button_UnionTransfer.SetActive(false);
            self.Button_UnionAider.SetActive(false);
            self.Button_UnionElder.SetActive(false);
            self.PositionSet = rc.Get<GameObject>("PositionSet");
        }
    }


    public static class UIWatchMenuComponentSystem
    {
        public static void OnClickImageBg(this UIWatchMenuComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIWatchMenu);
        }

        public static void OnButton_Leave(this UIWatchMenuComponent self)
        {
            bool isLeader = self.ZoneScene().GetComponent<TeamComponent>().IsTeamLeader();

            PopupTipHelp.OpenPopupTip(self.DomainScene(), "我的队伍", isLeader ? "是否离开队伍" : "是否离开队伍？",
                () =>
                {
                    self.ZoneScene().GetComponent<TeamComponent>().SendLeaveRequest().Coroutine();
                    self.OnClickImageBg();
                }
                ).Coroutine();
        }

        public static void OnButton_InviteUnion(this UIWatchMenuComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;

            Unit watchUnit = unit.GetParent<UnitComponent>().Get(self.UserId);
            string playName = watchUnit.GetComponent<UnitInfoComponent>().MasterName;
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "邀请加入", $"邀请玩家{playName}加入{userInfo.UnionName}家族?", () =>
            {
                C2M_UnionInviteRequest request = new C2M_UnionInviteRequest() { InviteId = self.UserId };
                self.ZoneScene().GetComponent<SessionComponent>().Session.Send(request);
            }, null).Coroutine();
        }

        public static  void OnButton_KickUnion(this UIWatchMenuComponent self)
        {
            PopupTipHelp.OpenPopupTip( self.ZoneScene(), "踢出家族", "确定将该玩家踢出家族?", () =>
            {
                self.RequestKickUnion().Coroutine();
            }, null).Coroutine();
        }

        public static async ETTask OnButton_UnionOperate(this UIWatchMenuComponent self, int postion)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            C2U_UnionOperatateRequest c2M_ItemHuiShouRequest = new C2U_UnionOperatateRequest()
            {
                UnitId = unit.Id,
                Operatate = 3,
                UnionId = unit.GetUnionId(),
                Value = $"{self.UserId}_{postion}"
            };
            U2C_UnionOperatateResponse r2c_roleEquip = (U2C_UnionOperatateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
            UI uI = UIHelper.GetUI( self.ZoneScene(), UIType.UIFriend );
            uI?.GetComponent<UIFriendComponent>().OnUpdateMyUnion();
            self.OnClickImageBg();
        }

        public static async ETTask OnButton_UnionTransfer(this UIWatchMenuComponent self)
        {
            C2M_UnionTransferRequest request = new C2M_UnionTransferRequest()
            {
                NewLeader = self.UserId
            };
            M2C_UnionTransferResponse response = (M2C_UnionTransferResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIFriend);
            uI?.GetComponent<UIFriendComponent>().OnUpdateMyUnion();
            self.OnClickImageBg();
        }

        public static async ETTask RequestKickUnion(this UIWatchMenuComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long unionId = (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0));
            C2U_UnionKickOutRequest c2M_SkillSet = new C2U_UnionKickOutRequest() { UnionId = unionId, UserId = self.UserId };
            U2C_UnionKickOutResponse m2C_SkillSet = (U2C_UnionKickOutResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

            UI uifreind = UIHelper.GetUI(self.ZoneScene(), UIType.UIFriend);
            uifreind.GetComponent<UIFriendComponent>().OnUpdateMyUnion();

            self.OnClickImageBg();
        }

        public static void OnButton_KickOut(this UIWatchMenuComponent self)
        {
            PopupTipHelp.OpenPopupTip(self.DomainScene(), "我的队伍", "是否踢出队伍？",
                () =>
                {
                    self.ZoneScene().GetComponent<TeamComponent>().SendKickOutRequest(self.UserId).Coroutine();
                    self.OnClickImageBg();
                }
                ).Coroutine();
        }

        public static async ETTask OnButton_AddFriend(this UIWatchMenuComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            C2F_FriendApplyRequest c2F_FriendApplyReplyRequest = new C2F_FriendApplyRequest() { UserID = self.UserId,
                RoleInfo = new FriendInfo()
                {
                    UserId = userInfoComponent.UserInfo.UserId,
                    PlayerName = userInfoComponent.UserInfo.Name,
                    PlayerLevel = userInfoComponent.UserInfo.Lv,
                    Occ = userInfoComponent.UserInfo.Occ,
                } };
            F2C_FriendApplyResponse f2C_FriendApplyResponse = (F2C_FriendApplyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2F_FriendApplyReplyRequest);
            self.OnClickImageBg();
        }

        public static async ETTask OnButton_BlackAdd(this UIWatchMenuComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            C2F_FriendBlacklistRequest c2F_FriendApplyReplyRequest = new C2F_FriendBlacklistRequest()
            {
                OperateType = 1,
                UserID = userInfoComponent.UserInfo.UserId,
                FriendId = self.UserId,
            };
            F2C_FriendBlacklistResponse f2C_FriendApplyResponse = (F2C_FriendBlacklistResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2F_FriendApplyReplyRequest);
            NetHelper.RequestFriendInfo(self.ZoneScene()).Coroutine();
            self.OnClickImageBg();
        }

        public static async ETTask OnButton_BlackRemove(this UIWatchMenuComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            C2F_FriendBlacklistRequest c2F_FriendApplyReplyRequest = new C2F_FriendBlacklistRequest()
            {
                OperateType = 2,
                UserID = userInfoComponent.UserInfo.UserId,
                FriendId = self.UserId,
            };
            F2C_FriendBlacklistResponse f2C_FriendApplyResponse = (F2C_FriendBlacklistResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2F_FriendApplyReplyRequest);
            NetHelper.RequestFriendInfo(self.ZoneScene()).Coroutine();
            self.OnClickImageBg();
        }

        public static async ETTask OnButton_InviteTeam(this UIWatchMenuComponent self)
        {
            C2T_TeamInviteRequest c2M_SkillSet = new C2T_TeamInviteRequest() 
            { 
                UserID = self.UserId,
                TeamPlayerInfo = UnitHelper.GetSelfTeamPlayerInfo(self.ZoneScene())
            };
            T2C_TeamInviteResponse m2C_SkillSet = (T2C_TeamInviteResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

            self.OnClickImageBg();
        }

        public static  void OnButton_ApplyTeam(this UIWatchMenuComponent self)
        {
            self.ZoneScene().GetComponent<TeamComponent>().SendTeamApply(self.TeamId, 0, 0, 0).Coroutine();
            self.OnClickImageBg();
        }

        public static async ETTask OnClickButton_Watch(this UIWatchMenuComponent self)
        {
            C2F_WatchPlayerRequest c2M_SkillSet = new C2F_WatchPlayerRequest() { UserId = self.UserId, WatchType = 0 };
            F2C_WatchPlayerResponse m2C_SkillSet = (F2C_WatchPlayerResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIWatch);
            uI.GetComponent<UIWatchComponent>().OnUpdateUI(m2C_SkillSet);

            self.OnClickImageBg();
        }

        /// <summary>
        /// 家族菜单
        /// </summary>
        /// <param name="self"></param>
        /// <param name="menuList"></param>
        /// <param name="userId"></param>
        public static  void OnUpdateUI_2(this UIWatchMenuComponent self, List<int> menuList, long userId)
        {
            self.UserId = userId;
            self.Button_ApplyTeam.SetActive(menuList.Contains(MenuOperation.ApplyTeam));
            self.Button_LeaveTeam.SetActive(menuList.Contains(MenuOperation.LeaveTeam)); 
            self.Button_KickTeam.SetActive(menuList.Contains(MenuOperation.KickTeam));
            self.Button_AddFriend.SetActive(menuList.Contains(MenuOperation.AddFriend));
            self.Button_InviteTeam.SetActive(menuList.Contains(MenuOperation.InviteTeam)); 
            self.Button_Watch.SetActive(menuList.Contains(MenuOperation.Watch));
            self.Button_InviteUnion.SetActive(menuList.Contains(MenuOperation.InviteUnion));
            self.Button_KickUnion.SetActive(menuList.Contains(MenuOperation.KickUnion));
            self.Button_BlackRemove.SetActive(menuList.Contains(MenuOperation.BlackRemove));
            self.Button_BlackAdd.SetActive(menuList.Contains(MenuOperation.BlackAdd));
            self.Button_UnionTransfer.SetActive(menuList.Contains(MenuOperation.TransUnion));
            self.Button_UnionAider.SetActive(menuList.Contains(MenuOperation.UnionAider));
            self.Button_UnionElder.SetActive(menuList.Contains(MenuOperation.UnionElde));

            self.OnUpdatePos();
            self.OnUpdateDi();
        }

        public static void OnUpdateDi(this UIWatchMenuComponent self)
        {
            int number = 0;
            for (int i = 0; i < self.PositionSet.transform.childCount; i++)
            {
                if (self.PositionSet.transform.GetChild(i).gameObject.activeSelf)
                {
                    number++;
                }
            }
            self.ImageDi.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(220, number * 70f);
        }

        public static void OnUpdatePos(this UIWatchMenuComponent self)
        {
            Vector2 localPoint;
            RectTransform canvas = self.GetParent<UI>().GameObject.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, Input.mousePosition, uiCamera, out localPoint);
            self.PositionSet.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
            self.ImageDi.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
            self.ImageDi.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(220, 0f);
        }

        public static async ETTask OnUpdateUI_1(this UIWatchMenuComponent self, MenuEnumType menuEnumType, long userId)
        {
            self.OnUpdatePos();

            self.UserId = userId;
            for (int i = 0; i < self.PositionSet.transform.childCount; i++)
            {
                self.PositionSet.transform.GetChild(i).gameObject.SetActive(false);
            }

            long instanceId = self.InstanceId;
            C2F_WatchPlayerRequest c2M_SkillSet = new C2F_WatchPlayerRequest() { UserId = self.UserId, WatchType = 2 };
            F2C_WatchPlayerResponse m2C_SkillSet = (F2C_WatchPlayerResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);
            if (instanceId != self.InstanceId)
            {
                return;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            Unit watchUnit = unit.GetParent<UnitComponent>().Get( userId );
            long myunionid = unit.GetComponent<NumericComponent>().GetAsLong( NumericType.UnionId_0 );
            long wathunion = watchUnit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0);

            self.TeamId = m2C_SkillSet.TeamId;
            int friendType = self.ZoneScene().GetComponent<FriendComponent>().GetFriendType(userId);
            TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            long myUserId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            bool isLeader = teamInfo != null && teamInfo.PlayerList[0].UserID == myUserId;

            //self.Button_ApplyTeam.SetActive(false); 申请入队
            //self.Button_Leave.SetActive(false);     离开队伍
            //self.Button_KickOut.SetActive(false);   踢出队伍
            //self.Button_AddFriend.SetActive(false); 添加好友
            //self.Button_InviteTeam.SetActive(false);邀请组队
            //self.Button_Watch.SetActive(false);     观察
            self.Button_ApplyTeam.SetActive(teamInfo == null && userId!= myUserId && m2C_SkillSet.TeamId!=0);
            self.Button_LeaveTeam.SetActive(teamInfo != null && userId == myUserId);
            self.Button_KickTeam.SetActive(isLeader && userId != myUserId && m2C_SkillSet.TeamId == myUserId);
            self.Button_AddFriend.SetActive(friendType == 0);
            self.Button_BlackAdd.SetActive(friendType == 0);
            self.Button_BlackRemove.SetActive(friendType == 2);
            self.Button_InviteTeam.SetActive(userId != myUserId && (isLeader ||teamInfo == null) && m2C_SkillSet.TeamId == 0);
            self.Button_Watch.SetActive(true);
            self.Button_KickUnion.SetActive(false);
            self.Button_InviteUnion.SetActive(myunionid > 0 && wathunion == 0);

            switch (menuEnumType)
            {
                case MenuEnumType.Main:
                    break;
                case MenuEnumType.Team:
                    break;
            }
            self.OnUpdateDi();
        }

    }
}
