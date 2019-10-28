using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DoorLock_Library.Data.Models
{
    public class SMS_Model
    {
        [JsonProperty("smsMessages")]
        public string _SMS_Messages { get; set; }

        [JsonProperty("cellPhoneNumbers")]
        public string _CellPhoneNumbers { get; set; }
    }

}
