using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;

namespace RedBox.IBLL
{
    public interface InterfaceRedBoxService:InterfaceBaseService<redbox>
    {
        /// <summary>
        /// 机器是否存在
        /// </summary>
        /// <param name="code">机器码</param>
        /// <returns>布尔值</returns>
        bool Exist(string code);

        /// <summary>
        /// 查找机器
        /// </summary>
        /// <param name="code">机器码</param>
        /// <returns></returns>
        redbox Find(string  code);

        /// <summary>
        /// 查找机器
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        redbox Find(int id);

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <param name="pageIndex">页码数</param>
        /// <param name="pageSize">每页记录数</param>
        /// <param name="totalRecord">总记录数</param>
        /// <param name="order">排序：0-ID升序（默认），1ID降序，2注册时间升序，3注册时间降序，4登录时间升序，5登录时间降序</param>
        /// <returns></returns>
        IQueryable<redbox> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order);
    }
}
