using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSolid.SOLID
{
    internal class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

        public void LogError(string errorMessage)
        {
            Console.WriteLine($"Error: {errorMessage}");
        }

        public void LogWarning(string message) 
        {
            Console.WriteLine($"Warning: {message}");
        }
    }

    internal class SingleResponsibilityPrinciple
    {
        private readonly Logger _logger;

        public SingleResponsibilityPrinciple()
        {
            _logger = new Logger();
        }

        public void PerformTask()
        {
            try
            {
                Console.WriteLine("Performing a task..."); 
                throw new Exception("Something went wrong!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
    }
}
