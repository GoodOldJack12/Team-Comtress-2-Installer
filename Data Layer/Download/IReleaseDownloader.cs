using System;
using System.Collections.Generic;
using Octokit;

namespace Data_Layer
{
    public interface IReleaseDownloader
    {
        Action onComplete { get; set; }
        void DownloadRelease(string version);
        IList<Release> GetReleases();
        void DownloadLatestRelease();
    }
}