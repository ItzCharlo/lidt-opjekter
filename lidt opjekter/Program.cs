using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidt_opjekter
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Area a1 = new Area();
            //a1.width = 20;
            //a1.length = 7;
            //a1.name = "Torben"

            a1.Color = MyColorEnum.Blue;
            a1.setname("Torben");
            Console.WriteLine(a1.getname());
           
            a1.Length = 20;
            int len = a1.Length;
            a1.Width = 12;

            Console.WriteLine(a1.ToString());

            Area a2 = new Area();
            a2.setname("Oliver");
            a2.Length = 34;
            a2.Width = 13;
            Console.WriteLine(a2);

            Area a3 = new Area(MyColorEnum.Red,"subarna", 16, 7);
            Console.WriteLine(a3);

            Area[] area = new Area[5];
            area[0] = a1;
            area[1] = a2;
            area[2] = a3;
            area[3] = new Area(MyColorEnum.Cyan,"Hansen", 3, 4);
            area[4] = new Area(MyColorEnum.Green,"Basuka", 456, 567);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("unsorted");

            foreach(Area a in area)
            {
                Console.WriteLine(a);
            }

            Array.Sort(area);
            Console.WriteLine("sorted: ");

            foreach( Area a in area)
            {
                Console.WriteLine(a);
            }

            //Array.Sort(area);

            //int result = a1.CompareTo(a2);

            //object o5 = new Area();
            //Area a5 = (Area)o5;
            //a5.GetSize();

            //////////////////////////////////////////////////////////////////
            ///CUBIC
            /////////////////////////////////////////////////////////////////

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("Now Cubics");
            
            Cubic c1 = new Cubic();
            c1.setname("Marko");
            c1.Height = 23;
            c1.Width = 17;
            c1.Length = 7;
            Console.WriteLine(c1.ToString()); ;

            Cubic c2 = new Cubic();
            c2.setname("Erik");
            c2.Height = 2333;
            c2.Width = 17;
            c2.Length = 7;
            Console.WriteLine(c2.ToString()); ;

            object[] objects = new object[8];
            objects[0] = c1;
            objects[1] = a1;
            objects[2] = c2;
            objects[3] = a2;
            objects[4] = a3;
            objects[5] = new Cubic(MyColorEnum.Yellow,"visar", 23, 45, 8);
            objects[6] = new Area(MyColorEnum.Magenta,"Joshi", 3, 4);
            objects[7] = new Cubic(MyColorEnum.Green,"aksel", 45, 75, 56);
            foreach (Object o in objects)
            {
                Console.WriteLine(o);
            }

            Console.ReadLine();
        }
    }
}