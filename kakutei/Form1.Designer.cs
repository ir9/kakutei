namespace kakutei
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxDate = new System.Windows.Forms.TextBox();
			this.textBoxYen = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AllowDrop = true;
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 83);
			this.label1.TabIndex = 0;
			this.label1.Text = "D&&D";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
			this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.label1_DragEnter);
			// 
			// textBoxDate
			// 
			this.textBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDate.Location = new System.Drawing.Point(163, 24);
			this.textBoxDate.Name = "textBoxDate";
			this.textBoxDate.Size = new System.Drawing.Size(100, 19);
			this.textBoxDate.TabIndex = 1;
			this.textBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxDate_TextChanged);
			this.textBoxDate.Enter += new System.EventHandler(this.textBoxDate_Enter);
			// 
			// textBoxYen
			// 
			this.textBoxYen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxYen.Location = new System.Drawing.Point(163, 73);
			this.textBoxYen.Name = "textBoxYen";
			this.textBoxYen.Size = new System.Drawing.Size(100, 19);
			this.textBoxYen.TabIndex = 2;
			this.textBoxYen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBoxYen.TextChanged += new System.EventHandler(this.textBoxYen_TextChanged);
			this.textBoxYen.Enter += new System.EventHandler(this.textBoxYen_Enter);
			this.textBoxYen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxYen_KeyDown);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(161, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "Date (mmdd)";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(161, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "Date (mmdd)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(275, 106);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxYen);
			this.Controls.Add(this.textBoxDate);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxDate;
		private System.Windows.Forms.TextBox textBoxYen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

