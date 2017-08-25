using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.IBLL;
using RedBox.Models.RedBox;
using RedBox.IDAL;
using RedBox.DLL;
namespace RedBox.BLL
{
    public class RedBoxShowsServices : BaseService<redbox_shows>, IRedBoxShowService
    {
        protected InterfaceRedBoxRepository RedBoxRepository;
        protected IRedBoxShowRepository ShowRepository;

        public RedBoxShowsServices()
        {
            RedBoxRepository = RepositoryFactory.RedBoxRepository;
            ShowRepository = RepositoryFactory.ShowsRepository;
        }
        public override redbox_shows Add(redbox_shows entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(redbox_shows entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(redbox_shows entity)
        {
            throw new NotImplementedException();
        }

        public dynamic GetRedBoxShows(redbox entity)
        {
            return ShowRepository.GetRedBoxShow(entity);
        }
    }
}
