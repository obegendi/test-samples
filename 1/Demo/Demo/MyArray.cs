using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public class MyArray
    {
        private int[] Data { get; }

        public MyArray(IEnumerable<int> values)
        {
            Data = values.ToArray();
        }

        public int Maximum()
        {
            // Assume this.Data.Length > 0
            int max = 0; //this.Data[0]; // Uncomment to fix the bug

            for (int i = 1; i < this.Data.Length; i++)
            {
                if (this.Data[i] > max)
                {
                    max = this.Data[i];
                }
            }

            return max;
        }
    }
}
