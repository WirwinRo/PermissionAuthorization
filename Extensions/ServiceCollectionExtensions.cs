
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;
using PermissionAuthorization.Authorization;
using PermissionAuthorization.Policy;
using PermissionAuthorization.Services;

namespace PermissionAuthorization.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPermissionAuthorization<T>(this IServiceCollection services)
            where T : class, IPermissionService
        {
            services.AddScoped<IPermissionService, T>();
            services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
            services.AddScoped<IAuthorizationHandler, PermissionHandler>();

            return services;
        }
    }
}
