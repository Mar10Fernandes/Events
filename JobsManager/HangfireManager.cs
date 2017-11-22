using Hangfire;
using System;
using PredictHq;
using System.Threading.Tasks;
using Hangfire.SqlServer;
using Owin;
using Microsoft.Owin;
using System.IO;
using Hangfire.Logging.LogProviders;
using Hangfire.Logging;

[assembly: OwinStartup(typeof(JobsManager.HangfireManager))]

namespace JobsManager
{
    public class HangfireManager
    {
        
        public void Run()
        {

            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data"));

            LogProvider.SetCurrentLogProvider(new ColouredConsoleLogProvider());

            GlobalConfiguration.Configuration.UseSqlServerStorage("DefaultConnection",new SqlServerStorageOptions { QueuePollInterval = TimeSpan.FromSeconds(1) });

            
            //BackgroundJob.Enqueue(() => TextBuffer.WriteLine("Background Job completed successfully!"));
            //TextBuffer.WriteLine("Background job has been created.");

            RecurringJob.AddOrUpdate(() => ExecutaJobMario(), Cron.Hourly);

            
        }

        public void ExecutaJobMario()
        {
            string stringData = GetEventsFromPredictAsync().ToString();
            // 
            
            //Trabalhar e Enviar a stringData para a BD
        }

        private async Task<string> GetEventsFromPredictAsync()
        {
            ExternalAccess externalAccess = new ExternalAccess();

            string stringData = "";//await externalAccess.GetEvents("Lisboa");

            return stringData;
        }

        //public void Configuration(IAppBuilder app)
        //{
           
        //    GlobalConfiguration.Configuration.UseSqlServerStorage(
        //        "DefaultConnection",
        //        new SqlServerStorageOptions { QueuePollInterval = TimeSpan.FromSeconds(1) });

        //    //app.UseHangfireDashboard();
        //    //app.UseHangfireServer();
            

        //    RecurringJob.AddOrUpdate(
        //        () => Console.WriteLine("{0} Recurring job completed successfully!", DateTime.Now.ToString()),
        //        Cron.Minutely);
        //}

    }

    
}


