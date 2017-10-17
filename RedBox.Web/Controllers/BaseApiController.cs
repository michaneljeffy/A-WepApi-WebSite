using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using RedBox.Models.RedBox;
using System.Web.Http.Cors;

namespace RedBox.Web.Controllers
{
    [RequestAuthorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BaseApiController : ApiController
    {  
        public dynamic GetAgent()
        {
            dynamic agent = null;
            return agent;
           
        }
    }
}