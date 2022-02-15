using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszog_kerulet_terulet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a_oldal = 0;
            int b_oldal = 0;
            int c_oldal = 0;
            try
            {
                
                Console.Write("Add meg az a oldalt(cm-ben): ");
                a_oldal = int.Parse(Console.ReadLine());

                Console.Write("Add meg a b oldalt(cm-ben): ");
                b_oldal = int.Parse(Console.ReadLine());

                Console.Write("Add meg a c oldalt(cm-ben): ");
                c_oldal = int.Parse(Console.ReadLine());

                if (a_oldal + b_oldal > c_oldal && a_oldal + c_oldal > b_oldal && b_oldal + c_oldal > a_oldal)
                {
                    int kerulet = a_oldal + b_oldal + c_oldal;
                    int s = kerulet / 2;
                    double terulet = Math.Sqrt(s * (s - a_oldal) * (s - b_oldal) * (s - c_oldal));//héron képlettel (https://profifelkeszito.net/a-haromszog-terulete-kerulete)
                    Console.WriteLine($"A háromszög kerülete: {kerulet}cm\n" +
                    $"A háromszög területe: {terulet}cm\xB2");
                    
                }
                else
                {
                    Console.WriteLine("A háromszög nem szerkezhető!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Nem megfelelő a karakter bemenet!\nKérlek inditsd újra a programot!");
            }
            catch (Exception err)
            {

                Console.WriteLine(err);
            }
            

            Console.ReadKey();
        }
    }
}
