using System.Collections.Generic;



namespace Addresses
{

    public class AddressBook

    {

        public Dictionary<string, Contact> DofContacts = new Dictionary<string, Contact>();
        public void AddContact(Contact obj)
        {
            DofContacts.Add(obj.Email, obj);
        }
        public Contact GetByEmail(string email)
        {
            foreach (KeyValuePair<string, Contact> contact in DofContacts)
            {
                if (contact.Key == email)
                {
                    return contact.Value;
                }
            }
            return null;
        }



    }
}