using CsharpHandlers.Functions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpHandlers
{
    internal class StartUp
    {
        internal IConfiguration BuildConfig(IServiceCollection services)
        {
            return new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddUserSecrets<CreateWithDrawallHandler>()
            .Build();

        }
    }
}
