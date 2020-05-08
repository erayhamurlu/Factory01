using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory01
{
    class Iphone7:Telefon
    {
        public string BilgiGoster()
        {
            return "Model: Iphone7  | Batarya: 3600Mah | Ekran: 7inc";
        }
    }
}
