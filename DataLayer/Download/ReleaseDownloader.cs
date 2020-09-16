using System;
using System.Collections.Generic;
using System.Linq;
using Octokit;

namespace DataLayer
{
    public class ReleaseDownloader : IReleaseDownloader
    {
        private GitHubClient _client;
        private long _repository;
        private string _targetPath;
        

        public ReleaseDownloader(string targetPath)
        {
            _client = new GitHubClient(new ProductHeaderValue("TC-Updater"));
            _repository = _client.Repository.Get("mastercomfig", "team-comtress-2").Result.Id;
            _targetPath = targetPath;
        }

        public Action onComplete { get; set; }

        public void DownloadRelease(string version)
        {
            DownloadRelease(GetRelease(version));
        }

        private Release GetRelease(string tag)
        {
            return _client.Repository.Release.Get(_repository, tag).Result;
        }
        public IList<Release> GetReleases()
        {
            return _client.Repository.Release.GetAll(_repository).Result.ToList();
        }

        public Release GetLatestRelease()
        {
            return GetReleases()[0];
        }

        public void DownloadLatestRelease()
        {
            DownloadRelease(GetLatestRelease());
        }
        
        public void DownloadRelease(Release release)
        {
            ReleaseAsset releaseAsset = release.Assets.SingleOrDefault(a => a.Name == "game_clean.zip");
            if (releaseAsset != null)
            {
                Download(releaseAsset.BrowserDownloadUrl);
            }
        }

        public void Download(string url)
        {
            Downloader.DownloadFile(url,_targetPath,onComplete);
        }
        
        
    }
}