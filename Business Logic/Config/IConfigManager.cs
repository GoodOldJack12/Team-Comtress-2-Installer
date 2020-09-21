using Domain;

namespace BusinessLogic
{
    public interface IConfigManager
    {
        public Config Config { get; set; }
        bool TryGetConfig(out Config config);
        void SaveConfig();
        
    }
}