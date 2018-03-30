using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otoparkOtomasyon2
{
    public partial class Form1 : Form
    {
        Kat1 q = new Kat1(15);
        Kat2 b = new Kat2();
        BodrumKat stk = new BodrumKat(15);
        int sayac0 = 0, sayac1 = 0, sayac2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBodrumEkle_Click(object sender, EventArgs e)
        {
            Araba a = new Araba();
            a.Renk = txtRenk.Text;
            stk.Push(a);
            if (sayac2 == stk.size - 1)
                sayac2 = 0;
            lBoxBodrum.Items.Add(stk.Listele(sayac2));
            sayac2++;
            //lBoxBodrum.Items.Add(txtRenk.Text);
        }

        private void btnKat1Ekle_Click(object sender, EventArgs e)
        {
            Araba a = new Araba();
            a.Renk = txtRenk.Text;
            q.Ekle(a);
            if (sayac0 == q.size - 1)
                sayac0 = 0;

            lBoxKat1.Items.Add(q.Listele());
            sayac0++;
            //lBoxKat1.Items.Add(txtRenk.Text);
        }

        private void btnKat2Ekle_Click(object sender, EventArgs e)
        {
            Araba a = new Araba();
            a.Renk = txtRenk.Text;
            b.Ekle(a);
            if (sayac1 == b.Size - 1)
                sayac1 = 0;
            lBoxKat2.Items.Clear();
            lBoxKat2.Items.Add(b.Listele());
            sayac1++;
            // lBoxKat2.Items.Add(txtRenk.Text);
        }
        //Remove Fonksiyonu Düzenlenip Listeye Doğru Yazdırılacak. BtnBodrumEKle --> Null Expection.
        private void btnCikar_Click(object sender, EventArgs e)
        {
            Random sayi = new Random();
            int secim = sayi.Next(0, 2);
            Araba cikarilan;
            if (secim == 0)
            {
                cikarilan = stk.Pop();
                q.Ekle(cikarilan);

                lBoxBodrum.Items.Remove(cikarilan.Renk);

                sayac0--;
            }
            else if (secim == 1)
            {
                sayac1++;

                if (sayac1 == q.size - 1)
                    sayac1 = 0;
                q.Cikar();
                lBoxKat1.Items.Clear();
                lBoxKat1.Items.Add(q.Listele());
                lBoxKat1.Items.RemoveAt(sayac1);

            }
            else
            {
                b.Cikar();
                lBoxKat2.Items.Clear();
                lBoxKat2.Items.Add(b.Listele());
                lBoxKat2.Items.RemoveAt(sayac2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
