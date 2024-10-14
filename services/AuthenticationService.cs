using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using nrcv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nrcv2.services
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(string username, string password);
        Task LogoutAsync();
        Task<Entry> GetCurrentUserAsync();
    }

    public class AuthenticationService : IAuthenticationService
    {
        [Inject]
        IDbContextFactory<nrcwebContext> dbf { get; set; }


        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AuthenticationService(IDbContextFactory<nrcwebContext> dbContext, AuthenticationStateProvider authenticationStateProvider)
        {
            dbf = dbContext;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            using (var db = dbf.CreateDbContext())
            {
                var user = await db.Entries.SingleOrDefaultAsync(u => u.UserName == username);

                if (user != null  && user.UserAmr==password)
                {
                    ((CustomAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(username);
                    return true;
                }

                return false;
            }

           
        }


        public Task LogoutAsync()
        {
            ((CustomAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            return Task.CompletedTask;
        }

        public async Task<Entry> GetCurrentUserAsync()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var username = authState.User.Identity.Name;
            Entry result;
            using (var db = dbf.CreateDbContext()) result = await db.Entries.SingleOrDefaultAsync(u => u.UserName == username);
            return (Entry)result;
        }
    }
}