
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using PermissionAuthorization.Services;

namespace PermissionAuthorization.Authorization
{
    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        private readonly IPermissionService _permissionService;

        public PermissionHandler(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            PermissionRequirement requirement)
        {
            if (await _permissionService.HasPermissionAsync(context.User, requirement.Permission))
            {
                context.Succeed(requirement);
            }
        }
    }
}
