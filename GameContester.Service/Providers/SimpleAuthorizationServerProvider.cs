﻿using GameContester.Application.Services;
using GameContester.Contracts.Services;
using GameContester.DataAccess;
using GameContester.DataAccess.Managers;
using GameContester.DataAccess.Repository;
using GameContester.Domain.Entities;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GameContester.Service.Providers
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        private readonly IUserService userService;

        public SimpleAuthorizationServerProvider(IUserService userService)
        {
           
            this.userService = userService;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            User user = userService.Login(context.UserName, context.Password);

            if (user == null)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }

            if (user.IsBanned)
            {
                context.SetError("invalid_grant", "This account has been banned.");
                return;
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
            identity.AddClaim(new Claim(ClaimTypes.Role, user.Role));
            identity.AddClaim(new Claim("id", user.Id));

            context.Validated(identity);

        }
    }
}