using Business.Concrete;
using Entities.Concrete;
using System;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "A";
            person1.LastName = "D";
            person1.DateOfBirthYear = 1991;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }
    }

}
