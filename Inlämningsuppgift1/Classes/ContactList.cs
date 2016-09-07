using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AddressBook.Classes
{
    class ContactList
    {
        static Form1 aBook = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public static List<Contact> contactList = new List<Contact>();

        public class Contact
        {
            public string Name { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }

            public string Street { get; set; }

            public string Zip { get; set; }

            public string Town { get; set; }
        }

        public static void LoadContacts()
        {
            contactList.Clear();

            var myContacts = XDocument.Load(Constants.pathToXml);

            foreach (var cInfo in myContacts.Descendants("Contact"))
            {
                var contact = new ContactList.Contact();

                contact.Name = cInfo.Element("Name").Value;
                contact.Email = cInfo.Element("Email").Value;
                contact.Phone = cInfo.Element("Phone").Value;
                contact.Street = cInfo.Element("Street").Value;
                contact.Zip = cInfo.Element("Zip").Value;
                contact.Town = cInfo.Element("Town").Value;

                aBook.lstContacts.Items.Add(contact.Name);

                ContactList.contactList.Add(contact);
            }
        }

        public static void UpdateContactList()
        {
            var myContacts = XDocument.Load(Constants.pathToXml);
            myContacts.Save(Constants.pathToXml);
            aBook.lstContacts.Items.Clear();
            LoadContacts();
        }

    }
}
