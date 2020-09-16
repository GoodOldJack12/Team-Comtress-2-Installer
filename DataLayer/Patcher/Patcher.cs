using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

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
                oncomplete.Invoke();
            }));
        }
        
    }
}