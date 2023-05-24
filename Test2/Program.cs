using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một đối tượng Dog
            Chicken d = new Chicken();

            // Tạo một đối tượng Cat
            Pig c = new Pig();

            // Gọi phương thức Speak của d và c
            d.Speak();
            c.Speak();
        }
    }
}
