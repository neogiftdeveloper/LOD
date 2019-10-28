using System;
using System.Collections.Generic;
using System.Text;

using DoorLock_Library.Data.Models;
using DoorLock_Library.DataBaseConnection.classes;

namespace DoorLock_Library.DataBaseConnection.DataBaseConnectionsHelper
{
    public class DoorLockConnectionHelper
    {

        public DoorLock_Model GetDoorState()
        {
            try
            {

                var value = new DataBlockAccessor<DoorLock_Model>().QueryDataSingle("public.fn_door_get", new { _door_id = 1 });

                if (value != null)
                {

                    return value;

                }
                else
                {
                    return new DoorLock_Model();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }

        }

        public bool UpdateDoorState(bool state)
        {
            try
            {

                var value = new DataBlockAccessor<bool>().QueryDataSingle("public.fn_door_update", new { _id = 1, _door_state = state });

                return value;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }

        }

    }
}
