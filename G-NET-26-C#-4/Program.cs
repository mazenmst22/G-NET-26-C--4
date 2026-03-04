using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_C__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //string prodList = "";
            //for (int i = 0; i <= 5000; i++)
            //{
            //    prodList += $"Prod-{i},";

            //}
            //(a):
            //The problem here is thet we are creating a new string every time we concatenate, and that is very inefficient,
            //especially when we have a large number of iterations.
            //The Solutiion to this is to use a String builder that modifies
            //every time on the same string instead of making a new copy every time we concatenate.
            //(b): Solution Using StringBuilder
            //StringBuilder ProductList = new StringBuilder(50000);
            //for (int i = 0; i <= 5000; i++)
            //{
            //    ProductList.Append($"Prod-{i},");
            //}
            //string prodList = ProductList.ToString();
            //(c): Making a timer to compare both code :
            
            //Stopwatch sw = new Stopwatch();
            //Console.WriteLine("Starting Timer for 5000 iterations.");
            //GC.Collect();
            //sw.Start();
            //string prodList = "";
            //for (int i = 0; i <= 5000; i++)
            //{
            //    prodList += $"Prod-{i},";
            //}
            //sw.Stop();
            //int Time1 = (int)sw.ElapsedMilliseconds;
            //sw.Reset();
            //GC.Collect();
            //Console.WriteLine("Starting Timer for 5000 iterations (Using StringBuilder).");
            //sw.Start();
            //StringBuilder ProductList = new StringBuilder(50000);
            //for (int i = 0; i <= 5000; i++)
            //{
            //    ProductList.Append($"Prod-{i},");
            //}
            //string prodList2 = ProductList.ToString();
            //sw.Stop();
            //int Time2 = (int)sw.ElapsedMilliseconds;
            //Console.WriteLine($"Time taken for string concatenation: {Time1} ms ");
            //Console.WriteLine($"Time taken for StringBuilder concatenation: {Time2} ms ");


            #endregion



        }
    }
}
