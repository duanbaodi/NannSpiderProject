﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Xivid.UtilModule;

namespace NannSpider.View
{
	public partial class ResultForm : Form
	{
		private List<SpiderFormula> spiderFormulas;
		private List<INannSpider> spiders = new List<INannSpider>();

		public ResultForm(List<SpiderFormula> spiderFormulas)
		{
			InitializeComponent();

			this.spiderFormulas = spiderFormulas;

			buttonRefresh_Click(null, null);
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			if(spiderFormulas != null)
			{
				searchResultPanel.Controls.Clear();
				foreach(var i in spiderFormulas)
				{
					if(i.searchengine == "百度" 
						|| i.searchengine=="百度搜索")
					{
						var baidu = new BaiduSpider();
						baidu.Run(i, searchResultPanel);
						spiders.Add(baidu);
					}
					else if(i.searchengine == "360搜索")
					{
						var so = new ThreeSixZeroSpider();
						so.Run(i, searchResultPanel);
						spiders.Add(so);
					}
					else if(i.searchengine == "搜狗搜索")
					{
						var so = new SogouSpider();
						so.Run(i, searchResultPanel);
						spiders.Add(so);
					}
				}
			}
		}

		private void buttonExportResult_Click(object sender, EventArgs e)
		{
			try
			{
				string path = Anny.ShowSaveFileDialog();
				StringBuilder sb = new StringBuilder("");
				sb.Append("搜索引擎").Append("\t")
							.Append("关键字").Append("\t")
							.Append("排位").Append("\t")
							.Append("标题").Append("\t")
							.Append("网址").Append("\r\n");
				foreach(var i in spiders)
				{
					foreach(var j in i.Ranklist())
					{
						sb.Append(j.searchengine).Append("\t")
							.Append(j.keyword).Append("\t")
							.Append(j.no).Append("\t")
							.Append(j.title).Append("\t")
							.Append(j.ipaddress).Append("\r\n");
					}
				}
				Anny.SaveToFile(sb.ToString(), path);

				System.Diagnostics.Process.Start(path);
			}
			catch(Exception)
			{
			}

		}
	}
}
