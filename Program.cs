
using FilmesApi.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace FilmesApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var conectionString = builder.Configuration.GetConnectionString("FilmeConnection");

            builder.Services.AddDbContext<FilmeContext>(options => options.UseMySql(conectionString, ServerVersion.AutoDetect(conectionString)));

            // Add services to the container.

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