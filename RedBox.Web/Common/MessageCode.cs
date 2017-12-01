using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace RedBox.Web.Common
{
    /// <summary>
    /// 短信服务类
    /// </summary>
    public static class MessageCode
    {
        /// <summary>
        /// SMS上的用户
        /// </summary>
        private const string SMS_UID = "";

        /// <summary>
        /// 接口安全秘钥
        /// </summary>
        private const string SERECT_KEY = "";

        public static dynamic SendMessageCode(string phoneNumber,string messageCode)
        {
            try
            {
                string API = "http://utf8.api.smschinese.cn/?Uid="+SMS_UID + "&Key="+ SERECT_KEY +"&smsMob="+phoneNumber +"&smsText"+messageCode + ":8888";
                var request = WebRequest.Create(API);
                var stream = request.GetResponse().GetResponseStream();

                string result = new StreamReader(stream ,Encoding.GetEncoding("utf-8")).ReadToEnd();

                return result;
            }

            catch(Exception ex)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <param name="codeNumber">短信验证码位数</param>
        /// <returns></returns>
        public static dynamic GenerateMessageCode(int codeNumber)
        {
            string message = string.Empty;
            for(int i=0;i<codeNumber;i++)
            {
                Random r = new Random(10);
                int one = r.Next();
                message = message + one.ToString ();
            }

            return message;
        }
        
    }
}