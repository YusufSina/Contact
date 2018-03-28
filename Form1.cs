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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kayitekleButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
        }

        private void kayitlisteleButton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            string dosyaYolu = @"veriler.txt";
            if (File.Exists(dosyaYolu)) { f3.ShowDialog(); }
            else { MessageBox.Show("Lütfen kayıt ekleyiniz.");  };
            //veriler.txt yoksa uyarı verir.
           
        }
    }
}
