namespace ET
{
    public static class ErrorCore
    {
        public const int ERR_Success = 0;
        public const int ERR_MyErrorCore = 110000;
        
        public const int ERR_KcpConnectTimeout = 100205;
        public const int ERR_PeerDisconnect = 100208;
        public const int ERR_SocketCantSend = 100209;
        public const int ERR_SocketError = 100210;
        public const int ERR_KcpWaitSendSizeTooLarge = 100211;
        public const int ERR_KcpCreateError = 100212;
        public const int ERR_SendMessageNotFoundTChannel = 100213;
        public const int ERR_TChannelRecvError = 100214;
        public const int ERR_MessageSocketParserError = 100215;
        public const int ERR_KcpNotFoundChannel = 100216;

        public const int ERR_WebsocketSendError = 100217;
        public const int ERR_WebsocketPeerReset = 100218;
        public const int ERR_WebsocketMessageTooBig = 100219;
        public const int ERR_WebsocketRecvError = 100220;
        
        public const int ERR_KcpReadNotSame = 100230;
        public const int ERR_KcpSplitError = 100231;
        public const int ERR_KcpSplitCountError = 100232;

        public const int ERR_ActorLocationSenderTimeout = 110004;
        public const int ERR_PacketParserError = 110005;
        public const int ERR_KcpChannelAcceptTimeout = 110206;
        public const int ERR_KcpRemoteDisconnect = 110207;
        public const int ERR_WebsocketError = 110303;
        public const int ERR_WebsocketConnectError = 110304;
        public const int ERR_RpcFail = 110307;
        public const int ERR_ReloadFail = 110308;
        public const int ERR_ConnectGateKeyError = 110309;
        public const int ERR_SessionSendOrRecvTimeout = 110311;
        public const int ERR_OuterSessionRecvInnerMessage = 110312;
        public const int ERR_NotFoundActor = 110313;
        public const int ERR_ActorTimeout = 110315;
        public const int ERR_UnverifiedSessionSendMessage = 110316;
        public const int ERR_ActorLocationSenderTimeout2 = 110317;
        public const int ERR_ActorLocationSenderTimeout3 = 110318;
        public const int ERR_ActorLocationSenderTimeout4 = 110319;
        public const int ERR_ActorLocationSenderTimeout5 = 110320;
        
        public const int ERR_KcpRouterTimeout = 110401;
        public const int ERR_KcpRouterTooManyPackets = 110402;
        public const int ERR_KcpRouterSame = 110402;
        
        // 110000 以上，避免跟SocketError冲突


        //-----------------------------------

        // 小于这个Rpc会抛异常，大于这个异常的error需要自己判断处理，也就是说需要处理的错误应该要大于该值
        public const int ERR_Exception = 200000;

        public const int ERR_Cancel = 200001;

        public const int ERR_Error = 200002;                                       //通用错误

        public const int ERR_NetWorkError = 200003;                                 //网络错误

        public const int ERR_OperationOften = 200004;                               //操作太频繁
        

        public const int ERR_TransferFailError = 200006;
        public const int ERR_EnterSonFubenError = 200008;
        public const int ERR_GoldNotEnoughError = 200009;                           //金币不足
        public const int ERR_DiamondNotEnoughError = 200010;                        //钻石不足
        public const int ERR_UnSafeSqlString = 200012;                              //非法字符串
        public const int ERR_EquipLvLimit = 200013;                                 //装备等级不足
        public const int ERR_BagIsFull = 200014;                                    //背包已满
        public const int ERR_ItemNotEnoughError = 200015;                           //道具不足
        public const int ERR_UserNoFind = 200016;                                   //未查询到角色      
        public const int ERR_RequestSceneTypeError = 200017;                        //"请求的Scene错误
        public const int ERR_ItemOnlyUseMiJing = 200018;                            //该道具只能在秘境使用
        public const int ERR_ItemOnlyUseOcc = 200019;                               //只有某职业才能使用
        public const int ERR_VitalityNotEnoughError = 200020;                       //活力不足
        public const int ERR_ItemDropProtect = 200021;                              //掉落保护中
        public const int ERR_NoPayValueError = 200022;                              //赞助额度不足
        public const int ERR_ItemNoUseTime = 200023;                                //道具使用次数不足
        public const int ERR_ItemBelongOther = 200024;                              //道具归属别人
        public const int ERR_ZhuaBuFail = 200025;
        public const int ERR_AleardyMaxCell = 200026;
        public const int ERR_HouBiNotEnough= 200027;                                 //金币不足
        public const int ERR_ItemNotExist = 200028;                                  //道具不存在
        public const int ERR_ItemBing = 200029;                                     //道具绑定状态

