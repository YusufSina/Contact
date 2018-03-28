using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TelefonRehberi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string dosyaYolu = @"veriler.txt";
           
            FileStream fs = new FileStream(dosyaYolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);

            string yazi = sw.ReadLine();

            int ad;
            int soyad;
            int numara;
            int satirSayisi = 0;
            while (yazi != null)
            {

                
                int son = yazi.Length;
                
                for (int i = 0; i < son; i++) { if (yazi[i].ToString()==" ") {
                        ad = i + 1;//ilk boşluk bulundu
                        
                        for (int j = i + 1; j < son; j++) { if (yazi[j].ToString() == " ") {
                                soyad = j + 1;//ikinci boşluk bulundu
                                
                                for (int k = j + 1; k < son; k++) { if (yazi[k].ToString() == " ") {
                                        numara =k + 1;//üçüncü boşluk bulundu
                                        
                                        if (satirSayisi % 2 == 0) { richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold); }
                                        else { richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 12, FontStyle.Regular); };
                                        // tek satırlar kalın çiftler ince fontla yazıldı.



                                        if (yazi[0].ToString() == "k") { richTextBox1.SelectionColor = Color.Red; }
                                        else if (yazi[0].ToString() == "m") { richTextBox1.SelectionColor = Color.Blue; }
                                        else if (yazi[0].ToString() == "y") { richTextBox1.SelectionColor = Color.Green; }
                                        else;
                                        richTextBox1.AppendText(yazi.Substring(ad, soyad - ad));
                                        // isim eklendi.
                                        if (yazi[1].ToString() == "k") { richTextBox1.SelectionColor = Color.Red; }
                                        else if (yazi[1].ToString() == "m") { richTextBox1.SelectionColor = Color.Blue; }
                                        else if (yazi[1].ToString() == "y") { richTextBox1.SelectionColor = Color.Green; }
                                        else;
                                        richTextBox1.AppendText(yazi.Substring(soyad, numara-soyad));
                                        //soyad eklendi
                                        if (yazi[2].ToString() == "k") { richTextBox1.SelectionColor = Color.Red; }
                                        else if (yazi[2].ToString() == "m") { richTextBox1.SelectionColor = Color.Blue; }
                                        else if (yazi[2].ToString() == "y") { richTextBox1.SelectionColor = Color.Green; }
                                        else;
                                        richTextBox1.AppendText(yazi.Substring(numara, son-numara)+"\n");
                                                                                                         //numara eklendi.

                                        break;
                                    } }
                                break;
                            } }
                        break;
                    } }



                satirSayisi++;//ince kalın yazdırmak için 
             
                yazi = sw.ReadLine();
               
            }

            sw.Close();
            fs.Close();

        }
    }
}
