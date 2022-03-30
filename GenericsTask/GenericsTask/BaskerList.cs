using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTask
{
    class BaskerList<F,V>
    {
        public F[] Fruits;
        public V[] Vitamins;

        public BaskerList()
        {
            Fruits = new F[0];
            Vitamins = new V[0];
        }

        public F[] GetFruits()
        {
            return Fruits;
        }
        public V[] GetVitamins()
        {
            return Vitamins;
        }

        public void Add(F fruits, V vitamins)
        {
            Array.Resize(ref Fruits, Fruits.Length + 1);
            Fruits[Fruits.Length - 1] = fruits;

            Array.Resize(ref Vitamins, Vitamins.Length + 1);
            Vitamins[Vitamins.Length - 1] = vitamins;
        }

        
    }
}
