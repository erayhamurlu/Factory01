using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory01
{
    class Iphone6:Telefon
    {
        public string BilgiGoster()
        {
            return "Model: Iphone6  | Batarya: 3500Mah | Ekran: 6inc";
        }
    }
}
