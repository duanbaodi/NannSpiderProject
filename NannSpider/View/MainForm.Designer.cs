namespace NannSpider
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.buttonAddFormula = new System.Windows.Forms.Button();
			this.buttonRunOne = new System.Windows.Forms.Button();
			this.buttonRunAll = new System.Windows.Forms.Button();
			this.buttonSetting = new System.Windows.Forms.Button();
			this.listViewFormula = new System.Windows.Forms.ListView();
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderSearchEngine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderKeyword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderKeywordRegex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderContinuePage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderContinuePageCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonDeleteFormula = new System.Windows.Forms.Button();
			this.buttonEditFormula = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonAddFormula
			// 
			this.buttonAddFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonAddFormula.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonAddFormula.Location = new System.Drawing.Point(12, 12);
			this.buttonAddFormula.Name = "buttonAddFormula";
			this.buttonAddFormula.Size = new System.Drawing.Size(75, 41);
			this.buttonAddFormula.TabIndex = 0;
			this.buttonAddFormula.Text = "添加规则";
			this.buttonAddFormula.UseVisualStyleBackColor = false;
			this.buttonAddFormula.Click += new System.EventHandler(this.buttonAddFormula_Click);
			// 
			// buttonRunOne
			// 
			this.buttonRunOne.BackColor = System.Drawing.Color.Chartreuse;
			this.buttonRunOne.ForeColor = System.Drawing.Color.Black;
			this.buttonRunOne.Location = new System.Drawing.Point(298, 12);
			this.buttonRunOne.Name = "buttonRunOne";
			this.buttonRunOne.Size = new System.Drawing.Size(75, 41);
			this.buttonRunOne.TabIndex = 3;
			this.buttonRunOne.Text = "运行";
			this.buttonRunOne.UseVisualStyleBackColor = false;
			this.buttonRunOne.Click += new System.EventHandler(this.buttonRunOne_Click);
			// 
			// buttonRunAll
			// 
			this.buttonRunAll.BackColor = System.Drawing.Color.Aqua;
			this.buttonRunAll.ForeColor = System.Drawing.Color.Black;
			this.buttonRunAll.Location = new System.Drawing.Point(379, 12);
			this.buttonRunAll.Name = "buttonRunAll";
			this.buttonRunAll.Size = new System.Drawing.Size(75, 41);
			this.buttonRunAll.TabIndex = 4;
			this.buttonRunAll.Text = "运行全部";
			this.buttonRunAll.UseVisualStyleBackColor = false;
			this.buttonRunAll.Click += new System.EventHandler(this.buttonRunAll_Click);
			// 
			// buttonSetting
			// 
			this.buttonSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSetting.BackColor = System.Drawing.Color.CadetBlue;
			this.buttonSetting.ForeColor = System.Drawing.Color.White;
			this.buttonSetting.Location = new System.Drawing.Point(772, 12);
			this.buttonSetting.Name = "buttonSetting";
			this.buttonSetting.Size = new System.Drawing.Size(49, 41);
			this.buttonSetting.TabIndex = 5;
			this.buttonSetting.Text = "关于";
			this.buttonSetting.UseVisualStyleBackColor = false;
			this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
			// 
			// listViewFormula
			// 
			this.listViewFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewFormula.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.columnHeaderSearchEngine,
            this.columnHeaderKeyword,
            this.columnHeaderKeywordRegex,
            this.columnHeaderContinuePage,
            this.columnHeaderContinuePageCount,
            this.columnHeaderName});
			this.listViewFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewFormula.FullRowSelect = true;
			this.listViewFormula.HideSelection = false;
			this.listViewFormula.Location = new System.Drawing.Point(1, 59);
			this.listViewFormula.Name = "listViewFormula";
			this.listViewFormula.ShowGroups = false;
			this.listViewFormula.Size = new System.Drawing.Size(832, 508);
			this.listViewFormula.TabIndex = 6;
			this.listViewFormula.UseCompatibleStateImageBehavior = false;
			this.listViewFormula.View = System.Windows.Forms.View.Details;
			this.listViewFormula.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.priceListView_ColumnClick);
			this.listViewFormula.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewFormula_MouseDoubleClick);
			// 
			// id
			// 
			this.id.Text = "编号";
			this.id.Width = 8;
			// 
			// columnHeaderSearchEngine
			// 
			this.columnHeaderSearchEngine.Text = "搜索引擎";
			this.columnHeaderSearchEngine.Width = 80;
			// 
			// columnHeaderKeyword
			// 
			this.columnHeaderKeyword.Text = "查询词";
			this.columnHeaderKeyword.Width = 142;
			// 
			// columnHeaderKeywordRegex
			// 
			this.columnHeaderKeywordRegex.Text = "关键字正则表达式";
			this.columnHeaderKeywordRegex.Width = 252;
			// 
			// columnHeaderContinuePage
			// 
			this.columnHeaderContinuePage.Text = "连续查询";
			this.columnHeaderContinuePage.Width = 84;
			// 
			// columnHeaderContinuePageCount
			// 
			this.columnHeaderContinuePageCount.Text = "连续查询页数";
			this.columnHeaderContinuePageCount.Width = 111;
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Text = "备注";
			this.columnHeaderName.Width = 92;
			// 
			// buttonDeleteFormula
			// 
			this.buttonDeleteFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.buttonDeleteFormula.Location = new System.Drawing.Point(174, 12);
			this.buttonDeleteFormula.Name = "buttonDeleteFormula";
			this.buttonDeleteFormula.Size = new System.Drawing.Size(75, 41);
			this.buttonDeleteFormula.TabIndex = 2;
			this.buttonDeleteFormula.Text = "删除规则";
			this.buttonDeleteFormula.UseVisualStyleBackColor = false;
			this.buttonDeleteFormula.Click += new System.EventHandler(this.buttonDeleteFormula_Click);
			// 
			// buttonEditFormula
			// 
			this.buttonEditFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonEditFormula.Location = new System.Drawing.Point(93, 12);
			this.buttonEditFormula.Name = "buttonEditFormula";
			this.buttonEditFormula.Size = new System.Drawing.Size(75, 41);
			this.buttonEditFormula.TabIndex = 1;
			this.buttonEditFormula.Text = "编辑规则";
			this.buttonEditFormula.UseVisualStyleBackColor = false;
			this.buttonEditFormula.Click += new System.EventHandler(this.buttonEditFormula_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonRunOne;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 566);
			this.Controls.Add(this.buttonDeleteFormula);
			this.Controls.Add(this.buttonEditFormula);
			this.Controls.Add(this.listViewFormula);
			this.Controls.Add(this.buttonSetting);
			this.Controls.Add(this.buttonRunAll);
			this.Controls.Add(this.buttonRunOne);
			this.Controls.Add(this.buttonAddFormula);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "NannSpider-暔蜘-抓取关键词在搜索引擎的排位";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAddFormula;
		private System.Windows.Forms.Button buttonRunOne;
		private System.Windows.Forms.Button buttonRunAll;
		private System.Windows.Forms.Button buttonSetting;
		private System.Windows.Forms.ListView listViewFormula;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ColumnHeader columnHeaderSearchEngine;
		private System.Windows.Forms.ColumnHeader columnHeaderKeyword;
		private System.Windows.Forms.Button buttonDeleteFormula;
		private System.Windows.Forms.Button buttonEditFormula;
		private System.Windows.Forms.ColumnHeader columnHeaderContinuePage;
		private System.Windows.Forms.ColumnHeader columnHeaderContinuePageCount;
		private System.Windows.Forms.ColumnHeader columnHeaderKeywordRegex;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
	}
}