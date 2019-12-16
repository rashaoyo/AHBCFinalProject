using AHBCFinalProject.DAL;
using Identity.Dapper.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        //private readonly UserManager<DapperIdentityUser> _userManager;

        public UserIdService(IUserIDStore userIdStore, IHttpContextAccessor httpContextAccessor/*, UserManager<DapperIdentityUser> userManager*/)
        {
            _userIDStore = userIdStore;
            _httpContextAccessor = httpContextAccessor;
            //_userManager = userManager;
        }

     

        public int getUserId()
        {
            //Ed's method...
            //var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            //var id = user.Id;

            //Stack overflow method...
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var id = int.Parse(userId);
            
            //Custom method...
            //UserId = _userIDStore.getUserId(email);


            return id;
        }
    }
}
