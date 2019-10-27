using System;

namespace WebApp.Infrastructure.Services.Contracts
{
    public interface ILoggingService
    {
        void Error(string errorMessage);

        void Warning(string warningMessage);

        void Info(string traceMessage);
    }
}
