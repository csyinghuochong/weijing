using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ET
{
	[ObjectSystem]
    public class ConfigAwakeSystem : AwakeSystem<ConfigComponent>
    {
        public override void Awake(ConfigComponent self)
        {
	        ConfigComponent.Instance = self;
        }
    }
    
    [ObjectSystem]
    public class ConfigDestroySystem : DestroySystem<ConfigComponent>
    {
	    public override void Destroy(ConfigComponent self)
	    {
		    ConfigComponent.Instance = null;
	    }
    }
    
    public static class ConfigComponentSystem
	{
		public static void LoadOneConfig(this ConfigComponent self, Type configType)
		{
			byte[] oneConfigBytes = self.ConfigLoader.GetOneConfigBytes(configType.FullName);

			object category = ProtobufHelper.FromBytes(configType, oneConfigBytes, 0, oneConfigBytes.Length);

			self.AllConfig[configType] = category;
		}
		
		public static void Load(this ConfigComponent self)
		{
			self.AllConfig.Clear();
			List<Type> types = Game.EventSystem.GetTypes(typeof (ConfigAttribute));
			
			Dictionary<string, byte[]> configBytes = new Dictionary<string, byte[]>();
			self.ConfigLoader.GetAllConfigBytes(configBytes);

			foreach (Type type in types)
			{
				self.LoadOneInThread(type, configBytes);
			}
		}

        public static void PreLoad(this ConfigComponent self)
        {
            self.AllConfig.Clear();

            Dictionary<string, byte[]> configBytes = new Dictionary<string, byte[]>();
            self.ConfigLoader.GetAllConfigBytes(configBytes);
            self.ConfigBytes = configBytes;

            //提前加载
            List<string> prelist = self.GetPreLoadList();	

            for (int i  =0;i < prelist.Count; i++)
			{
				self.LoadOneInThread(Game.EventSystem.GetType(prelist[i]), configBytes);
            }
        }

        public static bool IsLoadFinish(this ConfigComponent self)
        { 
            return self.AllConfig.Count >= self.ConfigBytes.Count;
        }

		public static List<string> GetPreLoadList(this ConfigComponent self)
		{
			List<string> prelist = new List<string>
			{
                "ET.ShouJiConfigCategory",
                "ET.ShouJiItemConfigCategory",
                "ET.MulLanguageConfigCategory",
                "ET.OccupationTwoConfigCategory",
                "ET.OccupationConfigCategory",
                "ET.FashionConfigCategory",
                "ET.SkillConfigCategory",
                "ET.NpcConfigCategory",
                "ET.GlobalValueConfigCategory",
                "ET.SkillBuffConfigCategory",
                "ET.SkillWeaponConfigCategory",
                "ET.SceneConfigCategory",
                "ET.ExpConfigCategory",
                "ET.ActivityConfigCategory",
                "ET.ItemConfigCategory",
                "ET.EffectConfigCategory"
            };

			return prelist;
		}

        public static  void Load_2(this ConfigComponent self)
        {
            List<string> prelist = self.GetPreLoadList();
            if (self.AllConfig.Count > prelist.Count)
            {
                Log.ILog.Debug($"ConfigComponent return");

                return;
            }
            else
            {
                Log.ILog.Debug($"ConfigComponent load other");
            }

            List<Type> types = Game.EventSystem.GetTypes(typeof(ConfigAttribute));
            foreach (Type type in types)
            {
                if (prelist.Contains(type.FullName))
                {
                    continue;
                }

                self.LoadOneInThread(type, self.ConfigBytes);
            }

        }

        public static async ETTask LoadAsync_2(this ConfigComponent self)
        {
            List<string> prelist = self.GetPreLoadList();
            if (self.AllConfig.Count > prelist.Count)
            {
                return;
            }

            List<Type> types = Game.EventSystem.GetTypes(typeof(ConfigAttribute));
            //foreach (Type type in types)
            //{
            //    if (type.FullName.Contains("ShouJiConfig")
            //        || type.FullName.Contains("ShouJiItemConfig")
            //        || type.FullName.Contains("MulLanguageConfig"))
            //    {
            //        continue;
            //    }

            //    self.LoadOneInThread(type, self.ConfigBytes);
            //}
          
            using (ListComponent<Task> listTasks = ListComponent<Task>.Create())
            {
                foreach (Type type in types)
                {
					if (prelist.Contains(type.FullName))
					{
                        continue;
                    }

					Task task = Task.Run(() => self.LoadOneInThread(type, self.ConfigBytes));
                    listTasks.Add(task);
                }

                await Task.WhenAll(listTasks.ToArray());
            }
        }

        public static async ETTask LoadAsync(this ConfigComponent self)
		{
			self.AllConfig.Clear();
			List<Type> types = Game.EventSystem.GetTypes(typeof (ConfigAttribute));
			
			Dictionary<string, byte[]> configBytes = new Dictionary<string, byte[]>();

#if NOT_UNITY
			if (Game.Options.Process == 1 || Game.Options.Process == 203)
			{
				self.ConfigLoader.PreGetAllConfigBytes();
            }
#endif

			self.ConfigLoader.GetAllConfigBytes(configBytes);

			using (ListComponent<Task> listTasks = ListComponent<Task>.Create())
			{
				foreach (Type type in types)
				{
					Task task = Task.Run(() => self.LoadOneInThread(type, configBytes));
					listTasks.Add(task);
				}

				await Task.WhenAll(listTasks.ToArray());
			}
		}

		private static void LoadOneInThread(this ConfigComponent self, Type configType, Dictionary<string, byte[]> configBytes)
		{
			try
			{
				byte[] oneConfigBytes = configBytes[configType.Name];

				object category = ProtobufHelper.FromBytes(configType, oneConfigBytes, 0, oneConfigBytes.Length);

				lock (self)
				{
					self.AllConfig[configType] = category;
				}
			}
			catch (Exception ex)
			{
				string message = ex.ToString();
				message = null;
				Log.Error("configType:  " + configType.Name + "  " + message);
			}
			
		}
	}
}