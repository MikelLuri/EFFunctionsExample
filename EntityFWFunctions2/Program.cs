using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFWFunctions2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyContext())
            {
                var people = context.Persons.ToList();

                foreach(var person in people)
                {
                    Console.WriteLine(person.FirstName + " " + person.LastName);
                }
            }
        }
    }
}
