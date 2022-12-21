namespace KareKodUygulamasi
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
            this.txt_karekod_icerik = new System.Windows.Forms.TextBox();
            this.pc_karekod = new System.Windows.Forms.PictureBox();
            this.btn_karekod_uret = new System.Windows.Forms.Button();
            this.btn_karekod_coz = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.karekodGetirVeOkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karekodKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_BYTE = new System.Windows.Forms.RadioButton();
            this.rad_ALPHA_NUMERIC = new System.Windows.Forms.RadioButton();
            this.rad_NUMERIC = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pc_karekod)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_karekod_icerik
            // 
            this.txt_karekod_icerik.Location = new System.Drawing.Point(12, 135);
            this.txt_karekod_icerik.Multiline = true;
            this.txt_karekod_icerik.Name = "txt_karekod_icerik";
            this.txt_karekod_icerik.Size = new System.Drawing.Size(522, 140);
            this.txt_karekod_icerik.TabIndex = 0;
            this.txt_karekod_icerik.TextChanged += new System.EventHandler(this.txt_karekod_icerik_TextChanged);
            // 
            // pc_karekod
            // 
            this.pc_karekod.ContextMenuStrip = this.contextMenuStrip1;
            this.pc_karekod.Location = new System.Drawing.Point(540, 135);
            this.pc_karekod.Name = "pc_karekod";
            this.pc_karekod.Size = new System.Drawing.Size(140, 140);
            this.pc_karekod.TabIndex = 1;
            this.pc_karekod.TabStop = false;
            // 
            // btn_karekod_uret
            // 
            this.btn_karekod_uret.Location = new System.Drawing.Point(191, 284);
            this.btn_karekod_uret.Name = "btn_karekod_uret";
            this.btn_karekod_uret.Size = new System.Drawing.Size(343, 23);
            this.btn_karekod_uret.TabIndex = 2;
            this.btn_karekod_uret.Text = "KareKod Üret";
            this.btn_karekod_uret.UseVisualStyleBackColor = true;
            this.btn_karekod_uret.Click += new System.EventHandler(this.btn_karekod_uret_Click);
            // 
            // btn_karekod_coz
            // 
            this.btn_karekod_coz.Location = new System.Drawing.Point(540, 284);
            this.btn_karekod_coz.Name = "btn_karekod_coz";
            this.btn_karekod_coz.Size = new System.Drawing.Size(140, 23);
            this.btn_karekod_coz.TabIndex = 3;
            this.btn_karekod_coz.Text = "KareKod Çöz";
            this.btn_karekod_coz.UseVisualStyleBackColor = true;
            this.btn_karekod_coz.Click += new System.EventHandler(this.btn_karekod_coz_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karekodGetirVeOkuToolStripMenuItem,
            this.karekodKaydetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 48);
            // 
            // karekodGetirVeOkuToolStripMenuItem
            // 
            this.karekodGetirVeOkuToolStripMenuItem.Name = "karekodGetirVeOkuToolStripMenuItem";
            this.karekodGetirVeOkuToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.karekodGetirVeOkuToolStripMenuItem.Text = "Karekod Getir ve Oku";
            this.karekodGetirVeOkuToolStripMenuItem.Click += new System.EventHandler(this.karekodGetirVeOkuToolStripMenuItem_Click);
            // 
            // karekodKaydetToolStripMenuItem
            // 
            this.karekodKaydetToolStripMenuItem.Name = "karekodKaydetToolStripMenuItem";
            this.karekodKaydetToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.karekodKaydetToolStripMenuItem.Text = "Karekod Kaydet";
            this.karekodKaydetToolStripMenuItem.Click += new System.EventHandler(this.karekodKaydetToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Karakter Sayısı : 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_NUMERIC);
            this.groupBox1.Controls.Add(this.rad_ALPHA_NUMERIC);
            this.groupBox1.Controls.Add(this.rad_BYTE);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENCODE_MODE";
            // 
            // rad_BYTE
            // 
            this.rad_BYTE.AutoSize = true;
            this.rad_BYTE.Location = new System.Drawing.Point(6, 19);
            this.rad_BYTE.Name = "rad_BYTE";
            this.rad_BYTE.Size = new System.Drawing.Size(293, 17);
            this.rad_BYTE.TabIndex = 0;
            this.rad_BYTE.TabStop = true;
            this.rad_BYTE.Text = "BYTE (Byte olarak şifrelenir. Tüm karakterler desteklenir.)";
            this.rad_BYTE.UseVisualStyleBackColor = true;
            // 
            // rad_ALPHA_NUMERIC
            // 
            this.rad_ALPHA_NUMERIC.AutoSize = true;
            this.rad_ALPHA_NUMERIC.Location = new System.Drawing.Point(6, 41);
            this.rad_ALPHA_NUMERIC.Name = "rad_ALPHA_NUMERIC";
            this.rad_ALPHA_NUMERIC.Size = new System.Drawing.Size(528, 17);
            this.rad_ALPHA_NUMERIC.TabIndex = 1;
            this.rad_ALPHA_NUMERIC.TabStop = true;
            this.rad_ALPHA_NUMERIC.Text = "ALPHA_NUMERIC (Alfa nümerik olarak şifrelenir.  Metin şifreleme yapılırsa geri ok" +
    "umada sadece 0 geliyor. )";
            this.rad_ALPHA_NUMERIC.UseVisualStyleBackColor = true;
            // 
            // rad_NUMERIC
            // 
            this.rad_NUMERIC.AutoSize = true;
            this.rad_NUMERIC.Location = new System.Drawing.Point(6, 64);
            this.rad_NUMERIC.Name = "rad_NUMERIC";
            this.rad_NUMERIC.Size = new System.Drawing.Size(326, 17);
            this.rad_NUMERIC.TabIndex = 2;
            this.rad_NUMERIC.TabStop = true;
            this.rad_NUMERIC.Text = "NUMERIC (Sayısal olarak şifrelenir. Sadece sayı kullanmalısınız.)";
            this.rad_NUMERIC.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOT: Boyut sınırlamaları, yukarıdaki modlara göre değişiyor.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_karekod_coz);
            this.Controls.Add(this.btn_karekod_uret);
            this.Controls.Add(this.pc_karekod);
            this.Controls.Add(this.txt_karekod_icerik);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KareKod Oluşturma ve Okuma - Mustafa Bükülmez";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_karekod)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_karekod_icerik;
        private System.Windows.Forms.PictureBox pc_karekod;
        private System.Windows.Forms.Button btn_karekod_uret;
        private System.Windows.Forms.Button btn_karekod_coz;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem karekodGetirVeOkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karekodKaydetToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_NUMERIC;
        private System.Windows.Forms.RadioButton rad_ALPHA_NUMERIC;
        private System.Windows.Forms.RadioButton rad_BYTE;
        private System.Windows.Forms.Label label2;
    }
}

