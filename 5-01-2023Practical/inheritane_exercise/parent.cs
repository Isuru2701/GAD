using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritane_exercise
{
    class Father
    {
        public string house = "12/31 Rds.HQufaf";
        protected string carModel = "idgaf";
        internal string surname = "fml";
        private double account_balance = 69420;

        public void DisplayDetails()
        {
            Console.WriteLine("House: " + house + "\ncar model: " + carModel + "\nsurname: " + surname + "\naccount balance: " + account_balance);
        }
    }

    class Child : Father
    {
        public string degree = "kms", name = "fakwgfwau";

        public void DisplayDetails()
        {
            Console.WriteLine("House: " + house + "\ncar model: " + carModel + "\nname: " + name + "\nsurname: " + surname + "\ndegree: " + degree);
        }
    }
    internal class parent
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.DisplayDetails();
            Console.ReadKey();
        }
    }
}
