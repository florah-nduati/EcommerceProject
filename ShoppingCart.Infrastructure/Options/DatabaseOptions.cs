using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Infrastructure.Options
{
    public class DatabaseOptions
    {
        public int MaxRetryCount { get; set; } 
        public int MaxRetryDelay { get; set; }

        public int CommandTimeout { get; set; }

        public string? ConnectionString { get; set; } = string.Empty;
    }
}
