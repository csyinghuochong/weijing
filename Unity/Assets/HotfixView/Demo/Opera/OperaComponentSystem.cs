using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{
    public enum LayerEnum
    {
        Drop,
        NPC,
        Terrain,
        Monster,
        Player,
        Map,
        RenderTexture,
        Box,
        Obstruct,
        Building,
    }

    [ObjectSystem]
    public class OperaComponentAwakeSystem : AwakeSystem<OperaComponent>
    {
        public override void Awake(OperaComponent self)
        {
            self.mainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
            self.mapMask =
                (1 << LayerMask.NameToLayer(LayerEnum.Terrain.ToString())) |
                (1 << LayerMask.NameToLayer(LayerEnum.Map.ToString()));

            self.npcMask = 1 << LayerMask.NameToLayer(LayerEnum.NPC.ToString());
            self.boxMask = 1 << LayerMask.NameToLayer(LayerEnum.Box.ToString());
            self.playerMask = 1 << LayerMask.NameToLayer(LayerEnum.Player.ToString());
            self.monsterMask = 1 << LayerMask.NameToLayer(LayerEnum.Monster.ToString());
            self.buildingMask = 1 << LayerMask.NameToLayer(LayerEnum.Building.ToString());

            Init init = GameObject.Find("Global").GetComponent<Init>();
            self.EditorMode = init.EditorMode;
            self.MainUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            init.OnGetKeyHandler = (int key) => { self.OnGetKeyHandler(key); };
            init.OnGetMouseButtonDown_0 = self.OnGetMouseButtonDown_0;
            init.OnGetMouseButtonDown_1 = self.OnGetMouseButtonDown_1;
            self.UpdateClickMode();
        }
    }

    [ObjectSystem]
    public class OperaComponentDestroySystem : DestroySystem<OperaComponent>
    {
        public override void Destroy(OperaComponent self)
        {
            Init init = GameObject.Find("Global").GetComponent<Init>();
            init.OnGetKeyHandler = null;
            init.OnGetMouseButtonDown_0 = null;
            init.OnGetMouseButtonDown_1 = null;
        }
    }

    public static class OperaComponentSystem
    {
        public static void UpdateClickMode(this OperaComponent self)
        {
            self.ClickMode = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.Click) == "1";
        }

        public static void OnGetKeyHandler(this OperaComponent self, int keyCode)
        {
            //if (!self.EditorMode)
            //{
            //    return;
            //}
            if (!self.ClickMode)
            {
                return;
            }
            if (Time.time - self.LastSendTime < 0.2f)
            {
                return;
            }
            if (keyCode == 257 && self.EditorMode)
            {
                AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
                if (!GMHelp.GmAccount.Contains(accountInfoComponent.Account))
                {
                    return;
                }
                //60030060 黑暗炸裂 吟唱前  62021301 吟唱中  62023202治愈之境（己方加血） 63102001减速光环   62023402（92034012驱散buff） 61021201 子弹1   61023301能量球2  62021401大魔导之影
                //60030060 吟唱   61022102光能击  67000277旋转攻击
                //UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);66001012玩家预警技能  66001013玩家燃烧技能
                //uI.GetComponent<UIMainComponent>().UIMainSkillComponent.UIAttackGrid.PointerUp(null);
                List<int> skillids = new List<int>() { 63103001 }; //心灵光环
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                unit.GetComponent<SkillManagerComponent>().SendUseSkill(skillids[RandomHelper.RandomNumber(0, skillids.Count)],
                    0, Mathf.FloorToInt(unit.Rotation.eulerAngles.y), 0, 0).Coroutine();
                self.LastSendTime = Time.time;

                Log.Info("PrintAllEntity");
                Log.Error(EventSystem.Instance.ToString());
                Log.Error(ObjectPool.Instance.ToString());
            }
            Vector3 dir = Vector3.zero;
            if (keyCode == 119)
            {
                dir.z = 1f;
            }
            if (keyCode == 97)
            {
                dir.x = -1f;
            }
            if (keyCode == 115)
            {
                dir.z = -1f;
            }
            if (keyCode == 100)
            {
                dir.x = 1f;
            }
            if (dir != Vector3.zero)
            {
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                if (ErrorCore.ERR_Success!=unit.GetComponent<StateComponent>().CanMove())
                {
                    return;
                }
                Vector3 target = dir * 2f + self.MainUnit.Position;
                self.MoveToPosition(target, true).Coroutine();
                self.LastSendTime = Time.time;
                return;
            }
        }

        public static void OnGetMouseButtonDown_1(this OperaComponent self)
        {
            if (self.EditorMode)
            {
                if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
                {
                    return;
                }
            }
            else
            {
                if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    return;
                }
            }
            if (self.CheckMove())
            {
                return;
            }
        }

        public static void OnGetMouseButtonDown_0(this OperaComponent self)
        {
            if (self.EditorMode)
            {
                if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
                {
                    return;
                }
            }
            else
            {
                if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    return;
                }
            }

            if (self.IsPointerOverGameObject(Input.mousePosition)
                || self.CheckBox()
                || self.CheckNpc()
                || self.CheckPlayer()
                || self.CheckMonster()
                || self.CheckBuilding())
            {
                return;
            }
            if (self.ClickMode && self.CheckMove())
            {
                return;
            }
        }

        public static bool CheckMove(this OperaComponent self)
        {
            Ray ray = self.mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000, self.mapMask))
            {
                self.MoveToPosition(hit.point, true).Coroutine();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckBox(this OperaComponent self)
        {
            RaycastHit Hit;
            Ray Ray = self.mainCamera.ScreenPointToRay(Input.mousePosition);
            bool hit = Physics.Raycast(Ray, out Hit, 100, self.boxMask);
            if (!hit)
                return false;
            try
            {
                long chestId = long.Parse(Hit.collider.gameObject.name);
                self.OnClickChest(chestId);
                return true;
            }
            catch (Exception ex)
            {
                Log.Debug("无效的宝箱: " + ex.ToString());
            }
            return false;
        }

        public static void OnClickChest(this OperaComponent self, long boxid)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            Unit box = UnitHelper.GetUnitFromZoneSceneByID(self.ZoneScene(), boxid);

            if (PositionHelper.Distance2D(unit, box) < 2)
            {
                UI uI = UIHelper.GetUI(unit.ZoneScene(), UIType.UIMain);
                uI.GetComponent<UIMainComponent>().UIOpenBoxComponent.OnOpenBox(boxid);
                return;
            }
            self.MoveToChest(boxid).Coroutine();
        }

        public static async ETTask MoveToChest(this OperaComponent self, long boxid)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (ErrorCore.ERR_Success!=unit.GetComponent<StateComponent>().CanMove())
                return;
            Unit box = UnitHelper.GetUnitFromZoneSceneByID(self.ZoneScene(), boxid);

            Vector3 position = box.Position;
            Vector3 dir = (unit.Position - position).normalized;
            position += dir * 2f;

            int ret = await self.MoveToPosition(position, true);
            if (ret != 0)
            {
                return;
            }
            UI uI = UIHelper.GetUI(unit.ZoneScene(), UIType.UIMain);
            uI.GetComponent<UIMainComponent>().UIOpenBoxComponent.OnOpenBox(boxid);
        }

        public static bool CheckPlayer(this OperaComponent self)
        {
            RaycastHit Hit;
            Ray Ray = self.mainCamera.ScreenPointToRay(Input.mousePosition);
            bool hit = Physics.Raycast(Ray, out Hit, 100, self.playerMask);
            if (!hit)
                return false;
            string obname = Hit.collider.gameObject.name;
            try
            {
                long unitid = long.Parse(obname);
                self.OnClickUnitItem(unitid).Coroutine();
                return true;
            }
            catch (Exception ex)
            {
                Log.Debug("无效的player: " + ex.ToString());
            }
            return false;
        }

        public static async ETTask OnClickUnitItem(this OperaComponent self, long unitid)
        {
            if (unitid == self.ZoneScene().GetComponent<AccountInfoComponent>().MyId)
            {
                return;
            }
            Unit unit = self.DomainScene().GetComponent<UnitComponent>().Get(unitid);
            if (unit.Type == UnitType.Player)
            {
                if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Stall) == 1)
                {
                    UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIPaiMaiStall);
                    uI.GetComponent<UIPaiMaiStallComponent>().OnUpdateUI(unit);
                }
                else
                {
                    UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIWatchMenu);
                    uI.GetComponent<UIWatchMenuComponent>().OnUpdateUI(MenuEnumType.Main, unit.Id).Coroutine();
                }
            }
        }

        public static bool CheckMonster(this OperaComponent self)
        {
            RaycastHit Hit;
            Ray Ray = self.mainCamera.ScreenPointToRay(Input.mousePosition);
            bool hit = Physics.Raycast(Ray, out Hit, 100, self.monsterMask);
            if (!hit)
                return false;
            string obname = Hit.collider.gameObject.name;
            try
            {
                long unitid = long.Parse(obname);
                self.OnClickMonsterItem(unitid);
                return true;
            }
            catch (Exception ex)
            {
                Log.Debug("无效的Monster: " + ex.ToString());
            }
            return false;
        }

        public static bool CheckBuilding(this OperaComponent self)
        {
            RaycastHit Hit;
            Ray Ray = self.mainCamera.ScreenPointToRay(Input.mousePosition);
            bool hit = Physics.Raycast(Ray, out Hit, 100, self.buildingMask);
            if (!hit)
            {
                return false;
            }
            if (Hit.collider == null || Hit.collider.gameObject == null)
            {
                return false;
            }
            GameObject colliderobj = Hit.collider.gameObject;
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (colliderobj.name.Contains("C_PlankPlanterLow_1x1m") && mapComponent.SceneTypeEnum == SceneTypeEnum.JiaYuan)
            {
                GameObject gameObject = colliderobj.transform.parent.gameObject;
                string[] namelist = gameObject.name.Split('_');
                int index = int.Parse(namelist[namelist.Length - 1]);
                self.ZoneScene().GetComponent<JianYuanComponent>().CellIndex = index;
                //UIHelper.Create(self.ZoneScene(), UIType.UIJiaYuanBag).Coroutine();
                UIHelper.Create(self.ZoneScene(), UIType.UIJiaYuanMenu).Coroutine();
                return true;
            }
            return false;
        }

        public static void OnClickMonsterItem(this OperaComponent self, long unitid)
        {
            Unit unit = self.DomainScene().GetComponent<UnitComponent>().Get(unitid);
            if (unit.Type == UnitType.Monster)
            {
                self.ZoneScene().GetComponent<LockTargetComponent>().LockTargetUnitId(unitid);
            }
        }

        public static bool CheckNpc(this OperaComponent self)
        {
            RaycastHit Hit;
            Ray Ray = self.mainCamera.ScreenPointToRay(Input.mousePosition);
            bool hit = Physics.Raycast(Ray, out Hit, 100, self.npcMask);
            if (!hit)
                return false;
            string obname = Hit.collider.gameObject.name;
            try
            {
                int npcid = int.Parse(obname);
                self.OnClickNpc(npcid);
                return true;
            }
            catch (Exception ex)
            {
                Log.Error($"无效的npc collider: {obname}" + ex.ToString());
            }
            return false;
        }

        public static void OnClickNpc(this OperaComponent self, int npcid)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            Unit npc = TaskHelper.GetNpcByConfigId(self.ZoneScene(), npcid);

            if (npc != null)
            {
                self.ZoneScene().GetComponent<LockTargetComponent>().OnLockNpc(npc);
            }
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcid);
            if (npcConfig.MovePosition.Length == 0 && npc != null && npc.GetComponent<AnimatorComponent>() != null)
            {
                npc.GetComponent<AnimatorComponent>().Play(MotionType.SelectNpc);
            }

            self.NpcId = npcid;
            Vector3 newTarget = new Vector3(npcConfig.Position[0] * 0.01f, npcConfig.Position[1] * 0.01f, npcConfig.Position[2] * 0.01f);
            newTarget.y = unit.Position.y;
            Vector3 dir = (unit.Position - newTarget).normalized;
            self.UnitStartPosition = unit.Position;

            if (PositionHelper.Distance2D(unit.Position, newTarget) <= TaskHelper.NpcSpeakDistance + 1f)
            {
                self.OnArriveToNpc();
                self.OnUnitToSpeak(newTarget);
                return;
            }

            newTarget += dir * TaskHelper.NpcSpeakDistance;
            self.MoveToNpc(newTarget).Coroutine();
        }

        public static void OnArriveToNpc(this OperaComponent self)
        {
            int functionId = NpcConfigCategory.Instance.Get(self.NpcId).NpcType;
            if (functionId < 100)
            {
                self.OpenNpcTaskUI(self.NpcId).Coroutine(); 
            }
            else
            {
                FunctionUI.GetInstance().OpenFunctionUI(self.ZoneScene(), self.NpcId, functionId);
            }
        }

        public static async ETTask OpenNpcTaskUI(this OperaComponent self, int npcid)
        {
            UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UITaskGet);
            if (uI == null)
                return;
            uI.GetComponent<UITaskGetComponent>().InitData(npcid);
        }

        public static async ETTask MoveToNpc(this OperaComponent self, Vector3 position)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (ErrorCore.ERR_Success != unit.GetComponent<StateComponent>().CanMove())
                return;

            int ret = await self.MoveToPosition(position, true);
            if (ret != 0)
            {
                return;
            }
            if (PositionHelper.Distance2D(unit.Position, position) > TaskHelper.NpcSpeakDistance + 0.2f)
            {
                return;
            }
            self.OnArriveToNpc();
            self.OnUnitToSpeak(position);
            UIHelper.Remove(self.ZoneScene(), UIType.UIMapBig);
        }

        public static void OnUnitToSpeak(this OperaComponent self, Vector3 vector3)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmNpcSpeak);
            unit.Rotation = Quaternion.LookRotation(vector3 - self.UnitStartPosition);
            unit.GetComponent<StateComponent>().SetNetWaitEndTime(TimeHelper.ClientNow()+200);
        }

        public static async ETTask MoveToNpc(this OperaComponent self, Vector3 position, Action action = null)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.UnitStartPosition = unit.Position;
            if (ErrorCore.ERR_Success != unit.GetComponent<StateComponent>().CanMove())
                return;

            if (Vector3.Distance(unit.Position, position) < TaskHelper.NpcSpeakDistance)
            {
                action?.Invoke();
                self.OnUnitToSpeak(position);
                return;
            }
            int ret = await self.MoveToPosition(position, true);
            if (ret != 0)
            {
                return;
            }
            action?.Invoke();
            self.OnUnitToSpeak(position);
        }

        public static int CheckObstruct(this OperaComponent self, Vector3 start, Vector3 target)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.TeamDungeon)
            {
                return 0;
            }

            Vector3 dir = (target - start).normalized;
            while (true)
            {
                RaycastHit hit;
                if (Vector3.Distance(start, target) < 1f)
                {
                    break;
                }
                start = start + (1f * dir);
                int mapMask = (1 << LayerMask.NameToLayer(LayerEnum.Obstruct.ToString()));
                Physics.Raycast(start + new Vector3(0f, 10f, 0f), Vector3.down, out hit, 100, mapMask);

                if (hit.collider != null)
                {
                    return int.Parse(hit.collider.gameObject.name);
                }
            }
            return 0;
        }

        public static async ETTask<int> MoveToPosition(this OperaComponent self, Vector3 position, bool yanGan = false)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int obstruct = self.CheckObstruct(unit.Position, position);
            if (obstruct != 0)
            {
                string monsterName = MonsterConfigCategory.Instance.Get(obstruct).MonsterName;
                FloatTipManager.Instance.ShowFloatTip($"请先消灭{monsterName}");
                return -1;
            }
            EventType.BeforeMove.Instance.ZoneScene = unit.ZoneScene();
            Game.EventSystem.PublishClass(EventType.BeforeMove.Instance);
            int ret = await unit.MoveToAsync2(position, yanGan);
            return ret;
        }

        /// <summary>
        /// 检测是否点击UI
        /// </summary>
        /// <param name="mousePosition"></param>
        /// <returns></returns>
        public static bool IsPointerOverGameObject(this OperaComponent self, Vector2 mousePosition)
        {
            //创建一个点击事件
            PointerEventData eventData = new PointerEventData(UnityEngine.EventSystems.EventSystem.current);
            eventData.position = mousePosition;
            List<RaycastResult> raycastResults = new List<RaycastResult>();
            //向点击位置发射一条射线，检测是否点击UI
            UnityEngine.EventSystems.EventSystem.current.RaycastAll(eventData, raycastResults);
            if (raycastResults.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}