        //登录
        public const int ERR_AccountAlreadyRegister = 200101;                       //表示账号已经被注册
        public const int ERR_AccountOrPasswordError = 200102;                       //登录时,表示密码错误
        public const int ERR_RequestRepeatedly = 200103;                            //请求重复
        public const int ERR_LoginInfoIsNull = 200104;                              //登录出错
        public const int ERR_AccountInBlackListError = 200105;                      //账号黑名单
        public const int ERR_OtherAccountLogin = 200106;                            //异地登录
        public const int ERR_TokenError = 200107;                                   //token错误
        public const int ERR_EnterGameError = 200108;
        public const int ERR_ReEnterGameError = 200109;
        public const int ERR_ReEnterGameError2 = 200109;
        public const int ERR_SessionPlayerError = 200110;
        public const int ERR_NonePlayerError = 200111;
        public const int ERR_PlayerSessionError = 200112;
        public const int ERR_SessionStateError = 200113;
        public const int ERR_LoginTimeOut = 200114;                                 //登录超时
        public const int ERR_EnterQueue = 200115;                                   //进入排队    
        public const int ERR_LoginRealm = 200116;
        public const int ERR_StopServer = 200117;
        public const int ERR_BingPhoneError_1 = 200118;
        public const int ERR_BingPhoneError_2 = 200119;
        public const int ERR_VersionNoMatch = 200120;
        public const int ERR_ModifyData = 200121;

        //300001-400001 服务器提示性错误码
        //角色
        public const int ERR_EquipAppraisal_Item = 300001;                          //装备鉴定道具不足
        public const int ERR_ItemUseError = 300002;                                 //道具使用失败
        public const int ERR_Occ_Hint_1 = 300101;                                   //转职等级不足
        public const int ERR_Occ_Hint_2 = 300102;                                   //已经进行转职
        public const int ERR_NotRealName = 300202;                                  //登录时,未实名认证
        public const int ERR_GMError = 300203;
        public const int ERR_AlreadyReceived = 300204;                              //领取过奖励
        public const int ERR_RealNameFail = 300205;                              //实名认证失败

        public const int ERR_MailFull = 300301;                                     //邮箱已满
        public const int ERR_CreateRoleName = 300302;
        public const int ERR_WordChat = 300303;                                     //世界频道发消息 1分钟1次
        public const int ERR_InMakeCD = 300304;
        public const int ERR_MakeTypeError = 300305;
        public const int ERR_RoleNameRepeat = 300306;
        public const int ERR_ShuLianDuNotEnough = 300307;                           //熟练度不足
        public const int ERR_EquipType = 300308;                                    //装备类型不符
        public const int ERR_GemNoError = 300309;                                   //道具使用失败
        public const int ERR_GemShiShiNumFull = 300310;                             //镶嵌史诗宝石达到上限

        //队伍
        public const int ERR_TeamIsFull = 300401;                                   //队伍已满
        public const int ERR_LevelIsNot = 300402;                                   //等级不足
        public const int ERR_IsHaveTeam = 300403;                                   //已经有组队了
        public const int ERR_TimesIsNot = 300404;                                   //组队次数不足
        public const int ERR_IsNotLeader = 300405;                                  //队长才能创建副本
        public const int ERR_PlayerIsNot = 300406;                                  //人数不足
        public const int ERR_TeamerLevelIsNot = 300407;                            //队员等级不足
        public const int Err_TeamDungeonXieZhu = 300408;
        public const int Err_TeamIsNull = 300409;                                   //队伍信息为空
        public const int Err_HaveNotPrepare = 300410;                                //还有没准备的
        public const int Err_ShenYuanItemError = 300411;                             //深渊道具不足
        public const int Err_PlayerRefuse = 300412;
        public const int Err_OnLineTimeNot = 300413;
        public const int Err_OnLineTimeNotFenXiang = 300414;
        public const int ERR_LevelIsNotFenXiang = 300415;                                   //等级不足

        //防沉迷
        public const int ERR_FangChengMi_Tip1 = 300501;
        public const int ERR_FangChengMi_Tip2 = 300502;
        public const int ERR_FangChengMi_Tip3 = 300503;
        public const int ERR_FangChengMi_Tip4 = 300504;
        public const int ERR_FangChengMi_Tip5 = 300505;
        public const int ERR_FangChengMi_Tip6 = 300506;
        public const int ERR_FangChengMi_Tip7 = 300507;

        public const int ERR_TaskCommited = 300601;                             //已经领取
        public const int ERR_NotFindLevel = 300602;                             //找不到对应关卡
        public const int ERR_TiLiNoEnough = 300603;                             //体力不足
        public const int ERR_LevelNotOpen = 300604;                             //前置关卡未通关
        public const int ERR_LevelNoEnough = 300605;                            //等级不足
        public const int ERR_LevelNormalNoPass = 300606;                        //普通关卡未通关
        public const int ERR_LevelChallengeNoPass = 300607;                     //挑战关卡未通关
        public const int ERR_NotFindNpc = 300608;                               //"当前场景未找到NPC"
        public const int ERR_TaskCanNotGet = 300609;                             //任务未达到领取条件
        public const int ERR_ExpNoEnough = 300610;                            //经验不足
        public const int ERR_NotFindAccount = 300611;

