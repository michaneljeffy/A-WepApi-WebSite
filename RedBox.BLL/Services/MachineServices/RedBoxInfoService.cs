using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.IBLL;
using RedBox.Models.RedBox;
using RedBox.IDAL;
using RedBox.DLL;
using System.Dynamic;

namespace RedBox.BLL.Services
{
    public class RedBoxInfoService :BaseService<redbox>, IRedBoxInfoService
    {
        protected InterfaceRedBoxRepository CurrentRepository;

        public RedBoxInfoService()
        {
            CurrentRepository = RepositoryFactory.RedBoxRepository;
        }

        public override redbox Add(redbox entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(redbox entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(redbox entity)
        {
            throw new NotImplementedException();
        }

       



    }
}
