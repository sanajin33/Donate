using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Claims;

namespace Donate.Data.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static string? GivenName(this ClaimsPrincipal user)
    {
        ArgumentNullException.ThrowIfNull(user);
        return user.FindFirstValue(ClaimTypes.GivenName);
    }
    public static int Id(this ClaimsPrincipal user)
    {
        ArgumentNullException.ThrowIfNull(user);
        if(int.TryParse(user.FindFirstValue(ClaimTypes.NameIdentifier), out int id))
            return id;
        else
            return 0;
    }
    public static string? Email(this ClaimsPrincipal user)
    {
        ArgumentNullException.ThrowIfNull(user);
        return user.FindFirstValue(ClaimTypes.Email);
    }
}
