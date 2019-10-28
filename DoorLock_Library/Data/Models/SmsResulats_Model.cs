using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DoorLock_Library.Data.Models
{
    public class SmsResulats_Model
    {
        [JsonProperty("status")]
        public bool _Status { get; set; }

        [JsonProperty("statusMessage")]
        public string _StatusMessage { get; set; }
        
        [JsonProperty("messageID")]
        public string _MessageID { get; set; }
    }
}
