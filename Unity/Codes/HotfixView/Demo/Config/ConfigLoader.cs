using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class ConfigLoader: IConfigLoader
    {
        public void GetAllConfigBytes(Dictionary<string, byte[]> output)
        {
            //Dictionary<string, UnityEngine.Object> keys = ResourcesComponent.Instance.GetBundleAll("config.unity3d");
            //foreach (var kv in keys)
            //{
            //    TextAsset v = kv.Value as TextAsset;
            //    string key = kv.Key;
            //    output[key] = v.bytes;
            //}

            var types = Game.EventSystem.GetTypes(typeof(ConfigAttribute));
            foreach (var kv in types)
            {
                var path = ABPathHelper.GetConfigPath(kv.Name);
                output[kv.Name] = ResourcesComponent.Instance.LoadAsset<TextAsset>(path).bytes;
            }
        }

        public byte[] GetOneConfigBytes(string configName)
        {
            //TextAsset v = ResourcesComponent.Instance.GetAsset("config.unity3d", configName) as TextAsset;
            var path = ABPathHelper.GetConfigPath(configName);
            var v = ResourcesComponent.Instance.LoadAsset<TextAsset>(path);
            return v.bytes;
        }
    }
}