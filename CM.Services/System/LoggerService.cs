using CM.Contracts.System;

namespace CM.Services.System
{
    public class LoggerService : ILoggerService
    {
        void ILoggerService.LogError(string errorMessage)
        {
            Console.WriteLine($"Error: {errorMessage}");
        }

        void ILoggerService.LogInfo(string message)
        {
            Console.WriteLine($"Information: {message}");
        }
    }
}
