namespace firstProject;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        //app.MapGet("/", () => "Hello World!");
        app.Run(async (HttpContext context) =>
        {
            context.Response.StatusCode = 400;
            await context.Response.WriteAsync("hello");
            await context.Response.WriteAsync(" world");
        });

        app.Run();
    }
}