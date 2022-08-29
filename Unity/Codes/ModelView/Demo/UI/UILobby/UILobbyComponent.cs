
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

		public CreateRoleListInfo SeletRoleInfo;              
		public List<UI> createRoleListUI = new List<UI>();

		public AccountInfoComponent PlayerComponent;
	}
}
