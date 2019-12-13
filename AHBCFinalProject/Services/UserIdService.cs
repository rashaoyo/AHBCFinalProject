using AHBCFinalProject.DAL;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public class UserIdService : IUserIdService
    {
        private readonly IUserIDStore _userIDStore;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserIdService(IUserIDStore userIdStore, IHttpContextAccessor httpContextAccessor)
        {
            _userIDStore = userIdStore;
            _httpContextAccessor = httpContextAccessor;
        }

        public int UserId { get; set; }

        public int getUserId()
        {
            //UserId = _userIDStore.getUserId(email);
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.Parse(userId);
        }
    }
}
