using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace contactmgr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Contact objContact = new Contact();
            try
            {
                        

                        objContact.FirstName = "Manoj";
                        objContact.LastName = "Mohan";
                        objContact.Email = "mmohan@xebia.com";
                        objContact.Phone = "9686569319";

                        Console.WriteLine(objContact.Save(objContact));
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
            finally
            {
                objContact = null;
            }

        }
    }
}
