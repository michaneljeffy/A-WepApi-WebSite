using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;

namespace RedBox.IBLL
{
    public interface  IOfficialAccountService:InterfaceBaseService<official_account>
    {
        /// <summary>
        /// 查看某一个公众号
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        dynamic Find(long id);

        /// <summary>
        /// 公众号是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Exists(long id);

        /// <summary>
        /// 公众号列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRecord"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        IQueryable<official_account> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order);
    }
}
