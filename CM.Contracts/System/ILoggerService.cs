using System;

namespace CM.Contracts.System
{
    public interface ILoggerService
    {
        void LogError(string errorMessage);

        void LogInfo(string message);
    }
}
