namespace _01MVCBasics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //// Add services to the container.
            //builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapGet("/", () => "Hello World");

            app.Use(async(context, next) =>
            {
                await context.Response.WriteAsync("Welcome to MVC");
                await next(context);
            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("\n This is mvc basic");
            });

            app.Run();
        }
    }
}