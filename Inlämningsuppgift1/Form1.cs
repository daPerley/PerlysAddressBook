using AddressBook.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Constants.pathToXml))
            {
                ContactList.LoadContacts();
            }
            else
            {
                //Create the xml doc
                XDocument myContacts = new XDocument(
                        new XElement("Contacts"));

                myContacts.Save(Constants.pathToXml);
            }
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentContact.ShowCurrent(lstContacts.SelectedIndex);
        }

        private void btnCSave_Click(object sender, EventArgs e) //Need to be fixed
        {
            CurrentContact.SaveChanges();
            ContactList.UpdateContactList();
        }

        private void btnCDelete_Click(object sender, EventArgs e)
        {
            CurrentContact.DeleteContact();
            CurrentContact.ClearCurrentContact();
            ContactList.UpdateContactList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddContact.ValidateContact();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            ContactSearch.NewSearch();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (Form1.ActiveForm.AcceptButton != btnSearch)
            {
                Form1.ActiveForm.AcceptButton = btnSearch;
            }
        }

        private void AddContactEnter_TextChanged(object sender, EventArgs e)
        {
            if (Form1.ActiveForm.AcceptButton != btnAdd)
            {
                Form1.ActiveForm.AcceptButton = btnAdd;
            }
        }

        private void lstSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentContact.ShowSearched(lstSearchResult.SelectedIndex);
            lstSearchResult.Hide();
        }
    }
}
