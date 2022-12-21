using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Drawing.Imaging;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.IO;

namespace KareKodUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Image KareKodOlustur(string giris, int kkDuzey)
        {
            var deger = giris;
            MessagingToolkit.QRCode.Codec.QRCodeEncoder qre = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();

            if (rad_ALPHA_NUMERIC.Checked == true)
                qre.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;

            if (rad_BYTE.Checked == true)
                qre.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;

            if (rad_NUMERIC.Checked == true)
                qre.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;

            qre.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            qre.QRCodeVersion = kkDuzey;
            System.Drawing.Bitmap bm = qre.Encode(deger);
            return bm;
        }


        private void btn_karekod_uret_Click(object sender, EventArgs e)
        {
            try
            {
                int sauyi = txt_karekod_icerik.Text.Length;
                if (rad_ALPHA_NUMERIC.Checked == true || rad_BYTE.Checked == true || rad_NUMERIC.Checked == true)
                {
                    pc_karekod.Image = KareKodOlustur(txt_karekod_icerik.Text, 4);

                }
                else
                {
                    MessageBox.Show("Lütfen ENCODE_MODE seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Karakter sınırını aştınız. Lütfen biraz kısaltın", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_karekod_coz_Click(object sender, EventArgs e)
        {
            karekod_cozumle();
        }
        void karekod_cozumle()
        {
            try
            {
                QRCodeDecoder decoder = new QRCodeDecoder();
                txt_karekod_icerik.Text = decoder.decode(new QRCodeBitmapImage(pc_karekod.Image as Bitmap));
            }
            catch (MessagingToolkit.QRCode.ExceptionHandler.DecodingFailedException ex)
            {
                MessageBox.Show("Karekod çözümlenemiyor.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void karekodGetirVeOkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog()
            {
                Title = "Karekod Seçin",
                Filter = "JPG Dosyası |*.jpg| PNG Dosyası|*.png| GIF Dosyası|*.gif| Bitmap Dosyası|*.bmp",
                FilterIndex = 1,
                RestoreDirectory = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            };

            string DosyaYolu;
            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;
                pc_karekod.Image = Image.FromFile(DosyaYolu);
                karekod_cozumle();
            }
        }

        private void karekodKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            try
            {
                filename = "KK-" + txt_karekod_icerik.Lines[0] + ".jpg";
            }
            catch (IndexOutOfRangeException) // textbox un ilk satırında yazılı bir şey yok ise...
            {
                filename = "KK-" + DateTime.Now.ToString() + ".jpg";
            }

            if (pc_karekod.Image != null)
            {
                SaveFileDialog sf = new SaveFileDialog()
                {
                    Title = "Kaydet",
                    RestoreDirectory = true,
                    Filter = "JPG Dosyası |*.jpg",
                    FileName = filename,
                };
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    pc_karekod.Image.Save(sf.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("KareKod kaydedildi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Oluşturulmuş bir Karekod bulunamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_karekod_icerik_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Karakter Sayısı : " + txt_karekod_icerik.Text.Length.ToString();
        }
    }
}
