using NannSpider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NannSpider
{
	interface INannSpider
	{
		List<DecodeResult> Ranklist();

		Task Run(SpiderFormula formula, FlowLayoutPanel floatPanel);
	}
}
