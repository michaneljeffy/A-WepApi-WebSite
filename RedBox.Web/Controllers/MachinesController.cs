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
        protected IRedBoxInfoService MachineInfoService;

        public MachinesController(InterfaceRedBoxService _redboxService, IRedBoxInfoService _machineInfoService)
        {
            MachineService = _redboxService;
            MachineInfoService = _machineInfoService;
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

        [HttpGet]
        public IHttpActionResult GetStatics()
        {
            dynamic  MachineInfo = MachineInfoService.GetSummaryInfo();

            if (MachineInfo == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(MachineInfo);
            }
        }
    }
}
