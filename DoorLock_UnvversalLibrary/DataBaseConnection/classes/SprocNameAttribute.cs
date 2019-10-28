using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DoorLock_Library.DataBaseConnection.classes
{
    public class SprocNameAttribute : Attribute
    {
        public string SprocName { get; set; }

        public SprocNameAttribute(string SprocName)
        {
            this.SprocName = SprocName;
        }
    }
}
