namespace _15253055P
{
    partial class uyeKaydiOlusturma
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kayitOlusturBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.kayitGuncelleBtn = new System.Windows.Forms.Button();
            this.kayitSilBtn = new System.Windows.Forms.Button();
            this.geriDonBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gosterBtn = new System.Windows.Forms.Button();
            this.bankaOtomasyonDataSet = new _15253055P.BankaOtomasyonDataSet();
            this.bankaOtomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaOtomasyonDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adınız";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifreniz";
            // 
            // kayitOlusturBtn
            // 
            this.kayitOlusturBtn.Location = new System.Drawing.Point(12, 169);
            this.kayitOlusturBtn.Name = "kayitOlusturBtn";
            this.kayitOlusturBtn.Size = new System.Drawing.Size(178, 39);
            this.kayitOlusturBtn.TabIndex = 11;
            this.kayitOlusturBtn.Text = "Kayıt Oluştur";
            this.kayitOlusturBtn.UseVisualStyleBackColor = true;
            this.kayitOlusturBtn.Click += new System.EventHandler(this.kayitOlusturBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(25, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "KULLANICI İŞLEMLERİ";
            // 
            // kayitGuncelleBtn
            // 
            this.kayitGuncelleBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.kayitGuncelleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kayitGuncelleBtn.Location = new System.Drawing.Point(654, 271);
            this.kayitGuncelleBtn.Name = "kayitGuncelleBtn";
            this.kayitGuncelleBtn.Size = new System.Drawing.Size(178, 39);
            this.kayitGuncelleBtn.TabIndex = 13;
            this.kayitGuncelleBtn.Text = "Kaydı Güncelle";
            this.kayitGuncelleBtn.UseVisualStyleBackColor = false;
            this.kayitGuncelleBtn.Click += new System.EventHandler(this.kayitGuncelleBtn_Click);
            // 
            // kayitSilBtn
            // 
            this.kayitSilBtn.BackColor = System.Drawing.Color.DarkRed;
            this.kayitSilBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kayitSilBtn.Location = new System.Drawing.Point(12, 225);
            this.kayitSilBtn.Name = "kayitSilBtn";
            this.kayitSilBtn.Size = new System.Drawing.Size(178, 39);
            this.kayitSilBtn.TabIndex = 14;
            this.kayitSilBtn.Text = "Kaydı Sil";
            this.kayitSilBtn.UseVisualStyleBackColor = false;
            this.kayitSilBtn.Click += new System.EventHandler(this.kayitSilBtn_Click);
            // 
            // geriDonBtn
            // 
            this.geriDonBtn.BackColor = System.Drawing.Color.DarkRed;
            this.geriDonBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.geriDonBtn.Location = new System.Drawing.Point(234, 225);
            this.geriDonBtn.Name = "geriDonBtn";
            this.geriDonBtn.Size = new System.Drawing.Size(178, 39);
            this.geriDonBtn.TabIndex = 15;
            this.geriDonBtn.Text = "Geri Dön";
            this.geriDonBtn.UseVisualStyleBackColor = false;
            this.geriDonBtn.Click += new System.EventHandler(this.geriDonBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 241);
            this.dataGridView1.TabIndex = 16;
            // 
            // gosterBtn
            // 
            this.gosterBtn.BackColor = System.Drawing.Color.Gold;
            this.gosterBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gosterBtn.Location = new System.Drawing.Point(234, 169);
            this.gosterBtn.Name = "gosterBtn";
            this.gosterBtn.Size = new System.Drawing.Size(178, 39);
            this.gosterBtn.TabIndex = 17;
            this.gosterBtn.Text = "Göster";
            this.gosterBtn.UseVisualStyleBackColor = false;
            this.gosterBtn.Click += new System.EventHandler(this.gosterBtn_Click);
            // 
            // bankaOtomasyonDataSet
            // 
            this.bankaOtomasyonDataSet.DataSetName = "BankaOtomasyonDataSet";
            this.bankaOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankaOtomasyonDataSetBindingSource
            // 
            this.bankaOtomasyonDataSetBindingSource.DataSource = this.bankaOtomasyonDataSet;
            this.bankaOtomasyonDataSetBindingSource.Position = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(475, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 22);
            this.textBox3.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Güncellenecek ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(186, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(646, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Güncelleme Yaparken Yukarıdaki Kısma Yeni Kullanıcı Adını ve Şifreyi Girin.";
            // 
            // uyeKaydiOlusturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 344);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.gosterBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geriDonBtn);
            this.Controls.Add(this.kayitSilBtn);
            this.Controls.Add(this.kayitGuncelleBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kayitOlusturBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "uyeKaydiOlusturma";
            this.Text = "uyeKaydiOlusturma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaOtomasyonDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kayitOlusturBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kayitGuncelleBtn;
        private System.Windows.Forms.Button kayitSilBtn;
        private System.Windows.Forms.Button geriDonBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gosterBtn;
        private BankaOtomasyonDataSet bankaOtomasyonDataSet;
        private System.Windows.Forms.BindingSource bankaOtomasyonDataSetBindingSource;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}