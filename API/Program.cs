using System;
using API.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API {

  public class Program {

    public static void Main(string[] args) {
      var host = CreateHostBuilder(args).Build();
      using var scope = host.Services.CreateScope(); // making sure garbage collector picks up after use
      var context = scope.ServiceProvider.GetRequiredService<StoreContext>();
      var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
      try {
        context.Database.Migrate();
        DBInitializer.Initialize(context);
      } catch (Exception ex) {
        logger.LogError(ex, "Problem migrating data");
      }

      host.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => {
              webBuilder.UseStartup<Startup>();
            });

  }

}
