using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RedBox.IBLL;

namespace RedBox.Web.Controllers
{
    public class AgentsController : ApiController
    {
        InterfaceAgentService AgentServices;

        public AgentsController(InterfaceAgentService _agentServices)
        {
            AgentServices = _agentServices;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        public dynamic Get(string username, string password)
        {
           return  AgentServices.Login(username, password);
        }

        // POST api/<controller>
        public dynamic Post([FromUri]string username, [FromUri]string password)
        {
             return AgentServices.Login(username, password);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}