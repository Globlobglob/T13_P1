using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_P1
{


    
    class Program
    {
        static void N()
        {
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {

            
            Student s1 = new Student("Abebsandr",5,20,"Painter");s1.ShowInfo();

           // Console.WriteLine(s1.ToString());s1.ShowInfo();

            Console.WriteLine("");

            Student s2 = new Student("Saha", 2, 15, "Bebra");s2.ShowInfo(); N(); s2.ShowInfo(); N(); s2.ShowInfo();
            // Console.WriteLine($"{s2.ToString()}");
            N();
            Avto avto = new Avto("grey",120,"BMW");
            Console.WriteLine(avto.ToString());
            N();

            Tovar t1 = new Tovar("Apple",10,5);
            t1.Cena();

            Console.ReadKey();
        }
    }
}
