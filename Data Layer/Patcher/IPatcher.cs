namespace Data_Layer.Patcher
{
    public interface IPatcher
    {
        //Delete the target directory
        void Clean();
        void DownloadPatch();
        void DownloadPatch(string version);
        void ExtractPatch();
        void CopyGame();
    }
}