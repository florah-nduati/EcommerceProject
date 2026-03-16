using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace ShoppingCart.Infrastructure.Options
{
   public sealed class DatabaseOptionsSetup : IConfigureOptions<DatabaseOptions>
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _configuration;
        private const string StagingConnectionStringName = "StagingConnection";

        public DatabaseOptionsSetup(IWebHostEnvironment env, IConfiguration configuration)
        {
            _env = env;
            _configuration = configuration;
        }
        public void Configure(DatabaseOptions options)
        {
            if(_env.IsStaging() is true)
            {
                options.ConnectionString = _configuration.GetConnectionString("StagingConnection");
                options.CommandTimeout = _configuration.GetValue<int>("Database:CommandTimeout");
                options.MaxRetryCount = _configuration.GetValue<int>("Database:MaxRetryCount");
                options.MaxRetryDelay = _configuration.GetValue<int>("Database:MaxRetryDelay");
            }
        }
    }
}
