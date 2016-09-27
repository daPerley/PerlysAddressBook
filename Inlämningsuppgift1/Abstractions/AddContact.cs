using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AddressBook.Abstractions
{
    class AddContact
    {
        static Form1 aBook = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public static void ValidateContact()
        {
            bool isNameOk = Validation.NameCheck(aBook.txtName.Text);
            bool isEmailOk = Validation.EmailCheck(aBook.txtEmail.Text);
            bool isPhoneOk = Validation.PhoneCheck(aBook.txtPhone.Text);
            bool isZipOk = Validation.ZipCeck(aBook.txtZip.Text);

            if (isEmailOk && isPhoneOk && isZipOk && isNameOk)
            {
                ClearErrors();
                Add();
                ContactList.UpdateContactList();
                ClearForm();
            }
        }

        public static void ClearErrors()
        {
            aBook.errorProviderName.Clear();
            aBook.errorProviderEmail.Clear();
            aBook.errorProviderPhone.Clear();
            aBook.errorProviderZip.Clear();
        }

        public static void Add()
        {
            var myContacts = XDocument.Load(Constants.pathToXml);

            myContacts.Element("Contacts").Add(new XElement("Contact",
                new XElement("Name", aBook.txtName.Text),
                new XElement("Email", aBook.txtEmail.Text),
                new XElement("Phone", aBook.txtPhone.Text),
                new XElement("Street", aBook.txtStreet.Text),
                new XElement("Zip", aBook.txtZip.Text),
                new XElement("Town", aBook.txtTown.Text)
                ));

            myContacts.Save(Constants.pathToXml);
        }

        public static void ClearForm()
        {
            aBook.txtName.Clear();
            aBook.txtEmail.Clear();
            aBook.txtPhone.Clear();
            aBook.txtStreet.Clear();
            aBook.txtZip.Clear();
            aBook.txtTown.Clear();
        }
    }
}
