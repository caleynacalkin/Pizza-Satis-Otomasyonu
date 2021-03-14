namespace PizzaDukkan
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
            this.btn_yonetici = new System.Windows.Forms.Button();
            this.btn_Siparis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_yonetici
            // 
            this.btn_yonetici.Location = new System.Drawing.Point(300, 133);
            this.btn_yonetici.Name = "btn_yonetici";
            this.btn_yonetici.Size = new System.Drawing.Size(239, 72);
            this.btn_yonetici.TabIndex = 0;
            this.btn_yonetici.Text = "Yönetici";
            this.btn_yonetici.UseVisualStyleBackColor = true;
            this.btn_yonetici.Click += new System.EventHandler(this.btn_yonetici_Click);
            // 
            // btn_Siparis
            // 
            this.btn_Siparis.Location = new System.Drawing.Point(300, 211);
            this.btn_Siparis.Name = "btn_Siparis";
            this.btn_Siparis.Size = new System.Drawing.Size(239, 72);
            this.btn_Siparis.TabIndex = 1;
            this.btn_Siparis.Text = "Sipariş oluştur ...";
            this.btn_Siparis.UseVisualStyleBackColor = true;
            this.btn_Siparis.Click += new System.EventHandler(this.btn_Siparis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 432);
            this.Controls.Add(this.btn_Siparis);
            this.Controls.Add(this.btn_yonetici);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_yonetici;
        private System.Windows.Forms.Button btn_Siparis;
    }
}

