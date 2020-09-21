using System;
using BusinessLogic;
using CommandLine;
using Team_Comtress_Updater;
using Team_Comtress_Updater.Patch;

namespace TCInstaller_CLI
{
    class Program
    {
        private static PatchManager _patchManager;
        private static IConfigManager _configManager;
        private static bool sane = false;
        private static bool clean;
        private static bool done = false;
        static void Main(string[] args)
        {
            _configManager = new ConfigManager();
            CommandLine.Parser.Default.ParseArguments<Options>(args).WithParsed(ValidateArguments);
            if (!sane)
            {
                Environment.Exit(1);
            }
            _patchManager = new PatchManager();
            _patchManager.onStateUpdate += WriteStatus;
            string gamedir = _configManager.Config.TF2Path;
            string installdir = _configManager.Config.TCPath;
            _patchManager.Init(gamedir,installdir,clean,false);
            do
            {
                Console.ReadKey();
            } while (!done);
            Environment.Exit(0);
        }

        static void WriteStatus()
        {
            Console.WriteLine(_patchManager.State);
            if (_patchManager.State == PatchState.DONE)
            {
                done = true;
            }
        }


        static void ValidateArguments(Options options)
        {
            //Check TC2 Directory
            if (options.tc2dir != null)
            {
                if (!ValidateTC2(options.tc2dir))
                {
                    Console.WriteLine("Invalid TC2 Directory!");
                    sane=  false;
                    return;
                }
                else
                {
                    _configManager.Config.TCPath = options.tc2dir;
                }
            }
            else
            {
                if (!ValidateTC2(_configManager.Config.TCPath))
                {
                    Console.WriteLine("Invalid TC2 Directory!");
                    sane = false;
                    return;
                }
            }

            //Check TF2 Directory
            if (options.tf2dir == null)
            {
                if (!ValidateTF2(_configManager.Config.TF2Path))
                {
                    Console.WriteLine("Couldn't find TF2, please supply it with the --tf2dir flag!");
                    sane = false;
                    return;
                }
            }
            else
            {
                if (!ValidateTF2(options.tf2dir))
                {
                    Console.WriteLine("Invalid TF2 Directory!");
                    sane = false;
                    return;
                }
                else
                {
                    _configManager.Config.TF2Path = options.tf2dir;
                }
            }

            clean = options.clean;
            _configManager.SaveConfig();
            sane = true;
        }

        static bool ValidateTF2(string path)
        {
            return Validator.IsGameDir(path);
        }

        static bool ValidateTC2(string path)
        {
            return Validator.IsValidPath(path);
        }
    }
}