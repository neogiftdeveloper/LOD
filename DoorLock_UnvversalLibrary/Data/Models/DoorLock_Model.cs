
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DoorLock_Library.Data.Models
{
    public class DoorLock_Model
    {
        [JsonProperty("iD")]
        public long _ID { get; set; }

        [JsonProperty("doorState")]
        public bool _DoorState { get; set; }
    }
}
