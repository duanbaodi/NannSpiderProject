using NannSpider.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NannSpider
{
	public class SogouSpider : INannSpider
	{
		public static string SearchEngineName = "搜狗搜索";
		private WebQuery query = new WebQuery();
		public List<DecodeResult> ranklist = new List<DecodeResult>();
		public List<DecodeResult> Ranklist() => ranklist;
		private bool hasUri = false;
		public async Task Run(SpiderFormula formula, FlowLayoutPanel panel)
		{
			if(formula == null)
				return;
			int pagecount = 1;
			if(formula.continuepage)
			{
				pagecount = formula.continuepagecount;
			}
			Regex titleRegex = new Regex(formula.interestcontentregex, RegexOptions.Compiled, Regex.InfiniteMatchTimeout);
			for(int i = 0; i < pagecount; i++)
			{
				if(!hasUri)
				{  
					query.SetUri("https://www.sogou.com");
					hasUri = true;
				}
				string result = await query.HttpClientDoGet("/web?query=" + formula.keyword + "&page=" + (i+1));
				List<DecodeResult> list = DecodeResult(result, formula);
				if(list == null || list.Count == 0)
					continue;
				foreach(var item in list)
				{
					item.keyword = formula.keyword;
					if(titleRegex.IsMatch(item.title))
					{
						ranklist.Add(item);
					}
				}
			}

			foreach(var i in ranklist)
			{
				panel.Controls.Add(new NannListItem(i as DecodeResult));
			}
		}


		private Regex regex = new Regex("id=\"(rb_|vr_)(\\d+)\".+?href=\"(.+?)\".+?>(.+?)</", RegexOptions.Compiled, Regex.InfiniteMatchTimeout);
		private List<DecodeResult> DecodeResult(string result, SpiderFormula formula)
		{
			List<DecodeResult> list = new List<DecodeResult>();
			string text = result.Substring(result.IndexOf("<div class=\"results\">"))
				.Replace("\r", " ").Replace("\\n", " ").Replace("\n", " ")
				.Replace("<em>", "").Replace("</em>", "")
				.Replace("<!--awbg5-->", "").Replace("<!--red_beg-->", "")
				.Replace("<!--red_end-->", "");
			var matches = regex.Matches(text);
			if(matches == null)
				return null;
			foreach(Match match in matches)
			{
				var d = new DecodeResult();
				d.searchengine = SearchEngineName;
				d.ipaddress = match.Groups[3].Value.ToString();
				d.no = match.Groups[2].Value.ToString();
				d.title = match.Groups[4].Value.ToString();
				list.Add(d);
			}
			return list;
		}
	}
}
