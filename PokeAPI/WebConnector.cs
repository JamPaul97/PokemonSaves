using System;
using System.Collections.Specialized;
using System.Net;
using System.IO;
using System.Net.Cache;
namespace PokeAPI
{
    public static class WebConnector
    {
        public static string Request(string url,NameValueCollection data = null)
        {
            string dataString = string.Empty;
            if (data != null)
            {
                dataString = (data == null ? null : String.Join("&", Array.ConvertAll(data.AllKeys, key =>

                   string.Format("{0}={1}", WebUtility.UrlEncode(key), WebUtility.UrlEncode(data[key]))
           )));
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "?" + dataString);
            request.Method = "GET";
            request.Accept = "application/json, text/javascript;q=0.9, */*;q=0.5";
            request.ContentType = "application/json; charset=UTF-8";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36";
            request.Timeout = 10000;
            request.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Revalidate);
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            var re = request.GetResponse() as HttpWebResponse;
            using (var reader = new StreamReader(re.GetResponseStream()))
            {
               return reader.ReadToEnd();
            }
        }

    }
}
