using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory01
{
    class Iphone8:Telefon
    {
        public string BilgiGoster()
        {
            return "Model: Iphone8  | Batarya: 3700Mah | Ekran: 7.2inc";
        }
    }
}
