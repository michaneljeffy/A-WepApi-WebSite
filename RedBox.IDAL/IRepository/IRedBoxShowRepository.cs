using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;

namespace RedBox.IDAL
{
    public interface IRedBoxShowRepository:InterfaceBaseRepository<redbox_shows>
    {
        dynamic GetRedBoxShow(redbox entity);
    }
}
