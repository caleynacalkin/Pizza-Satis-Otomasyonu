namespace PizzaDukkan
{
    partial class Adminsiparisler
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
            this.gvListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListe
            // 
            this.gvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListe.Location = new System.Drawing.Point(12, 3);
            this.gvListe.Name = "gvListe";
            this.gvListe.Size = new System.Drawing.Size(962, 417);
            this.gvListe.TabIndex = 0;
            // 
            // Adminsiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(986, 432);
            this.Controls.Add(this.gvListe);
            this.Name = "Adminsiparisler";
            this.Text = "Adminsiparisler";
            this.Load += new System.EventHandler(this.Adminsiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListe;
    }
}