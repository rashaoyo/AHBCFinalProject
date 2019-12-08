using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public class UserIdService : IUserIdService
    {
        public int UserId { get; set; }

        public UserIdService(string userId)
        {
            UserId = int.Parse(userId);
        }

    }
}
