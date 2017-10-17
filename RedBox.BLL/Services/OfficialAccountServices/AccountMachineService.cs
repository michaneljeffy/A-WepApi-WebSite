using RedBox.Models.RedBox;
using System;
using RedBox.IBLL;
using System.Linq;
using RedBox.IDAL;
using RedBox.DLL;

namespace RedBox.BLL.Services
{
    public class AccountMachineService : BaseService<preference_printer>,IAccountMachineService
    {
        protected IAccountMachineRepository CurrentRepository;

        public AccountMachineService()
        {
            this.CurrentRepository = RepositoryFactory.AccountMachineRepository;
        }

        public override preference_printer Add(preference_printer entity)
        {
            if (entity !=  null)
            {
               
            }

            return this.CurrentRepository.Add(entity);
        }

        public override bool Delete(preference_printer entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(preference_printer entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(long id)
        {
            throw new NotImplementedException();
        }

        public dynamic Find(string code)
        {
            throw new NotImplementedException();
        }

        public IQueryable<preference_printer> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order)
        {
            switch (order)
            {
                case 1: return this.CurrentRepository.FindPageList(pageIndex,pageSize,out totalRecord ,r=>r.status ==1,true,r=>r.machine_code);
                default:return this.CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, r => r.status == 1, true, r => r.id);
            }
        }        
    }
}
