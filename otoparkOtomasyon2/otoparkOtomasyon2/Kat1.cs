using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkOtomasyon2
{
    public class Kat1
    {
        public Araba[] Araba;
        public int front = -1;
        public int rear = -1;
        public int size = 0;
        public int count = 0;
        public Kat1 (int size)
        {
            this.size = size;
            Araba = new Araba[size];
        }

        public void Ekle(Araba a)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception(" KAT DOLU! ");

            if (front == -1)
                front = 0;

            if (rear == size - 1)
                rear = 0;
            else
                rear++;
            Araba[rear] = a;
            count++;
        }

        public void Cikar()
        {
            if (IsEmpty())
                throw new Exception(" KAT BOŞ! ");
            Araba[front] = null;
            front++;
            count--;

        }
        // front ile ilgili bir problem var. NULL Expection. File.
        public string Listele()
        {
            return Araba[front - 1].Renk;
        }
        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
