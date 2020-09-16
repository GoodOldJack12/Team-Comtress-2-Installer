using System;

namespace DataLayer.Patcher
{
    public interface IPatcher
    {
        //Delete the target directory
        void Clean(Action onComplete = null);
        void DownloadPatch(Action onComplete = null);
        void DownloadPatch(string version,Action onComplete = null);
        void ExtractPatch();
        void CopyGame(Action onComplete = null);
    }
}