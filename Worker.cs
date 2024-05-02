using impromed_client;
using Impromed_Service;

namespace Impromed_Service

{
    public class Worker : BackgroundService
    {
        
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Service1 service1 = new Service1();

            service1.StartServiceLoop();

            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(1100, stoppingToken);
            }
        }
    }
}