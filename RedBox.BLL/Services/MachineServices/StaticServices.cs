using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.IBLL;
using RedBox.Models.RedBox;
using RedBox.DLL;
using RedBox.IDAL;

namespace RedBox.BLL.Services
{
    public class StaticServices:BaseService<redbox>,IRedBoxInfoService 
    {
        protected InterfaceRedBoxRepository   staticRepository;

        public StaticServices(RedBoxInfoService _redboxInfoService)
        {
            staticRepository = RepositoryFactory.RedBoxRepository;
        }

        public override redbox Add(redbox entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(redbox entity)
        {
            throw new NotImplementedException();
        }

        public dynamic GetSummaryInfo()
        {
            return "";
        }

        public override bool Update(redbox entity)
        {
            throw new NotImplementedException();
        }
    }
}
