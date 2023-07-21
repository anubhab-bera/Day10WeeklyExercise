using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(LargeDataCollection Collection = new LargeDataCollection(new int[] {1,2,3,4,5}))
            {
                //access and display elements
                Console.WriteLine("Accessing elements: ");
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Element at index {i}: {Collection.AccessElement(i)}");
                }
                //add and display element
                Collection.AddElement(6);
                Console.WriteLine($"Element at index 5: {Collection.AccessElement(5)}");
                //remove the element and display the updated list
                Collection.RemoveElement(3);
                Console.WriteLine("Updated collection: ");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Element at index {i}: {Collection.AccessElement(i)}");
                }
                //after using 'largedatacollection' object, call the "dispose" method explicitly
                Collection.Dispose();


            }
            Console.ReadKey();
        }
    }
}
