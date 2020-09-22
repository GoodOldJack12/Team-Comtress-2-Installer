using System;
using System.Runtime.InteropServices;
using Domain;
using Team_Comtress_Updater;

namespace DataLayer
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
            string windows64_tf2 = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Team Fortress 2";
            string windows32_tf2 = "C:\\Program Files\\Steam\\steamapps\\common\\Team Fortress 2";
            string tf2dir = "Please select a path!";
            
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (Validator.IsGameDir(windows64_tf2))
                {
                    tf2dir = windows64_tf2;
                }else if (Validator.IsGameDir(windows32_tf2))
                {
                    tf2dir = windows32_tf2;
                }
            }

            return new Config()
            {
                TCPath = "Please select a path!",
                TF2Path = tf2dir
            };
        }
    }
}