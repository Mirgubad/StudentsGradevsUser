using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class User
    {
         



        public string Name;
        public string SurName;
        public string UserName;
        public string Password;



        public virtual void GetGrade()
        {
            Console.WriteLine("It is not Student");

        }


    }
}