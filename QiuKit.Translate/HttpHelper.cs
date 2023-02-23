using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuKit.Translate
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


    }
}
