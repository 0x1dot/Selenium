namespace Selenium
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAranacakKelime = new System.Windows.Forms.TextBox();
            this.lstSonuclar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(406, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // txtAranacakKelime
            // 
            this.txtAranacakKelime.Location = new System.Drawing.Point(108, 6);
            this.txtAranacakKelime.Name = "txtAranacakKelime";
            this.txtAranacakKelime.Size = new System.Drawing.Size(292, 20);
            this.txtAranacakKelime.TabIndex = 1;
            this.txtAranacakKelime.Text = "cyber-warrior";
            // 
            // lstSonuclar
            // 
            this.lstSonuclar.FormattingEnabled = true;
            this.lstSonuclar.Location = new System.Drawing.Point(12, 32);
            this.lstSonuclar.Name = "lstSonuclar";
            this.lstSonuclar.Size = new System.Drawing.Size(469, 277);
            this.lstSonuclar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aranacak Kelime:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSonuclar);
            this.Controls.Add(this.txtAranacakKelime);
            this.Controls.Add(this.btnAra);
            this.Name = "Form1";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAranacakKelime;
        private System.Windows.Forms.ListBox lstSonuclar;
        private System.Windows.Forms.Label label1;
    }
}

