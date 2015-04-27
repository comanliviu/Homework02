using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

           Employee Liviu= new Employee("Liviu","Coman","Octombrie","Noiembrie","UNU",30);
           
            Leave Concediu= new Leave("Decembrie", 10, "Concediu");
            Liviu.DisplayInfo();
            
            try
            {
                Liviu.AddNewLeave(Concediu, Liviu);
            }
            catch (Exception e) {

                
            };
            Liviu.DisplayInfo();
            Console.ReadLine();
            
               
        }
    }
}
