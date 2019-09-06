using System.Threading.Tasks;
using DotRedis.Connection;

namespace MyLab.RedisManager
{
    /// <summary>
    /// Provides abilities to work with Redis
    /// </summary>
    public interface IRedisManager
    {
        /// <summary>
        /// Provides new Redis connection
        /// </summary>
        Task<IRedisConnection> GetConnection();
    }
}