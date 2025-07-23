using System.Collections.Generic;
using Douyin.Game;
using UnityEngine.Scripting;

namespace Demo.Douyin.Game
{
    [Preserve]
    public class DemoGameRoleFunctionScript : Singeton<DemoGameRoleFunctionScript>
    {
        public const string ITEM_ID_SDK_ROLE_REPORTER = "sdk_game_role_repoter";
        public const string ITEM_ID_SDK_ROLE_MOCK = "sdk_game_role_mock";
        private Dictionary<string, string> Args = new Dictionary<string, string>();

        /**
         * 生成mock数据
         */
        private void GenerateArgs()
        {
            Args["game_user_id"] = "1000" + UnityEngine.Random.Range(0, 1000);
            var RegisterTime = 1701007123 - UnityEngine.Random.Range(0, 10000);
            Args["game_role_id"] = RegisterTime.ToString();
            Args["game_role_name"] = (RegisterTime + UnityEngine.Random.Range(0, 10000)).ToString();
            Args["game_role_level"] = (RegisterTime + UnityEngine.Random.Range(0, 10000)).ToString();
        }
        
        [Preserve]
        public void FunctionDispatcher(string ItemID)
        {
            switch (ItemID)
            {
                case ITEM_ID_SDK_ROLE_MOCK:
                    DemoLog.D("调用账号绑定MOCK方法");
                    GenerateArgs();
                    var userid = Args["game_user_id"];
                    DemoStandardGameRole.ShowToastAndPrint($"[COPY]参数已经生成, gameuserid:{userid}");
                    Clipboard.CopyToClipboard(userid);
                    break;
                case ITEM_ID_SDK_ROLE_REPORTER:
                    if (Args.Count == 0)
                    {
                        DemoStandardGameRole.ShowToastAndPrint("请先生成MOCK参数");
                    }
                    DemoLog.D("调用账号绑定方法");
                    var role = new GameAccountRole();
                    role.RoleId = Args["game_role_id"];
                    role.RoleLevel = Args["game_role_level"];
                    role.RoleName = Args["game_role_name"];
                    role.AvatarUrl =
                        "https://p26-passport.byteacctimg.com/img/motor-img/4421dd562bd484463de19de1bd5ce890~noop.jpg";
                    DemoStandardGameRole.Instance.ReportGameRole(
                        Args["game_user_id"],
                        role
                    );
                    break;
            }
        }
    }
}