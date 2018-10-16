using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace DiabaseScanWizard.Duet
{
    public class OemInfo
    {
        public string Vendor { get; set; }

        public static async Task<OemInfo> Get(string ipAddress)
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://" + ipAddress + "/rr_download?name=0:/sys/oem.json");
            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string jsonResponse = reader.ReadToEnd();
            reader.Close();
            response.Close();

            return JsonConvert.DeserializeObject<OemInfo>(jsonResponse);
        }
    }

    public class ExtendedStatusResponse
    {
        public string Name { get; set; }

        public static async Task<ExtendedStatusResponse> Get(string ipAddress)
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://" + ipAddress + "/rr_status?type=2");
            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string jsonResponse = reader.ReadToEnd();
            reader.Close();
            response.Close();

            return JsonConvert.DeserializeObject<ExtendedStatusResponse>(jsonResponse);
        }
    }

    public class FileListResponse
    {
        public class FileListItem
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public int Size { get; set; }
            public DateTime Date { get; set; }
        }

        public int First { get; set; }
        public int Next { get; set; }
        public List<FileListItem> Files { get; set; } = new List<FileListItem>();

        public static async Task<FileListResponse> Get(string ipAddress, string directory)
        {
            FileListResponse result = new FileListResponse();
            FileListResponse lastResponse = new FileListResponse();
            do
            {
                HttpWebRequest request = WebRequest.CreateHttp("http://" + ipAddress + "/rr_filelist?dir=" + directory + "&first=" + lastResponse.Next);
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string jsonResponse = reader.ReadToEnd();
                reader.Close();
                response.Close();

                lastResponse = JsonConvert.DeserializeObject<FileListResponse>(jsonResponse);
                result.Files.AddRange(lastResponse.Files);
            }
            while (lastResponse.Next != 0);
            return result;
        }
    }
}