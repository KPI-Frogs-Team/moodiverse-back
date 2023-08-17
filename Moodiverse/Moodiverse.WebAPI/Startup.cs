using Microsoft.EntityFrameworkCore;
using Moodiverse.DAL.Context;
using Moodiverse.WebAPI.Extensions;

namespace Moodiverse.WebAPI;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<MoodiverseDbContext>(options =>
            options.UseSqlServer(_configuration.GetConnectionString("MoodiverseConnectionString")));
        
        services.RegisterAutoMapper();
        services.RegisterCustomServices();
        
        services.ConfigureJwt(_configuration);

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddControllers();
    }
    
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
        app.UseCors(builder => builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
            .WithOrigins("(link to client)"));

        app.UseRouting();
        app.UseHttpsRedirection();
        
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(cfg =>
        {
            cfg.MapControllers();
        });
    }
    
}