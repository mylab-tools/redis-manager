using System;

namespace MyLab.RedisManager
{
    /// <summary>
    /// Contains Redis connection options
    /// </summary>
    public class RedisOptions
    {
        /// <summary>
        /// Redis hostname or IP
        /// </summary>
        public string Host { get; set; }
        /// <summary>
        /// Connection port
        /// </summary>
        public int Port { get; set; } 
        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Index of database
        /// </summary>
        public int DbIndex { get; set; }
        /// <summary>
        /// Text encoding
        /// </summary>
        public string Encoding { get; set; }
    }
}
