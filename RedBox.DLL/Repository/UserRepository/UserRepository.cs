using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.Models;
using RedBox.IDAL;

namespace RedBox.DLL
{
    public class UserRepository:BaseRepository<User>,InterfaceUserRepository
    {
    }
}
