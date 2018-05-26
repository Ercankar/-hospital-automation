namespace Hastaneotomasyonu1
{
    partial class Stokguncelleme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridurun = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.krıtık_stok_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.urun_adedı_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.urun_cınsı_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.urun_foytı_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.urun_adı_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urunkodu_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridurun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridurun);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.krıtık_stok_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.urun_adedı_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.urun_cınsı_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.urun_foytı_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.urun_adı_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.urunkodu_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 542);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "\"";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridurun
            // 
            this.dataGridurun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridurun.Location = new System.Drawing.Point(12, 220);
            this.dataGridurun.Name = "dataGridurun";
            this.dataGridurun.Size = new System.Drawing.Size(843, 310);
            this.dataGridurun.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "GÜNCELLE";
            this.toolTip1.SetToolTip(this.button1, "Kaydetmek için tıklayınız");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "ÜRÜN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(581, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 119);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Resim Yüklemek için tıklayınız");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // krıtık_stok_txt
            // 
            this.krıtık_stok_txt.Location = new System.Drawing.Point(355, 165);
            this.krıtık_stok_txt.Name = "krıtık_stok_txt";
            this.krıtık_stok_txt.Size = new System.Drawing.Size(100, 20);
            this.krıtık_stok_txt.TabIndex = 26;
            this.krıtık_stok_txt.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = " Kritik STOK";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // urun_adedı_txt
            // 
            this.urun_adedı_txt.Location = new System.Drawing.Point(355, 116);
            this.urun_adedı_txt.Name = "urun_adedı_txt";
            this.urun_adedı_txt.Size = new System.Drawing.Size(100, 20);
            this.urun_adedı_txt.TabIndex = 24;
            this.urun_adedı_txt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = " Ürün ADEDİ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // urun_cınsı_txt
            // 
            this.urun_cınsı_txt.Location = new System.Drawing.Point(355, 63);
            this.urun_cınsı_txt.Name = "urun_cınsı_txt";
            this.urun_cınsı_txt.Size = new System.Drawing.Size(100, 20);
            this.urun_cınsı_txt.TabIndex = 22;
            this.urun_cınsı_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = " Ürin CİNSİ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // urun_foytı_txt
            // 
            this.urun_foytı_txt.Location = new System.Drawing.Point(113, 161);
            this.urun_foytı_txt.Name = "urun_foytı_txt";
            this.urun_foytı_txt.Size = new System.Drawing.Size(100, 20);
            this.urun_foytı_txt.TabIndex = 20;
            this.urun_foytı_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = " Ürün FİYATI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // urun_adı_txt
            // 
            this.urun_adı_txt.Location = new System.Drawing.Point(113, 119);
            this.urun_adı_txt.Name = "urun_adı_txt";
            this.urun_adı_txt.Size = new System.Drawing.Size(100, 20);
            this.urun_adı_txt.TabIndex = 18;
            this.urun_adı_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = " Ürün ADI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // urunkodu_txt
            // 
            this.urunkodu_txt.Location = new System.Drawing.Point(113, 63);
            this.urunkodu_txt.Name = "urunkodu_txt";
            this.urunkodu_txt.Size = new System.Drawing.Size(100, 20);
            this.urunkodu_txt.TabIndex = 16;
            this.urunkodu_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = " Ürün KODU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "Stok";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stokguncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 542);
            this.Controls.Add(this.groupBox1);
            this.Name = "Stokguncelleme";
            this.Text = "Stokguncelleme";
            this.Load += new System.EventHandler(this.Stokguncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridurun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox krıtık_stok_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox urun_adedı_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox urun_cınsı_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urun_foytı_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urun_adı_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunkodu_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridurun;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}