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
		Task Run(SpiderFormula formula, FlowLayoutPanel floatPanel);
	}
}
