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
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserIdService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
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