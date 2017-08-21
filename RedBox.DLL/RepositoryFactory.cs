using RedBox.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBox.DLL
{
    public static class RepositoryFactory
    {
        /// <summary>
        /// 用户仓储
        /// </summary>
        public static InterfaceUserRepository UserRepository { get { return new UserRepository(); } }

        public static InterfaceRedBoxRepository RedBoxRepository { get { return new RedBoxRepository(); } }

        public static InterfaceAgentRepository AgentRepository { get { return new AgentRepository(); } }
    }
}
