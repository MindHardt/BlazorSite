using Serilog;

Host.CreateDefaultBuilder(args)
	.ConfigureAppConfiguration(config =>
	{
		config.AddJsonFile("appsettings.json");
	})
	.UseSerilog((ctx, logger) =>
	{
		logger.ReadFrom.Configuration(ctx.Configuration);
	})
	.ConfigureWebHostDefaults(webBuilder =>
	{
		webBuilder.UseStartup<BlazorSite.Server.Startup>();
	})
	.Build()
	.Run();


