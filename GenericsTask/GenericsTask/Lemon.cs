using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTask
{
    class Lemon<V>
    {
        public string Name;
        public V View;

        public Lemon(string name,V view)
        {
            Name = name;
            View = view;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Vitamin view: {View}";
        }
    }
}
