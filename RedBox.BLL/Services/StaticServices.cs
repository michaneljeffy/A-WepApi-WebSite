using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.IBLL;

namespace RedBox.BLL.Services
{
    public class StaticServices
    {
        protected RedBoxInfoService  redboxInfoService;

        public StaticServices(RedBoxInfoService _redboxInfoService)
        {
            redboxInfoService = _redboxInfoService;
        }

        public dynamic GetSummaryInfo()
        {
            return "";
        }
    }
}
