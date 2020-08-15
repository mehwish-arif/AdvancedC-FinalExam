using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> g = new Generic<int>();
            g.Add(10);
            g.Add(20);
            g.Add(30);
            g.Add(40);
            Console.WriteLine(g.get());
            Console.WriteLine(g.get());
            Console.WriteLine(g.get());
            Console.WriteLine(g.get());
            Console.ReadLine();
        }
    }

    public class Generic<T> where T : struct

    {
        private T[] myArr ;
        private int position =0;
        private int getposition=0;

        public Generic()
        {
            myArr = new T[50];
        }

        public void Add(T item)
        {
            myArr[position] = item;
            position++;
        }

        public T get ()
        {
          
                T item = myArr[getposition];
                getposition++;
           
                return item;
        }
      
        }

    }