        //活动
        public const int ERR_RoleYueKaRepeat = 300701;                          //月卡重复状态
        public const int ERR_AlreadyFinish = 300702;

        /// <summary>
        /// 技能CD中
        /// </summary>
        public const int ERR_UseSkillInCD1 = 300801;    
        /// <summary>
        /// 技能公用CD
        /// </summary>
        public const int ERR_UseSkillInCD2 = 300802;
        /// <summary>
        /// 当前状态无法释放技能
        /// </summary>
        public const int ERR_CanNotUseSkill_1 = 300803;
        public const int ERR_UseSkillError = 300804;
        public const int ERR_NoUseItemSkill = 300805;
        public const int ERR_CanNotSkillDead = 300806;

        public const int ERR_UseSkillInCD3 = 300811;
        public const int ERR_UseSkillInCD4 = 300812;

        public const int ERR_UseSkillInCD5 = 300813;
        public const int ERR_UseSkillInCD6 = 300814;
        public const int ERR_SkillMoveTime = 300815;

        public const int ERR_CanNotUseSkill_Rigidity = 300816;
        public const int ERR_CanNotUseSkill_NetWait = 300817;
        public const int ERR_CanNotUseSkill_Dizziness = 300818;
        public const int ERR_CanNotUseSkill_JiTui = 300819;
        public const int ERR_CanNotUseSkill_Silence = 300820;

        public const int ERR_CanNotMove_1 = 300830;
        public const int ERR_CanNotMove_Dead = 300831;
        public const int ERR_CanNotMove_Rigidity = 300832;
        public const int ERR_CanNotMove_NetWait = 300833;
        public const int ERR_CanNotMove_Dizziness = 300834;
        public const int ERR_CanNotMove_JiTui = 300835;
        public const int ERR_CanNotMove_Shackle = 300836;
  
        //宠物
        public const int ERR_Pet_Hint_1 = 300901;                                   //宠物星级出错
        public const int ERR_Pet_UpStar = 300902;                                   //宠物星级失败                                                                 //宠物
        public const int ERR_Pet_AddSkillSame = 300903;                             //宠物打书技能ID相同
        public const int ERR_Pet_NoUseItem = 300904;                              //无法给宠物使用道具
        public const int ERR_PetIsFull = 300905;                                    //宠物已满
        public const int ERR_Pet_UpStage = 300906;                                   //宠物进阶   

        public const int ERR_Union_Same_Name = 301001;                              //同名的家族
        public const int ERR_MysteryItem_Max = 301002;                              //改道具每日购买次数已达上限
        public const int ERR_Union_Not_Exist = 301003;                              //家族不存在
        public const int ERR_UnionXiuLianMax = 301004;
        public const int ERR_Union_PeopleMax = 301005;                              //家族人数上限

        //赏金任务
        public const int ERR_ShangJinNumFull = 301101;                              //赏金任务完成上限

        //战场
        public const int ERR_BattleJoined = 301201;                                //已经参与过战场活动

        //拍卖行
        public const int Err_PaiMaiPriceLow = 301301;                               //拍卖出售价格过低
        public const int Err_StopPaiMai = 301302;                               //拍卖道具无法上架

        //充值
        public const int ERR_IOSVerify = 301401;

        //坐骑
        public const int ERR_HoreseNotActive = 301501;                                //坐骑未激活
        public const int ERR_HoreseNotFight = 301502;                                 //坐骑未出战

        //珍宝
        public const int ERR_ShouJIActived = 301601;                                    //已经激活

        //称号
        public const int ERR_TitleNoActived = 301701;                                   //称号未激活

        //家园
        public const int ERR_AlreadyPlant = 301801;
        public const int ERR_CanNotGather = 301802;
        public const int ERR_WarehouseFul = 301803;
        public const int ERR_PeopleNumber = 301804;
        public const int ERR_JiaYuanLevel = 301805;
        public const int ERR_JiaYuanSteal = 301806;

        //推广
        public const int ERR_PopularizeNot = 301901;
        public const int ERR_PopularizeMax = 301901;
        public const int ERR_PopularizeThe = 301902;
        public const int ERR_SerialNoExist = 301903;

        public static bool IsRpcNeedThrowException(int error)
        {
            if (error == 0)
            {
                return false;
            }
            // ws平台返回错误专用的值
            if (error == -1)
            {
                return false;
            }

            if (error > ERR_Exception)
            {
                return false;
            }

            return true;
        }
    }
}