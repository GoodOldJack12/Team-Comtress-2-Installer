using System;
using Data_Layer.Patcher;
using DataLayer.Patcher;

namespace Team_Comtress_Updater.Patch
{
    public class PatchManager
    {
        private IPatcher _patcher;
        private string _version;
        private string _installdir;
        public PatchState State = PatchState.IDLE;
        public Action onStateUpdate;
       

        public void Init(string gamedir, string installdir, bool clean = false, bool overwrite = false, string version = null) 
        {
            _patcher = new Patcher(gamedir,installdir);
            _installdir = installdir;
            _version = version;
            if (clean)
            {
                Clean((() => 
                    CopyGame(() =>
                    {
                        DownloadPatch((ExtractPatch));
                    },overwrite)));
            }
            else
            {
                CopyGame(() =>
                {
                    DownloadPatch((ExtractPatch));
                },overwrite);
            }
        }

        public void Clean(Action nextStep)
        {
            UpdateState(PatchState.CLEANING);
            _patcher.Clean(nextStep);
        }

        public void CopyGame(Action nextStep, bool overwrite = false)
        {
            //Only copy files if not already present, OR if overwrite is true
            if (!Validator.IsGameDir(_installdir) || overwrite)
            {
                UpdateState(PatchState.COPYING);
                _patcher.CopyGame(nextStep);
            }
            else
            {
                nextStep.Invoke();
            }
        }

        public void DownloadPatch(Action nextStep)
        {
            if (_version != null)
            {
                UpdateState(PatchState.DOWNLOADING);
                _patcher.DownloadPatch(_version, nextStep);
            }
            else
            {
                UpdateState(PatchState.DOWNLOADING);
                _patcher.DownloadPatch(nextStep);
            }
            
        }

        public void ExtractPatch()
        {
            UpdateState(PatchState.EXTRACTING);
            _patcher.ExtractPatch();
            UpdateState(PatchState.DONE);
        }

        public void UpdateState(PatchState state)
        {
            State = state;
            onStateUpdate.Invoke();
        }
    }
}