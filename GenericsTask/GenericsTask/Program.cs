using System;

namespace GenericsTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Lemon<char> lemons = new Lemon<char>("Lemon",'C');
            Console.WriteLine(lemons);

            Pineapple<string> pineapple = new Pineapple<string>("Pineapple", "B3");
            Console.WriteLine(pineapple);


            BaskerList<string, string> fruitData = new BaskerList<string, string>();
            fruitData.Add("Orange","C");
            fruitData.Add("Bananas", "K");
            fruitData.Add("Kiwi", "B6");
            fruitData.Add("Cherry", "E");
            fruitData.Add("Grape", "PP");

            for(int i = 0; i < fruitData.GetFruits().Length;i++)
            {
                Console.WriteLine($"Name: {fruitData.GetFruits()[i]}, Vitamin: {fruitData.GetVitamins()[i]} ");
            }
        }
    }
}
