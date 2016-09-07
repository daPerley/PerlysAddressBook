using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AddressBook.Classes
{
    class CurrentContact
    {
        static Form1 aBook = Application.OpenForms.OfType<Form1>().FirstOrDefault();

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
            }
            catch (System.Exception)
            {
                
            }

        }

        public static void SaveChanges() // Make this work
        {
            var myContacts = XDocument.Load(Constants.pathToXml);

            var changedContact = myContacts.Descendants("Contact").Where(aa => aa.Element("Name").Value == aBook.txtCName.Text);

            myContacts.Element("Name").Value = aBook.txtCName.Text;
            myContacts.Element("Email").Value = aBook.txtCEmail.Text;
            myContacts.Element("Phone").Value = aBook.txtCPhone.Text;
            myContacts.Element("Street").Value = aBook.txtCStreet.Text;
            myContacts.Element("Zip").Value = aBook.txtCZip.Text;
            myContacts.Element("Town").Value = aBook.txtCTown.Text;
            myContacts.Save(Constants.pathToXml);
        }

        public static void DeleteContact()
        {
            var myContacts = XDocument.Load(Constants.pathToXml);

            myContacts.Descendants("Contact").Where(aa => aa.Element("Name").Value == aBook.txtCName.Text).Remove();
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
