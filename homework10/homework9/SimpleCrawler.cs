using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Crawler
{
    class SimpleCrawler
    {
        public event Action<SimpleCrawler> CrawlerStopped;
        public event Action<SimpleCrawler, string, string> PageDownloaded;
        private ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string, bool>();
        private ConcurrentQueue<string> pending = new ConcurrentQueue<string>();
        private readonly string urlDetectRegex = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";
        public static readonly string urlParseRegex = @"^(?<site>https?://(?<host>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";
        public string HostFilter { get; set; }
        public string FileFilter { get; set; }
        public int MaxPage { get; set; }
        public string StartURL { get; set; }
        public Encoding HtmlEncoding { get; set; }
        public int tasksCount = 0;
        //public ConcurrentDictionary<string, bool> DownloadedPages { get => urls; }
        public SimpleCrawler()
        {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
            ThreadPool.SetMaxThreads(4, 4);
            PageDownloaded += (SimpleCrawler, url, status) => { tasksCount++; };
        }
        public void Start()
        {
            urls.Clear();
            pending = new ConcurrentQueue<string>();
            pending.Enqueue(StartURL);
            List<Task> tasks = new List<Task>();
            while (tasks.Count < MaxPage)
            {
                string url = "";
                if (!pending.TryDequeue(out url))
                {
                    if (tasksCount < tasks.Count)
                    {
                        continue;
                    }
                    else break;
                }
                try
                {
                    string html = "";
                    int count = tasks.Count;
                    Task task = Task.Run(() =>
                    {
                        html = DownLoad(url, count);
                        urls[url] = true;
                        Parse(html, url);
                        PageDownloaded(this, url, "success");
                    }
                    );
                    tasks.Add(task);
                }
                catch (Exception ex)
                {
                    PageDownloaded(this, url, "  Error:" + ex.Message);
                }
            }
            Task.WaitAll(tasks.ToArray());
            CrawlerStopped(this);
        }
        private string DownLoad(string url,int count)
        {
            Task<string>task=Task.Run(()=>
            { WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = urls.Count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html; }
            );
            return task.Result;
        }
        private void Parse(string html, string pageUrl)
        {

            var matches = new Regex(urlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "") continue;
                linkUrl = FixUrl(linkUrl, pageUrl);
                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (file == "") file = "index.html";

                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !urls.ContainsKey(linkUrl))
                {
                    pending.Enqueue(linkUrl);
                }
            }
        }
        static private string FixUrl(string url, string baseUrl)
        {
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("//"))
            {
                return "http:" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(baseUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = baseUrl.LastIndexOf('/');
                return FixUrl(url, baseUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), baseUrl);
            }

            int end = baseUrl.LastIndexOf("/");
            return baseUrl.Substring(0, end) + "/" + url;
        }
    }
}