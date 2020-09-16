using System;
using System.ComponentModel;
using System.Net;

namespace Data_Layer
{
    public static class Downloader
    {
        public static void DownloadFile(string url, string targetpath, Action onComplete = null)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += (sender, e) => onComplete?.Invoke();
            webClient.DownloadFileAsync(new Uri(url), targetpath);
        }
        
    }
}