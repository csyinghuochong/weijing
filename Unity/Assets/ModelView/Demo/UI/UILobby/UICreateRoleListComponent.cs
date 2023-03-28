using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ET
{
    public class UICreateRoleListComponent : Entity, IAwake<GameObject>
    {
        //public int SelectXuHaoID;
        public GameObject ImageDi;
        public GameObject ObjRoleName;
        public GameObject ObjRoleLv;
        public GameObject ObjImgSelect;
        public GameObject ObjBtnSelectRole;
        public GameObject ObjImgOccHeadIcon;
        public GameObject RoleOcc;
        public GameObject NoRole;
        public GameObject Role;
        public CreateRoleInfo CreateRoleInfo;

        public GameObject GameObject;
    }
}
