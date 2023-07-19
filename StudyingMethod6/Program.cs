using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingMethod6
{
    internal class Program
    {
        static void Identitiy(string name, int age )
        {
            Console.WriteLine(name + " " + "Flower" + " " + "is" + " " + age + " " + "years old");
        }
        static void Main(string[] args)
        {
            Identitiy("Sam",22);
            Identitiy("Lucy",33);
            Identitiy("Carol",38);
            Identitiy("Jimy",36);

            Console.ReadLine();

        }
    }
}
