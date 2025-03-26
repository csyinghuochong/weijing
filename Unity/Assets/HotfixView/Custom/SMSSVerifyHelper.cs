
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ET
{

    public static class SMSSVerifyHelper
    {
        public static (int, string) ConnectSSL(string phone, string code)
        {
            WebRequest request = WebRequest.Create("https://webapi.sms.mob.com/sms/verify");
            request.Proxy = null;
            request.Credentials = CredentialCache.DefaultCredentials;

            //allows for validation of SSL certificates 
            string appkey = string.Empty;
#if UNITY_ANDROID
            appkey = "36af6e3967670";
#elif UNITY_IPHONE || UNITY_IOS
            appkey = "2d21337c7dc80";
#endif
            string zone = "86";
            ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(ValidateServerCertificate);
            byte[] bs = Encoding.UTF8.GetBytes($"appkey={appkey}&phone={phone}&zone={zone}&code={code}");
            request.Method = "Post";
            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(bs, 0, bs.Length);
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            SMSSVerifyResult sMSSVerify = JsonHelper.FromJson<SMSSVerifyResult>(responseFromServer);
            Log.ILog.Debug($"11111111:  {sMSSVerify.status}   {sMSSVerify.error}");

            return (sMSSVerify.status, sMSSVerify.error);
        }

        //for testing purpose only, accept any dodgy certificate... 
        public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }

}

   