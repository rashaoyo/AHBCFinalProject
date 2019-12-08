using AHBCFinalProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public class UserIdService : IUserIdService
    {
        private readonly IUserIDStore _userIDStore;

        public UserIdService(IUserIDStore userIdStore)
        {
            _userIDStore = userIdStore;
        }

        public int UserId { get; set; }

        public int getUserId(string email)
        {
            UserId = _userIDStore.getUserId(email);
            return UserId;
        }
    }
}
