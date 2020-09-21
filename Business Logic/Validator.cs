using System;
using System.IO;
using System.Linq;

namespace Team_Comtress_Updater
{
    public static class Validator
    {
        public static bool IsValidPath(string path)
        {
            try
            {
                FileAttributes attributes = File.GetAttributes(path);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool IsGameDir(string dir)
        {
            if (!IsValidPath(dir))
            {
                return false;
            }

            if (File.GetAttributes(dir) != FileAttributes.Directory)
            {
                return false;
            }

            bool exePresent = Directory.GetFiles(dir, "hl2.exe").Any();
            return exePresent;
        }
    }
}