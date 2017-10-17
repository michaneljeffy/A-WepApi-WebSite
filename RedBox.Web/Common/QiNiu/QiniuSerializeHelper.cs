using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Qiniu.Util;

namespace RedBox.Web.QiNiu
{
    /// <summary>
    /// 
    /// </summary>
    public class AnotherJsonSerializer: JsonSerializer
    {
        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string Serialize<T> (T obj) where T:new()
        {
            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.NullValueHandling = NullValueHandling.Ignore;
            return JsonConvert.SerializeObject(obj,settings);
        }
    }

    /// <summary>
    ///反序列化
    /// </summary>
    public class AnotherDeserializer
    {
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Deserialize<T>(string str,out T obj) where T:new()
        {
            obj = default(T);
            bool ok = true;
            try
            {
                obj = JsonConvert.DeserializeObject<T>(str);
            }

            catch(System.Exception ex)
            {
                ok = false;
            }
            return ok;
        }
    }

}