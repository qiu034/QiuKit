using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace QiuKit.ProgramHelper
{
    public class HttpHelper
    {
        private static HttpHelper _Instance = null;
        public static HttpHelper Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new HttpHelper();
                return _Instance;
            }
        }

        #region GetResponse

        public string GetResponse(string url)
        {
            return GetResponse(url,"GET");
        }

        /// <summary>
        /// 发起Http请求
        /// </summary>
        /// <param name="url">WebApi</param>
        /// <param name="method">请求方式</param>
        /// <returns></returns>
        public string GetResponse(string url,string method)
        {
            HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create(new Uri(url));
            request.Method = method;
            request.KeepAlive = false;
            request.ContentType = "application/json; charset=UTF-8";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                string result = reader.ReadToEnd();
                responseStream.Close();
                reader.Close();
                if (response != null) response.Close();
                if (request != null) request.Abort();
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion 
    }
}
