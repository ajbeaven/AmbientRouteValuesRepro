using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AmbientRouteValuesDotNetCore3_1
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
		}
		
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "fancyRouteWithCulture",
					pattern: "{culture}/test-a-with-fancy-route",
					defaults: new { controller = "TestA", action = "Index" });

				endpoints.MapControllerRoute(
					name: "fancyRoute",
					pattern: "test-a-with-fancy-route",
					defaults: new { controller = "TestA", action = "Index" });

				endpoints.MapControllerRoute(
					name: "defaultWithCulture",
					pattern: "{culture}/{controller=Home}/{action=Index}/{id?}");

				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
