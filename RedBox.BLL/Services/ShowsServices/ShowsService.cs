using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.IBLL;
using RedBox.Models.RedBox;
using RedBox.IDAL;
using RedBox.DLL;

namespace RedBox.BLL.Services
{
    public class ShowsService : BaseService<shows>,IShowsService
    {
        protected IShowsRepository CurrentRepository;

        public ShowsService ()
        {
            this.CurrentRepository = RepositoryFactory.ShowsRepository;
        }

        public override shows Add(shows entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(shows entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(long id)
        {
            throw new NotImplementedException();
        }

        public dynamic Find(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<shows> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order)
        {
            switch (order)
            {
                case 1: return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, s => true, false,s=>s.created_at);
                case 2:  return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, s => true, true, s => s.id);
                default: return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, s => true, true, s => s.id);
            }          
        }

        public override bool Update(shows entity)
        {
            throw new NotImplementedException();
        }
    }
}
