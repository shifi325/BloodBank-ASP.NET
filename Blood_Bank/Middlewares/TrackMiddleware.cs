namespace Blood_Bank.Middlewares
{
    public class TrackMiddleware
    {
        private readonly RequestDelegate _next;

        public TrackMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var guid = Guid.NewGuid().ToString();
            context.Items.Add("guid", guid);
            context.Response.Headers.Add("Set-Cookie", guid);
            if (1 == 1)
            {
                await _next(context);
            }
            else
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
        }
    }
}
