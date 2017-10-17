using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;
using RedBox.IDAL;

namespace RedBox.DLL
{
    public class RedBoxShowRepository : BaseRepository<vb_redbox_shows>, IRedBoxShowRepository
    {
        public dynamic GetMachinesFromShow(long showID)
        {
            var machineInfo = from machines in this.nContext.redbox
                           join vb_shows in this.nContext.vb_redbox_shows
                           on machines.id equals vb_shows.redbox_id
                           where vb_shows.id == showID
                           select machines;

            return machineInfo;
        }

        public dynamic GetRedBoxShow(string code)
        {
            var shows = from MachineShows in this.nContext.vb_redbox_shows
                        join box in this.nContext.redbox on MachineShows.redbox_id equals box.id
                        where box.code == code
                        select MachineShows;

            return shows;

        }
    }
}
