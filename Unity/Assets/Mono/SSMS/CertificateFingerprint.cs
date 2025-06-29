using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class CertificateFingerprint : MonoBehaviour
{
    void Start()
    {
        string sha256 = GetSHA256Fingerprint();

        Debug.Log("SHA256 Fingerprint: " + sha256);

    }

    string GetSHA256Fingerprint()
    {
        try
        {
            // 获取Android应用的签名信息
            AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaObject packageManager = currentActivity.Call<AndroidJavaObject>("getPackageManager");
            string packageName = currentActivity.Call<string>("getPackageName");

            // 获取签名
            AndroidJavaObject packageInfo = packageManager.Call<AndroidJavaObject>(
                "getPackageInfo", packageName, 0x40); // GET_SIGNATURES = 64 (0x40)
            AndroidJavaObject[] signatures = packageInfo.Get<AndroidJavaObject[]>("signatures");

            if (signatures != null && signatures.Length > 0)
            {
                // 获取签名的字节数组
                byte[] signatureBytes = signatures[0].Call<byte[]>("toByteArray");

                // 计算SHA256哈希
                using (SHA256 sha256Algorithm = SHA256.Create())
                {
                    byte[] hashBytes = sha256Algorithm.ComputeHash(signatureBytes);

                    // 转换为十六进制字符串
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                        if (i < hashBytes.Length - 1)
                            sb.Append(":");
                    }

                    return sb.ToString();
                }
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("Failed to get certificate fingerprint: " + e.Message);
        }

        return null;
    }
}