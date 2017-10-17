using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;

namespace RedBox.IBLL
{
    public interface IAccountMachineService:InterfaceBaseService<preference_printer>
    {
        /// <summary>
        /// 查看某一台机器上的公众号
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        dynamic Find(string  code);

        /// <summary>
        /// 公众号是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Exists(long id);

        /// <summary>
        /// 公众号上线的机器列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRecord"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        IQueryable<preference_printer> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order);
    }
}
