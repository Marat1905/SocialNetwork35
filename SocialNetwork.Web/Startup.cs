using Microsoft.AspNetCore.Builder;

namespace SocialNetwork.Web
{
    public class Startup
    {

        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Метод вызывается средой ASP.NET.
        // Используйте его для подключения сервисов приложения
        // Документация:  https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // Метод вызывается средой ASP.NET.
        // Используйте его для настройки конвейера запросов
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Проверяем, не запущен ли проект в среде разработки
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               // app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            //Добавляем компонент с настройкой маршрутов для главной страницы
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

        }
    }
}
