using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;
using RedBox.IDAL;

namespace RedBox.DLL
{
    public class RedBoxRepository:BaseRepository<redbox>, InterfaceRedBoxRepository
    {
        public dynamic GetMachineByVersion(int? ownerid,string version, string[] machines,int pageindex,int pagesize)
        {
            IQueryable<redbox> totalMachines = null;
            if(machines == null)
            {
                if(!string.IsNullOrWhiteSpace(version))
                {
                    totalMachines = (from vmachines in nContext.redbox
                                     where (vmachines.version == version || vmachines.ver_type == version)
                                     select vmachines).OrderBy(u => u.code).Skip(pageindex - 1).Take(pagesize);
                }

                if (!(ownerid == 0 || ownerid == null))
                {
                    totalMachines = from targetMachine in totalMachines
                                    where targetMachine.owner_cid == ownerid
                                    select targetMachine;
                }             
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(version))
                {
                    totalMachines = (from vmachines in nContext.redbox
                                     where machines.Contains(vmachines.code) && (vmachines.version == version || vmachines.ver_type == version)
                                     select vmachines).OrderBy(u => u.code).Skip(pageindex - 1).Take(pagesize);
                }

                if (!(ownerid == 0 || ownerid == null))
                {
                    totalMachines = from targetMachine in totalMachines
                                    where targetMachine.owner_cid == ownerid
                                    select targetMachine;
                }

            }
            return totalMachines;
        }
    }
}
