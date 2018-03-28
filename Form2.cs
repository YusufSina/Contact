using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            Kisiler kisi = new Kisiler
            {
                Ad = adTextBox.Text,
                Soyad = soyadTextBox.Text,
                Numara = Convert.ToInt64(numaraTextBox.Text),

            };

            if (comboBox1.SelectedItem=="Kırmızı")
            { kisi.adRenk = "k"; }
            else if (comboBox1.SelectedItem == "Mavi")
            { kisi.adRenk = "m"; }
            else if (comboBox1.SelectedItem == "Yeşil")
            { kisi.adRenk = "y"; }

            if (comboBox2.SelectedItem=="Kırmızı")
            { kisi.soyadRenk = "k"; }
            else if (comboBox2.SelectedItem == "Mavi")
            { kisi.soyadRenk = "m"; }
            else if (comboBox2.SelectedItem == "Yeşil")
            { kisi.soyadRenk = "y"; }

            if (comboBox3.SelectedItem=="Kırmızı")
            { kisi.numaraRenk = "k"; }
            else if (comboBox3.SelectedItem == "Mavi")
            { kisi.numaraRenk = "m"; }
            else if (comboBox3.SelectedItem == "Yeşil")
            { kisi.numaraRenk = "y"; }


            string dosyaYolu = @"veriler.txt";

            if (!File.Exists(dosyaYolu)) {
                //dosya yoksa dosyayı  oluşturur ve kayıt ekler.
                FileStream fs = new FileStream(dosyaYolu, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(kisi.adRenk + kisi.soyadRenk + kisi.numaraRenk + " " + kisi.Ad + " " + kisi.Soyad + " " + kisi.Numara);
                sw.Flush();
                sw.Close();
                fs.Close();

                MessageBox.Show("Kaydedildi");
            }
            else {
                //dosya varsa dosyayı ellemeden kaydını ekler.
                StreamWriter sw = File.AppendText(dosyaYolu);
                sw.WriteLine(kisi.adRenk + kisi.soyadRenk + kisi.numaraRenk + " " + kisi.Ad + " " + kisi.Soyad + " " + kisi.Numara);
                sw.Flush();
                sw.Close();
                MessageBox.Show("Kaydedildi");

            }

            Close();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kırmızı");
            comboBox1.Items.Add("Mavi");
            comboBox1.Items.Add("Yeşil");
            comboBox2.Items.Add("Kırmızı");
            comboBox2.Items.Add("Mavi");
            comboBox2.Items.Add("Yeşil");
            comboBox3.Items.Add("Kırmızı");
            comboBox3.Items.Add("Mavi");
            comboBox3.Items.Add("Yeşil");

        }
    }

}

