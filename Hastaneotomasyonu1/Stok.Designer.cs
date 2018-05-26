namespace Hastaneotomasyonu1
{
    partial class Stok
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
            this.stok_takip = new System.Windows.Forms.TabControl();
            this.stok_kartı = new System.Windows.Forms.TabPage();
            this.stok_listesi = new System.Windows.Forms.TabPage();
            this.stok_grubu = new System.Windows.Forms.TabPage();
            this.stok_hareketleri = new System.Windows.Forms.TabPage();
            this.stok_takip.SuspendLayout();
            this.SuspendLayout();
            // 
            // stok_takip
            // 
            this.stok_takip.Controls.Add(this.stok_kartı);
            this.stok_takip.Controls.Add(this.stok_listesi);
            this.stok_takip.Controls.Add(this.stok_grubu);
            this.stok_takip.Controls.Add(this.stok_hareketleri);
            this.stok_takip.Location = new System.Drawing.Point(12, 12);
            this.stok_takip.Name = "stok_takip";
            this.stok_takip.SelectedIndex = 0;
            this.stok_takip.Size = new System.Drawing.Size(683, 375);
            this.stok_takip.TabIndex = 0;
            // 
            // stok_kartı
            // 
            this.stok_kartı.Location = new System.Drawing.Point(4, 22);
            this.stok_kartı.Name = "stok_kartı";
            this.stok_kartı.Padding = new System.Windows.Forms.Padding(3);
            this.stok_kartı.Size = new System.Drawing.Size(675, 349);
            this.stok_kartı.TabIndex = 0;
            this.stok_kartı.Text = "Stok Kartı";
            this.stok_kartı.UseVisualStyleBackColor = true;
            this.stok_kartı.Click += new System.EventHandler(this.stok_kartı_Click);
            // 
            // stok_listesi
            // 
            this.stok_listesi.Location = new System.Drawing.Point(4, 22);
            this.stok_listesi.Name = "stok_listesi";
            this.stok_listesi.Padding = new System.Windows.Forms.Padding(3);
            this.stok_listesi.Size = new System.Drawing.Size(675, 349);
            this.stok_listesi.TabIndex = 1;
            this.stok_listesi.Text = "Stok listesi";
            this.stok_listesi.UseVisualStyleBackColor = true;
            // 
            // stok_grubu
            // 
            this.stok_grubu.Location = new System.Drawing.Point(4, 22);
            this.stok_grubu.Name = "stok_grubu";
            this.stok_grubu.Padding = new System.Windows.Forms.Padding(3);
            this.stok_grubu.Size = new System.Drawing.Size(675, 349);
            this.stok_grubu.TabIndex = 2;
            this.stok_grubu.Text = "Stok grubu";
            this.stok_grubu.UseVisualStyleBackColor = true;
            // 
            // stok_hareketleri
            // 
            this.stok_hareketleri.Location = new System.Drawing.Point(4, 22);
            this.stok_hareketleri.Name = "stok_hareketleri";
            this.stok_hareketleri.Padding = new System.Windows.Forms.Padding(3);
            this.stok_hareketleri.Size = new System.Drawing.Size(675, 349);
            this.stok_hareketleri.TabIndex = 3;
            this.stok_hareketleri.Text = "Stok Hareketleri";
            this.stok_hareketleri.UseVisualStyleBackColor = true;
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 412);
            this.Controls.Add(this.stok_takip);
            this.Name = "Stok";
            this.Text = "Stok";
            this.stok_takip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl stok_takip;
        private System.Windows.Forms.TabPage stok_kartı;
        private System.Windows.Forms.TabPage stok_listesi;
        private System.Windows.Forms.TabPage stok_grubu;
        private System.Windows.Forms.TabPage stok_hareketleri;
    }
}