using DotRedis.Connection;
using Microsoft.Extensions.DependencyInjection;

namespace MyLab.RedisManager
{
    /// <summary>
    /// Extension for configuration system
    /// </summary>
    public static class ConfigurationExtension
    {
        /// <summary>
        /// Registers Redis manager singleton
        /// </summary>
        public static void AddRedisManager(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IRedisManager, DefaultRedisManager>();
        }
    }
}