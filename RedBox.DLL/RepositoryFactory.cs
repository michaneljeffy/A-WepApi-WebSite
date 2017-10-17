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

        public static IRedBoxShowRepository BoxShowsRepository { get { return new RedBoxShowRepository(); } }

        public static IShowsRepository ShowsRepository { get { return new ShowsRepository(); } }

        public static IOfficialAccountRepository OfficialAccountRepository { get { return new OfficialAccountRepository(); } }

        public static ICityRepository CityRepository { get { return new CityRepository(); } }

        public static IAccountMachineRepository AccountMachineRepository { get { return new AccountMachineRepository(); } }
    }
}
