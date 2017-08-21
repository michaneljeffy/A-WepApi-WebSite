using System.Runtime.Remoting.Messaging;
using RedBox.Models;
using RedBox.Models.RedBox;

namespace RedBox.DLL
{
    public class ContextFactory
    {
        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns></returns>
        public static RedBoxModel GetCurrentContext()
        {
            RedBoxModel _nContext = CallContext.GetData("RedBox") as RedBoxModel;
            if (_nContext == null)
            {
                _nContext = new RedBoxModel();
                CallContext.SetData("RedBox", _nContext);
            }
            return _nContext;
        }
    }
}
