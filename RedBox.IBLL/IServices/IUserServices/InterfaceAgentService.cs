using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models.RedBox;

namespace RedBox.IBLL
{
    public interface InterfaceAgentService:InterfaceBaseService<channel>
    {
        dynamic Login(string userName,string passWord);
    }
}
