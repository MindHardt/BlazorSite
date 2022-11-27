using Microsoft.AspNetCore.Builder;

namespace BlazorSite.Server
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
			services.AddRazorPages();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseWebAssemblyDebugging();
			}
			else
			{
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseBlazorFrameworkFiles();
			app.UseStaticFiles();

			app.UseRouting();


			app.UseEndpoints(endpoints =>
			{
				endpoints.MapRazorPages();
				endpoints.MapControllers();
				endpoints.MapFallbackToFile("index.html");
			});
		}
	}
}
