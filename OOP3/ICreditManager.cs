using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager  //interface şablon görevi görüyor. Eğer ki birisi bu interface'i kullanırsa o tüm metodları içermek zorunda. //Interface (Şablon, arayüz)
    {
        void Calculate();
    }

    //interface'leri genelde operasyonel kullanırız.
    //interface'leri birbirlerinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
}
