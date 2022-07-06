using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Sharp
{
    internal class Program
    {
        static private Dictionary<int, Terminal> terminals = new()
        {
            { 1, new Terminal(1) },
            { 2, new Terminal(2) },
            { 3, new Terminal(3) },
            { 4, new Terminal(4) }
        };
        static private Dictionary<int, LandingStrip> strips = new()
        {
            { 1, new LandingStrip(1) },
            { 2, new LandingStrip(2) },
            { 3, new LandingStrip(3) },
            { 4, new LandingStrip(4) }
        };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Terminal term = new();
            LandingStrip ls = new();
            foreach (var el in terminals)
            {
                if (el.Key == 1) term = el.Value;
            }
            foreach (var el in strips)
            {
                if (el.Key == 2) ls = el.Value;
            }
            Console.WriteLine("Перший літак:");
            Plane SamPlane = new Plane("Sam");
            Dispatcher disp = new Dispatcher(term, ls);
            term.SetTerminal(SamPlane);
            foreach (var el in terminals)
            {
                if (el.Key == 3) term = el.Value;
            }
            Console.WriteLine("Другий літак:");
            Plane MikePlane = new Plane("Mike");
            disp = new Dispatcher(term, ls);
            ls.SetLandingStrip(MikePlane);
            Console.WriteLine(SamPlane);
            Console.WriteLine(MikePlane);
        }
    }
}
