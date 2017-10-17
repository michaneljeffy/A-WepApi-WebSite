using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;

namespace RedBox.IDAL
{
    public interface InterfaceRedBoxRepository:InterfaceBaseRepository<redbox>
    {
        dynamic GetMachineByVersion(int? ownerid,string version, string[] machines,int pageindex,int pagesize);
    }
}
