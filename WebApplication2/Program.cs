using Microsoft.EntityFrameworkCore;
using WebApplication2.DAL;

namespace WebApplication2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();
			builder.Services.AddDbContext<AppDbContext>(opt =>
			{
				opt.UseSqlServer("server=DESKTOP-KEF82RQ\\SQLEXPRESS;database=Cctv;trusted_connection=true;Encrypt=false");
			});

			var app = builder.Build();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}"
				);

			app.UseStaticFiles();

			app.Run();
		}
	}
}
