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
    public class OfficicalAccountsServices : BaseService<official_account>,IOfficialAccountService 
    {
        protected IOfficialAccountRepository CurrentRepository;

        public OfficicalAccountsServices ()
        {
            this.CurrentRepository = RepositoryFactory.OfficialAccountRepository;
        }

        public override official_account Add(official_account entity)
        {
           return this.CurrentRepository.Add(entity);          
        }

        public override bool Delete(official_account entity)
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

        public IQueryable<official_account> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order)
        {
           switch(order)
            {
                case 1: return CurrentRepository.FindPageList(pageIndex,pageSize,out totalRecord,oa=>true, false,oa=>oa.created_at);
                case 2: return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, oa => true, false, oa => oa.id);
                default: return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, oa => true, false, oa => oa.created_at);
            }
        }

        public override bool Update(official_account entity)
        {
            throw new NotImplementedException();
        }
    }
}
