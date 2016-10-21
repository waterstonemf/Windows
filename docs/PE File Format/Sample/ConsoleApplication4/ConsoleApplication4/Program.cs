using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication4
{
   [Flags]
    enum NodeType
    {
        None = 0,
        Single = -1,
        Double = -2,
        Three = -4
    }
    class Program
    {
        static void Main(string[] args)
        {
            NodeType t = NodeType.Single | NodeType.Three;

            if (t == NodeType.None)
            {
                Console.WriteLine("Hello None");
            }else
            {
                Console.WriteLine(t.ToString());
            }

            Console.Read();
        }
    }
}
