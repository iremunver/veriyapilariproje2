using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkOtomasyon2
{
    public class Kat2:Node
    {
        public Node Head;
        public int Size = 0;
        int count = 0;

        public int Josephus(int n)
        {
            int x, y = 0;
            for (x = 2; x <= n; x++)
                y = (y + 2) % x;

            return y + 1;

        }
        //  public new Araba[] Araba;

        public void Ekle(Araba a)
        {
            Node tmpHead = new Node
            {
                Araba = a
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }
        public string Listele()
        {
            string temp = "";
            Node listelenecek = Head;

            int i = 0;
            while (i < Size)
            {
                temp += " " + listelenecek.Araba.Renk;
                listelenecek = listelenecek.Next;
                i++;
            }

            return temp;
        }
        public Araba Cikar()
        {
            Node simdiki = null;
            Node cikarilan = null;
            int pozisyon = Josephus(count);
            Node onceki = null;

            simdiki = Head;
            while (simdiki != null)
            {
                simdiki = simdiki.Next;
                for (int i = 0; i < pozisyon; i++)
                {
                    if (Head != null && Head.Next != null)
                        if (i == pozisyon - 2)
                        {
                            onceki = cikarilan.Next;

                        }
                    if (cikarilan.Next == null)
                    {
                        onceki.Next = Head;
                    }
                }
            }
            cikarilan = onceki.Next;
            Size--;
            return cikarilan.Araba;
        }
    }
}
