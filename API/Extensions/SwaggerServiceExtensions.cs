using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;

namespace API.Extensions
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
             services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "SkiNet App", Version = "v1"});
            });

            return services;
            
        }

        public static IApplicationBuilder UseSwaggerDocumention(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => {c
                .SwaggerEndpoint("/swagger/v1/swagger.json", "SkiNet API v1");});
             
             return app;
        }


    }
}