namespace Q1
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
			this.guesstextBox = new System.Windows.Forms.TextBox();
			this.resulttextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Confirmbutton
			// 
			this.Confirmbutton.Location = new System.Drawing.Point(270, 53);
			this.Confirmbutton.Name = "Confirmbutton";
			this.Confirmbutton.Size = new System.Drawing.Size(75, 23);
			this.Confirmbutton.TabIndex = 0;
			this.Confirmbutton.Text = "輸入";
			this.Confirmbutton.UseVisualStyleBackColor = true;
			this.Confirmbutton.Click += new System.EventHandler(this.Confirmbutton_Click);
			// 
			// guesstextBox
			// 
			this.guesstextBox.Location = new System.Drawing.Point(78, 53);
			this.guesstextBox.Name = "guesstextBox";
			this.guesstextBox.Size = new System.Drawing.Size(151, 22);
			this.guesstextBox.TabIndex = 1;
			// 
			// resulttextBox
			// 
			this.resulttextBox.Location = new System.Drawing.Point(78, 103);
			this.resulttextBox.Multiline = true;
			this.resulttextBox.Name = "resulttextBox";
			this.resulttextBox.Size = new System.Drawing.Size(267, 222);
			this.resulttextBox.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 356);
			this.Controls.Add(this.resulttextBox);
			this.Controls.Add(this.guesstextBox);
			this.Controls.Add(this.Confirmbutton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Confirmbutton;
		private System.Windows.Forms.TextBox guesstextBox;
		private System.Windows.Forms.TextBox resulttextBox;
	}
}

