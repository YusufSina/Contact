namespace TelefonRehberi
{
    partial class Form2
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
            this.adLabel = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.numaraLabel = new System.Windows.Forms.Label();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.numaraTextBox = new System.Windows.Forms.TextBox();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(12, 47);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(29, 20);
            this.adLabel.TabIndex = 0;
            this.adLabel.Text = "Ad";
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.Location = new System.Drawing.Point(12, 140);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(54, 20);
            this.soyadLabel.TabIndex = 1;
            this.soyadLabel.Text = "Soyad";
            // 
            // numaraLabel
            // 
            this.numaraLabel.AutoSize = true;
            this.numaraLabel.Location = new System.Drawing.Point(12, 225);
            this.numaraLabel.Name = "numaraLabel";
            this.numaraLabel.Size = new System.Drawing.Size(65, 20);
            this.numaraLabel.TabIndex = 2;
            this.numaraLabel.Text = "Numara";
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(110, 47);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(191, 26);
            this.adTextBox.TabIndex = 3;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(110, 140);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(191, 26);
            this.soyadTextBox.TabIndex = 4;
            // 
            // numaraTextBox
            // 
            this.numaraTextBox.Location = new System.Drawing.Point(110, 222);
            this.numaraTextBox.Name = "numaraTextBox";
            this.numaraTextBox.Size = new System.Drawing.Size(191, 26);
            this.numaraTextBox.TabIndex = 5;
            // 
            // kaydetButton
            // 
            this.kaydetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kaydetButton.Location = new System.Drawing.Point(777, 506);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(122, 67);
            this.kaydetButton.TabIndex = 6;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(366, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 37);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(366, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(280, 37);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(366, 215);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(280, 37);
            this.comboBox3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Renk Seçimi";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.numaraTextBox);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.numaraLabel);
            this.Controls.Add(this.soyadLabel);
            this.Controls.Add(this.adLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.Label numaraLabel;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox numaraTextBox;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
    }
}