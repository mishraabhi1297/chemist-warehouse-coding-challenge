using Microsoft.Extensions.DependencyInjection;
using PizzaShop;

var services = Startup.ConfigureServices();
var serviceProvider = services.BuildServiceProvider();
await serviceProvider.GetRequiredService<App>().Run();
