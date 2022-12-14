namespace ET
{
	public static partial class OuterOpcode
	{
		 public const ushort C2A_Register = 10002;
		 public const ushort A2C_Register = 10003;
		 public const ushort C2Center_Register = 10004;
		 public const ushort Center2C_Register = 10005;
		 public const ushort C2A_RealNameRequest = 10006;
		 public const ushort A2C_RealNameResponse = 10007;
		 public const ushort C2M_TestRequest = 10008;
		 public const ushort M2C_TestResponse = 10009;
		 public const ushort Actor_TransferRequest = 10010;
		 public const ushort Actor_TransferResponse = 10011;
		 public const ushort C2A_CreateRoleData = 10012;
		 public const ushort A2C_CreateRoleData = 10013;
		 public const ushort C2A_DeleteRoleData = 10014;
		 public const ushort A2C_DeleteRoleData = 10015;
		 public const ushort C2Q_EnterQueue = 10016;
		 public const ushort Q2C_EnterQueue = 10017;
		 public const ushort Q2C_EnterGame = 10018;
		 public const ushort C2A_GetRealmKey = 10019;
		 public const ushort A2C_GetRealmKey = 10020;
		 public const ushort C2R_LoginRealm = 10021;
		 public const ushort R2C_LoginRealm = 10022;
		 public const ushort C2G_LoginGameGate = 10023;
		 public const ushort G2C_LoginGameGate = 10024;
		 public const ushort C2G_EnterGame = 10025;
		 public const ushort G2C_EnterGame = 10026;
		 public const ushort MoveInfo = 10027;
		 public const ushort UserInfo = 10028;
		 public const ushort KeyValuePair = 10029;
		 public const ushort KeyValuePairInt = 10030;
		 public const ushort CreateRoleListInfo = 10031;
		 public const ushort UnitInfo = 10032;
		 public const ushort M2C_CreateUnits = 10033;
		 public const ushort M2C_CreateMyUnit = 10034;
		 public const ushort M2C_StartSceneChange = 10035;
		 public const ushort M2C_RemoveUnits = 10036;
		 public const ushort C2M_PathfindingResult = 10037;
		 public const ushort C2M_Stop = 10038;
		 public const ushort C2M_StopTest = 10039;
		 public const ushort M2C_PathfindingResult = 10040;
		 public const ushort M2C_Stop = 10041;
		 public const ushort C2G_Ping = 10042;
		 public const ushort G2C_Ping = 10043;
		 public const ushort G2C_Test = 10044;
		 public const ushort C2M_Reload = 10045;
		 public const ushort M2C_Reload = 10046;
		 public const ushort C2A_LoginAccount = 10047;
		 public const ushort A2C_LoginAccount = 10048;
		 public const ushort A2C_Disconnect = 10049;
		 public const ushort PlayerInfo = 10050;
		 public const ushort C2M_TestActorRequest = 10051;
		 public const ushort M2C_TestActorResponse = 10052;
		 public const ushort C2G_PlayerInfo = 10053;
		 public const ushort G2C_PlayerInfo = 10054;
		 public const ushort C2M_Move = 10055;
		 public const ushort M2C_MoveResult = 10056;
		 public const ushort C2G_HeartBeat = 10057;
		 public const ushort G2C_HeartBeat = 10058;
		 public const ushort M2C_BuffInfo = 10059;
		 public const ushort C2R_TestCall = 10060;
		 public const ushort R2C_TestResponse = 10061;
		 public const ushort C2A_Notice = 10062;
		 public const ushort A2C_Notice = 10063;
		 public const ushort C2A_Thanks = 10064;
		 public const ushort A2C_Thanks = 10065;
		 public const ushort C2A_ServerList = 10066;
		 public const ushort A2C_ServerList = 10067;
		 public const ushort ServerItem = 10068;
		 public const ushort C2G_CreateRole = 10069;
		 public const ushort G2C_CreateRole = 10070;
		 public const ushort M2C_PetDataUpdate = 10071;
		 public const ushort M2C_PetDataBroadcast = 10072;
		 public const ushort M2C_RoleDataUpdate = 10073;
		 public const ushort M2C_RoleDataBroadcast = 10074;
		 public const ushort BagInfo = 10075;
		 public const ushort HideProList = 10076;
		 public const ushort C2M_GetHeroDataRequest = 10077;
		 public const ushort M2C_GetHeroDataResponse = 10078;
		 public const ushort C2M_SkillCmd = 10079;
		 public const ushort M2C_SkillCmd = 10080;
		 public const ushort M2C_UnitUseSkill = 10081;
		 public const ushort M2C_ChainLightning = 10082;
		 public const ushort SkillInfo = 10083;
		 public const ushort C2M_CreateSpiling = 10084;
		 public const ushort M2C_CreateSpilings = 10085;
		 public const ushort SpilingInfo = 10086;
		 public const ushort M2C_UnitNumericUpdate = 10087;
		 public const ushort M2C_SyncUnitPos = 10088;
		 public const ushort M2C_CreateDropItems = 10089;
		 public const ushort DropInfo = 10090;
		 public const ushort TransferInfo = 10091;
		 public const ushort NpcInfo = 10092;
		 public const ushort M2C_CancelAttack = 10093;
		 public const ushort C2M_TestRobotCase = 10094;
		 public const ushort M2C_TestRobotCase = 10095;
		 public const ushort C2M_TransferMap = 10096;
		 public const ushort M2C_TransferMap = 10097;
		 public const ushort C2M_UnitStateUpdate = 10098;
		 public const ushort M2C_UnitStateUpdate = 10099;
		 public const ushort M2C_UnitBuffUpdate = 10100;
		 public const ushort C2G_OffLine = 10101;
		 public const ushort G2C_OffLine = 10102;
		 public const ushort C2D_Test = 10103;
		 public const ushort D2C_Test = 10104;
		 public const ushort C2M_GMCommandRequest = 10105;
		 public const ushort C2C_SendChatRequest = 10106;
		 public const ushort C2C_SendChatResponse = 10107;
		 public const ushort ChatInfo = 10108;
		 public const ushort M2C_SyncChatInfo = 10109;
		 public const ushort C2M_RechargeRequest = 10110;
		 public const ushort M2C_RechargeResponse = 10111;
		 public const ushort M2C_HorseNoticeInfo = 10112;
		 public const ushort C2M_ItemSortRequest = 10113;
		 public const ushort C2M_ItemHuiShouRequest = 10114;
		 public const ushort M2C_ItemHuiShouResponse = 10115;
		 public const ushort C2M_ItemMeltingRequest = 10116;
		 public const ushort M2C_ItemMeltingResponse = 10117;
		 public const ushort C2M_ItemQiangHuaRequest = 10118;
		 public const ushort M2C_ItemQiangHuaResponse = 10119;
		 public const ushort C2M_ItemXiLianRequest = 10120;
		 public const ushort M2C_ItemXiLianResponse = 10121;
		 public const ushort C2M_ItemOperateRequest = 10122;
		 public const ushort M2C_ItemOperateResponse = 10123;
		 public const ushort M2C_RoleBagUpdate = 10124;
		 public const ushort Actor_FubenEnergySkillRequest = 10125;
		 public const ushort Actor_FubenEnergySkillResponse = 10126;
		 public const ushort Actor_EnterFubenRequest = 10127;
		 public const ushort Actor_EnterFubenResponse = 10128;
		 public const ushort FubenInfo = 10129;
		 public const ushort SonFubenInfo = 10130;
		 public const ushort FubenPassInfo = 10131;
		 public const ushort Actor_GetFubenInfoRequest = 10132;
		 public const ushort Actor_GetFubenInfoResponse = 10133;
		 public const ushort Actor_EnterSonFubenRequest = 10134;
		 public const ushort Actor_EnterSonFubenResponse = 10135;
		 public const ushort Actor_QuitFubenRequest = 10136;
		 public const ushort Actor_QuitFubenResponse = 10137;
		 public const ushort Actor_SendReviveRequest = 10138;
		 public const ushort Actor_SendReviveResponse = 10139;
		 public const ushort M2C_FubenSettlement = 10140;
		 public const ushort Actor_GetFubenRewardRequest = 10141;
		 public const ushort Actor_GetFubenRewardReponse = 10142;
		 public const ushort Actor_PickItemRequest = 10143;
		 public const ushort Actor_PickItemResponse = 10144;
		 public const ushort Actor_ItemInitRequest = 10145;
		 public const ushort Actor_ItemInitResponse = 10146;
		 public const ushort C2M_TaskHuoYueRewardRequest = 10147;
		 public const ushort M2C_TaskHuoYueRewardResponse = 10148;
		 public const ushort C2M_TaskCountryInitRequest = 10149;
		 public const ushort M2C_TaskCountryInitResponse = 10150;
		 public const ushort C2M_CommitTaskCountryRequest = 10151;
		 public const ushort M2C_CommitTaskCountryResponse = 10152;
		 public const ushort M2C_TaskCountryUpdate = 10153;
		 public const ushort C2M_TaskInitRequest = 10154;
		 public const ushort M2C_TaskInitResponse = 10155;
		 public const ushort C2M_TaskGetRequest = 10156;
		 public const ushort M2C_TaskGetResponse = 10157;
		 public const ushort C2M_TaskGiveUpRequest = 10158;
		 public const ushort M2C_TaskGiveUpResponse = 10159;
		 public const ushort C2M_TaskTrackRequest = 10160;
		 public const ushort M2C_TaskTrackResponse = 10161;
		 public const ushort C2M_TaskNoticeRequest = 10162;
		 public const ushort M2C_TaskNoticeResponse = 10163;
		 public const ushort C2M_TaskCommitRequest = 10164;
		 public const ushort M2C_TaskCommitResponse = 10165;
		 public const ushort M2C_TaskUpdate = 10166;
		 public const ushort TaskPro = 10167;
		 public const ushort C2M_RolePetList = 10168;
		 public const ushort M2C_RolePetList = 10169;
		 public const ushort PetFubenInfo = 10170;
		 public const ushort M2C_RolePetUpdate = 10171;
		 public const ushort C2M_RolePetFormationSet = 10172;
		 public const ushort M2C_RolePetFormationSet = 10173;
		 public const ushort C2M_RolePetSkinSet = 10174;
		 public const ushort M2C_RolePetSkinSet = 10175;
		 public const ushort C2M_RolePetHeXin = 10176;
		 public const ushort M2C_RolePetHeXin = 10177;
		 public const ushort C2M_RolePetEggPut = 10178;
		 public const ushort M2C_RolePetEggPut = 10179;
		 public const ushort C2M_RolePetEggHatch = 10180;
		 public const ushort M2C_RolePetEggHatch = 10181;
		 public const ushort C2M_RolePetEggOpen = 10182;
		 public const ushort M2C_RolePetEggOpen = 10183;
		 public const ushort C2M_RolePetRName = 10184;
		 public const ushort M2C_RolePetRName = 10185;
		 public const ushort C2M_RolePetFight = 10186;
		 public const ushort M2C_RolePetFight = 10187;
		 public const ushort C2M_RolePetFenjie = 10188;
		 public const ushort M2C_RolePetFenjie = 10189;
		 public const ushort C2M_RolePetJiadian = 10190;
		 public const ushort M2C_RolePetJiadian = 10191;
		 public const ushort C2M_RolePetHeCheng = 10192;
		 public const ushort M2C_RolePetHeCheng = 10193;
		 public const ushort C2M_RolePetUpStar = 10194;
		 public const ushort M2C_RolePetUpStar = 10195;
		 public const ushort C2M_RolePetXiLian = 10196;
		 public const ushort M2C_RolePetXiLian = 10197;
		 public const ushort C2M_RolePetXiuLian = 10198;
		 public const ushort M2C_RolePetXiuLian = 10199;
		 public const ushort M2C_CreateRolePet = 10200;
		 public const ushort RolePetEgg = 10201;
		 public const ushort RolePetInfo = 10202;
		 public const ushort C2M_SkillInitRequest = 10203;
		 public const ushort M2C_SkillInitResponse = 10204;
		 public const ushort C2M_SkillUp = 10205;
		 public const ushort M2C_SkillUp = 10206;
		 public const ushort C2M_SkillSet = 10207;
		 public const ushort M2C_SkillSet = 10208;
		 public const ushort C2M_SkillOperation = 10209;
		 public const ushort M2C_SkillOperation = 10210;
		 public const ushort SkillPro = 10211;
		 public const ushort RewardItem = 10212;
		 public const ushort C2M_ChangeOccTwoRequest = 10213;
		 public const ushort M2C_ChangeOccTwoResponse = 10214;
		 public const ushort C2M_StoreBuyRequest = 10215;
		 public const ushort M2C_StoreBuyResponse = 10216;
		 public const ushort C2M_GameSettingRequest = 10217;
		 public const ushort M2C_GameSettingResponse = 10218;
		 public const ushort C2M_ModifyNameRequest = 10219;
		 public const ushort M2C_ModifyNameResponse = 10220;
		 public const ushort M2C_UpdateMailInfo = 10221;
		 public const ushort MailInfo = 10222;
		 public const ushort C2M_ReceiveMailRequest = 10223;
		 public const ushort M2C_ReceiveMailResponse = 10224;
		 public const ushort C2E_ReceiveMailRequest = 10225;
		 public const ushort E2C_ReceiveMailResponse = 10226;
		 public const ushort C2E_GetAllMailRequest = 10227;
		 public const ushort E2C_GetAllMailResponse = 10228;
		 public const ushort C2M_MakeEquipRequest = 10229;
		 public const ushort M2C_MakeEquipResponse = 10230;
		 public const ushort C2M_MakeLearnRequest = 10231;
		 public const ushort M2C_MakeLearnResponse = 10232;
		 public const ushort C2M_TianFuActiveRequest = 10233;
		 public const ushort M2C_TianFuActiveResponse = 10234;
		 public const ushort C2M_RealNameRewardRequest = 10235;
		 public const ushort M2C_RealNameRewardResponse = 10236;
		 public const ushort C2M_YueKaOpenRequest = 10237;
		 public const ushort M2C_YueKaOpenResponse = 10238;
		 public const ushort C2M_YueKaRewardRequest = 10239;
		 public const ushort M2C_YueKaRewardResponse = 10240;
		 public const ushort ChengJiuInfo = 10241;
		 public const ushort C2M_ChengJiuListRequest = 10242;
		 public const ushort M2C_ChengJiuListResponse = 10243;
		 public const ushort C2M_ChengJiuRewardRequest = 10244;
		 public const ushort M2C_ChengJiuRewardResponse = 10245;
		 public const ushort C2M_ChouKaRequest = 10246;
		 public const ushort M2C_ChouKaResponse = 10247;
		 public const ushort C2R_RankListRequest = 10248;
		 public const ushort R2C_RankListResponse = 10249;
		 public const ushort RankingInfo = 10250;
		 public const ushort RankPetInfo = 10251;
		 public const ushort C2R_RankPetListRequest = 10252;
		 public const ushort R2C_RankPetListResponse = 10253;
		 public const ushort C2M_RankPetCombatRequest = 10254;
		 public const ushort M2C_RankPetCombatResponse = 10255;
		 public const ushort C2M_QuitPetRankRequest = 10256;
		 public const ushort M2C_QuitPetRankResponse = 10257;
		 public const ushort C2M_PaiMaiShopRequest = 10258;
		 public const ushort M2C_PaiMaiShopResponse = 10259;
		 public const ushort C2P_PaiMaiShopShowListRequest = 10260;
		 public const ushort P2C_PaiMaiShopShowListResponse = 10261;
		 public const ushort C2M_PaiMaiBuyRequest = 10262;
		 public const ushort M2C_PaiMaiBuyResponse = 10263;
		 public const ushort C2M_PaiMaiSellRequest = 10264;
		 public const ushort M2C_PaiMaiSellResponse = 10265;
		 public const ushort PaiMaiItemInfo = 10266;
		 public const ushort PaiMaiShopItemInfo = 10267;
		 public const ushort C2P_PaiMaiListRequest = 10268;
		 public const ushort P2C_PaiMaiListResponse = 10269;
		 public const ushort C2M_PaiMaiXiaJiaRequest = 10270;
		 public const ushort M2C_PaiMaiXiaJiaResponse = 10271;
		 public const ushort C2M_StallOperationRequest = 10272;
		 public const ushort M2C_StallOperationResponse = 10273;
		 public const ushort C2M_PaiMaiDuiHuanRequest = 10274;
		 public const ushort M2C_PaiMaiDuiHuanResponse = 10275;
		 public const ushort MysteryItemInfo = 10276;
		 public const ushort C2M_MysteryBuyRequest = 10277;
		 public const ushort M2C_MysteryBuyResponse = 10278;
		 public const ushort Actor_FubenMoNengRequest = 10279;
		 public const ushort Actor_FubenMoNengResponse = 10280;
		 public const ushort C2M_RolePetChouKaRequest = 10281;
		 public const ushort M2C_RolePetChouKaResponse = 10282;
		 public const ushort C2M_EnergyReceiveRequest = 10283;
		 public const ushort M2C_EnergyReceiveResponse = 10284;
		 public const ushort C2M_EnergyAnswerRequest = 10285;
		 public const ushort M2C_EnergyAnswerResponse = 10286;
		 public const ushort C2M_EnergyInfoRequest = 10287;
		 public const ushort M2C_EnergyInfoResponse = 10288;
		 public const ushort Actor_PickBoxRequest = 10289;
		 public const ushort Actor_PickBoxResponse = 10290;
		 public const ushort C2C_GMInfoRequest = 10291;
		 public const ushort C2C_GMInfoResponse = 10292;
		 public const ushort C2E_GMEMailRequest = 10293;
		 public const ushort E2C_GMEMailResponse = 10294;
		 public const ushort C2R_DBServerInfoRequest = 10295;
		 public const ushort R2C_DBServerInfoResponse = 10296;
		 public const ushort C2A_MysteryListRequest = 10297;
		 public const ushort A2C_MysteryListResponse = 10298;
		 public const ushort C2M_ActivityReceiveRequest = 10299;
		 public const ushort M2C_ActivityReceiveResponse = 10300;
		 public const ushort C2M_ActivityInfoRequest = 10301;
		 public const ushort M2C_ActivityInfoResponse = 10302;
		 public const ushort C2M_ZhanQuReceiveRequest = 10303;
		 public const ushort M2C_ZhanQuReceiveResponse = 10304;
		 public const ushort C2M_ZhanQuInfoRequest = 10305;
		 public const ushort M2C_ZhanQuInfoResponse = 10306;
		 public const ushort ZhanQuReceiveNumber = 10307;
		 public const ushort TokenRecvive = 10308;
		 public const ushort TeamInfo = 10309;
		 public const ushort TeamPlayerInfo = 10310;
		 public const ushort C2T_TeamInviteRequest = 10311;
		 public const ushort T2C_TeamInviteResponse = 10312;
		 public const ushort C2T_TeamAgreeRequest = 10313;
		 public const ushort T2C_TeamAgreeResponse = 10314;
		 public const ushort C2T_TeamLeaveRequest = 10315;
		 public const ushort T2C_TeamLeaveResponse = 10316;
		 public const ushort C2T_TeamKickOutRequest = 10317;
		 public const ushort T2C_TeamKickOutResponse = 10318;
		 public const ushort C2T_TeamDungeonInfoRequest = 10319;
		 public const ushort T2C_TeamDungeonInfoResponse = 10320;
		 public const ushort C2T_TeamDungeonApplyRequest = 10321;
		 public const ushort T2C_TeamDungeonApplyResponse = 10322;
		 public const ushort C2T_TeamDungeonAgreeRequest = 10323;
		 public const ushort T2C_TeamDungeonAgreeResponse = 10324;
		 public const ushort C2M_TeamDungeonCreateRequest = 10325;
		 public const ushort M2C_TeamDungeonCreateResponse = 10326;
		 public const ushort C2M_TeamDungeonOpenRequest = 10327;
		 public const ushort M2C_TeamDungeonOpenResponse = 10328;
		 public const ushort C2M_TeamDungeonEnterRequest = 10329;
		 public const ushort M2C_TeamDungeonEnterResponse = 10330;
		 public const ushort M2C_TeamDungeonQuitMessage = 10331;
		 public const ushort C2M_TeamDungeonBoxRewardRequest = 10332;
		 public const ushort M2C_TeamDungeonBoxRewardResponse = 10333;
		 public const ushort M2C_TeamDungeonBoxRewardResult = 10334;
		 public const ushort M2C_TeamDungeonSettlement = 10335;
		 public const ushort M2C_TeamDungeonOpenResult = 10336;
		 public const ushort M2C_TeamInviteResult = 10337;
		 public const ushort M2C_TeamDungeonApplyResult = 10338;
		 public const ushort M2C_TeamUpdateResult = 10339;
		 public const ushort ChatUnitInfo = 10340;
		 public const ushort C2F_WatchPlayerRequest = 10341;
		 public const ushort F2C_WatchPlayerResponse = 10342;
		 public const ushort C2F_FriendInfoRequest = 10343;
		 public const ushort F2C_FriendInfoResponse = 10344;
		 public const ushort C2F_FriendApplyRequest = 10345;
		 public const ushort F2C_FriendApplyResponse = 10346;
		 public const ushort C2F_FriendBlacklistRequest = 10347;
		 public const ushort F2C_FriendBlacklistResponse = 10348;
		 public const ushort M2C_FriendApplyResult = 10349;
		 public const ushort C2F_FriendApplyReplyRequest = 10350;
		 public const ushort F2C_FriendApplyReplyResponse = 10351;
		 public const ushort FriendInfo = 10352;
		 public const ushort C2M_UserInfoRequest = 10353;
		 public const ushort M2C_UserInfoInitResponse = 10354;
		 public const ushort RechargeInfo = 10355;
		 public const ushort ShouJiChapterInfo = 10356;
		 public const ushort M2C_GameNotice = 10357;
		 public const ushort C2M_UnionCreateRequest = 10358;
		 public const ushort M2C_UnionCreateResponse = 10359;
		 public const ushort C2U_UnionListRequest = 10360;
		 public const ushort U2C_UnionListResponse = 10361;
		 public const ushort C2U_UnionApplyRequest = 10362;
		 public const ushort U2C_UnionApplyResponse = 10363;
		 public const ushort C2U_UnionMyInfoRequest = 10364;
		 public const ushort U2C_UnionMyInfoResponse = 10365;
		 public const ushort C2M_UnionLeaveRequest = 10366;
		 public const ushort M2C_UnionLeaveResponse = 10367;
		 public const ushort C2U_UnionApplyListRequest = 10368;
		 public const ushort U2C_UnionApplyListResponse = 10369;
		 public const ushort C2U_UnionApplyReplyRequest = 10370;
		 public const ushort U2C_UnionApplyReplyResponse = 10371;
		 public const ushort C2U_UnionOperatateRequest = 10372;
		 public const ushort U2C_UnionOperatateResponse = 10373;
		 public const ushort C2U_UnionKickOutRequest = 10374;
		 public const ushort U2C_UnionKickOutResponse = 10375;
		 public const ushort M2C_UnionApplyResult = 10376;
		 public const ushort UnionInfo = 10377;
		 public const ushort UnionApplyItem = 10378;
		 public const ushort UnionPlayerInfo = 10379;
		 public const ushort UnionListItem = 10380;
		 public const ushort C2M_ReddotReadRequest = 10381;
		 public const ushort M2C_ReddotReadResponse = 10382;
		 public const ushort C2M_GuideUpdateRequest = 10383;
		 public const ushort M2C_GuideUpdateResponse = 10384;
		 public const ushort C2M_YeWaiSceneRequest = 10385;
		 public const ushort M2C_YeWaiSceneResponse = 10386;
		 public const ushort C2M_YeWaiSceneQuitRequest = 10387;
		 public const ushort M2C_YeWaiSceneQuitResponse = 10388;
		 public const ushort C2M_ShoujiRewardRequest = 10389;
		 public const ushort M2C_ShoujiRewardResponse = 10390;
		 public const ushort C2M_LingDiUpRequest = 10391;
		 public const ushort M2C_LingDiUpResponse = 10392;
		 public const ushort C2M_LingDiRewardRequest = 10393;
		 public const ushort M2C_LingDiRewardResponse = 10394;
		 public const ushort C2M_XiuLianCenterRequest = 10395;
		 public const ushort M2C_XiuLianCenterResponse = 10396;
		 public const ushort C2M_PetFubenBeginRequest = 10397;
		 public const ushort M2C_PetFubenBeginResponse = 10398;
		 public const ushort C2M_PetFubenOverRequest = 10399;
		 public const ushort C2M_PetFubenRewardRequest = 10400;
		 public const ushort M2C_PetFubenRewardResponse = 10401;
		 public const ushort C2M_HongBaoOpenRequest = 10402;
		 public const ushort M2C_HongBaoOpenResponse = 10403;
		 public const ushort C2M_RandomTowerBeginRequest = 10404;
		 public const ushort M2C_RandomTowerBeginResponse = 10405;
		 public const ushort C2M_RandomTowerRewardRequest = 10406;
		 public const ushort M2C_RandomTowerRewardResponse = 10407;
		 public const ushort C2M_PetHeXinHeChengRequest = 10408;
		 public const ushort M2C_PetHeXinHeChengResponse = 10409;
		 public const ushort C2M_ChouKaRewardRequest = 10410;
		 public const ushort M2C_ChouKaRewardResponse = 10411;
		 public const ushort C2M_RoleAddPointRequest = 10412;
		 public const ushort M2C_RoleAddPointResponse = 10413;
		 public const ushort C2R_CampRankListRequest = 10414;
		 public const ushort R2C_CampRankListResponse = 10415;
		 public const ushort C2M_CampRankSelectRequest = 10416;
		 public const ushort M2C_CampRankSelectResponse = 10417;
		 public const ushort C2M_RoleOpenCangKuRequest = 10418;
		 public const ushort M2C_RoleOpenCangKuResponse = 10419;
		 public const ushort C2M_PetEggDuiHuanRequest = 10420;
		 public const ushort M2C_PetEggDuiHuanResponse = 10421;
		 public const ushort C2M_PetEggChouKaRequest = 10422;
		 public const ushort M2C_PetEggChouKaResponse = 10423;
		 public const ushort C2M_RolePetEggPutOut = 10424;
		 public const ushort M2C_RolePetEggPutOut = 10425;
		 public const ushort C2M_PetHeXinHeChengQuickRequest = 10426;
		 public const ushort M2C_PetHeXinHeChengQuickResponse = 10427;
		 public const ushort ServerInfo = 10428;
		 public const ushort C2R_WorldLvRequest = 10429;
		 public const ushort R2C_WorldLvResponse = 10430;
		 public const ushort C2M_ExpToGoldRequest = 10431;
		 public const ushort M2C_ExpToGoldResponse = 10432;
		 public const ushort C2M_MakeSelectRequest = 10433;
		 public const ushort M2C_MakeSelectResponse = 10434;
		 public const ushort FirstWinInfo = 10435;
		 public const ushort C2A_FirstWinInfoRequest = 10436;
		 public const ushort A2C_FirstWinInfoResponse = 10437;
		 public const ushort C2M_ItemXiLianRewardRequest = 10438;
		 public const ushort M2C_ItemXiLianRewardResponse = 10439;
		 public const ushort C2M_BuChangeRequest = 10440;
		 public const ushort M2C_BuChangeResponse = 10441;
		 public const ushort ItemXiLianResult = 10442;
		 public const ushort C2M_ItemXiLianSelectRequest = 10443;
		 public const ushort M2C_ItemXiLianSelectResponse = 10444;
		 public const ushort C2M_ItemXiLianTransferRequest = 10445;
		 public const ushort M2C_ItemXiLianTransferResponse = 10446;
		 public const ushort C2G_ExitGameGate = 10447;
		 public const ushort G2C_ExitGameGate = 10448;
		 public const ushort C2M_ItemOperateGemRequest = 10449;
		 public const ushort M2C_ItemOperateGemResponse = 10450;
		 public const ushort C2M_PetDuiHuanRequest = 10451;
		 public const ushort M2C_PetDuiHuanResponse = 10452;
		 public const ushort C2M_ActivityRechargeSignRequest = 10453;
		 public const ushort M2C_ActivityRechargeSignResponse = 10454;
		 public const ushort C2M_TeamDungeonRBornRequest = 10455;
		 public const ushort M2C_TeamDungeonRBornResult = 10456;
		 public const ushort C2M_RefreshUnitRequest = 10457;
		 public const ushort M2C_BattleInfoResult = 10458;
		 public const ushort C2M_TaskLoopGetRequest = 10459;
		 public const ushort M2C_TaskLoopGetResponse = 10460;
		 public const ushort M2C_TeamPickMessage = 10461;
		 public const ushort C2M_TeamPickRequest = 10462;
		 public const ushort C2G_LoginRobotRequest = 10463;
		 public const ushort G2C_LoginRobotResponse = 10464;
		 public const ushort C2M_TrialDungeonFinishRequest = 10465;
		 public const ushort M2C_TrialDungeonFinishResponse = 10466;
		 public const ushort C2M_TrialDungeonBeginRequest = 10467;
		 public const ushort M2C_TrialDungeonBeginResponse = 10468;
		 public const ushort C2M_HorseRideRequest = 10469;
		 public const ushort M2C_HorseRideResponse = 10470;
		 public const ushort C2M_TowerFightBeginRequest = 10471;
		 public const ushort M2C_TowerFightBeginResponse = 10472;
		 public const ushort C2M_TowerExitRequest = 10473;
		 public const ushort M2C_TowerExitResponse = 10474;
		 public const ushort M2C_UpdateSkillSet = 10475;
		 public const ushort C2C_SendBroadcastRequest = 10476;
		 public const ushort C2C_SendBroadcastResponse = 10477;
		 public const ushort M2C_UnitFinishSkill = 10478;
		 public const ushort M2C_SyncMiJingDamage = 10479;
		 public const ushort C2M_FubenTimesResetRequest = 10480;
		 public const ushort M2C_FubenTimesResetResponse = 10481;
		 public const ushort C2M_IOSPayVerifyRequest = 10482;
		 public const ushort M2C_IOSPayVerifyResponse = 10483;
		 public const ushort C2M_FubenMessageRequest = 10484;
		 public const ushort M2C_FubenMessageResponse = 10485;
		 public const ushort M2C_UpdateVersion = 10486;
		 public const ushort C2M_ShareSucessRequest = 10487;
		 public const ushort M2C_ShareSucessResponse = 10488;
	}
}
