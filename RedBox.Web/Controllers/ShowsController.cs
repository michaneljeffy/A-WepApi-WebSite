using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RedBox.IBLL;
using RedBox.Common.Cache;
using RedBox.Models.RedBox;

namespace RedBox.Web.Controllers
{
    /// <summary>
    /// 广告
    /// </summary>
    public class ShowsController : BaseApiController    
    {
        protected IShowsService ShowService;

        protected ICacheManager cacheManager;

        /// <summary>
        /// 构造函数注入services
        /// </summary>
        /// <param name="_ShowServcie"></param>
        public ShowsController(IShowsService _ShowServcie)
        {
            ShowService = _ShowServcie;
            cacheManager = new RedisCacheManager();
        }

        /// <summary>
        /// 分页获取所以的广告信息
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        [Route("api/shows/all")]
        public dynamic GetAllShows(int pageIndex,int pageSize,int order)
        {
            int totalCount = 0;

            if(cacheManager.Contains("shows"))
            {
                dynamic showsData = cacheManager.Get<dynamic>("shows");
                return Ok(showsData);
            }
            else
            {
                dynamic AllShows = ShowService.FindPageList(pageIndex, pageSize, out totalCount, order);

                cacheManager.Set("shows", AllShows, TimeSpan.FromMinutes (1));

                if (AllShows != null)
                {
                    return Ok(AllShows);
                }
                else
                {
                    return NotFound();
                }
            }         
        }

        /// <summary>
        /// 获取单个广告信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public shows GetShow(long id)
        {
            var show = ShowService.Find(id);

            return show;
        }
    }
}
