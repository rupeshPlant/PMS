using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace UI.Extensions
{
    public static class AuthenticationServiceExtension
    {
        public static IServiceCollection AddAuthenticationServices(this IServiceCollection services, IConfiguration config)
        {
            var environment = services.BuildServiceProvider().GetRequiredService<IWebHostEnvironment>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
              .AddCookie(options =>
              {
                  options.LoginPath = "/Account/Login";
                  options.LogoutPath = "/Account/Logout";
                  options.Cookie.Name = "PMSCookie";
                  options.SlidingExpiration = false;
                  options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                  options.Cookie.HttpOnly = true;
                  options.Cookie.SameSite = SameSiteMode.Strict;
              });

            return services;
        }
    }
}