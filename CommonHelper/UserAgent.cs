﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonHelper
{
    public static class UserAgent
    {
        static UserAgent()
        {
            _DicUserAgent.Add("safari 5.1 – MAC", "User-Agent:Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_8; en-us) AppleWebKit/534.50 (KHTML, like Gecko) Version/5.1 Safari/534.50");
            _DicUserAgent.Add("safari 5.1 – Windows", "User-Agent:Mozilla/5.0 (Windows; U; Windows NT 6.1; en-us) AppleWebKit/534.50 (KHTML, like Gecko) Version/5.1 Safari/534.50");
            _DicUserAgent.Add("IE 9.0", "User-Agent:Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0;");
            _DicUserAgent.Add("IE 8.0", "User-Agent:Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; Trident/4.0)");
            _DicUserAgent.Add("IE 7.0", "User-Agent:Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0)");
            _DicUserAgent.Add("IE 6.0", "User-Agent: Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)");
            _DicUserAgent.Add("Firefox 4.0.1 – MAC", "User-Agent: Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.0.1) Gecko/20100101 Firefox/4.0.1");
            _DicUserAgent.Add("Firefox 4.0.1 – Windows", "User-Agent:Mozilla/5.0 (Windows NT 6.1; rv:2.0.1) Gecko/20100101 Firefox/4.0.1");
            _DicUserAgent.Add("Opera 11.11 – MAC", "User-Agent:Opera/9.80 (Macintosh; Intel Mac OS X 10.6.8; U; en) Presto/2.8.131 Version/11.11");
            _DicUserAgent.Add("Opera 11.11 – Windows", "User-Agent:Opera/9.80 (Windows NT 6.1; U; en) Presto/2.8.131 Version/11.11");
            _DicUserAgent.Add("Chrome 17.0 – MAC", "User-Agent: Mozilla/5.0 (Macintosh; Intel Mac OS X 10_7_0) AppleWebKit/535.11 (KHTML, like Gecko) Chrome/17.0.963.56 Safari/535.11");
            _DicUserAgent.Add("傲游（Maxthon）", "User-Agent: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Maxthon 2.0)");
            _DicUserAgent.Add("腾讯TT", "User-Agent: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; TencentTraveler 4.0)");
            _DicUserAgent.Add("世界之窗（The World） 2.x", "User-Agent: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)");
            _DicUserAgent.Add("世界之窗（The World） 3.x", "User-Agent: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; The World)");
            _DicUserAgent.Add("搜狗浏览器 1.x", "User-Agent: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Trident/4.0; SE 2.X MetaSr 1.0; SE 2.X MetaSr 1.0; .NET CLR 2.0.50727; SE 2.X MetaSr 1.0)");
            _DicUserAgent.Add("360浏览器", "User-Agent: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; 360SE)");
            _DicUserAgent.Add("Avant", "User-Agent: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Avant Browser)");
            _DicUserAgent.Add("Green Browser", "User-Agent: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)");
            _DicUserAgent.Add("safari iOS 4.33 – iPhone", "User-Agent:Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_3_3 like Mac OS X; en-us) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8J2 Safari/6533.18.5");
            _DicUserAgent.Add("safari iOS 4.33 – iPod Touch", "User-Agent:Mozilla/5.0 (iPod; U; CPU iPhone OS 4_3_3 like Mac OS X; en-us) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8J2 Safari/6533.18.5");
            _DicUserAgent.Add("safari iOS 4.33 – iPad", "User-Agent:Mozilla/5.0 (iPad; U; CPU OS 4_3_3 like Mac OS X; en-us) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8J2 Safari/6533.18.5");
            _DicUserAgent.Add("Android N1", "User-Agent: Mozilla/5.0 (Linux; U; Android 2.3.7; en-us; Nexus One Build/FRF91) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            _DicUserAgent.Add("Android QQ浏览器 For android", "User-Agent: MQQBrowser/26 Mozilla/5.0 (Linux; U; Android 2.3.7; zh-cn; MB200 Build/GRJ22; CyanogenMod-7) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");
            _DicUserAgent.Add("Android Opera Mobile", "User-Agent: Opera/9.80 (Android 2.3.4; Linux; Opera Mobi/build-1107180945; U; en-GB) Presto/2.8.149 Version/11.10");
            _DicUserAgent.Add("Android Pad Moto Xoom", "User-Agent: Mozilla/5.0 (Linux; U; Android 3.0; en-us; Xoom Build/HRI39) AppleWebKit/534.13 (KHTML, like Gecko) Version/4.0 Safari/534.13");
            _DicUserAgent.Add("BlackBerry", "User-Agent: Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en) AppleWebKit/534.1&#43; (KHTML, like Gecko) Version/6.0.0.337 Mobile Safari/534.1&#43;");
            _DicUserAgent.Add("WebOS HP Touchpad", "User-Agent: Mozilla/5.0 (hp-tablet; Linux; hpwOS/3.0.0; U; en-US) AppleWebKit/534.6 (KHTML, like Gecko) wOSBrowser/233.70 Safari/534.6 TouchPad/1.0");
            _DicUserAgent.Add("Nokia N97", "User-Agent: Mozilla/5.0 (SymbianOS/9.4; Series60/5.0 NokiaN97-1/20.0.019; Profile/MIDP-2.1 Configuration/CLDC-1.1) AppleWebKit/525 (KHTML, like Gecko) BrowserNG/7.1.18124");
            _DicUserAgent.Add("Windows Phone Mango", "User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows Phone OS 7.5; Trident/5.0; IEMobile/9.0; HTC; Titan)");
            _DicUserAgent.Add("UC无", "User-Agent: UCWEB7.0.2.37/28/999");
            _DicUserAgent.Add("UC标准", "User-Agent: NOKIA5700/ UCWEB7.0.2.37/28/999");
            _DicUserAgent.Add("UCOpenwave", "User-Agent: Openwave/ UCWEB7.0.2.37/28/999");
            _DicUserAgent.Add("UC Opera", "User-Agent: Mozilla/4.0 (compatible; MSIE 6.0; ) Opera/UCWEB7.0.2.37/28/999");
            _DicUserAgent.Add("BaiduspiderPC", "Mozilla/5.0 (compatible; Baiduspider/2.0; +http://www.baidu.com/search/spider.html)");

        }
        public static Dictionary<string, string> _DicUserAgent = new Dictionary<string, string>();
        public static string GetRandomUserAgent
        {
            get
            {
                Random r = new Random(DateTime.Now.Millisecond);
                return _DicUserAgent.ElementAt(r.Next(_DicUserAgent.Count - 1)).Value;
            }
        }
    }
}