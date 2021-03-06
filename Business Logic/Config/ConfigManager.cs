using System;
using System.IO;
using BusinessLogic;
using DataLayer;
using Domain;

namespace Team_Comtress_Updater
{
    public class ConfigManager : IConfigManager
    {
        private IConfigSerializer _serializer;
        private string configPath;
        public Config Config { get; set; }
        public ConfigManager(string configpath = null)
        {
            if (configpath == null)
            {
                this.configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TCUpdater");
            }
            else
            {
                this.configPath = configpath;
            }
            _serializer = new ConfigSerializer(configPath);
            Config = GetConfig();
        }

        private Config GetConfig()
        {
            return _serializer.Load();
        }

        public bool TryGetConfig(out Config config)
        {
            try
            {
                config = GetConfig();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                config = null;
                return false;
            }
        }

        public void SaveConfig()
        {
            _serializer.Save(Config);
        }
    }
}