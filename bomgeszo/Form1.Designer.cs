namespace bomgeszo
{
	partial class Form1
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
			if (disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.back = new System.Windows.Forms.Button();
			this.fore = new System.Windows.Forms.Button();
			this.go = new System.Windows.Forms.Button();
			this.refresh = new System.Windows.Forms.Button();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// txtAddress
			// 
			this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAddress.Location = new System.Drawing.Point(106, 8);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(618, 20);
			this.txtAddress.TabIndex = 1;
			this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
			this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
			// 
			// back
			// 
			this.back.Location = new System.Drawing.Point(12, 5);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(25, 25);
			this.back.TabIndex = 2;
			this.back.Text = "<";
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// fore
			// 
			this.fore.Location = new System.Drawing.Point(43, 5);
			this.fore.Name = "fore";
			this.fore.Size = new System.Drawing.Size(25, 25);
			this.fore.TabIndex = 3;
			this.fore.Text = ">";
			this.fore.UseVisualStyleBackColor = true;
			this.fore.Click += new System.EventHandler(this.fore_Click);
			// 
			// go
			// 
			this.go.Image = ((System.Drawing.Image)(resources.GetObject("go.Image")));
			this.go.Location = new System.Drawing.Point(75, 5);
			this.go.Name = "go";
			this.go.Size = new System.Drawing.Size(25, 25);
			this.go.TabIndex = 4;
			this.go.UseVisualStyleBackColor = true;
			this.go.Click += new System.EventHandler(this.go_Click);
			// 
			// refresh
			// 
			this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
			this.refresh.Location = new System.Drawing.Point(742, 8);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(26, 25);
			this.refresh.TabIndex = 5;
			this.refresh.UseVisualStyleBackColor = true;
			this.refresh.Click += new System.EventHandler(this.refresh_Click);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.webBrowser1.Location = new System.Drawing.Point(12, 63);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(756, 398);
			this.webBrowser1.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.go);
			this.Controls.Add(this.fore);
			this.Controls.Add(this.back);
			this.Controls.Add(this.txtAddress);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Button fore;
		private System.Windows.Forms.Button go;
		private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.WebBrowser webBrowser1;
	}
}

