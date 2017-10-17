using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;
using RedBox.IBLL;
using RedBox.DLL;
using RedBox.IDAL;
using System.Collections;

namespace RedBox.BLL
{
    public class CityService : BaseService<printer_channel>, ICityService
    {
        protected ICityRepository CurrentReposity;

        public CityService()
        {
            CurrentReposity = RepositoryFactory.CityRepository;
        }

        public override printer_channel Add(printer_channel entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(printer_channel entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(printer_channel entity)
        {
            throw new NotImplementedException();
        }

        public dynamic GetCities()
        {
            var CityInfo =  CurrentReposity.Find((city)=>city.deleted_at == null);

            
            return CityInfo;
        }


        public dynamic getCollapseCities()
        {

            IQueryable<printer_channel> CollapseCities = CurrentReposity.getCollapseCities();
            var returnDictionary = new Dictionary<int?, List<Dictionary<int?, long>>>();

            foreach (var item in CollapseCities)
            {
                var CitiesInfo = new { CitiKey = item.city_code == null ? item.city_code : (int)item.id,
                    ProvinceCode = item.province_code, ID = item.id
                };
            
                var tmpDictionary = new Dictionary<int?,long>();
          
                if (!returnDictionary.ContainsKey(CitiesInfo.ProvinceCode))
                {
                    if (!tmpDictionary.ContainsKey(CitiesInfo.CitiKey))
                    {
                        tmpDictionary.Add(CitiesInfo.CitiKey, CitiesInfo.ID);
                    }
                }                          

            }
            return returnDictionary;
        }
    }
}
