using System;
using System.Text;
using IdentityData.Context;
using IdentityData.Entities;
using IdentityData.Managers;
using IdentityData.Providers;
using IdentityData.Stores;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using WebAPI.Services;
using WebAPI.Settings;

namespace WebAPI.Configurations
{
    public static class ServiceConfigurationExtensions
    {
        public static IServiceCollection ConfigureAuthentication(this IServiceCollection services, 
                                                                    IConfiguration configuration)
        {
            var jwtSettings = new JwtSettings();
            configuration.Bind(nameof(JwtSettings), jwtSettings);
            

            var key = Encoding.ASCII.GetBytes(jwtSettings.Secret);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.FromMinutes(5)
                };
            });
            
            
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.Secret)),
                ValidateIssuer = false,
                ValidateAudience = false,
                RequireExpirationTime = false,
                ValidateLifetime = true
            };

            
            services.AddSingleton(tokenValidationParameters);
            services.AddSingleton(jwtSettings);
            
            return services;
        }


        public static IServiceCollection ConfigureDatabase(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(builder =>
            {
                builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), 
                    optionsBuilder => optionsBuilder.MigrationsAssembly("WebAPI"));
            });
            
            return services;
        }

        public static IServiceCollection InstallServices(this IServiceCollection services)
        {
            services.AddScoped<IUserStore<User>, UserStore>();
            services.AddScoped<IPasswordHasher<User>, PasswordHasher>();
            services.AddScoped<ILookupNormalizer, LookupNormalizer>();
            services.AddScoped<IdentityErrorDescriber>();
            
            services.AddScoped<UserManager>();   
            
            services.AddScoped<RoleManager>();   
            services.AddScoped<IRoleStore<Role>, RoleStore>();   
            
            services.AddScoped<IIdentityService, IdentityService>();
            return services;
        }
    }
}