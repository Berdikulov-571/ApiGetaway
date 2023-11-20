using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ApiGateway.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            // For registration
            builder.Configuration.AddJsonFile("ocelot.json");

            // Add 
            builder.Services.AddOcelot();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            // Use
            app.UseOcelot().Wait();

            app.MapControllers();

            app.Run();
        }
    }
}