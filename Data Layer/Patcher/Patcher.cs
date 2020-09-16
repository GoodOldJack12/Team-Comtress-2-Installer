using System;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic.FileIO;

namespace Data_Layer.Patcher
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

        public void Clean()
        {
            if (Directory.Exists(_installDir))
            {
                Directory.Delete(_installDir,true);
                Directory.CreateDirectory(_installDir);
            }
        }

        public void DownloadPatch(string version)
        { 
            downloader.DownloadRelease(version);
        }

        public void DownloadPatch()
        {
            downloader.DownloadLatestRelease();
        }

        public void ExtractPatch()
        {
            ZipFile.ExtractToDirectory(_patchPath,_installDir,true);
        }

        public void CopyGame()
        {
            FileSystem.CopyDirectory(_gamedir,_installDir);
        }
    }
}