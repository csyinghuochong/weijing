using System.Diagnostics;
using System.IO;
using UnityEngine;

namespace Douyin.Game
{
    public static class OSDKIntegrationUtils
    {
        internal class LGExeShellResult
        {
            public readonly string StandardOutput;
            public readonly long ExitCode;
            public LGExeShellResult(string output, long code)
            {
                StandardOutput = output;
                ExitCode = code;
            }
        }
        private static Texture _questionTexture;
        internal static Texture GetQuestionTexture()
        {
            if (_questionTexture == null)
            {
                _questionTexture = GetTexture(OSDKIntegrationPathUtils.IntegrationImgQuesPath, 40, 40);
            }
            return _questionTexture;
        }
        
        private static Texture GetTexture(string path, int width, int height)
        {
            if (path == null)
            {
                return null;
            }
            //创建文件读取流
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            //创建文件长度缓冲区
            byte[] bytes = new byte[fileStream.Length];
            //读取文件
            fileStream.Read(bytes, 0, (int)fileStream.Length);
            //释放文件读取流
            fileStream.Close();
            //释放本机屏幕资源
            fileStream.Dispose();
            var texture = new Texture2D(width, height);
            texture.LoadImage(bytes);
            return texture;
        }
        
        // 读取iOS配置文件UUID
        internal static string GetMobileprovisionUuid(string profilePath)
        {
            var command = $"-c '{GetMobileProvisionUUIDShellCommand(profilePath)}'";
            LGExeShellResult result = ExecuteBashShellCommand(command);
            return result.StandardOutput;
        }
        // 读取iOS配置文件Teamid
        internal static string GetMobileprovisionTeamid(string profilePath)
        {
            var command = $"-c '{GetMobileProvisionTeamidShellCommand(profilePath)}'";
            LGExeShellResult result = ExecuteBashShellCommand(command);
            return result.StandardOutput;
        }
        internal static string GetMobileprovisionEnv(string profilePath)
        {
            var command = $"-c '{GetMobileProvisionEnvShellCommand(profilePath)}'";
            LGExeShellResult result = ExecuteBashShellCommand(command);
            return result.StandardOutput;
        }
        
        internal static string GetMobileprovisionTaskAllow(string profilePath)
        {
            var command = $"-c '{GetMobileProvisionTaskAllowShellCommand(profilePath)}'";
            LGExeShellResult result = ExecuteBashShellCommand(command);
            return result.StandardOutput;
        }

        internal static int AccessBashShell(string shellPath)
        {
            var command = $"-c '{GetAccessShellCommand(shellPath)}'";
            LGExeShellResult result = ExecuteBashShellCommand(command);
            return (int) result.ExitCode;
        }

        internal static LGExeShellResult ExecuteBashShellCommand(string command)
        {
            using (var myProcess = new Process())
            {
                myProcess.StartInfo.FileName = "bash";
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.Arguments = command;
                myProcess.Start();
                string strOutput = myProcess.StandardOutput.ReadToEnd().Replace("\n","") + myProcess.StandardError.ReadToEnd().Replace("\n","");
                myProcess.WaitForExit();
                int exitCode = myProcess.ExitCode;
                myProcess.Close();
                return new LGExeShellResult(strOutput, exitCode);
            }
        }

        private static string GetMobileProvisionUUIDShellCommand(string profilePath)
        {
            return "#!/bin/bash\n"
                   + $"mobileprovision_uuid=`/usr/libexec/PlistBuddy -c \"Print UUID\" /dev/stdin <<< $(/usr/bin/security cms -D -i \"{profilePath}\")`\n"
                   + "echo ${mobileprovision_uuid}";
        }
        private static string GetMobileProvisionTeamidShellCommand(string profilePath)
        {
            return "#!/bin/bash\n"
                   + $"mobileprovision_teamid=`/usr/libexec/PlistBuddy -c \"Print TeamIdentifier:0\" /dev/stdin <<< $(/usr/bin/security cms -D -i \"{profilePath}\")`\n"
                   + "echo ${mobileprovision_teamid}";
        }
        private static string GetMobileProvisionEnvShellCommand(string profilePath)
        {
            return "#!/bin/bash\n"
                   + $"mobileprovision_env=`/usr/libexec/PlistBuddy -c \"Print :Entitlements:aps-environment\" /dev/stdin <<< $(/usr/bin/security cms -D -i \"{profilePath}\")`\n"
                   + "echo ${mobileprovision_env}";
        }

        private static string GetMobileProvisionTaskAllowShellCommand(string profilePath)
        {
            return "#!/bin/bash\n"
                   + $"mobileprovision_taskallow=`/usr/libexec/PlistBuddy -c \"Print :Entitlements:get-task-allow\" /dev/stdin <<< $(/usr/bin/security cms -D -i \"{profilePath}\")`\n"
                   + "echo ${mobileprovision_taskallow}";
        }

        private static string GetAccessShellCommand(string profilePath)
        {
            return "#!/bin/bash\n"
                   + $"chmod a+x \"{profilePath}\"";
        }
    }
}