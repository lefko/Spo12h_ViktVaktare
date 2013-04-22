using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViktVaktare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPointsDish> matratter = new List<IPointsDish>();

            matratter.Add(new BiffStroganoff());
            matratter.Add(new FriteradAnka());
            matratter.Add(new BiffStroganoff());
            matratter.Add(new Tartbit());

            foreach (IPointsDish ip in matratter)
            {
                Console.WriteLine(ip.ToString() + ", " + ip.SumPoints() + " points\n");
            }

            Console.ReadLine();

        }
    }
}
