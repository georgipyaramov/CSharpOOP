using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64Project
{
    class Test
    {
        static void Main(string[] args)
        {
            var bitArr = new BitArray64(1256363556);
            for (int i = 0; i < 63; i++)
            {
                Console.Write(bitArr[i]);
            }
            Console.WriteLine();
        }
    }
}
