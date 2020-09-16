using Domain;

namespace Team_Comtress_Updater
{
    public interface IConfigManager
    {
        public Config Config { get; set; }
        bool TryGetConfig(out Config config);
        void SaveConfig();
        
    }
}