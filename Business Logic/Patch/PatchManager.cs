using Data_Layer.Patcher;

namespace Team_Comtress_Updater.Patch
{
    public class PatchManager
    {
        private IPatcher _patcher;
        private string _version;
        private string _installdir;

        public void Init(string gamedir, string installdir)
        {
            _patcher = new Patcher(gamedir,installdir);
            _installdir = installdir;
        }

        public void Init(string gamedir, string installdir, string version) 
        {
            Init(gamedir,installdir);
            _version = version;
        }

        public void Clean()
        {
            _patcher.Clean();
        }

        public void CopyGame(bool overwrite = false)
        {
            //Only copy files if not already present, OR if overwrite is true
            if (!Validator.IsGameDir(_installdir) || overwrite)
            {
                _patcher.CopyGame();
            }
        }

        public void InstallPatch()
        {
            if (_version != null)
            {
                _patcher.DownloadPatch(_version);
            }
            else
            {
                _patcher.DownloadPatch();
            }
            _patcher.ExtractPatch();
        }

    }
}