namespace _25_PA09_Mohamad_Riduan
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_USDollar = new System.Windows.Forms.RadioButton();
            this.rb_JPYen = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rb_Ringgit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 98);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 302);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted Amount :";
            // 
            // rb_USDollar
            // 
            this.rb_USDollar.AutoSize = true;
            this.rb_USDollar.Location = new System.Drawing.Point(323, 146);
            this.rb_USDollar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_USDollar.Name = "rb_USDollar";
            this.rb_USDollar.Size = new System.Drawing.Size(89, 21);
            this.rb_USDollar.TabIndex = 5;
            this.rb_USDollar.TabStop = true;
            this.rb_USDollar.Text = "US Dollar";
            this.rb_USDollar.UseVisualStyleBackColor = true;
            this.rb_USDollar.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rb_JPYen
            // 
            this.rb_JPYen.AutoSize = true;
            this.rb_JPYen.Location = new System.Drawing.Point(323, 194);
            this.rb_JPYen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_JPYen.Name = "rb_JPYen";
            this.rb_JPYen.Size = new System.Drawing.Size(123, 21);
            this.rb_JPYen.TabIndex = 6;
            this.rb_JPYen.TabStop = true;
            this.rb_JPYen.Text = "Japanese YEN";
            this.rb_JPYen.UseVisualStyleBackColor = true;
            this.rb_JPYen.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // rb_Ringgit
            // 
            this.rb_Ringgit.AutoSize = true;
            this.rb_Ringgit.Location = new System.Drawing.Point(323, 241);
            this.rb_Ringgit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_Ringgit.Name = "rb_Ringgit";
            this.rb_Ringgit.Size = new System.Drawing.Size(140, 21);
            this.rb_Ringgit.TabIndex = 9;
            this.rb_Ringgit.TabStop = true;
            this.rb_Ringgit.Text = "Malaysian Ringgit";
            this.rb_Ringgit.UseVisualStyleBackColor = true;
            this.rb_Ringgit.CheckedChanged += new System.EventHandler(this.rb_Ringgit_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_Ringgit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_JPYen);
            this.Controls.Add(this.rb_USDollar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "04_PA09_Dasharupa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_USDollar;
        private System.Windows.Forms.RadioButton rb_JPYen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rb_Ringgit;
    }
}

