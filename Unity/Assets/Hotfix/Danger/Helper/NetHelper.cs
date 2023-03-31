namespace ET
{

    public static class NetHelper
    {

        public static async ETTask<int> RequestTowerReward(Scene zoneScene, int towerid)
        {
            C2M_RandomTowerRewardRequest request = new C2M_RandomTowerRewardRequest() { RewardId = towerid };
            M2C_RandomTowerRewardResponse respone = (M2C_RandomTowerRewardResponse)await zoneScene.GetComponent<SessionComponent>().Session.Call(request);
            if (respone.Error== ErrorCore.ERR_Success)
            {
                UserInfoComponent userInfoComponent = zoneScene.GetComponent<UserInfoComponent>();
                userInfoComponent.UserInfo.TowerRewardIds.Add(towerid);
            }
            return respone.Error;
        }

        public static async ETTask<int> RequstArenaEnter(Scene zoneScene)
        {
            int sceneId = BattleHelper.GetSceneIdByType(SceneTypeEnum.Arena);
            //FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1031);
            //bool intime = FunctionHelp.IsInTime(funtionConfig.OpenTime);
            //if (!intime)
            //{
            //    return ErrorCore.ERR_AlreadyFinish;
            //}
            int errorCode = await EnterFubenHelp.RequestTransfer(zoneScene, SceneTypeEnum.Arena, sceneId);
            return errorCode;
        }

        public static async ETTask<int> RequstBattleEnter(Scene zoneScene)
        {
            int sceneId = BattleHelper.GetBattFubenId(zoneScene.GetComponent<UserInfoComponent>().UserInfo.Lv);
            if (sceneId == 0)
            {
                return ErrorCore.ERR_LevelNoEnough;
            }
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1025);
            bool intime = FunctionHelp.IsInTime(funtionConfig.OpenTime);
            if (!intime)
            {
                return ErrorCore.ERR_AlreadyFinish;
            }
            int errorCode = await EnterFubenHelp.RequestTransfer(zoneScene, SceneTypeEnum.Battle, sceneId);
            return errorCode;
        }

        public static async ETTask SendReddotRead(Scene scene, int reddotType)
        {
            C2M_ReddotReadRequest m_ReddotReadRequest = new C2M_ReddotReadRequest() { ReddotType = reddotType };
            M2C_ReddotReadResponse m_ReddotReadResponse = (M2C_ReddotReadResponse)await scene.GetComponent<SessionComponent>().Session.Call(m_ReddotReadRequest);
            scene.GetComponent<ReddotComponent>().RemoveReddont(reddotType);
        }

        public static async ETTask PaiMaiStallRequest(Scene scene, int statllType)
        {
            C2M_StallOperationRequest c2M_PaiMaiBuyRequest = new C2M_StallOperationRequest() { StallType = statllType };
            M2C_StallOperationResponse m2C_PaiMaiBuyResponse = (M2C_StallOperationResponse)await scene.GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);
        }

        public static async ETTask RequestUserInfo(Scene zoneScene, bool relink = false)
        {
            C2M_UserInfoRequest c2M_PaiMaiBuyRequest = new C2M_UserInfoRequest() {  };
            M2C_UserInfoInitResponse m2C_PaiMaiBuyResponse = (M2C_UserInfoInitResponse)await zoneScene.GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);
            zoneScene.GetComponent<UserInfoComponent>().UserInfo = m2C_PaiMaiBuyResponse.UserInfo;
            zoneScene.GetComponent<ReddotComponent>().ReddontList = m2C_PaiMaiBuyResponse.ReddontList;
            zoneScene.GetComponent<ShoujiComponent>().TreasureInfo = m2C_PaiMaiBuyResponse.TreasureInfo;
            zoneScene.GetComponent<ShoujiComponent>().ShouJiChapterInfos = m2C_PaiMaiBuyResponse.ShouJiChapterInfos;
            zoneScene.GetComponent<TitleComponent>().TitleList = m2C_PaiMaiBuyResponse.TitleList;
            await ETTask.CompletedTask;
        }

        public static async ETTask RequestUnitInfo(Scene zoneScene, bool relink = false)
        {
            C2M_UnitInfoRequest request = new C2M_UnitInfoRequest() { };
            M2C_UnitInfoResponse response = (M2C_UnitInfoResponse)await zoneScene.GetComponent<SessionComponent>().Session.Call(request);

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            for (int i = 0; i < response.Ks.Count; ++i)
            {
                numericComponent.Set(response.Ks[i], response.Vs[i]);
            }
            await ETTask.CompletedTask;
        }

        public static async ETTask RequestBagInfo(Scene zoneScene)
        {
            await zoneScene.GetComponent<BagComponent>().GetAllBagItem();
        }

        public static async ETTask RequestFriendInfo(Scene zoneScene)
        {
            UserInfoComponent userInfoComponent = zoneScene.GetComponent<UserInfoComponent>();
            FriendComponent friendComponent = zoneScene.GetComponent<FriendComponent>();
            C2F_FriendInfoRequest c2M_ItemHuiShouRequest = new C2F_FriendInfoRequest() { UserID = userInfoComponent.UserInfo.UserId };
            F2C_FriendInfoResponse F2C_FriendInfoResponse = (F2C_FriendInfoResponse)await zoneScene.GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);

            friendComponent.FriendList = F2C_FriendInfoResponse.FriendList;
            friendComponent.ApplyList = F2C_FriendInfoResponse.ApplyList;
            friendComponent.Blacklist = F2C_FriendInfoResponse.Blacklist;
        }

        public static async ETTask RequestChengJiuData(Scene zoneScene)
        {
            await zoneScene.GetComponent<ChengJiuComponent>().GetChengJiuList();
        }

        public static async ETTask RequestJiaYuanInfo(Scene zoneScene)
        {
            C2M_JiaYuanInitRequest  request = new C2M_JiaYuanInitRequest();
            M2C_JiaYuanInitResponse response = (M2C_JiaYuanInitResponse)await zoneScene.GetComponent<SessionComponent>().Session.Call(request);
            JiaYuanComponent jiaYuanComponent = zoneScene.GetComponent<JiaYuanComponent>();
            jiaYuanComponent.PlanOpenList_3 = response.PlanOpenList;
            jiaYuanComponent.PurchaseItemList_3 = response.PurchaseItemList;
            jiaYuanComponent.LearnMakeIds_3 = response.LearnMakeIds;
            jiaYuanComponent.JiaYuanPastureList_3 = response.JiaYuanPastureList;
        }

        public static async ETTask RequestAllPets(Scene zoneScene)
        {
            await zoneScene.GetComponent<PetComponent>().RequestAllPets();
        }

        //1出战 0休息
        public static async ETTask RequestPetFight(Scene zoneScene, long petId, int fight)
        {
            await zoneScene.GetComponent<PetComponent>().RequestPetFight(petId, fight);
        }

        public static async ETTask RequestIniTask(Scene zoneScene)
        {
            await zoneScene.GetComponent<TaskComponent>().SendIniTask();
        }

        public static async ETTask SendGetTask(Scene zoneScene, int taskid)
        {
            await zoneScene.GetComponent<TaskComponent>().SendGetTask(taskid);
        }

        public static async ETTask SendTaskNotice(Scene zoneScene, int taskid)
        {
            await zoneScene.GetComponent<TaskComponent>().SendTaskNotice(taskid);
        }

        public static async ETTask RequestSkillSet(Scene zoneScene)
        {
            await zoneScene.GetComponent<SkillSetComponent>().RequestSkillSet();
        }

        public static async ETTask RequestActivityInfo(Scene zoneScene)
        {
            ActivityComponent activityComponent = zoneScene.GetComponent<ActivityComponent>();
            C2M_ActivityInfoRequest c2M_ItemHuiShouRequest = new C2M_ActivityInfoRequest() { };
            M2C_ActivityInfoResponse r2c_roleEquip = (M2C_ActivityInfoResponse)await zoneScene.GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
            activityComponent.ActivityReceiveIds = r2c_roleEquip.ReceiveIds;
            activityComponent.LastSignTime = r2c_roleEquip.LastSignTime;
            activityComponent.TotalSignNumber = r2c_roleEquip.TotalSignNumber;
            activityComponent.QuTokenRecvive = r2c_roleEquip.QuTokenRecvive;
            activityComponent.LastLoginTime = r2c_roleEquip.LastLoginTime;
            activityComponent.DayTeHui = r2c_roleEquip.DayTeHui;
        }

        public static async ETTask RequestZhanQuInfo(Scene zoneScene)
        {
            ActivityComponent activityComponent = zoneScene.GetComponent<ActivityComponent>();
            C2M_ZhanQuInfoRequest request = new C2M_ZhanQuInfoRequest() { };
            M2C_ZhanQuInfoResponse r2c_roleEquip = (M2C_ZhanQuInfoResponse)await zoneScene.GetComponent<SessionComponent>().Session.Call(request);

            activityComponent.ZhanQuReceiveIds = r2c_roleEquip.ReceiveIds;
            activityComponent.ZhanQuReceiveNumbers = r2c_roleEquip.ReceiveNum;
        }

        public static async ETTask RequestRemoveBlack(Scene zoneScene, long friendId)
        {
            UserInfoComponent userInfoComponent = zoneScene.GetComponent<UserInfoComponent>();
            C2F_FriendBlacklistRequest c2F_FriendApplyReplyRequest = new C2F_FriendBlacklistRequest()
            {
                OperateType = 2,
                UserID = userInfoComponent.UserInfo.UserId,
                FriendId = friendId,
            };
            F2C_FriendBlacklistResponse f2C_FriendApplyResponse = (F2C_FriendBlacklistResponse)await zoneScene.GetComponent<SessionComponent>().Session.Call(c2F_FriendApplyReplyRequest);
        }

        public static void SendIOSPayVerifyRequest(Scene zoneScene, string info)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            Receipt receipt = JsonHelper.FromJson<Receipt>(info);
            ET.Log.ILog.Debug("payload[内购成功]:" + receipt.Payload);
            C2R_IOSPayVerifyRequest request = new C2R_IOSPayVerifyRequest() { UnitId = unit.Id, payMessage = receipt.Payload };
            zoneScene.GetComponent<SessionComponent>().Session.Call(request).Coroutine();
        }

        public static async ETTask<int> RequestEquipMake(Scene zoneScene, long  baginfoId, int makeId)
        {
            C2M_MakeEquipRequest request = new C2M_MakeEquipRequest() { BagInfoID = baginfoId, MakeId = makeId };
            M2C_MakeEquipResponse response = (M2C_MakeEquipResponse)await zoneScene.GetComponent<SessionComponent>().Session.Call(request);
            if (response.ItemId == 0)
            {
                HintHelp.GetInstance().ShowHint("制作失败!");
            }
            if (response.NewMakeId != 0)
            {
                EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(response.NewMakeId);
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equipMakeConfig.MakeItemID);
                HintHelp.GetInstance().ShowHint($"恭喜你领悟到新的制作技能 {itemConfig.ItemName}");
                zoneScene.GetComponent<UserInfoComponent>().UserInfo.MakeList.Add(response.NewMakeId);
            }
            if (baginfoId == 0)
            {
                zoneScene.GetComponent<UserInfoComponent>().OnMakeItem(makeId);
            }
            return response.Error;
        }
    }
}
