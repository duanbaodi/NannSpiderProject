using NannSpider.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NannSpider
{
	public class ThreeSixZeroSpider : INannSpider
	{
		public static string SearchEngineName = "360搜索";
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
					query.SetUri("http://www.so.com");
					hasUri = true;
				}
				string result = await query.HttpClientDoGet("/s?q=" + formula.keyword + "&pn=" + (1+i));
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


		private Regex regex = new Regex("\"res-title.+?href=\"(.+?)\".+?\"pos\":(\\d+).+?>(.+?)</a></h3>", RegexOptions.Compiled, Regex.InfiniteMatchTimeout);
		private List<DecodeResult> DecodeResult(string result, SpiderFormula formula)
		{
			List<DecodeResult> list = new List<DecodeResult>();
			string text = result.Substring(result.IndexOf("<ul class=\"result\">"))
				.Replace("\r", " ").Replace("\\n", " ").Replace("\n", " ")
				.Replace("<em>","").Replace("</em>","");
			var matches = regex.Matches(text);
			if(matches == null)
				return null;
			foreach(Match match in matches)
			{
				var d = new DecodeResult();
				d.searchengine = SearchEngineName;
				d.ipaddress = match.Groups[1].Value.ToString();
				d.no = match.Groups[2].Value.ToString();
				d.title = match.Groups[3].Value.ToString();
				list.Add(d);
			}
			return list;
		}
	}
}
