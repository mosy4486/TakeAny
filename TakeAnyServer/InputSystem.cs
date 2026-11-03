using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public class InputSystem
    {
        public async Task<> GetCommand(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            { 
                string? answer = await Console.In.ReadLineAsync();

            }
        }
    }
}
