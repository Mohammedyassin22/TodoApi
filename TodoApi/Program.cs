using Microsoft.EntityFrameworkCore;

namespace TodoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<TodoDb>(x =>
                   x.UseInMemoryDatabase("TodoList"));

            var app = builder.Build();


            app.Run();
        }

    }
}
