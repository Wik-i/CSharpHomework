using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using class9;

namespace SimpleCrawl {
  class SimpleCrawler {
        public event CrawlHandler CrawlMessage;
        // private Hashtable urls = new Hashtable();

        private Dictionary<string, bool> urls = new Dictionary<string, bool>();

    private int count = 0;


    /*static void Main(string[] args) {
      SimpleCrawler myCrawler = new SimpleCrawler();
      string startUrl = "http://www.cnblogs.com/dstang2000/";

      //if (args.Length >= 1) startUrl = args[0];

      myCrawler.urls.Add(startUrl, false);//加入初始页面
      new Thread(myCrawler.Crawl).Start();
    }*/

            public void StartCrawl(string http)
        {
            //string startUrl = "http://www.cnblogs.com/dstang2000/";

            //if (args.Length >= 1) startUrl = args[0];
            if (!urls.ContainsKey(http)) {
                urls.Add(http, false);//加入初始页面
            }

                new Thread(Crawl).Start();

        }

        private void Crawl() {

            //Console.WriteLine("开始爬行了.... ");

            CrawlMessage(this, new CrawlArgs("开始爬行了……"));
      while (true) {
        string current = null;
       //         Console.WriteLine(urls.Keys);

        foreach (string url in urls.Keys) {
          if ((bool)urls[url]) continue;
          current = url;
        }

        if (current == null || count > 10) break;

                //Console.WriteLine("爬行" + current + "页面!");
                CrawlMessage(this, new CrawlArgs("爬行" + current + "页面！"));
                
        string html = DownLoad(current); // 下载

        urls[current] = true;
        count++;
        string htmlMatch = ".html$";

        if ((Regex.IsMatch(current, htmlMatch) ) || count == 1){
            Parse(html);//解析,并加入新的链接
        }
        
       // Console.WriteLine("爬行结束");
                CrawlMessage(this, new CrawlArgs("爬行结束"));

      }
    }

    public string DownLoad(string url) {
      try {
        WebClient webClient = new WebClient();
        webClient.Encoding = Encoding.UTF8;
        string html = webClient.DownloadString(url);
        string fileName = count.ToString();
        File.WriteAllText(fileName, html, Encoding.UTF8);
        return html;
      }
      catch (Exception ex) {
        Console.WriteLine(ex.Message);
        return "";
      }
    }

    private void Parse(string html) {
      string strRef = @"(href|HREF)[ ]*=[ ]*[""']http[^""'#>]+[""']";
      MatchCollection matches = new Regex(strRef).Matches(html);
      foreach (Match match in matches) {
        strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                  .Trim('"', '\"', '#', '>');

                if (strRef.Length == 0) continue;
                if (urls.ContainsKey(strRef)) continue;
        //if (urls[strRef] == true) continue;
                urls.Add(strRef, false);
            }

       string nothttp = @"(href|HREF)[ ]*=[ ]*[""'][^https][^""'#>]+[""']";
            MatchCollection matcher2 = new Regex(nothttp).Matches(html);
            foreach(Match match in matcher2)
            {
                nothttp = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (nothttp.Length == 0) continue;
                nothttp = "https://www.cnblogs.com" + nothttp;
                if (urls.ContainsKey(nothttp)) continue;
                urls.Add(nothttp, false);
            }


        }
    }
}
