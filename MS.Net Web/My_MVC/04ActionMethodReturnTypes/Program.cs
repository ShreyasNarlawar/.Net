namespace _04ActionMethodReturnTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}/{un?}/{pwd?}"
            //);

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=About}/{id?}"
                );


            app.Run();
        }
    }
}
