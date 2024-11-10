using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSTRONG_SAYISI_BULMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Armstrongsayi(int sayi) 
        {
            int girilensayi = sayi;
            int toplam = 0;
            int basamaksayisi = sayi.ToString().Length;
            
            for(int i=0; i< basamaksayisi; i++) 
            {
                int basamak = sayi % 10;

                int kuvvetal = 1;
                for(int j=0; j<basamaksayisi; j++) 
                {
                    kuvvetal *= basamak;
                
                }
                toplam = toplam + kuvvetal;
                sayi /= 10;

            
            }
            if (girilensayi == toplam) 
            {
                listBox1.Items.Add(girilensayi + "= Girdiğiniz Sayı Bir Armstrong Sayısıdır.");
            
            }
            else 
            {
                listBox1.Items.Add(girilensayi + "= Girdiğiniz Sayı Bir Armstrong Sayısı Değildir.");
            
            }
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            Armstrongsayi(sayi);
        }
    }
}
