﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
using System.Configuration;

namespace RedBox.Common.Cache
{
    public class RedisCacheManager : ICacheManager
    {
        private readonly string redisConnectionString;

        public volatile ConnectionMultiplexer redisConnection;

        public readonly object redisConnectionLock = new object();

        public RedisCacheManager()
        {
            string redisConfiguration = ConfigurationManager.ConnectionStrings["redisCache"].ToString();

            if (string.IsNullOrWhiteSpace(redisConfiguration))
            {
                throw new ArgumentException("redis config is empty", nameof(redisConfiguration));
            }
            this.redisConnectionString = redisConfiguration;
            this.redisConnection = GetRedisConnection();
        }

        private ConnectionMultiplexer GetRedisConnection()
        {
            if (this.redisConnection != null  )
            {
                return this.redisConnection;
            }

            lock (redisConnectionLock )
            {
                if(this.redisConnection != null)
                {
                    this.redisConnection.Dispose();
                }
                this.redisConnection = ConnectionMultiplexer.Connect(redisConnectionString);
            }

            return this.redisConnection;
        }

        public void Clear()
        {
            foreach (var endPoint in this.GetRedisConnection ().GetEndPoints())
            {
                var server = this.GetRedisConnection().GetServer(endPoint);

                foreach (var key in server.Keys())
                {
                    redisConnection.GetDatabase().KeyDelete(key);
                }
            }
        }

        public bool Contains(string key)
        {
           return  redisConnection.GetDatabase().KeyExists(key);
            
        }

        public T Get<T>(string key)
        {
            var value = redisConnection.GetDatabase().StringGet(key);

            if (value.HasValue)
            {
                return SerializeHelper.Deserialize<T>(value);
            }
            else
            {
                return default(T);
            }
        }

        public void Remove(string key)
        {
            redisConnection.GetDatabase().KeyDelete(key);
        }

        public void Set(string key, object value, TimeSpan cacheTime)
        {
            if (value!= null)
            {
                redisConnection.GetDatabase().StringSet(key, SerializeHelper.Serialize(value), cacheTime);
            }
           
        }
    }
}
