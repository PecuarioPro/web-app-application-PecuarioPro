using PecuarioProPlatform.API.IAM.Infrastructure.Pipeline.Middleware.Components;

namespace PecuarioProPlatform.API.IAM.Infrastructure.Pipeline.Middleware.Extensions;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseRequestAuthorization(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestAuthorizationMiddleware>();
    }
}