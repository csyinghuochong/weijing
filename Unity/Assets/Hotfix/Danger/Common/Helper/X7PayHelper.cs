namespace ET
{
    public class X7PayData
    {
        public string game_orderid;
        public string game_price;
        public string game_area;
        public string game_role_id;
        public string game_role_name;
        public string game_level;
        public string subject;
        public string extends_info_data;
        public string game_guid;
    }

    public class X7RoleReportData
    {
        public string type;
        public string game_area;
        public string game_role_id;
        public string game_role_name;
        public string game_level;
        public string game_guid;
    }

    public static class X7PayHelper
    {
        public const string ReportTypeCreate = "1";
        public const string ReportTypeEnter = "2";
        public const string ReportTypeLevelUp = "3";

        public static string BuildPayJson(string gameOrderId, int rechargeNumber, string gameGuid, long roleId, int roleLevel,
            string roleName, int serverId, int rechargeType)
        {
            X7PayData payData = new X7PayData
            {
                game_orderid = gameOrderId,
                game_price = rechargeNumber.ToString(),
                game_area = serverId.ToString(),
                game_role_id = roleId.ToString(),
                game_role_name = roleName,
                game_level = roleLevel.ToString(),
                subject = rechargeType == 1 ? GetWeeklyCardSubject(rechargeNumber) : $"{rechargeNumber * 100}钻石",
                extends_info_data = rechargeType.ToString(),
                game_guid = gameGuid,
            };
            return JsonHelper.ToJson(payData);
        }

        public static string BuildRoleReportJson(string reportType, string gameGuid, long roleId, int roleLevel, string roleName, int serverId)
        {
            X7RoleReportData reportData = new X7RoleReportData
            {
                type = reportType,
                game_area = serverId.ToString(),
                game_role_id = roleId.ToString(),
                game_role_name = roleName,
                game_level = roleLevel.ToString(),
                game_guid = gameGuid,
            };
            return JsonHelper.ToJson(reportData);
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
