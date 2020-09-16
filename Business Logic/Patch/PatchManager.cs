using Data_Layer.Patcher;

namespace Team_Comtress_Updater.Patch
{
    public class PatchManager
    {
        private IPatcher _patcher;
        private string _version;

        public void Init(string gamedir, string installdir)
        {
            _patcher = new Patcher(gamedir,installdir);
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

        public void CopyGame()
        {
            _patcher.CopyGame();
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