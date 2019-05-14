using System;
using System.Windows.Forms;

namespace NannSpider
{
	public partial class SpiderFormulaControl : UserControl
	{
		SpiderFormula spiderFormula = null;
		public SpiderFormulaControl(SpiderFormula i)
		{
			InitializeComponent();
			if(i != null)
			{
				spiderFormula = i;
				comboBoxSearchEngine.Text = i.searchengine;
				textBoxKeyword.Text = i.keyword;
				textBoxKeywordregex.Text = i.interestcontentregex;
				textBoxName.Text = i.name;
				checkBoxContinuePage.Checked = i.continuepage;
				numericUpDownPageCount.Value = i.continuepagecount;
				textBoxPageRegex.Text = i.continuepageregex;
				numericUpDownPageCount.Enabled = checkBoxContinuePage.Checked;
				textBoxPageRegex.Enabled = checkBoxContinuePage.Checked;
			}
		}

		private void checkBoxContinuePage_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDownPageCount.Enabled = checkBoxContinuePage.Checked;
			textBoxPageRegex.Enabled = checkBoxContinuePage.Checked;
		}

		public SpiderFormula UpdateFormula()
		{
			if (spiderFormula == null)
			{
				spiderFormula = new SpiderFormula();
				spiderFormula.searchengine = comboBoxSearchEngine.Text;
				spiderFormula.keyword = textBoxKeyword.Text;
				spiderFormula.interestcontentregex = textBoxKeywordregex.Text;
				spiderFormula.name = textBoxName.Text;
				spiderFormula.continuepage = checkBoxContinuePage.Checked;
				spiderFormula.continuepagecount = Convert.ToInt32(numericUpDownPageCount.Value);
				spiderFormula.continuepageregex = textBoxPageRegex.Text;
				return spiderFormula;
			}
			else
			{
				spiderFormula.searchengine = comboBoxSearchEngine.Text;
				spiderFormula.keyword = textBoxKeyword.Text;
				spiderFormula.interestcontentregex = textBoxKeywordregex.Text;
				spiderFormula.name = textBoxName.Text;
				spiderFormula.continuepage = checkBoxContinuePage.Checked;
				spiderFormula.continuepagecount = Convert.ToInt32(numericUpDownPageCount.Value);
				spiderFormula.continuepageregex = textBoxPageRegex.Text;
				return null;
			}
		}
	}
}
