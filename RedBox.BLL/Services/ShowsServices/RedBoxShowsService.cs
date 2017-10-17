using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;
using RedBox.IBLL;
using RedBox.IDAL;
using RedBox.DLL;

namespace RedBox.BLL
{
    public class RedBoxShowsService : BaseService<vb_redbox_shows>,IRedBoxShowService
    {
        protected IRedBoxShowRepository CurrentRepository;
        public RedBoxShowsService ()
        {
            CurrentRepository = RepositoryFactory.BoxShowsRepository;
        }

        public override vb_redbox_shows Add(vb_redbox_shows entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(vb_redbox_shows entity)
        {
            throw new NotImplementedException();
        }

        public bool Exist(string code)
        {
            throw new NotImplementedException();
        }

        public vb_redbox_shows Find(int id)
        {
            throw new NotImplementedException();
        }

        public vb_redbox_shows Find(string code)
        {
            return CurrentRepository.GetRedBoxShow(code);
        }

        public override bool Update(vb_redbox_shows entity)
        {
            throw new NotImplementedException();
        }

        public dynamic GetBoxShows(string code)
        {
            return CurrentRepository.GetRedBoxShow(code);
        }

        public dynamic GetMachinesFromShow(long showID)
        {
            return CurrentRepository.GetMachinesFromShow(showID);
        }
    }
}
