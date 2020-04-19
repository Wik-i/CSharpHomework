using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCrawl;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace class9
{
    public partial class Form1 : Form
    {
        SimpleCrawler myCrawler;

        public Form1()
        {
            InitializeComponent();
            myCrawler = new SimpleCrawler();
            myCrawler.CrawlMessage += AddCrawlMessage;
        }

        public  void AddCrawlMessage(object sender, CrawlArgs e)
        {
            AddToList(e.CrawlMessage);
        }
        public void AddToList(string text)
        {
            this.Invoke(new EventHandler(delegate
            {
                listBox1.Items.Add(text);
            }));
                

            
        }

        private void start_Click(object sender, EventArgs e)
        {
            myCrawler.StartCrawl(urlBox.Text);
            string urlRegex = "^(https|http)://";
            if (!Regex.IsMatch(urlBox.Text, urlRegex)){
                listBox2.Items.Add("非法地址：" + urlBox.Text + "!");
            }
        }
    }


    public class CrawlArgs : EventArgs
    {
        public string CrawlMessage;
        public CrawlArgs(string e)
        {
            CrawlMessage = e;
        }
    }

    public delegate void CrawlHandler(object sender, CrawlArgs e);


}
