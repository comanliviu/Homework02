using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
   public  class Leave
    {
        public string StartingDate;
        public int  Duration;
        public string LeaveType;
        public  Employee employee;

       public Leave (string startingdate,int duration,string leavetype)
       {
           this.StartingDate =startingdate ;
           this.Duration = duration;
           this.LeaveType = leavetype;
       }
    }
}
