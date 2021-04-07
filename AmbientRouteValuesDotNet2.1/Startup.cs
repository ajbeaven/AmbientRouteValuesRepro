using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AmbientRouteValuesDotNet2_1
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
		}
		
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseMvc(endpoints =>
			{
				endpoints.MapRoute(
					name: "testWithCulture",
					template: "{culture}/test-a-with-fancy-route",
					defaults: new { controller = "TestA", action = "Index" });

				endpoints.MapRoute(
					name: "test",
					template: "test-a-with-fancy-route",
					defaults: new { controller = "TestA", action = "Index" });

				endpoints.MapRoute(
					name: "defaultWithCulture",
					template: "{culture}/{controller=Home}/{action=Index}/{id?}");

				endpoints.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
