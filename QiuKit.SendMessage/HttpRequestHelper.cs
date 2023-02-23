using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace QiuKit.SendMessage
{
    public class HttpRequestHelper
    {
        private const string account = "C30776811";
        private const string password = "5537dda106064a1a40848d8d9b5f82dc";
        private string url = string.Empty;
        private static HttpRequestHelper _instance = null;

        public static HttpRequestHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HttpRequestHelper();
                return _instance;
            }
        }

        /// <summary>
        /// 生成请求接口
        /// </summary>
        /// <param name="url"></param>
        /// <param name="tel"></param>
        /// <param name="txt"></param>
        public void GetApiUrl(string tel, string txt)
        {
            string url = "https://106.ihuyi.com/webservice/sms.php?method=Submit";
            url = $"{url}&account={account}&password={password}&mobile={tel}&content={txt}";
            this.url = url;
        }

        /// <summary>
        /// 请求接口
        /// </summary>
        /// <param name="url"></param>
        public string RequestApi()
        {
            string url = this.url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            Stream stream = request.GetResponse().GetResponseStream();
            StreamReader read = new StreamReader(stream, Encoding.Default);
            string strRet = read.ReadToEnd();
            return strRet;
        }
    }
}
