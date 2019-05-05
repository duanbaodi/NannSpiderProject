using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannSpider
{
	public class SpiderFormula
	{
		public string id { get; set; }
		public string searchengine { get; set; }

		public string name { get; set; }
		public string domain { get; set; }
		public string ipaddress { get; set; }

		public bool continuepage { get; set; }
		public string continuepageregex { get; set; }
		public int continuepagecount { get; set; }

		public string keyword { get; set; }
		public string interestcontentregex { get; set; }

	}
}
