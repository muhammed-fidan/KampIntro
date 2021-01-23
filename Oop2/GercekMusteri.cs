using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Individual 
    class GercekMusteri: Musteri  //miras = inheritance 'ın asıl olayı: "Musteri de olan özellikler artık GercekMusteridede vardır."
    {
     
        public string IdentityNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
    }
}
