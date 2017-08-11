using System.Runtime.Remoting.Messaging;

namespace RedBox.DLL
{
    public class ContextFactory
    {
        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns></returns>
        public static RedBoxDbContext  GetCurrentContext()
        {
            RedBoxDbContext _nContext = CallContext.GetData("RedBoxDbContext") as RedBoxDbContext;
            if (_nContext == null)
            {
                _nContext = new RedBoxDbContext();
                CallContext.SetData("NineskyContext", _nContext);
            }
            return _nContext;
        }
    }
}
