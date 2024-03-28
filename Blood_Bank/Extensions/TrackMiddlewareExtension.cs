using Blood_Bank.Middlewares;

namespace Blood_Bank.Extensions
{
    public static class TrackMiddlewareExtension
    {
        public static IApplicationBuilder UseTrack(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TrackMiddleware>();
        }
    }
}
