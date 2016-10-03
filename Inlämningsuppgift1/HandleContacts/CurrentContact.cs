using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using AddressBook.Configures;
using AddressBook.LogExceptions;
using AddressBook.Validation;

namespace AddressBook.HandleContacts
{
    class CurrentContact
    {
        static Form1 aBook = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        static string currentEmail;

        public static void ShowCurrent(int contactIndex)
        {
            try
            {
                aBook.txtCName.Text = ContactList.contactList[contactIndex].Name;
                aBook.txtCEmail.Text = ContactList.contactList[contactIndex].Email;
                aBook.txtCPhone.Text = ContactList.contactList[contactIndex].Phone;
                aBook.txtCStreet.Text = ContactList.contactList[contactIndex].Street;
                aBook.txtCZip.Text = ContactList.contactList[contactIndex].Zip;
                aBook.txtCTown.Text = ContactList.contactList[contactIndex].Town;
                
                currentEmail = ContactList.contactList[contactIndex].Email;
            }
            catch (Exception exception)
            {
                LogHandler.WriteToLog(exception);
            }

        }

        public static void ShowSearched(int contactIndex)
        {
            try
            {
                aBook.txtCName.Text = ContactSearch.searchList[contactIndex].Name;
                aBook.txtCEmail.Text = ContactSearch.searchList[contactIndex].Email;
                aBook.txtCPhone.Text = ContactSearch.searchList[contactIndex].Phone;
                aBook.txtCStreet.Text = ContactSearch.searchList[contactIndex].Street;
                aBook.txtCZip.Text = ContactSearch.searchList[contactIndex].Zip;
                aBook.txtCTown.Text = ContactSearch.searchList[contactIndex].Town;
                
                currentEmail = ContactSearch.searchList[contactIndex].Email;
            }
            catch (System.Exception)
            {

            }

        }

        public static void SaveChanges()
        {
            var myContacts = XDocument.Load(Constants.pathToXml);

            var changedContact = (from contact in myContacts.Root.Elements("Contact")
                                  where contact.Element("Email").Value == currentEmail
                                  select contact).Single();

                changedContact.Element("Name").Value = aBook.txtCName.Text;
                changedContact.Element("Email").Value = aBook.txtCEmail.Text;
                changedContact.Element("Phone").Value = aBook.txtCPhone.Text;
                changedContact.Element("Street").Value = aBook.txtCStreet.Text;
                changedContact.Element("Zip").Value = aBook.txtCZip.Text;
                changedContact.Element("Town").Value = aBook.txtCTown.Text;

                myContacts.Save(Constants.pathToXml);

                currentEmail = aBook.txtCEmail.Text;
            
        }

        public static void DeleteContact()
        {
            var myContacts = XDocument.Load(Constants.pathToXml);

            myContacts.Descendants("Contact").Where(aa => aa.Element("Email").Value == aBook.txtCEmail.Text).Remove();
            myContacts.Save(Constants.pathToXml);
        }

        public static void ClearCurrentContact()
        {
            aBook.txtCName.Text = null;
            aBook.txtCEmail.Text = null;
            aBook.txtCPhone.Text = null;
            aBook.txtCStreet.Text = null;
            aBook.txtCZip.Text = null;
            aBook.txtCTown.Text = null;
        }
    }
}
