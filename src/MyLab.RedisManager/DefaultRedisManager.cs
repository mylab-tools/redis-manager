using System;
using System.Text;
using System.Threading.Tasks;
using DotRedis;
using DotRedis.Connection;
using Microsoft.Extensions.Options;

namespace MyLab.RedisManager
{
    /// <summary>
    /// Default implementation of Redis manager
    /// </summary>
    public class DefaultRedisManager : IRedisManager
    {
        public RedisOptions Options { get; }
        
        public DefaultRedisManager(IOptions<RedisOptions> options)
            :this(options.Value)
        {
            
        }
        
        public DefaultRedisManager(RedisOptions options)
        {
            Options = options ?? throw new ArgumentNullException(nameof(options));
        }
        
        public async Task<IRedisConnection> GetConnection()
        {
            Encoding encoding = Options.Encoding != null
                ? Encoding.GetEncoding(Options.Encoding)
                : null;

            int port = Options.Port != 0
                ? Options.Port
                : 6379;
            
            return await Redis.ConnectAsync(new ConnectionParams
            {
                Encoding = encoding,
                Host = Options.Host,
                Password = Options.Password,
                Port = port,
                DbIndex = Options.DbIndex
            });
        }
    }
}