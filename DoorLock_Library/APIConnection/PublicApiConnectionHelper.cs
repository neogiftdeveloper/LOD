using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


using DoorLock_Library.DataBaseConnection.classes;
using DoorLock_Library.Data.Models;

namespace DoorLock_Library.APIConnection
{
    public class PublicApiConnectionHelper
    {
        #region Variable

        DataFormat<DoorLock_Model> APIDataFormat;


        #endregion

        #region Contractor

        public PublicApiConnectionHelper()
        {
            APIDataFormat = new DataFormat<DoorLock_Model>();
            
        }

        #endregion

        #region Main Functions


      

        public async Task<DoorLock_Model> GetDoorState()
        {
            try
            {
                string path = $"v1/public/getdoor";

                using (HttpResponseMessage response = await SMSApiHelper.ApiClient.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        this.APIDataFormat = await response.Content.ReadAsAsync<DataFormat<DoorLock_Model>>();

                        if (this.APIDataFormat != null)
                        {
                            return this.APIDataFormat.Single_Data;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<bool> UpdateDoorState(DoorLock_Model data)
        {
            try
            {
                string path = $"v1/public/updatedoorstate";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(path, data, new System.Net.Http.Formatting.JsonMediaTypeFormatter()))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var results = await response.Content.ReadAsAsync<bool>();

                        return results;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<SmsResulats_Model> SendSMSes(SMS_Model data, string username,  string password, string authkey)
        {
            try
            {
                string path = $"v1/public/sendotp?username={username}&password={password}&apitoken={authkey}";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(path, data, new System.Net.Http.Formatting.JsonMediaTypeFormatter()))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var results = await response.Content.ReadAsAsync<SmsResulats_Model>();

                        return results;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        #endregion
    }
}
