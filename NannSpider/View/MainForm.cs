using GlassPlusExcelAddIn.UtilModule;
using NannSpider.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Xivid.UtilModule;

namespace NannSpider
{
	public partial class MainForm : Form
	{
		public static MainForm Instance = null;
		private List<SpiderFormula> spiderFormulas = new List<SpiderFormula>();
		private const string Path = "NannSpider_FormulaSave.txt";
		public MainForm()
		{
			InitializeComponent();

			Instance = this;
			string content = Anny.LoadFile(Path);
			spiderFormulas = Anny.FromXml<List<SpiderFormula>>(content);
			if(spiderFormulas == null )
			{
				spiderFormulas = new List<SpiderFormula>();
				spiderFormulas.Add(new SpiderFormula()
				{
					ipaddress = "https://www.baidu.com",
					keyword = "石家庄钢化玻璃",
					searchengine = "百度",
					continuepage = true,
					continuepagecount = 10,
					continuepageregex = "",

					interestcontentregex = "(光辉玻璃|光晖玻璃|光辉钢化|光晖钢化|迪辉玻璃|迪辉钢化)",
				});
				spiderFormulas.Add(new SpiderFormula()
				{
					ipaddress = "https://www.baidu.com",
					keyword = "石家庄中空玻璃",
					searchengine = "百度",
					continuepage = true,
					continuepagecount = 10,
					continuepageregex = "",

					interestcontentregex = "(光辉玻璃|光晖玻璃|光辉钢化|光晖钢化|迪辉玻璃|迪辉钢化)",
				});
				spiderFormulas.Add(new SpiderFormula()
				{
					ipaddress = "https://www.baidu.com",
					keyword = "石家庄夹胶玻璃",
					searchengine = "百度",
					continuepage = true,
					continuepagecount = 10,
					continuepageregex = "",

					interestcontentregex = "(光辉玻璃|光晖玻璃|光辉钢化|光晖钢化|迪辉玻璃|迪辉钢化)",
				});
				spiderFormulas.Add(new SpiderFormula()
				{
					ipaddress = "https://www.baidu.com",
					keyword = "正定钢化玻璃",
					searchengine = "百度",
					continuepage = true,
					continuepagecount = 10,
					continuepageregex = "",

					interestcontentregex = "(光辉玻璃|光晖玻璃|光辉钢化|光晖钢化|迪辉玻璃|迪辉钢化)",
				});
				spiderFormulas.Add(new SpiderFormula()
				{
					ipaddress = "https://www.baidu.com",
					keyword = "正定中空玻璃",
					searchengine = "百度",
					continuepage = true,
					continuepagecount = 10,
					continuepageregex = "",

					interestcontentregex = "(光辉玻璃|光晖玻璃|光辉钢化|光晖钢化|迪辉玻璃|迪辉钢化)",
				});
				spiderFormulas.Add(new SpiderFormula()
				{
					ipaddress = "https://www.baidu.com",
					keyword = "正定夹胶玻璃",
					searchengine = "百度",
					continuepage = true,
					continuepagecount = 10,
					continuepageregex = "",

					interestcontentregex = "(光辉玻璃|光晖玻璃|光辉钢化|光晖钢化|迪辉玻璃|迪辉钢化)",
				});
				new About().Show();
			}
			UpdateListview();
		}

		internal void AddNewFormula(SpiderFormula f) => spiderFormulas.Add(f);


		public void UpdateListview()
		{
			listViewFormula.Items.Clear();
			foreach(var i in spiderFormulas)
			{
				listViewFormula.Items.Add(new ListViewItem(new string[] {
					i.id,
					i.searchengine,
					i.keyword,
					i.interestcontentregex,
					i.continuepage.ToString(),
					i.continuepagecount.ToString(),
					i.name
				}));
			}
		}

		private void buttonAddFormula_Click(object sender, EventArgs e)
		{
			new FormulaEditForm(null).Show();
		}

