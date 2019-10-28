using System;
using System.Collections.Generic;
using System.Text;

namespace DoorLock_Library.DataBaseConnection.classes
{
    public class DataStracture<T> where T : new()
    {
        private DataFormat<T> sendData;

        public DataStracture()
        {
            this.sendData = new DataFormat<T>();

        }

        public DataFormat<T> GetDataFormat(T _temp)
        {
            T Temp = _temp;

            if (Temp != null)
            {

                sendData.Status = 1;
                sendData.Message = "Data Found";
                sendData._Data = null;
                sendData.Single_Data = _temp;

                
            }
            else
            {

                sendData.Status = 0;
                sendData.Message = "No Data Found";
                sendData._Data = null;
            }

            return sendData;
        }

        public DataFormat<T> GetDataFormat(List<T> _temp)
        {
            List<T> Temp = _temp;

            if (Temp != null)
            {
                sendData.Status = 1;
                sendData.Message = "Data Found";
                sendData._Data = Temp;

                
            }
            else
            {

                sendData.Status = 0;
                sendData.Message = "No Data Found";
                sendData._Data = null;
            }

            return sendData;
        }

    }
}
