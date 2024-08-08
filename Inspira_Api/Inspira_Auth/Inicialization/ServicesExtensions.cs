using Inspira_Auth.Adapters;
using Inspira_Auth.Inicialization.Options;
using Inspira_Auth.Services;

namespace Inspira_Auth.Inicialization
{
    public static class ServicesExtensions
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration cfg)
        {
            services.Configure<CognitoOptions>(cfg.GetSection("Cognito"));
            
            services.AddSwaggerGen();
            
            services.AddControllers();

            services.AddAuthorization();
        }

        public static void ConfigureIoC(this IServiceCollection services, IConfiguration cfg)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAuthServiceAdapter, AuthCognitoAdapter>();
        }

        public static void Configure(this WebApplicationBuilder builder)
        {
            builder.Services.ConfigureServices(builder.Configuration);
            builder.Services.ConfigureIoC(builder.Configuration);

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.RoutePrefix = "swagger";   
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Docs");
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
