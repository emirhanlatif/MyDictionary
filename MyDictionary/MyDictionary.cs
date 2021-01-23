using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<P,S>
    {
        P[] plaka;
        S[] sehir;
        public MyDictionary()
        {
            plaka = new P[0];
            sehir = new S[0];
        }
        P[] tempplaka;
        S[] tempsehir;
        public void Add(P plakas,S sehirs)
        {
            tempplaka = plaka;
            tempsehir = sehir;
            plaka = new P[plaka.Length + 1];
            sehir = new S[sehir.Length + 1];
            for (int i = 0; i < tempplaka.Length; i++)
            {
                plaka[i] = tempplaka[i];
            }
            for (int i = 0; i < tempsehir.Length; i++)
            {
                sehir[i] = tempsehir[i];
            }

            plaka[plaka.Length - 1] = plakas;
            sehir[sehir.Length - 1] = sehirs;
        }
        public void Yazdir()
        {
            for (int i = 0; i < plaka.Length; i++)
            {
                Console.WriteLine("Plaka: " + plaka[i] +"---" +" Sehir: " + sehir[i]);
            }
        }
        public void Say()
        {
            Console.WriteLine(plaka.Length);
        }
    }
}
