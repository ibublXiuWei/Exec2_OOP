namespace Q2
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.Confirmbutton = new System.Windows.Forms.Button();
			this.dicetextBox = new System.Windows.Forms.TextBox();
			this.countlabel = new System.Windows.Forms.Label();
			this.Resetbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Confirmbutton
			// 
			this.Confirmbutton.Location = new System.Drawing.Point(102, 76);
			this.Confirmbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Confirmbutton.Name = "Confirmbutton";
			this.Confirmbutton.Size = new System.Drawing.Size(112, 34);
			this.Confirmbutton.TabIndex = 0;
			this.Confirmbutton.Text = "取得骰子";
			this.Confirmbutton.UseVisualStyleBackColor = true;
			this.Confirmbutton.Click += new System.EventHandler(this.Confirmbutton_Click_1);
			// 
			// dicetextBox
			// 
			this.dicetextBox.Location = new System.Drawing.Point(102, 140);
			this.dicetextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dicetextBox.Multiline = true;
			this.dicetextBox.Name = "dicetextBox";
			this.dicetextBox.Size = new System.Drawing.Size(241, 142);
			this.dicetextBox.TabIndex = 1;
			// 
			// countlabel
			// 
			this.countlabel.AutoSize = true;
			this.countlabel.Location = new System.Drawing.Point(406, 198);
			this.countlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.countlabel.Name = "countlabel";
			this.countlabel.Size = new System.Drawing.Size(50, 18);
			this.countlabel.TabIndex = 2;
			this.countlabel.Text = "label1";
			// 
			// Resetbutton
			// 
			this.Resetbutton.Location = new System.Drawing.Point(366, 76);
			this.Resetbutton.Margin = new System.Windows.Forms.Padding(4);
			this.Resetbutton.Name = "Resetbutton";
			this.Resetbutton.Size = new System.Drawing.Size(71, 34);
			this.Resetbutton.TabIndex = 0;
			this.Resetbutton.Text = "重新";
			this.Resetbutton.UseVisualStyleBackColor = true;
			this.Resetbutton.Click += new System.EventHandler(this.resetbutton);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 378);
			this.Controls.Add(this.countlabel);
			this.Controls.Add(this.dicetextBox);
			this.Controls.Add(this.Resetbutton);
			this.Controls.Add(this.Confirmbutton);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Confirmbutton;
		private System.Windows.Forms.TextBox dicetextBox;
		private System.Windows.Forms.Label countlabel;
		private System.Windows.Forms.Button Resetbutton;
	}
}

