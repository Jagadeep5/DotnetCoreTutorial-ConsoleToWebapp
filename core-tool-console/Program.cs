using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace core_tool_console
{
	class Program
	{
		static void Main(string[] args)
		{
			// We converted this from console app to web app
			
			CreateWebHostBilder(args).Build().Run();
		}

		public static IHostBuilder CreateWebHostBilder(string[] args)
		{
			return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(x =>
			{
				x.UseStartup<StartupCustom>();
			});
		}
	}
}
