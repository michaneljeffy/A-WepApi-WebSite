using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;
using RedBox.IBLL;
using RedBox.DLL;
using RedBox.IDAL;
using System.Security.Cryptography;//加密

namespace RedBox.BLL
{
    public class AgentService:BaseService<channel>,InterfaceAgentService
    {
        protected InterfaceAgentRepository CurrentRepository;

        public AgentService()
        {
            CurrentRepository = RepositoryFactory.AgentRepository;
        }
        
        protected RedBoxService redBoxService { get; set; }

        public override channel Add(channel entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(channel entity)
        {
            throw new NotImplementedException();
        }

        public InterfaceRedBoxService GetRedBoxService()
        {
            if (redBoxService== null)
            {
                redBoxService = new RedBoxService();
            }
            return redBoxService;
        }

        public override bool Update(channel entity)
        {
            throw new NotImplementedException();
        }

        public dynamic Login(string userName,string passWord)
        {
            var agent = this.CurrentRepository.Find(user=>user.name == userName);
            if (agent == null ||! ISPasswordMatched (passWord,agent.password ))
            {
                return "用户名或密码错误";
            }

            return LoginWithAgent(agent);
        }

        private  bool ISPasswordMatched(string inputPassword,string dbPassword)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] result = Encoding.Default.GetBytes(inputPassword);
            byte[] output = md5.ComputeHash(result);

            inputPassword  = BitConverter.ToString(output).Replace("-","").ToLower();

            if(string.Equals(inputPassword ,dbPassword))
            {
                return true;
            }

            else
            {
                return false;
            }
           
        }

        private dynamic LoginWithAgent(channel agent)
        {
            return agent;
        }

        public dynamic GetDataWarning(channel agent,dynamic paras)
        {
            if(paras["start_time"]==null||paras["end_time"]==null)
            {
                return "";
            }

            return "";
        }


    }
}
