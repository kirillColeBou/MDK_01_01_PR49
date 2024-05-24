using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Праткическая_49_Тепляков
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "Авторизация и регистрация",
                    Description = "Авторизация и регистрация пользователей"
                });
                c.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v2",
                    Title = "Получение списка версий",
                    Description = "Получение всего списка версий"
                });
                c.SwaggerDoc("v3", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v3",
                    Title = "Получение списка блюд",
                    Description = "Получение всех блюд из базы"
                });
                c.SwaggerDoc("v4", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v4",
                    Title = "Отправка заказа",
                    Description = "Отправка заказов"
                });
                c.SwaggerDoc("v5", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v5",
                    Title = "Получение истории",
                    Description = "Получение списка истории всех заказов"
                });
                var filePath = Path.Combine(System.AppContext.BaseDirectory, "Практическая_49_Тепляков.xml");
                c.IncludeXmlComments(filePath);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseMvcWithDefaultRoute();
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Авторизация");
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "Получение списка версий");
                c.SwaggerEndpoint("/swagger/v3/swagger.json", "Получение списка блюд");
                c.SwaggerEndpoint("/swagger/v4/swagger.json", "Отправка заказа");
                c.SwaggerEndpoint("/swagger/v5/swagger.json", "Получение истории");
            });
        }
    }
}