		private void buttonEditFormula_Click(object sender, EventArgs e)
		{
			try
			{
				var i = listViewFormula.SelectedItems[0] as ListViewItem;
				foreach(var j in spiderFormulas)
				{
					if(j.searchengine == i.SubItems[1].Text
						&& j.keyword == i.SubItems[2].Text
						&& j.interestcontentregex == i.SubItems[3].Text
						&& j.continuepage.ToString().ToLower() == i.SubItems[4].Text.ToLower()
						&& j.continuepagecount.ToString() == i.SubItems[5].Text
						&& (j.name == i.SubItems[6].Text ||
						j.name == null && i.SubItems[6].Text == "")
						)
					{
						new FormulaEditForm(j).Show();
					}
				}
			}
			catch(Exception)
			{

			}
		}

		private void buttonDeleteFormula_Click(object sender, EventArgs e)
		{
			try
			{
				var i = listViewFormula.SelectedItems[0] as ListViewItem;
				foreach(var j in spiderFormulas)
				{
					if(j.searchengine == i.SubItems[1].Text
						&& j.keyword == i.SubItems[2].Text
						&& j.interestcontentregex == i.SubItems[3].Text
						&& j.continuepage.ToString().ToLower() == i.SubItems[4].Text.ToLower()
						&& j.continuepagecount.ToString() == i.SubItems[5].Text
						&& (j.name == i.SubItems[6].Text ||
						j.name == null && i.SubItems[6].Text == "")
						)
					{
						spiderFormulas.Remove(j);
						this.UpdateListview();
						this.SaveData();
					}
				}
			}
			catch(Exception)
			{

			}
		}

		private void buttonRunOne_Click(object sender, EventArgs e)
		{
			try
			{
				var i = listViewFormula.SelectedItems[0] as ListViewItem;
				foreach(var j in spiderFormulas)
				{
					if(j.searchengine == i.SubItems[1].Text
						&& j.keyword == i.SubItems[2].Text
						&& j.interestcontentregex == i.SubItems[3].Text
						&& j.continuepage.ToString().ToLower() == i.SubItems[4].Text.ToLower()
						&& j.continuepagecount.ToString() == i.SubItems[5].Text
						&& (j.name == i.SubItems[6].Text ||
						j.name == null && i.SubItems[6].Text == "")
						)
					{
						var form = new ResultForm(new List<SpiderFormula>() {j});
						form.Text = "「" + j.searchengine + "」 " + j.keyword;
						form.Show();
					}
				}
			}
			catch(Exception)
			{

			}
		}

		private void buttonRunAll_Click(object sender, EventArgs e)
		{
			var form = new ResultForm(spiderFormulas);
			form.Show();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			SaveData();
		}

		public void SaveData()
		{
			Anny.SaveToFile(Anny.ToXml(spiderFormulas), Path);
		}
		#region 点击表头排序
		private int sortColumn = -1;
		private void priceListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if(e.Column != sortColumn)
			{
				// Set the sort column to the new column.
				sortColumn = e.Column;
				// Set the sort order to ascending by default.
				listViewFormula.Sorting = SortOrder.Ascending;
			}
			else
			{
				// Determine what the last sort order was and change it.
				if(listViewFormula.Sorting == SortOrder.Ascending)
				{
					listViewFormula.Sorting = SortOrder.Descending;
				}
				else
				{
					listViewFormula.Sorting = SortOrder.Ascending;
				}
			}
			// Call the sort method to manually sort.
			listViewFormula.Sort();
			// Set the ListViewItemSorter property to a new ListViewItemComparer
			// object.
			listViewFormula.ListViewItemSorter = new ListViewItemComparer(e.Column, listViewFormula.Sorting);

		}
		#endregion

		private void listViewFormula_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListViewHitTestInfo info = (sender as ListView).HitTest(e.X, e.Y);
			if(info.Item != null)
			{
				var i = info.Item as ListViewItem;
				foreach(var j in spiderFormulas)
				{
					if(j.searchengine == i.SubItems[1].Text
						&& j.keyword == i.SubItems[2].Text
						&& j.interestcontentregex == i.SubItems[3].Text
						&& j.continuepage.ToString().ToLower() == i.SubItems[4].Text.ToLower()
						&& j.continuepagecount.ToString() == i.SubItems[5].Text
						&& (j.name == i.SubItems[6].Text ||
						j.name == null && i.SubItems[6].Text == "")
						)
					{
						new FormulaEditForm(j).Show();
					}
				}
			}
		}

		private void buttonSetting_Click(object sender, EventArgs e)
		{
			new About().Show();
		}
	}
}
