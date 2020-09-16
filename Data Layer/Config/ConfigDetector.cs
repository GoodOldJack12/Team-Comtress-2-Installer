using System;
using Domain;

namespace Data_Layer
{
    class ConfigDetector : IConfigDetector
    {
        public Config MakeAutoConfig()
        {
            return GetHardcodedTestConfig();
        }

        public bool TryMakeAutoConfig(out Config config)
        {
            try
            {
                config = MakeAutoConfig();
                return true;
            }
            catch (Exception e)
            {
                config = null;
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        private Config GetHardcodedTestConfig()
        {
            return new Config()
            {
                TCPath = "Please select a path!",
                TF2Path = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Team Fortress 2"
            };
        }
    }
}