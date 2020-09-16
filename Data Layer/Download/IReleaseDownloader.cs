using System.Collections.Generic;
using Octokit;

namespace Data_Layer
{
    public interface IReleaseDownloader
    {
        void DownloadRelease(string version);
        IList<Release> GetReleases();
        void DownloadLatestRelease();
        

    }
}