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

        public dynamic GetSummaryInfo()
        {
            dynamic data = new
            {
                total_count = GetTotalCount(),
                real_time_online_count = GetRealTimeOnlineCount(),
                today_accumulative_online_count = GetTodayOnline(),
                abnormal_count = GetAbnormalCount(),
                long_time_offline_count = GetLongTimeOffineCount()
            };
            return data;
        }

        //所有机器
        private dynamic GetTotalCount()
        {
            return CurrentRepository.Count((rb) => rb.code != string.Empty);
        }

        //在线机器
        private dynamic GetRealTimeOnlineCount()
        {
            return CurrentRepository.Count((rb) => rb.status == 0 && rb.onlined_at >= DateTime.Now && rb.code != string.Empty);
        }

        //今日累计在线机器
        private dynamic GetTodayOnline()
        {
            return CurrentRepository.Count((rb) => (rb.onlined_at >= DateTime.Now) && rb.code != string.Empty);
        }

        //异常机器
        private dynamic GetAbnormalCount()
        {
            return CurrentRepository.Count((rb) => (rb.onlined_at <= DateTime.Now || rb.status != 0) && rb.code != string.Empty);
        }

        //长时间不在线机器
        private dynamic GetLongTimeOffineCount()
        {
            DateTime lastOnlineDate = DateTime.Now.AddDays(-2);
            return CurrentRepository.Count((rb) => (rb.onlined_at <= lastOnlineDate || rb.status != 0) && rb.code != string.Empty);
        }

        public dynamic GetMachineByVersion(int? ownerid,string version,string[] machines,int pageindex,int pagesize)
        {
            var totalMachines = CurrentRepository.GetMachineByVersion(ownerid,version ,machines,pageindex,pagesize );
            return totalMachines;
        }
    }
}
