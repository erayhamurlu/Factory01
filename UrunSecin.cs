using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory01
{
    class UrunSecin : Telefon
    {
        public string BilgiGoster()
        {
            return "Lütfen Bir Urun Seciniz";
        }
    }
}
