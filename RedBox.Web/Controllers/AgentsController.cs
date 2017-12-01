using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RedBox.IBLL;
using RedBox.Models.RedBox;
using System.Web.Security;
using RedBox.Web.Models;
using System.Web;
using RedBox.Web.Common;
using System.Drawing;

namespace RedBox.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class AgentsController : ApiController
    {
        InterfaceAgentService AgentServices;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_agentServices"></param>
        public AgentsController(InterfaceAgentService _agentServices)
        {
            AgentServices = _agentServices;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET api/<controller>

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        // POST api/<controller>
        public dynamic Post([FromUri]string username, [FromUri]string password)
        {
            return AgentServices.Login(username, password);
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
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet]
        public dynamic Login(string username, string password)
        {
            var agent = AgentServices.Login(username, password);
            if (!(agent is channel))
            {
                return new { bRes = false };
            }

            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(0, username, DateTime.Now,
                           DateTime.Now.AddHours(1), true, string.Format("{0}&{1}", username, password),
                           FormsAuthentication.FormsCookiePath);

            //返回登录结果、用户信息、用户验证票据信息
            var oUser = new UserInfo { bRes = true, UserName = username, Password = password, Ticket = FormsAuthentication.Encrypt(ticket) };
            //将身份信息保存在session中，验证当前请求是否是有效请求
            HttpContext.Current.Session[username] = oUser;
            return oUser;
        }

        private bool ValidateUser(string strUser, string strPwd)
        {
            channel agent = AgentServices.Login(strUser, strPwd);
            if (agent.name == strUser && agent.password == strPwd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取图片验证码
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public dynamic GetImageCode()
        {
            string code = ImageCode.GenerateCheckCode();
            var image = Image.FromStream(ImageCode.Production(code));

            return new { Code = code, Image = image };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="photoNumber">参数为输入的手机号码</param>
        /// <returns></returns>
        [HttpGet]
        public dynamic GetMobileCheckCode(string photoNumber)
        {
            var message = MessageCode.GenerateMessageCode(6);//生成6位数的手机验证码

            var responseCode = MessageCode.SendMessageCode(photoNumber,message);

            return new { PhoneNo = photoNumber ,MessageCode = message ,Code = responseCode  };
        }
    }
}