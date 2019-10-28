using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using DoorLock_Library.DataBaseConnection.DataBaseConnectionsHelper;
using DoorLock_Library.Data.Models;
using DoorLock_Library.DataBaseConnection.classes;

namespace DoorLock_Api.v1.Controllers
{
    [Route("api/v1/Public")]
    [ApiController]
    public class PublicController : ControllerBase
    {

        private DoorLockConnectionHelper DataBase;

        public PublicController()
        {
            this.DataBase = new DoorLockConnectionHelper();
        }


        [HttpGet]
        [Route("GetDoor")]
        public DataFormat<DoorLock_Model> GetDoor()
        {

            DoorLock_Model data = this.DataBase.GetDoorState();


            var outPut = new DataStracture<DoorLock_Model>().GetDataFormat(data);

            return outPut;
        }


        [HttpPost]
        [Route("UpdateDoorState")]
        public bool UpdateDoorState([FromBody] DoorLock_Model data)
        {

            bool outPut = this.DataBase.UpdateDoorState(data._DoorState);

            return outPut;

        }

    }
}
