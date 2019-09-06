using DotRedis.Connection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyLab.RedisManager
{
    /// <summary>
    /// Extension for integration
    /// </summary>
    public static class IntegrationExtension
    {
        public const string DefaultConfigPath = "Redis";
        
        /// <summary>
        /// Registers Redis manager singleton
        /// </summary>
        public static void AddRedisManager(this IServiceCollection serviceCollection, IConfiguration configuration, string configPath = DefaultConfigPath)
        {
            serviceCollection.AddSingleton<IRedisManager, DefaultRedisManager>();
            serviceCollection.Configure<RedisOptions>(configuration.GetSection(configPath));
        }
    }
}