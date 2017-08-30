using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RedBox.IBLL;

namespace RedBox.Web.Controllers
{
    public class RedBoxShowsController : ApiController
    {
        protected IRedBoxShowService BoxShowService;
        public RedBoxShowsController(IRedBoxShowService _redBoxShowService)
        {
            BoxShowService = _redBoxShowService;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        public dynamic GetShows(string code)
        {
            return BoxShowService.GetBoxShows(code);
        }        
    }
}