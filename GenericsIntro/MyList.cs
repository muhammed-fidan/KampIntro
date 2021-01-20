using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T type demek. Kodu bana bir tip ver olarak okuyabiliriz.
    {
        T[] items;
        //constructor: newlediğiniz anda çalışan classa denir.
        public MyList()          // ctor and tab tab.
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length +1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
