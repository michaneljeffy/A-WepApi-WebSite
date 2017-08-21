using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RedBox.BLL;
using RedBox.Models.RedBox;
using RedBox.IBLL;
using Newtonsoft.Json;

namespace RedBox.Web.Controllers
{
    public class MachinesController : ApiController
    {
        protected InterfaceRedBoxService MachineService;

        public MachinesController(InterfaceRedBoxService _redboxService)
        {
            MachineService = _redboxService;
        }

        //get api/machines
        public IEnumerable<redbox> GetAllMachine(int pageIndex,int pageSize, int order)
        {
            int totalRecord = 0;
            IEnumerable <redbox> machines= MachineService.FindPageList(pageIndex, pageSize,out totalRecord, order);
            return machines;
        }

        //get api/machines/code =5

        public redbox  GetMachine(string code)
        {
            redbox Machine = MachineService.Find(code);

            if (Machine == null)
            {
                return null ;
            }
            else
            {
                return Machine;
            }

        }

        //public IHttpActionResult Get(string code)
        //{
        //    redbox Machine = MachineService.Find(code);

        //    if (Machine == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(Machine);
        //    }
        //}
    }
}
