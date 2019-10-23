using System;

namespace WebApp.Application.Services.Contract
{
    public interface ILoggingService
    {
        void Error(string errorMessage);

        void Warning(string warningMessage);

        void Info(string traceMessage);
    }
}
