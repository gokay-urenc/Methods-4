using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] methoddan_gelen = Method(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            label2.Text = methoddan_gelen[0].ToString();
            label3.Text = methoddan_gelen[1].ToString();
        }

        double[] Method(double sayi1, double sayi2)
        {
            double[] sonuclar = new double[2];
            sonuclar[0] = sayi1 / sayi2;
            sonuclar[1] = sayi1 % sayi2;
            return sonuclar;
        }
    }
}
// Parametre olarak gönderilen 2 sayının bölümünü ve bölümden kalanını veren method.
// 3 tane slash methodun üstüne bırakılırsa (///) açıklama bölümü gelir.

/// <summary>
/// 
/// </summary>
/// <param name="sayi1">İşlem Yapılacak 1. Sayı</param>
/// <param name="sayi2">İşlem Yapılacak 2. Sayı</param>
/// <returns>Dizi olarak double tipinde bir sonuç döner.</returns>