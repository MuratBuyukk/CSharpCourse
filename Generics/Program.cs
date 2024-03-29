﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Ankara");
            cities.Add("Ankara");

            Console.WriteLine(cities.Count);

            MyList<string> cities2 = new MyList<string>();
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");

            Console.WriteLine(cities2.Count);
           
            MyList<int> numbers = new MyList<int>(1,2,3,4,5,6,1,2,3);
            
            Console.WriteLine(numbers.Count);
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }

        public MyList(params T[] items)
        {
            _array = new T[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                _array[i] = items[i];
            }
        }


        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for(int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length-1] = item;
        }


        public int Count
        {
            get { return _array.Length; }
        }

    }
}
