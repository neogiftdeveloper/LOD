using System;
using System.Collections.Generic;
using System.Text;

namespace DoorLock_Library.DataBaseConnection.classes
{
    public class DataFormat<T> where T : new()
    {

        public int Status { get; set; }

        public string Message { get; set; }

        public List<T> _Data { get; set; } = new List<T>();

        public T Single_Data { get; set; }

    }
}
