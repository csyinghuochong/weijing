using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationHttp
    {
        private const string Host = "https://usdk.dailygn.com";
        private const string InitFileUrl = Host + "/osdk/account/get_osdk_game_config";
        private const string VersionUrl = Host + "/osdk/account/get_osdk_unity_upgrade_version";
        private const string RecordUrl = Host + "/osdk/common/osdk_report_event";

        //用于埋点上报鉴权，取配置拉取成功后时的包名与密钥，每次拉取后更新；
        private static string _tempPackageName = "";
        private static string _tempSecretKey = "";

        internal static Dictionary<string, object> FetchSDKConfigs(int devicePlatform, string secretKey, string packageName, int osdkType)
        {
            var paramsDict = new Dictionary<string, object>()
            {
                {"package_name", packageName},
                {"device_platform", devicePlatform},
                {"biz_mode", osdkType}
            };

            for (int i = 0; i < secretKey.Length; i++)
            {
                if (!char.IsLetterOrDigit(secretKey[i]))
                {
                    throw new ArgumentException($"secretKey 含有非法字符, index: {i}, value: {secretKey[i]}");
                }
            }

            var recodeParamsDict = new Dictionary<string, object>(paramsDict);
            recodeParamsDict.Add("secret_key", secretKey);

            var sign = GetSign(secretKey, paramsDict);
            paramsDict.Add("sign", sign);
            var body = Json.Serialize(paramsDict);
            var request = WebRequest.Create(InitFileUrl);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Timeout = 5 * 1000;
            if (OSDKIntegrationPathUtils.SDKDeveloperExists && EditorPrefs.GetString("osdk_env", "Formal") == "PPE")
            {
                request.Headers["X-Use-Ppe"] = "1";
                request.Headers["X-Tt-Env"] = "ppe_osdk_unity";
            }
            // 设置代理服务器的地址和端口, 支持clarles抓包
            // WebProxy proxy = new WebProxy("http://127.0.0.1:8888");
            // request.Proxy = proxy;

            var postData = Encoding.UTF8.GetBytes(body);
            request.ContentLength = postData.Length;
            try
            {
                Debug.Log("FetchSDKConfigs params: " + Json.Serialize(recodeParamsDict));
                
                var myRequestStream = request.GetRequestStream(); 
                myRequestStream.Write(postData, 0, postData.Length);
                myRequestStream.Close();
            }
            catch (WebException e)
            {
                Debug.LogError("FetchSDKConfigs myRequestStream e = " + e);
            }

            try
            {
                var response = (HttpWebResponse) request.GetResponse();
                var myResponseStream = response.GetResponseStream();
                if (myResponseStream != null)
                {
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                    var logID = response.GetResponseHeader("X-Tt-Logid");
                    var allNetText =  myStreamReader.ReadToEnd();
                    Debug.Log($"FetchSDKConfigs logID: {logID}, cofig: {allNetText}");

                    myStreamReader.Close();
                    myResponseStream.Close();
                    if (Json.Deserialize(allNetText) is Dictionary<string, object> obj)
                    {
                        _tempPackageName = packageName;
                        _tempSecretKey = secretKey;
                        return obj;
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return null;
        }

        internal static Dictionary<string, object> FetchSDKVersion(int devicePlatform, int bizMode, string secretKey, string packageName, out string logid)
        {
            logid = string.Empty;

            var currentVersion = OSDK.SDK_VERSION.Replace(".", string.Empty);

            var paramsDict = new Dictionary<string, object>()
            {
                {"package_name", packageName},
                {"device_platform", devicePlatform},
                {"biz_mode", bizMode}
            };

            if (secretKey == "")
            {
                throw new ArgumentException("secretKey 为空");
            }

            for (int i = 0; i < secretKey.Length; i++)
            {
                if (!char.IsLetterOrDigit(secretKey[i]))
                {
                    throw new ArgumentException($"secretKey 含有非法字符, index: {i}, value: {secretKey[i]}");
                }
            }

            var sign = GetSign(secretKey, paramsDict);
            paramsDict.Add("sign", sign);
            paramsDict.Add("sdk_version", currentVersion);
            var body = Json.Serialize(paramsDict);
            var request = WebRequest.Create(VersionUrl);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Timeout = 5 * 1000;
            if (OSDKIntegrationPathUtils.SDKDeveloperExists && EditorPrefs.GetString("osdk_env", "Formal") == "PPE")
            {
                request.Headers["X-Use-Ppe"] = "1";
                request.Headers["X-Tt-Env"] = "ppe_osdk_unity";
            }
            // 设置代理服务器的地址和端口, 支持clarles抓包
            // WebProxy proxy = new WebProxy("http://127.0.0.1:8888");
            // request.Proxy = proxy;

            var postData = Encoding.UTF8.GetBytes(body);
            request.ContentLength = postData.Length;
            try
            {
                var recodeParamsDict = new Dictionary<string, object>(paramsDict);
                recodeParamsDict.Add("secret_key", secretKey);

                Debug.Log("FetchSDKVersion params: " + Json.Serialize(recodeParamsDict));

                var myRequestStream = request.GetRequestStream(); 
                myRequestStream.Write(postData, 0, postData.Length);
                myRequestStream.Close();
            }
            catch (WebException e)
            {
                Debug.LogError("FetchSDKVersion myRequestStream e = " + e);
            }

            try
            {
                var response = (HttpWebResponse) request.GetResponse();

                logid = response.GetResponseHeader("X-TT-LOGID");

                var myResponseStream = response.GetResponseStream();
                if (myResponseStream != null)
                {
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                    var allNetText =  myStreamReader.ReadToEnd();
                    Debug.Log("FetchSDKVersion response body: " + allNetText + "logID: " + logid);
                    myStreamReader.Close();
                    myResponseStream.Close();
                    if (Json.Deserialize(allNetText) is Dictionary<string, object> obj)
                    {
                        
                        return obj;
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return null;
        }

        private static Dictionary<string, object> GetCommonParams()
        {
            var common = new Dictionary<string, object>()
            {
                {"android_package_name", OSDKIntegrationConfig.BundleId(OSDKPlatform.Android)},
                {"ios_package_name", OSDKIntegrationConfig.BundleId(OSDKPlatform.iOS)},
                {"android_game_app_id", OSDKIntegrationConfig.AppID(OSDKPlatform.Android)},
                {"ios_game_app_id", OSDKIntegrationConfig.AppID(OSDKPlatform.iOS)},
                {"sdk_version_name", OSDK.SDK_VERSION},
                {"display_name", OSDKIntegrationConfig.AppName()},
                {"unity_editor_version", Application.unityVersion},
                {"app_version", Application.version},
                {"biz_mode", (int)OSDKIntegrationConfig.GetBizMode()}
            };
#if UNITY_EDITOR_WIN
            common.Add("macos", "Windows");
#elif UNITY_EDITOR_OSX
            common.Add("macos", "Mac");
#else
            common.Add("macos", "Unknow");
#endif

            common.Add("android_scripting_backend", PlayerSettings.GetScriptingBackend(BuildTargetGroup.Android).ToString());
            common.Add("iOS_scripting_backend", PlayerSettings.GetScriptingBackend(BuildTargetGroup.iOS).ToString());
            common.Add("graphics_device_type", SystemInfo.graphicsDeviceType.ToString());

            common.Add("environment_os_version", Environment.OSVersion.ToString());
            if (OSDKIntegrationPathUtils.DouyinModuleImported)
            {
                common.Add("aweme_import", "1"); // 埋点字段，不要改
            }
            if (OSDKIntegrationPathUtils.AdModuleImported)
            {
                common.Add("ad_import", "1");
            }
            if (OSDKIntegrationPathUtils.ShareModuleImported)
            {
                common.Add("share_import", "1");
            }
            if (OSDKIntegrationPathUtils.CloudGameModuleImported)
            {
                common.Add("cld_import", "1");
            }
            if (OSDKIntegrationPathUtils.CpsModuleImported)
            {
                common.Add("cps_import", "1");
            }
            if (OSDKIntegrationPathUtils.DataLinkModuleImported)
            {
                common.Add("datalink_import", "1");
            }
            if (OSDKIntegrationPathUtils.LiveModuleImported)
            {
                common.Add("live_import", "1");
            }
            if (OSDKIntegrationPathUtils.ScreenRecordModuleImported)
            {
                common.Add("screen_record_import", "1");
            }
            if (OSDKIntegrationPathUtils.TeamPlayModuleImported)
            {
                common.Add("team_play_import", "1");
            }
            if (OSDKIntegrationPathUtils.UnionModuleImported)
            {
                common.Add("union_import", "1");
            }

            return common;
        }

        internal static void UploadRecord(string eventName, Dictionary<string, object> paramsMap) 
        {
            if (string.IsNullOrWhiteSpace(eventName)) return;
            var bodyMap = GetCommonParams();
            foreach (var pair in paramsMap)
            {
                bodyMap.Add(pair.Key, pair.Value);
            }

            if(_tempPackageName == "" || _tempSecretKey == ""){return;}
            var secretKey = _tempSecretKey;
            var packageName = _tempPackageName;
            var bizMode = (int)OSDKIntegrationConfig.GetBizMode();
            var paramsStr = Json.Serialize(bodyMap);
            var paramsDict = new Dictionary<string, object>()
            {
                {"event", eventName},
                {"event_device_id", 2236833850759902},
                {"event_user_id", 86310278},
                {"package_name", packageName},
                {"params", paramsStr},
                {"biz_mode", bizMode}
            };
            var sign = GetSign(secretKey, paramsDict);
            paramsDict.Add("sign", sign);
            var body = Json.Serialize(paramsDict);
            var request = WebRequest.Create(RecordUrl);
            request.Method = "POST";
            request.ContentType = "application/json";
            if (OSDKIntegrationPathUtils.SDKDeveloperExists && EditorPrefs.GetString("osdk_env", "Formal") == "PPE")
            {
                request.Headers["X-Use-Ppe"] = "1";
                request.Headers["X-Tt-Env"] = "ppe_osdk_unity";
            }
            // WebProxy proxy = new WebProxy("http://127.0.0.1:8888");
            // request.Proxy = proxy;
            request.Timeout = 5 * 1000;
            var postData = Encoding.UTF8.GetBytes(body);
            request.ContentLength = postData.Length;
            try
            {
                var myRequestStream = request.GetRequestStream(); 
                myRequestStream.Write(postData, 0, postData.Length);
                myRequestStream.Close();
            }
            catch (WebException e)
            {
                Debug.LogError("UploadRecord myRequestStream e = " + e);
            }

            try
            {
                var response = (HttpWebResponse) request.GetResponse();
                var myResponseStream = response.GetResponseStream();
                if (myResponseStream != null)
                {
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                    var allNetText =  myStreamReader.ReadToEnd();
                    if (OSDKIntegrationPathUtils.SDKDeveloperExists)
                    {
                        var logid = response.GetResponseHeader("X-TT-LOGID");
                        Debug.Log("report event respond logid " + logid +  allNetText);
                    }
                    myStreamReader.Close();
                    myResponseStream.Close();
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static string GetSign(string secretKey, Dictionary<string, object> paramsDictionary)
        {
            var orderParams = paramsDictionary.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);
            var content = string.Empty;
            foreach (var keyValuePair in orderParams)
            {
                if (keyValuePair.Key == "sign") continue;
                if (!string.IsNullOrWhiteSpace(content)) content += "&";
                content += $"{keyValuePair.Key}={keyValuePair.Value}";
            }
            return HMAC_SHA1(content, secretKey);
        }

        private static string HMAC_SHA1(string content, string secretKey)
        {
            var encoding = Encoding.UTF8;
            var hmacsha1 = new HMACSHA1(encoding.GetBytes(secretKey));
            var bytes = encoding.GetBytes(content);
            var sha1Hash = hmacsha1.ComputeHash(bytes);
            var base64Hash = Convert.ToBase64String(sha1Hash);
            return base64Hash.Replace("-", string.Empty);
        }
    }
}