using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.IBLL;
using RedBox.IDAL;
using RedBox.Models.RedBox;
using RedBox.DLL;

namespace RedBox.BLL
{
    public class RedBoxService : BaseService<redbox>, InterfaceRedBoxService
    {
        protected InterfaceRedBoxRepository  CurrentRepository;

        protected AgentRepository agentRepository;

        protected InterfaceAgentService agentService { get; set; }

        public RedBoxService()
        {
            CurrentRepository = RepositoryFactory.RedBoxRepository ;
        }

        public bool Exist(string code)
        {
            return CurrentRepository.Exist(rb => rb.code == code);
        }

        public redbox Find(string code)
        {
                return CurrentRepository.Find(rb=>rb.code == code);
        }

        public redbox Find(int id)
        {
            return CurrentRepository.Find(rb=>rb.id ==id);
        }

        public IQueryable<redbox> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order)
        {
            switch (order)
            {
                case 0: return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, true, u => u.id );
                case 1: return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => !string.IsNullOrWhiteSpace (u.code), false, u => u.code );
                case 2: return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, true, u => u.created_at );
                case 3: return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, false, u => u.cid );
                case 4: return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, true, u => u.city );
                case 5: return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, false, u => u.child_cid );
                default: return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, true, u => u.con_tel );
            }

        }

        public InterfaceAgentService GetAgentService()
        {
            if(this.agentService== null)
            {
                this.agentService = new AgentService();
            }

            return this.agentService;
        }

        public dynamic Bind()
        {
            
            return "";
        }

        public override redbox Add(redbox entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(redbox entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(redbox entity)
        {
            throw new NotImplementedException();
        }
    }
}
