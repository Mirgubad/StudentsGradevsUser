using System;

namespace User
{
    class Student : User
    {

        public Student(string UserName, string Password, string Surname, int Grade, string Name)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.SurName = Surname;
            this.Name = Name;
            this.Grade = Grade;
        }
        public int Grade;


        public override void GetGrade()
        {
            Console.WriteLine(Grade);
        }

    }
}