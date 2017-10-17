using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RedBox.Common.Cache;
using RedBox.Models;
using RedBox.IBLL;

namespace RedBox.Web.Controllers
{
    public class OfficialAccountsController : ApiController
    {
        protected IOfficialAccountService OfficialAccountService;
        protected ICacheManager cacheManager;

        public OfficialAccountsController(IOfficialAccountService _officialAccountService)
        {
            OfficialAccountService = _officialAccountService;
            cacheManager = new RedisCacheManager();
        }

        [HttpGet]
        public dynamic GetAllOfficialAccount(int pageIndex, int pageSize, int order)
        {
            int totalCount = 0;
            dynamic officialAccount;

            if (cacheManager.Contains("officialaccount"))
            {
                officialAccount = cacheManager.Get<dynamic>("officialaccount");
                return Ok(officialAccount);
            }
            else
            {
                officialAccount = OfficialAccountService.FindPageList(pageIndex, pageSize, out totalCount, order);

                cacheManager.Set("officialaccount", officialAccount, TimeSpan.FromMinutes(1));

                if (officialAccount != null)
                {
                    return Ok(officialAccount);
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
