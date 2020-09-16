using System.Net;

namespace Data_Layer
{
    public static class Downloader
    {
        public static void DownloadFile(string url, string targetpath)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, targetpath);

        }
    }
}