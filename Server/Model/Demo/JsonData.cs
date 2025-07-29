using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ET
{
    public class GetHistoryAccountResponse
    {
        [JsonPropertyName("err_no")]
        public int ErrNo { get; set; }

        [JsonPropertyName("err_msg")]
        public string ErrMsg { get; set; }

        [JsonPropertyName("log_id")]
        public string LogId { get; set; }

        [JsonPropertyName("data")]
        public ResponseData Data { get; set; }
    }

    public class ResponseData
    {
        [JsonPropertyName("base_resp")]
        public BaseResponse BaseResp { get; set; }

        [JsonPropertyName("log_id")]
        public string LogId { get; set; }  // 注意：与外层log_id重复

        [JsonPropertyName("sdk_open_id")]
        public string SdkOpenId { get; set; }
    }

    public class BaseResponse
    {
        [JsonPropertyName("status_code")]
        public int StatusCode { get; set; }

        [JsonPropertyName("status_message")]
        public string StatusMessage { get; set; }
    }
}
