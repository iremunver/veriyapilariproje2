using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkOtomasyon2
{
    public class BodrumKat:Araba,IBodrum
    {
        private Araba[] Araba;
        private int Top = 0;
        public int size = 0;

        public BodrumKat(int size)
        {
            this.Araba = new Araba[size];
            this.size = size;
        }
        public void Push(Araba a)
        {
            if (Araba.Length == Top + 1)
            {
                throw new Exception("KAT DOLU!!");
            }
            Araba[Top++] = a;
        }

        public Araba Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("KAT BOŞ!!");
            }
            Araba temp = Araba[Top--];
            Araba[Top++] = null;
            Top -= 1;
            return temp;
        }
        public string Listele(int a)
        {
            return Araba[a].Renk;
        }
        public bool IsEmpty()
        {
            return Top == 0 ? true : false;
        }
    }
}
