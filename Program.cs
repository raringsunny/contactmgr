using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contactmgr
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Contact contact = new Contact();


            Console.WriteLine(contact.GetContactById("manoj"));
        }
    }
}
