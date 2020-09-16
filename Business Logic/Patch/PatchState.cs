namespace Data_Layer.Patcher
{
    public enum PatchState
    {
        IDLE,
        CLEANING,
        DOWNLOADING,
        DOWNLOADED,
        EXTRACTING,
        COPYING,
        DONE
    }
}