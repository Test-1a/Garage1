using System.Collections;
using System.Collections.Generic;

namespace Garage1
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public string Name { get; set; }
        private Vehicle[] vehicles;

        public Garage(string name, int v)
        {
            Name = name;
            vehicles = new Vehicle[v];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in vehicles)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}