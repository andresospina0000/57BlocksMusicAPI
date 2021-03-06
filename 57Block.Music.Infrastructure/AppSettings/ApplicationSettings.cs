using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace _57Block.Music.Infrastructure.AppSettings
{
    /// <summary>
    /// This class access to the appsettings file in order to get the values from this configuration file
    /// </summary>
    public class ApplicationSettings
    {
        private static IConfiguration AppConfig => GetAppSettingsConfig();

        private static IConfiguration appConfig;
        private static IConfiguration GetAppSettingsConfig()
        {
            if (appConfig == null)
            {
                var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                string appSettingFileName = "appsettings.json";
                if (!string.IsNullOrEmpty(environment) && environment.Equals("Development"))
                {
                    appSettingFileName = $"appsettings.{environment}.json";
                }

                appConfig = new ConfigurationBuilder()
                   .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                   .AddJsonFile(appSettingFileName)
                   .Build();
            }
            return appConfig;
        }

        public static ApplicationSettings appSettings = null;

        public static ApplicationSettings AppSettings
        {
            get
            {
                if(appSettings == null)
                {
                   appSettings = new ApplicationSettings();
                }
                return appSettings;
            }
        }

        /// <summary>
        /// Gets the connection string needed to connect to the SqLite database
        /// </summary>
        public string GetConnectionString
            => AppConfig["ConnectionStrings:DefaultConnection"];

        public ApplicationSettings() { }
    }
}
