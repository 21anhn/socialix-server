
using Microsoft.EntityFrameworkCore;
using Socialix.Data;

namespace Socialix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Get connection string 
            var applicationConnection = builder.Configuration.GetConnectionString("ApplicationDbConnection");
            var authConnection = builder.Configuration.GetConnectionString("AuthDbConnection");

            // Add services to the container.
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(applicationConnection));
            builder.Services.AddDbContext<AuthDbContext>(options => options.UseSqlServer(authConnection));

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


            app.MapControllers();

            app.Run();
        }
    }
}
