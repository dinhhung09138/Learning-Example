using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Learning.Authentication.Data
{
    public class DummyAuthenticationStateProvider : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(5000);
            var anonymous = new ClaimsIdentity();

            var user = new ClaimsPrincipal(anonymous);

            return new AuthenticationState(user);
        }
    }
}
