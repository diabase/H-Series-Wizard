using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace DiabaseWizard.Duet
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
        public int Axes { get; set; }

        public string Name { get; set; }

        public class SpindleInfo
        {
            public int Tool;
        }

        public List<SpindleInfo> Spindles = new List<SpindleInfo>();

        public class ToolInfo
        {
            public int Number { get; set; }
            public List<int> Drives { get; set; } = new List<int>();
            public List<int> Heaters { get; set; } = new List<int>();
        }

        public List<ToolInfo> Tools { get; set; } = new List<ToolInfo>();

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

    public class ConfigResponse
    {
        public List<double> Accelerations = new List<double>();
        public List<double> MinFeedrates = new List<double>();
        public List<double> MaxFeedrates = new List<double>();

        public static async Task<ConfigResponse> Get(string ipAddress)
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://" + ipAddress + "/rr_config");
            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string jsonResponse = reader.ReadToEnd();
            reader.Close();
            response.Close();

            return JsonConvert.DeserializeObject<ConfigResponse>(jsonResponse);
        }
    }
}
