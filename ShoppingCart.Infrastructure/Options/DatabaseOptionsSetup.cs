using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ShoppingCart.Infrastructure.Options
{
   public sealed class DatabaseOptionsSetup : IConfigureOptions<DatabaseOptions>
    {
        private readonly IHostEnvironment _env;
        private readonly IConfiguration _configuration;
        private const string _devConnection = "DevelopmentConnection";
        private const string _stagingConnection = "StagingConnection";
        private const string _sectionName = "DatabaseOptions";

        public DatabaseOptionsSetup(IHostEnvironment env, IConfiguration configuration)
        {
            _env = env;
            _configuration = configuration;
        }
        public void Configure(DatabaseOptions options)
        {
            if (_env.IsStaging() is true)
            {
                options.ConnectionString = _configuration.GetConnectionString(_stagingConnection);
            }
            else if (_env.IsDevelopment() is true)
            {
                options.ConnectionString = _configuration.GetConnectionString(_devConnection);
            }
            else
            {
                throw new InvalidOperationException("Environment not supported");
            }
            _configuration.GetSection(_sectionName).Bind(options);

        }
    }
}
