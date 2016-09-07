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
        public static List<string> searchResult = new List<String>();

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
                            searchResult.Add(contact.Name);
                            break;
                        }
                    }
                }
            }
        }

        //Fix so the searchresult get written out
    }
}
