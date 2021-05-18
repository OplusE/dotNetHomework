using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    /// <summary>
    /// 爬虫开头
    /// </summary>
    private Hashtable urls = new Hashtable();
    private int count = 0;
    /// <summary>
    /// 应用程序的主入口点。
    /// </summary>
    [STAThread]
    class Crawler
    {
        private void Crawl()
        {
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)//find a web that hasnt been downloaded
                {
                    if ((bool)urls[url]) continue;//not to download a web that has been download
                    current = url;
                    ;
                }
                if (current == null || count > 10) break;

                string html = DownLoad(current);//download

                urls[current] = true;
                count++;
                Parse(html);
            }
        }
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);

                string fileName = count.ToString();
                return html;
            }
            catch (Exception ex) { return ""; }

        }
        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', ',', '>');//('"','\",'#','','>')
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
