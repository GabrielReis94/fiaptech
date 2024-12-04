﻿namespace UpdateContact
{
    public static class ContactUserHelper
    {
        private static IConfigurationRoot _configuration;
        static ContactUserHelper()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                 .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
        }
        public static string GetSetting(string key)
        {
            return _configuration[key];
        }

        public static string GetConnectionString(string key)
        {
            return _configuration.GetConnectionString(key);
        }
    }
}