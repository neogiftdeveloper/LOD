using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DoorLock_Library.APIConnection
{
    public static class SMSApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient(string baseUr)
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri(baseUr);
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
