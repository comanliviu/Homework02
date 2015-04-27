using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Employee : Person
    {
        protected string DateofEmployment;
        protected string Salary;
        protected int  AvailableDaysOff;

        public Employee(string lastname, string firstname, string dateofbirth, string dateofemployment, string salary, int availabledaysoff)
        {
            this.LastName = lastname;
            this.FirstName = firstname;
            this.DateofBirth = dateofbirth;
            this.DateofEmployment = dateofemployment;
            this.Salary = salary;
            this.AvailableDaysOff = availabledaysoff;
        }
        public void DisplayInfo()
        {

            Console.WriteLine(FirstName + " "  + LastName + " Salary:" + Salary + " Available days:" + AvailableDaysOff);
        }


       private void SubstractDays(int AvailableDaysOff,int duration)
        {
          

         
               this.AvailableDaysOff = this.AvailableDaysOff- duration;
          
        }

        public void AddNewLeave(Leave daysoff, Employee employee)
        {



            if (employee.AvailableDaysOff < daysoff.Duration)
                throw new NegativeLeaveDays("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
            else {
                SubstractDays(employee.AvailableDaysOff, daysoff.Duration);
                daysoff.employee = employee;
            }
         
        }
       



    }
}
