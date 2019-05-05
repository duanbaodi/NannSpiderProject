namespace NannSpider
{
	partial class NannListItem
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainText = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// mainText
			// 
			this.mainText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainText.Location = new System.Drawing.Point(0, 0);
			this.mainText.Name = "mainText";
			this.mainText.Size = new System.Drawing.Size(645, 112);
			this.mainText.TabIndex = 0;
			this.mainText.Text = "";
			this.mainText.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.mainText_LinkClicked);
			// 
			// NannListItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainText);
			this.Name = "NannListItem";
			this.Size = new System.Drawing.Size(645, 112);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox mainText;
	}
}
