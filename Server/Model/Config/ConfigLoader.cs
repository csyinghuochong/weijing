using System.Collections.Generic;
using System.IO;

namespace ET
{
    public class ConfigLoader : IConfigLoader
    {
        public void GetAllConfigBytes(Dictionary<string, byte[]> output)
        {
            foreach (string file in Directory.GetFiles($"../Config", "*.bytes"))
            {
                string key = Path.GetFileNameWithoutExtension(file);
                output[key] = File.ReadAllBytes(file);
            }
            output["StartMachineConfigCategory"] = File.ReadAllBytes($"../Config/{Game.Options.StartConfig}/StartMachineConfigCategory.bytes");
            output["StartProcessConfigCategory"] = File.ReadAllBytes($"../Config/{Game.Options.StartConfig}/StartProcessConfigCategory.bytes");
            output["StartSceneConfigCategory"] = File.ReadAllBytes($"../Config/{Game.Options.StartConfig}/StartSceneConfigCategory.bytes");
            output["StartZoneConfigCategory"] = File.ReadAllBytes($"../Config/{Game.Options.StartConfig}/StartZoneConfigCategory.bytes");
        }

        public byte[] GetOneConfigBytes(string configName)
        {
            if (configName.Contains("ET."))
            {
                configName = configName.Substring(3, configName.Length - 3);
            }
            byte[] configBytes = File.ReadAllBytes($"../Config/{configName}.bytes");
            return configBytes;
        }
    }
}