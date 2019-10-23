using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Application.Services.Contract;

namespace WebApp.Logging
{
    public class LoggingService : ILoggingService
    {
        public LoggingService()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.FromLogContext()
                .CreateLogger();
        }

        public void Error(string errorMessage)
        {
            Log.Error(errorMessage);
        }

        public void Info(string information)
        {
            Log.Information(information);
        }

        public void Warning(string warningMessage)
        {
            Log.Warning(warningMessage);
        }
    }
}
