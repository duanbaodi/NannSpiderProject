namespace NannSpider.View
{
	partial class ResultForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
			this.searchResultPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonExportResult = new System.Windows.Forms.Button();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// searchResultPanel
			// 
			this.searchResultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchResultPanel.AutoScroll = true;
			this.searchResultPanel.Location = new System.Drawing.Point(0, 59);
			this.searchResultPanel.Name = "searchResultPanel";
			this.searchResultPanel.Size = new System.Drawing.Size(745, 389);
			this.searchResultPanel.TabIndex = 0;
			// 
			// buttonExportResult
			// 
			this.buttonExportResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(86)))), ((int)(((byte)(192)))));
			this.buttonExportResult.ForeColor = System.Drawing.Color.White;
			this.buttonExportResult.Location = new System.Drawing.Point(93, 12);
			this.buttonExportResult.Name = "buttonExportResult";
			this.buttonExportResult.Size = new System.Drawing.Size(75, 41);
			this.buttonExportResult.TabIndex = 1;
			this.buttonExportResult.Text = "导出结果";
			this.buttonExportResult.UseVisualStyleBackColor = false;
			this.buttonExportResult.Click += new System.EventHandler(this.buttonExportResult_Click);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(192)))));
			this.buttonRefresh.ForeColor = System.Drawing.Color.White;
			this.buttonRefresh.Location = new System.Drawing.Point(12, 12);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(75, 41);
			this.buttonRefresh.TabIndex = 0;
			this.buttonRefresh.Text = "刷新";
			this.buttonRefresh.UseVisualStyleBackColor = false;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// ResultForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 450);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.buttonExportResult);
			this.Controls.Add(this.searchResultPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ResultForm";
			this.Text = "搜索引擎的排序结果";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel searchResultPanel;
		private System.Windows.Forms.Button buttonExportResult;
		private System.Windows.Forms.Button buttonRefresh;
	}
}