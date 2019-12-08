using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public interface IUserIDStore
    {
        int getUserId(string email);
    }
}
