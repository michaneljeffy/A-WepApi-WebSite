using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;

namespace RedBox.IDAL
{
    public interface IRedBoxShowRepository:InterfaceBaseRepository<vb_redbox_shows>
    {
        dynamic GetRedBoxShow(string code);

        dynamic GetMachinesFromShow(long showID);
    }
}
