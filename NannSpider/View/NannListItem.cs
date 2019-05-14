using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NannSpider.Model;

namespace NannSpider
{
	public partial class NannListItem : UserControl
	{
		public NannListItem(DecodeResult decodeResult)
		{
			InitializeComponent();

			this.mainText.Text = "【"+decodeResult.searchengine+"】" + decodeResult.keyword+"\r\n【" + decodeResult.no + "】" 
				+ decodeResult.title 
				+ "\r\n" + decodeResult.ipaddress;
		}

		private void mainText_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
	}
}
