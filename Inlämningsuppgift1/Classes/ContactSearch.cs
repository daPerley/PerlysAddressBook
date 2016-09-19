using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AddressBook.Classes
{
    class ContactSearch
    {
        static Form1 aBook = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public static List<Contact> searchList = new List<Contact>();

        public static void NewSearch()
        {
            searchList.Clear();
            aBook.lstSearchResult.Items.Clear();

            SearchContacts();
        }

        public static void SearchContacts()
        {
            var searchKey = aBook.txtSearch.Text;

            foreach (var contact in ContactList.contactList)
            {
                foreach (PropertyInfo propertyInfo in contact.GetType().GetProperties())
                {
                    if (propertyInfo.CanRead)
                    {
                        var firstValue = propertyInfo.GetValue(contact, null).ToString();

                        if (firstValue.ToLower().Contains(searchKey.ToLower()))
                        {
                            MatchFound(contact);
                            break;
                        }
                    }
                }
            }

            if (searchList.Count == 0)
            {
                aBook.lstSearchResult.Items.Insert(0, "No matches found");
            }
            aBook.lstSearchResult.Show();
        }

        public static void MatchFound(AddressBook.Classes.Contact contact)
        {
            var searchContact = new Contact();

            searchContact.Name = contact.Name;
            searchContact.Email = contact.Email;
            searchContact.Phone = contact.Phone;
            searchContact.Street = contact.Street;
            searchContact.Zip = contact.Zip;
            searchContact.Town = contact.Town;

            searchList.Add(searchContact);
            aBook.lstSearchResult.Items.Add(contact.Name);
        }
    }
}
