namespace WindowsFormsApp1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(271, 92);
            this.Label1.Name = "label1";
            this.Label1.Size = new System.Drawing.Size(84, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Hello, World!";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.Button1.Location = new System.Drawing.Point(283, 161);
            this.Button1.Name = "button1";
            this.Button1.Size = new System.Drawing.Size(124, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Click me!";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Button Button1;
	}
}

