using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;

namespace RedBox.IBLL
{
    public interface IRedBoxShowService:InterfaceBaseService<vb_redbox_shows>
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
        vb_redbox_shows Find(string code);

        /// <summary>
        /// 查找机器
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        vb_redbox_shows Find(int id);

        dynamic GetBoxShows(string code);

    }
}
