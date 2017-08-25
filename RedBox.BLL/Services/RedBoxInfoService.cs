using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.IBLL;
using RedBox.Models.RedBox;
using RedBox.IDAL;
using RedBox.DLL;
using System.Dynamic;

namespace RedBox.BLL.Services
{
    public class RedBoxInfoService :BaseService<redbox>, IRedBoxInfoService
    {
        protected InterfaceRedBoxRepository CurrentRepository;

        public RedBoxInfoService()
        {
            CurrentRepository = RepositoryFactory.RedBoxRepository;
        }

        public override redbox Add(redbox entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(redbox entity)
        {
            throw new NotImplementedException();
        }

        public dynamic GetSummaryInfo()
        {
            dynamic data = new {
                total_count = GetTotalCount(),
                real_time_online_count = GetRealTimeOnlineCount(),
                today_accumulative_online_count= GetTodayOnline(),
                abnormal_count = GetAbnormalCount(),
                long_time_offline_count = GetLongTimeOffineCount()
        };       
            return data;
        }

        public override bool Update(redbox entity)
        {
            throw new NotImplementedException();
        }

        //所有机器
        private dynamic GetTotalCount()
        {
            return CurrentRepository.Count((rb)=>rb.code !=string.Empty);
        }

        //在线机器
        private dynamic GetRealTimeOnlineCount()
        {
            return CurrentRepository.Count((rb)=>rb.status == 0 && rb.onlined_at >= DateTime.Now && rb.code != string.Empty);
        }

        //今日累计在线机器
        private dynamic GetTodayOnline()
        {
            return CurrentRepository.Count((rb) => (rb.onlined_at >= DateTime.Now ) && rb.code != string.Empty);
        }

        //异常机器
        private dynamic GetAbnormalCount()
        {
            return CurrentRepository.Count((rb) => (rb.onlined_at <= DateTime.Now || rb.status !=0) && rb.code != string.Empty);
        }

        //长时间不在线机器
        private dynamic GetLongTimeOffineCount()
        {
            DateTime lastOnlineDate = DateTime.Now.AddDays(-2);
            return CurrentRepository.Count((rb) => (rb.onlined_at <= lastOnlineDate|| rb.status!=0)&& rb.code != string.Empty);
        }

    }
}
