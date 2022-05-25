using System;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zehmet olmasa Istifadeci Adini ve Sifreni daxil edin");
            Console.Write("Istifadeci adi:");
            string username = Console.ReadLine();
            Console.Write("Istifadeci Sifresi:");
            string password = Console.ReadLine();

            User arif = new User { Name = "Arif", UserName = "Arif99", SurName = "Quliyev", Password = "Arif21" };
           
            Student elvin = new Student("Elvin97", "Elvin12", "Ibrahimovic", 89, "Elvin");
             
           Student faiq = new Student ("Faiq20", "Faiq321", "Eliyev", 95, "Faiq");
            
            User[] students = { arif, elvin,faiq };
            
            foreach (var user in students)
            {
                if (user.UserName == username && user.Password == password)
                {
                  
                   user.GetGrade();
                }
             
            } 


        }



    }
}
