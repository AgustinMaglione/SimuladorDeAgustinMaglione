using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeAgustinMaglione
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int horas, minutos, secons;
                string selecc;
                Console.WriteLine("Ingrese la hora:");
                horas =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese los minutos:");
                minutos = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese los segundos:");
                secons = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese si es Pm o Am:");
                selecc = Console.ReadLine();


                if (horas <= 13 && minutos < 61 && secons < 61)
                {
                    if (selecc.ToUpper() == "AM")
                    {
                        Console.Write($" {horas} { minutos}  {secons} Es Am ");
                    }
                    if (selecc.ToUpper() == "PM")
                    {
                        Console.Write($"{horas + 12} {minutos} {secons} Es Pm ");
                    }
                }
                else
                {
                    Console.Write(" se ingreso mal la hora, intente de nuevo");
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("fomrsto incorrecto"); 
            }

            Console.ReadLine();
            
        }

        //private static int controlarHoras(string v)
        //{
           
        //    if (v!= 

        //    {

        //    }
        //}
    }
}

