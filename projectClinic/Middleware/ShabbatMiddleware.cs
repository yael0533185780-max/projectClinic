namespace projectClinic.Middleware
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;
        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            if (DayOfWeek.Tuesday == DateTime.Now.DayOfWeek)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Response.ContentType = "text/plain; charset=utf-8";
                await context.Response.WriteAsync("אין הזמנת תורים בשבת קודש! במקרה דחוף יש לפנות לביה''ח");
                return;
            }
            await _next(context);
        }
    }
}
