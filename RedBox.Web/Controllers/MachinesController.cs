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
using System.Web;

namespace RedBox.Web.Controllers
{
    public class MachinesController : ApiController   
    {
        protected InterfaceRedBoxService MachineService;
        //protected IRedBoxInfoService MachineInfoService;

        //public MachinesController(InterfaceRedBoxService _redboxService, IRedBoxInfoService _machineInfoService)
        //{
        //    MachineService = _redboxService;
        //    MachineInfoService = _machineInfoService;
        //}

        public MachinesController(InterfaceRedBoxService _redboxService)
        {
            MachineService = _redboxService;
           // MachineInfoService = _machineInfoService;
        }

        //get api/machines
        [Route("all")]
        public IEnumerable<redbox> GetAllMachine(int pageIndex,int pageSize, int order)
        {
            int totalRecord = 0;
            IEnumerable <redbox> machines= MachineService.FindPageList(pageIndex, pageSize,out totalRecord, order);
            return machines;
        }

        /// <summary>
        /// 获取单台机器信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        //get api/machines/code =5
        [Route("one")]
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

        [Route("statics")]
        public IHttpActionResult GetStatics()
        {
            dynamic MachineInfo = MachineService.GetSummaryInfo();

            if (MachineInfo == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(MachineInfo);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("version")]
        public dynamic GetMachinesByVersion(int?cid ,string version, int pageindex, int pagesize,string machines ="")
        {
            //string version = HttpContext.Current.Request.QueryString["version"];
            //  string cid = HttpContext.Current.Request.QueryString["cid"];
            //  string machines = HttpContext.Current.Request.QueryString["machines"];

            // int? owner_cid = int.Parse(cid);
            string[] machinesList = null;
           if (!string.IsNullOrWhiteSpace (machines))
            {
                machinesList = machines.Trim().Split(',');
            }
            
            IQueryable<redbox> targetMachines = MachineService.GetMachineByVersion(cid,version,machinesList,pageindex ,pagesize);

            // targetMachines = targetMachines.OrderBy(r=>r.code).Skip(pageindex - 1).Take(pagesize);
            
            return targetMachines;
        }
    }
}
