
using System.Security.Claims;
using System.Threading.Tasks;

namespace PermissionAuthorization.Services
{
    public interface IPermissionService
    {
        Task<bool> HasPermissionAsync(ClaimsPrincipal user, string permission);
    }
}
