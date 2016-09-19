using AddressBook;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AddressBook.Classes
{
    class Validation
    {
        static Form1 aBook = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public static bool EmailCheck(string email)
        {
            if ((email.Count(x => x == '@')) == 1 && (email[email.Length - 4] == '.' || email[email.Length - 3] == '.') /*&& Regex.IsMatch(email, @"!^[\s ]+$")*/)
            {
                return true;
            }
            else
            {
                aBook.errorProviderEmail.SetError(aBook.txtEmail, "The email entered isn't valid!");
                return false;
            }
        }

        public static bool PhoneCheck(string phone)
        {
            if (Regex.IsMatch(phone, "^[0-9 ]+$"))
            {
                return true;
            }
            else
            {
                aBook.errorProviderPhone.SetError(aBook.txtPhone, "The phone number isn't valid! Please only use numbers.");
                return false;
            }
        }

        public static bool ZipCeck(string zip)
        {
            if (Regex.IsMatch(zip, "^[0-9 ]+$") && (zip.Length <= 5))
            {
                return true;
            }
            else
            {
                aBook.errorProviderZip.SetError(aBook.txtZip, "The zip entered isn't valid!");
                return false;
            }
        }
    }
}
