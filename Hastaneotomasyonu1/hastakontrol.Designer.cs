﻿namespace Hastaneotomasyonu1
{
    partial class hastakontrol
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
            this.maskedtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedtxtTC
            // 
            this.maskedtxtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtxtTC.Location = new System.Drawing.Point(184, 12);
            this.maskedtxtTC.Mask = "00000000000";
            this.maskedtxtTC.Name = "maskedtxtTC";
            this.maskedtxtTC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedtxtTC.Size = new System.Drawing.Size(151, 22);
            this.maskedtxtTC.TabIndex = 10;
            // 
            // btnGonder
            // 
            this.btnGonder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Location = new System.Drawing.Point(23, 60);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(312, 47);
            this.btnGonder.TabIndex = 12;
            this.btnGonder.Text = "HASTA DURUM KONTROL ET";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(23, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "TC numarasını eksiksiz giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "T.C. Kimlik Numarası";
            // 
            // hastakontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 135);
            this.Controls.Add(this.maskedtxtTC);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "hastakontrol";
            this.Text = "hastakontrol";
            this.Load += new System.EventHandler(this.hastakontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedtxtTC;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}