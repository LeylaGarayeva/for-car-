using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12._05._2017;

namespace _12._05._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars petrol = new Cars();
            petrol.FuelUsage = 1;
            //petrol.fuelCurrent = 10;
            double s = Convert.ToDouble(Console.ReadLine());
           double qaliq = petrol.ferq(s);
            

            
            petrol.possibleDistance();
            Console.Write("Ne qeder yol gedeceksiniz?");
            double uzunluq = Convert.ToDouble(Console.ReadLine());
            if (petrol.checkDistance(uzunluq)) // checkDistance(double km) ile gosterilmelidir cars.cs
            {
                Console.WriteLine("Ugurlar, yolunuza davam ede bilersiniz");
              
            }
            else
            {
                
                Console.Write("Bu yolu getmek ucun kifayet qeder benzininiz yoxdur,Neche litr benzin doldurmaq istediyinizi daxil edin:");
                double litr = Convert.ToDouble(Console.ReadLine());
                if (petrol.checkFuelAviable(litr))
                {
                    Console.WriteLine("Benzin dolduruldu");
                  
                }
                else
                {
                    Console.WriteLine("Istediyiniz qeder benzin umumi yanacaq cheninin hecminden" + " " +  qaliq+ " " + "litr coxdur ");
                    
                    
                }
            
            }
            
            Console.ReadKey();
        }
    }
}
