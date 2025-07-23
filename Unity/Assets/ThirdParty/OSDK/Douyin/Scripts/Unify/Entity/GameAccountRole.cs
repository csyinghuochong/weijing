using System.Collections.Generic;

namespace Douyin.Game
{
    public class GameAccountRole
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public string RoleId;
        
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName;
        
        /// <summary>
        /// 角色等级
        /// </summary>
        public string RoleLevel;

        /// <summary>
        /// 区服ID
        /// </summary>
        public string ServerId;
        
        /// <summary>
        /// 区服名称
        /// </summary>
        public string ServerName;

        /// <summary>
        /// 游戏中用户头像，根据游戏实际情况回传。如果游戏内有头像建议回传，会在抖音内展示
        /// </summary>
        public string AvatarUrl;

        /// <summary>
        /// 额外参数
        /// </summary>
        public Dictionary<string, string> Extra;

    }
}