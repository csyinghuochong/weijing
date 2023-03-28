
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UILobbyComponent : Entity, IAwake
	{
		public GameObject ImageDi;
		public GameObject Text_Lv;
		public GameObject Text_Name;
		public GameObject ObjRoleList;
		public GameObject ObjRoleListSet;
		public GameObject ObjBtnEnterGame;
		public GameObject ObjBtnCreateRole;
		public GameObject ObjBtnDeleteRole;
		public GameObject ObjBtnReturnRole;
		public GameObject ObjBtnRandomName;

		public GameObject ObjInputCreateRoleName;
		public GameObject ObjCreateRoleShow;

		public int PageIndex = 0;
		public int PageCount = 4;
		public GameObject Button_2;
		public GameObject Button_1;
		public CreateRoleInfo SeletRoleInfo;              
		public List<UICreateRoleListComponent> CreateRoleListUI = new List<UICreateRoleListComponent>();
		public ETCancellationToken eTCancellation = null;
		public AccountInfoComponent PlayerComponent;

		public float LastLoginTime;
	}
}
