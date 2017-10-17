using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RedBox.IBLL;

namespace RedBox.Web.Controllers
{
    /// <summary>
    /// 机器上线广告信息
    /// </summary>
    public class RedBoxShowsController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        protected IRedBoxShowService BoxShowService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_redBoxShowService"></param>
        public RedBoxShowsController(IRedBoxShowService _redBoxShowService)
        {
            BoxShowService = _redBoxShowService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<controller>/5
        public void Delete(int id)
        {

        }

        /// <summary>
        /// 获取当前机器的广告
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("show")]
        public dynamic GetShows(string code)
        {
            return BoxShowService.GetBoxShows(code);
        }
        
        /// <summary>
        /// 获取广告在线机器信息
        /// </summary>
        /// <param name="showID"></param>
        /// <returns></returns>
        [Route("machines")]
        public dynamic GetMachines(long showID)
        {
            return BoxShowService.GetMachinesFromShow(showID);
        }
    }
}