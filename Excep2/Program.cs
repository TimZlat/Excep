using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excep2
{
    class Program
    {
        static void M1(int x, int y, int z)
        {
            try
            {
                int a = checked((int)Math.Pow(x, y));
                Console.WriteLine("x^y/z = {0}", a / z);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZero Exception detected!!");
            }
            Console.WriteLine("M1 finished");
        }
        static void M2(int x, int y, int z)
        {
            try
            {
                M1(x, y, z);
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Arithmetic Exception detected");
            }
            Console.WriteLine("M2 finished");
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("y = ");
                int y = int.Parse(Console.ReadLine());
                Console.Write("z = ");
                int z = int.Parse(Console.ReadLine());
                M2(x, y, z);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.GetType().Name+":\n "+exp.Message);
            }
            
            Console.WriteLine("Для завершения нажмите любую клавишу ...");
            Console.ReadKey();
        }
    }
}
