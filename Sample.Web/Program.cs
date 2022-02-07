using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System;

namespace Sample.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();
            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>().ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.SetMinimumLevel(LogLevel.Trace);

                }).UseNLog().UseEnvironment(Environment);

        public static string Environment
        {
            get
            {
                string environmentName;
                #if DEBUG
                environmentName = "Development";
                #else
                environmentName = "Production";
                #endif
                return environmentName;
            }
        }
    }
}
