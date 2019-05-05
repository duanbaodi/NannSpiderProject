namespace NannSpider.View
{
	partial class FormulaEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaEditForm));
			this.buttonConfirm = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonConfirm
			// 
			this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonConfirm.Location = new System.Drawing.Point(589, 276);
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.Size = new System.Drawing.Size(75, 41);
			this.buttonConfirm.TabIndex = 1;
			this.buttonConfirm.Text = "确认";
			this.buttonConfirm.UseVisualStyleBackColor = false;
			this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(508, 276);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 41);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "取消";
			this.buttonCancel.UseVisualStyleBackColor = false;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// FormulaEditForm
			// 
			this.AcceptButton = this.buttonConfirm;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(676, 329);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonConfirm);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormulaEditForm";
			this.Text = "查询规则";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonConfirm;
		private System.Windows.Forms.Button buttonCancel;
	}
}