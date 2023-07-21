using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyExercise
{
    public class LargeDataCollection : IDisposable
    {
        private List<int> data;
        //constructor to initialize the collection with initial data

        public LargeDataCollection(IEnumerable<int> initialData) 
        {
            data = new List<int>(initialData);
            
        }
        //method to add elements in the collection
        public void AddElement(int element)
        {
            data.Add(element);
        }
        //method to remove collection from the collection

        public void RemoveElement(int element)
        {
            data.Remove(element);
        }
        //method to access the element in the collection

        public int AccessElement(int index)
        {
            if(index >= 0 && index < data.Count)
            {
                return data[index];
            }
            throw new IndexOutOfRangeException("Index is out of range");

        }
        //implement the dispose method to release resources and free up memory

        public void Dispose()
        {
            //release any unmanaged resource here 
            //set the internal data structure to null to free up memory
            data = null;
        }
    }
}
