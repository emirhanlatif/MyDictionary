using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> X = new MyDictionary<int, string>();
            X.Add(1, "Adana");
            X.Add(2, "Adıyaman");
            X.Add(3, "Afyon");
            X.Add(34, "İstanbul");
            X.Add(53, "Rize");
            X.Yazdir();
            X.Say();             
        }
    }
}
