using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;
using RedBox.IDAL;

namespace RedBox.DLL
{
    public class CityRepository : BaseRepository<printer_channel>, ICityRepository
    {
        public dynamic GetCitiesInfo()
        {
            var CityInfo = from cities in this.nContext.printer_channel
                           where cities.deleted_at == null
                           select new { cities.id,cities.channel_name};
            return CityInfo;
        }

        public dynamic getCollapseCities()
        {
            var StaticInfo = from cities in this.nContext.printer_channel
                             where cities.deleted_at == null
                             select cities;
            return StaticInfo;
        }
    }
}
