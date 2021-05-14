using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace core_tool_console
{
	class StartupCustom
	{
		public void ConfigureServices()
		{

		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.Use( async (context, a) =>
			{
				await context.Response.WriteAsync("Hello");
			});
		}
	}
}
