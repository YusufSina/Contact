namespace TelefonRehberi
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
            this.kayitekleButton = new System.Windows.Forms.Button();
            this.kayitlisteleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kayitekleButton
            // 
            this.kayitekleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kayitekleButton.Location = new System.Drawing.Point(319, 164);
            this.kayitekleButton.Name = "kayitekleButton";
            this.kayitekleButton.Size = new System.Drawing.Size(179, 72);
            this.kayitekleButton.TabIndex = 0;
            this.kayitekleButton.Text = "Kayıt Ekle";
            this.kayitekleButton.UseVisualStyleBackColor = true;
            this.kayitekleButton.Click += new System.EventHandler(this.kayitekleButton_Click);
            // 
            // kayitlisteleButton
            // 
            this.kayitlisteleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kayitlisteleButton.Location = new System.Drawing.Point(319, 254);
            this.kayitlisteleButton.Name = "kayitlisteleButton";
            this.kayitlisteleButton.Size = new System.Drawing.Size(179, 72);
            this.kayitlisteleButton.TabIndex = 1;
            this.kayitlisteleButton.Text = "Kayıt Listele";
            this.kayitlisteleButton.UseVisualStyleBackColor = true;
            this.kayitlisteleButton.Click += new System.EventHandler(this.kayitlisteleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 580);
            this.Controls.Add(this.kayitlisteleButton);
            this.Controls.Add(this.kayitekleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kayitekleButton;
        private System.Windows.Forms.Button kayitlisteleButton;
    }
}

