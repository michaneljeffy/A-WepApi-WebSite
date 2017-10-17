using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;

namespace RedBox.IBLL
{
    public interface IShowsService:InterfaceBaseService<shows>
    {
        /// <summary>
        /// 查看某一个广告
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        dynamic Find(long id);

        /// <summary>
        /// 广告是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Exists(long id);

        /// <summary>
        /// 广告列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRecord"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        IQueryable<shows> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order);
    }
}
