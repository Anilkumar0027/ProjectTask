using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRlib;
namespace ArrayList
{
    class Collections
    {   

        static void Main(string[] args)
        {
            SortedList st10 = new SortedList();
            st10.Add("Mark",10);
            st10.Add("Marks",98);
            IDictionaryEnumerator ie1 = st10.GetEnumerator();
            while (ie1.MoveNext())
            {
                Console.WriteLine(ie1.Key + " " + " " + ie1.Value);
            }
            Console.WriteLine("=======================");

            SortedDictionary<int, string> srtdy = new SortedDictionary<int, string>();
            srtdy.Add(1, "Pavan");
            srtdy.Add(2, "Vijay");
            srtdy.Add(3, "Sai");
            srtdy.Add(4, "Potti");
            foreach (var item in srtdy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            srtdy.Remove(2);
            foreach (var item in srtdy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=======================");
            SortedList s1 = new SortedList();
            s1.Add("Number", 1);
            s1.Add("Second", 2);

            ICollection keys = s1.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===============");
            ICollection Values = s1.Values;
            foreach (var item in Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("====================");
            IDictionaryEnumerator ie = s1.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key+" "+ie.Value);
            }

            Console.WriteLine("================");

            Stack st = new Stack();
            st.Push(100);
            st.Push(200);
            st.Push(300);
            st.Push(400);
            st.Push(600);

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================");
            Stack cl1 = (Stack)st.Clone();
            st.Push(900);
            foreach (var item in cl1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================");

            Queue q1 = new Queue();
            q1.Enqueue(90);
            q1.Enqueue(80);
            q1.Enqueue(70);
            q1.Peek();
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================");
            Console.WriteLine("========SortedDictionary==========");
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
                sd.Add(10, "Anil");
            sd.Add(20, "kumar");
            sd.Add(30, "Nallanukala");
            sd.Add(40, "kumari");
            foreach (var item in sd) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================");
            Console.WriteLine("=========SortedSet=========");

            SortedSet<int> si = new SortedSet<int>();
            si.Add(59);
            si.Add(34);
            si.Add(20);
            si.Add(69);
            foreach (var item in si)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================");
            si.Remove(34);
            foreach (var item in si)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Number of itms in sortedset");
            int cnt = si.Count();
            Console.WriteLine(cnt);
            Console.WriteLine("==================");
            Console.WriteLine("=========SortedSet with strings=========");

            SortedSet<string> ss = new SortedSet<string>();
            ss.Add("Anil");
            ss.Add("uday");
            ss.Add("pavan");
            foreach (var item in ss)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================");
            int cntt = ss.Count();
            Console.WriteLine(cntt);

            




            Console.ReadLine();
        }
    }
}
