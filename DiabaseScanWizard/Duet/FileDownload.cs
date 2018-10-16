using System;
using System.Net;
using System.Threading.Tasks;

namespace DiabaseScanWizard.Duet
{
    static class FileDownload
    {
        public static async Task Start(string ipAddress, string fileName, string targetFile, IProgress<long> progressIndicator)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += delegate(object sender, DownloadProgressChangedEventArgs e) {
                progressIndicator.Report(e.BytesReceived);
            };
            await client.DownloadFileTaskAsync($"http://{ipAddress}/rr_download?name={fileName}", targetFile);
        }
    }
}
