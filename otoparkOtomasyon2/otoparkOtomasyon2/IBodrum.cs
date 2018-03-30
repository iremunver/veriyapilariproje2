using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkOtomasyon2
{
    public interface IBodrum
    {
        void Push(Araba a);
        Araba Pop();
        bool IsEmpty();
    }
}
