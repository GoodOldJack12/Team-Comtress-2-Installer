using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using Validator = Team_Comtress_Updater.Validator;

namespace DataLayer.Patcher
{
    public class Patcher : IPatcher
    {
        private string _installDir;
        private string _patchPath;
        private string _gamedir;
        private IReleaseDownloader downloader;
        public Patcher(string gamedir,string installDir)
        {
            _installDir = installDir;
            _patchPath = Path.Combine(Path.GetTempPath(), "tcpatch.zip");
            _gamedir = gamedir;
            downloader = new ReleaseDownloader(_patchPath);
        }


        public void Clean(Action action)
        {
            Task.Run(() =>
            {
                if (Directory.Exists(_installDir))
                {
                    Directory.Delete(_installDir, true);
                    Directory.CreateDirectory(_installDir);
                }
                action.Invoke();
            });

        }

        public void DownloadPatch(string version, Action action)
        {
            downloader.onComplete = action;
            downloader.DownloadRelease(version);
        }

        public void DownloadPatch(Action a)
        {
            downloader.onComplete = a;
            downloader.DownloadLatestRelease();
        }

        public void ExtractPatch()
        {
            ZipFile.ExtractToDirectory(_patchPath,_installDir,true);
        }

        public void CopyGame(Action oncomplete)
        {
            Task.Run((() =>
            {
                FileSystem.CopyDirectory(_gamedir, _installDir);
                DeleteConfigs(_installDir);
                oncomplete.Invoke();
            }));
        }
        /**
         * tf2Root: the root directory of the tf2/tc2 folder (not the tf subfolder)
         */
        private void DeleteConfigs(string tf2Root)
        {
            tf2Root = Path.Combine(tf2Root, "tf");
            List<string> toDelete = new List<string>()
            {
                "custom",
                "addons",
                //custom configs
                Path.Combine("cfg","autoexec.cfg"),
                Path.Combine("cfg","config.cfg"),
                //class specific
                Path.Combine("cfg","scout.cfg"),
                Path.Combine("cfg","pyro.cfg"),
                Path.Combine("cfg","soldier.cfg"),
                Path.Combine("cfg","demoman.cfg"),
                Path.Combine("cfg","heavyweapons.cfg"),
                Path.Combine("cfg","engineer.cfg"),
                Path.Combine("cfg","medic.cfg"),
                Path.Combine("cfg","spy.cfg"),
                Path.Combine("cfg","sniper.cfg"),
            };
            foreach (var path in toDelete)
            {
                string finalpath = Path.Combine(tf2Root, path);
                Console.WriteLine($"Checking {finalpath}");
                if (Validator.IsValidPath(finalpath))
                {
                    if (File.GetAttributes(finalpath) == FileAttributes.Directory)
                    {
                        Console.WriteLine($"deleting {finalpath}");
                        Directory.Delete(finalpath,true);
                    }else
                    {
                        Console.WriteLine($"deleting {finalpath}");
                        File.Delete(finalpath);
                    }
                }
                
            }
        }
        
    }
}