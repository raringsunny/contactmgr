using System;

namespace contactmgr
{
    public class Contact
    {

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // public string Address{get; set;}


        public string GetContactById(string pContactName)
        {
            return pContactName;
            // return FirstName + ' ' + LastName;
        }
    }
}