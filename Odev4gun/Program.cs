using System;

namespace Odev4gun
{
    class Program
    {
        static void Main(string[] args)
        {
            List liste1 = new List() { Id = 1, Name = "Ayşe" };
            List liste2 = new List() { Id = 2, Name = "Fatma" };
            List liste3 = new List() { Id = 3, Name = "Meryem" };

            MyDictionary<int, string> mydictionary = new MyDictionary<int, string>();

            mydictionary.Add(liste1.Id, liste1.Name);
            mydictionary.Add(liste2.Id, liste2.Name);
            mydictionary.Add(liste3.Id, liste3.Name);

                Console.WriteLine("Toplam : " + mydictionary.Count);

            mydictionary.ShowList();
        }
    }
}
