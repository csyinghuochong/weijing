using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ET
{
    public class X7RoleReportData
    {
        public string type;
        public string game_area;
        public string game_area_id;
        public string game_role_id;
        public string game_role_name;
        public string roleLevel;
        public string game_guid;
        public string roleCE;
        public string roleStage;
        public string roleRechargeAmount;
        public string roleGuildId;
        public string roleGuild;
    }

    public static class X7PayHelper
    {
        public const string AppKey = "8e4a4fc224dc249ff012e2623f670b83";
        public const string X7PublicKey = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC+I0ZD9muTrBuLlCcfmUzuHTsAlg5PvJJBk5T8KMoC5oCbsjP6332xlX3gbdgJ38oY2k+ZsUrbaDqTobPSCDfH79IdGzCbSla2o9UYVdK3iL7M8970BOK9XW1IDHXF+EDEiYjvwq1CN9dgF7vmANOBI3XlIrtDvtHgzQF2FPQ2FwIDAQAB";
        public const string NotifyId = "-1";
        public const string GameCurrency = "CNY";
        // 支付下单 game_access_version，按渠道要求固定传 2507
        public const string GameAccessVersion = "2507";
        // 战力/关卡/充值/公会等无法准确取值时按渠道要求传 -1
        public const string RoleReportDefaultValue = "-1";

        public const string ReportTypeCreate = "1";
        public const string ReportTypeEnter = "2";
        public const string ReportTypeLevelUp = "3";

        public static string BuildPayJson(string gameOrderId, int rechargeNumber, string gameGuid, long roleId, int roleLevel,
            string roleName, int serverId, int rechargeType)
        {
            string price = rechargeNumber.ToString("F2", CultureInfo.InvariantCulture);
            string subject = rechargeType == 1 ? GetWeeklyCardSubject(rechargeNumber) : $"{rechargeNumber * 100}钻石";
            string extendsInfo = rechargeType.ToString();
            string area = serverId.ToString();
            string roleIdStr = roleId.ToString();
            string roleNameStr = roleName?.Trim() ?? string.Empty;
            string levelStr = roleLevel.ToString();
            string guid = gameGuid?.Trim() ?? string.Empty;
            string orderId = gameOrderId?.Trim() ?? string.Empty;

            string gameSign = BuildGameSign(orderId, price, guid, roleIdStr, roleNameStr, levelStr, area, subject, extendsInfo);

            Dictionary<string, string> payData = new Dictionary<string, string>
            {
                { "game_orderid", orderId },
                { "game_price", price },
                { "game_area", area },
                { "game_role_id", roleIdStr },
                { "game_role_name", roleNameStr },
                { "game_level", levelStr },
                { "subject", subject },
                { "extends_info_data", extendsInfo },
                { "game_guid", guid },
                { "notify_id", NotifyId },
                { "game_currency", GameCurrency },
                { "game_access_version", GameAccessVersion },
                { "game_sign", gameSign },
            };
            return JsonHelper.ToJson(payData);
        }

        public static string BuildRoleReportJson(string reportType, string gameGuid, long roleId, int roleLevel, string roleName, int serverId)
        {
            string areaId = serverId.ToString();
            string roleIdStr = roleId.ToString();
            string roleNameStr = roleName?.Trim() ?? string.Empty;
            string levelStr = roleLevel.ToString();
            string guid = gameGuid?.Trim() ?? string.Empty;

            Dictionary<string, string> reportData = new Dictionary<string, string>
            {
                { "type", reportType },
                { "game_area", areaId },
                { "game_area_id", areaId },
                { "game_role_id", roleIdStr },
                { "game_role_name", roleNameStr },
                { "roleLevel", levelStr },
                { "game_guid", guid },
                { "roleCE", RoleReportDefaultValue },
                { "roleStage", RoleReportDefaultValue },
                { "roleRechargeAmount", RoleReportDefaultValue },
                { "roleGuildId", RoleReportDefaultValue },
                { "roleGuild", RoleReportDefaultValue },
            };
            return JsonHelper.ToJson(reportData);
        }

        private static string BuildGameSign(string gameOrderId, string gamePrice, string gameGuid, string roleId,
            string roleName, string roleLevel, string gameArea, string subject, string extendsInfo)
        {
            SortedDictionary<string, string> signFields = new SortedDictionary<string, string>
            {
                { "extends_info_data", extendsInfo },
                { "game_area", gameArea },
                { "game_level", roleLevel },
                { "game_guid", gameGuid },
                { "game_orderid", gameOrderId },
                { "game_price", gamePrice },
                { "game_role_id", roleId },
                { "game_role_name", roleName },
                { "notify_id", NotifyId },
                { "subject", subject },
                { "game_access_version", GameAccessVersion },
                { "game_currency", GameCurrency },
            };

            StringBuilder signBuilder = new StringBuilder();
            bool first = true;
            foreach (KeyValuePair<string, string> item in signFields)
            {
                if (!first)
                {
                    signBuilder.Append('&');
                }

                signBuilder.Append(item.Key);
                signBuilder.Append('=');
                signBuilder.Append(item.Value);
                first = false;
            }

            return MD5Helper.StringMD5_2(signBuilder.ToString() + X7PublicKey);
        }

        private static string GetWeeklyCardSubject(int rechargeNumber)
        {
            if (rechargeNumber == 30)
            {
                return "金币周卡";
            }

            if (rechargeNumber == 98)
            {
                return "钻石周卡";
            }

            return $"{rechargeNumber}元周卡";
        }
    }
}
