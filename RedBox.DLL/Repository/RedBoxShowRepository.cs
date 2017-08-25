using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.IDAL;
using RedBox.Models.RedBox;

namespace RedBox.DLL
{
    public class RedBoxShowRepository:BaseRepository<redbox_shows>,IRedBoxShowRepository 
    {
        public dynamic GetRedBoxShow(redbox entity)
        {
            var redboxshow = nContext.redbox_shows.FirstOrDefault((u) =>u.redbox_id == entity.id);
            return redboxshow;
        }
    }
}
