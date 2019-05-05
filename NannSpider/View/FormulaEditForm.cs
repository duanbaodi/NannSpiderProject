using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NannSpider.View
{
	public partial class FormulaEditForm : Form
	{
		private SpiderFormulaControl formulaControl;

		public FormulaEditForm(SpiderFormula formula)
		{
			InitializeComponent();
			formulaControl = new SpiderFormulaControl(formula);
			Controls.Add(formulaControl);
			formulaControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		}

		private void buttonConfirm_Click(object sender, EventArgs e)
		{
			if (formulaControl != null)
			{
				var f = formulaControl.UpdateFormula();
				if(f != null)
					MainForm.Instance?.AddNewFormula(f);
				MainForm.Instance?.UpdateListview();
				MainForm.Instance?.SaveData();
				this.Close();
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
