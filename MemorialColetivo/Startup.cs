using MemorialColetivo.Data;
using MemorialColetivo.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace MemorialColetivo
{
    public class Startup
    {
        public Startup(IConfiguration configuration) 
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)    
        {
            //DbContext configuration
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));

            //Services configuration
            services.AddScoped<IUsuariosService, UsuariosService>();
            services.AddScoped<IMemorialService, MemorialService>();

            services.AddControllersWithViews();
        }
        public void Configure(WebApplication app, IWebHostEnvironment enviroment)
        {
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            //Seed database
            AppDbInitializer.Seed(app);
        }
    }
}
