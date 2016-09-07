namespace AddressBook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblAdresses = new System.Windows.Forms.Label();
            this.panAdd = new System.Windows.Forms.Panel();
            this.lblNStreet = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCSave = new System.Windows.Forms.Button();
            this.btnCDelete = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtCStreet = new System.Windows.Forms.TextBox();
            this.lblCName = new System.Windows.Forms.Label();
            this.txtCTown = new System.Windows.Forms.TextBox();
            this.lblCEmail = new System.Windows.Forms.Label();
            this.txtCZip = new System.Windows.Forms.TextBox();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.lblCStreet = new System.Windows.Forms.Label();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.lblCZip = new System.Windows.Forms.Label();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.lblCText = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddCon = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstSearchResult = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.lblContacts = new System.Windows.Forms.Label();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderZip = new System.Windows.Forms.ErrorProvider(this.components);
            this.panAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZip)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 266);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(38, 13);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "E-mail:";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 289);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone:";
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(12, 288);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 3;
            this.lblStreet.Text = "Street:";
            // 
            // lblZip
            // 
            this.lblZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(12, 334);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 4;
            this.lblZip.Text = "Zip:";
            // 
            // lblTown
            // 
            this.lblTown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(12, 358);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 5;
            this.lblTown.Text = "Town:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(57, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.AddContactEnter_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(57, 286);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(337, 20);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.TextChanged += new System.EventHandler(this.AddContactEnter_TextChanged);
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStreet.Location = new System.Drawing.Point(57, 309);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(337, 20);
            this.txtStreet.TabIndex = 9;
            this.txtStreet.TextChanged += new System.EventHandler(this.AddContactEnter_TextChanged);
            // 
            // txtZip
            // 
            this.txtZip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZip.Location = new System.Drawing.Point(57, 332);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(337, 20);
            this.txtZip.TabIndex = 10;
            this.txtZip.TextChanged += new System.EventHandler(this.AddContactEnter_TextChanged);
            // 
            // txtTown
            // 
            this.txtTown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTown.Location = new System.Drawing.Point(57, 355);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(337, 20);
            this.txtTown.TabIndex = 11;
            this.txtTown.TextChanged += new System.EventHandler(this.AddContactEnter_TextChanged);
            // 
            // lblAdresses
            // 
            this.lblAdresses.BackColor = System.Drawing.Color.Black;
            this.lblAdresses.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresses.ForeColor = System.Drawing.Color.White;
            this.lblAdresses.Location = new System.Drawing.Point(0, 0);
            this.lblAdresses.Name = "lblAdresses";
            this.lblAdresses.Size = new System.Drawing.Size(634, 50);
            this.lblAdresses.TabIndex = 12;
            this.lblAdresses.Text = "ADDRESSES";
            this.lblAdresses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panAdd
            // 
            this.panAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panAdd.Controls.Add(this.lblNStreet);
            this.panAdd.Controls.Add(this.lblName);
            this.panAdd.Controls.Add(this.txtName);
            this.panAdd.Controls.Add(this.btnCSave);
            this.panAdd.Controls.Add(this.btnCDelete);
            this.panAdd.Controls.Add(this.lblInformation);
            this.panAdd.Controls.Add(this.txtCStreet);
            this.panAdd.Controls.Add(this.lblCName);
            this.panAdd.Controls.Add(this.txtCTown);
            this.panAdd.Controls.Add(this.lblCEmail);
            this.panAdd.Controls.Add(this.txtCZip);
            this.panAdd.Controls.Add(this.lblCPhone);
            this.panAdd.Controls.Add(this.lblCStreet);
            this.panAdd.Controls.Add(this.txtCPhone);
            this.panAdd.Controls.Add(this.lblCZip);
            this.panAdd.Controls.Add(this.txtCEmail);
            this.panAdd.Controls.Add(this.lblCText);
            this.panAdd.Controls.Add(this.txtCName);
            this.panAdd.Controls.Add(this.btnAdd);
            this.panAdd.Controls.Add(this.lblAddCon);
            this.panAdd.Controls.Add(this.txtStreet);
            this.panAdd.Controls.Add(this.txtTown);
            this.panAdd.Controls.Add(this.lblMail);
            this.panAdd.Controls.Add(this.txtZip);
            this.panAdd.Controls.Add(this.lblPhone);
            this.panAdd.Controls.Add(this.lblStreet);
            this.panAdd.Controls.Add(this.txtPhone);
            this.panAdd.Controls.Add(this.lblZip);
            this.panAdd.Controls.Add(this.txtEmail);
            this.panAdd.Controls.Add(this.lblTown);
            this.panAdd.Location = new System.Drawing.Point(-6, 0);
            this.panAdd.Name = "panAdd";
            this.panAdd.Size = new System.Drawing.Size(415, 411);
            this.panAdd.TabIndex = 13;
            // 
            // lblNStreet
            // 
            this.lblNStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNStreet.AutoSize = true;
            this.lblNStreet.Location = new System.Drawing.Point(11, 312);
            this.lblNStreet.Name = "lblNStreet";
            this.lblNStreet.Size = new System.Drawing.Size(38, 13);
            this.lblNStreet.TabIndex = 39;
            this.lblNStreet.Text = "Street:";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 243);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(57, 240);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(337, 20);
            this.txtName.TabIndex = 38;
            this.txtName.TextChanged += new System.EventHandler(this.AddContactEnter_TextChanged);
            // 
            // btnCSave
            // 
            this.btnCSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCSave.BackColor = System.Drawing.Color.DimGray;
            this.btnCSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSave.Location = new System.Drawing.Point(316, 172);
            this.btnCSave.Name = "btnCSave";
            this.btnCSave.Size = new System.Drawing.Size(78, 23);
            this.btnCSave.TabIndex = 33;
            this.btnCSave.Text = "Save";
            this.btnCSave.UseVisualStyleBackColor = false;
            this.btnCSave.Click += new System.EventHandler(this.btnCSave_Click);
            // 
            // btnCDelete
            // 
            this.btnCDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnCDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDelete.Location = new System.Drawing.Point(235, 172);
            this.btnCDelete.Name = "btnCDelete";
            this.btnCDelete.Size = new System.Drawing.Size(78, 23);
            this.btnCDelete.TabIndex = 32;
            this.btnCDelete.Text = "Delete";
            this.btnCDelete.UseVisualStyleBackColor = false;
            this.btnCDelete.Click += new System.EventHandler(this.btnCDelete_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformation.BackColor = System.Drawing.Color.DimGray;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(0, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(422, 25);
            this.lblInformation.TabIndex = 30;
            this.lblInformation.Text = "INFORMATION";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCStreet
            // 
            this.txtCStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCStreet.Location = new System.Drawing.Point(57, 99);
            this.txtCStreet.Name = "txtCStreet";
            this.txtCStreet.Size = new System.Drawing.Size(337, 20);
            this.txtCStreet.TabIndex = 27;
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(13, 33);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(38, 13);
            this.lblCName.TabIndex = 18;
            this.lblCName.Text = "Name:";
            // 
            // txtCTown
            // 
            this.txtCTown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCTown.Location = new System.Drawing.Point(57, 145);
            this.txtCTown.Name = "txtCTown";
            this.txtCTown.Size = new System.Drawing.Size(337, 20);
            this.txtCTown.TabIndex = 29;
            // 
            // lblCEmail
            // 
            this.lblCEmail.AutoSize = true;
            this.lblCEmail.Location = new System.Drawing.Point(13, 56);
            this.lblCEmail.Name = "lblCEmail";
            this.lblCEmail.Size = new System.Drawing.Size(38, 13);
            this.lblCEmail.TabIndex = 19;
            this.lblCEmail.Text = "E-mail:";
            // 
            // txtCZip
            // 
            this.txtCZip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCZip.Location = new System.Drawing.Point(57, 122);
            this.txtCZip.Name = "txtCZip";
            this.txtCZip.Size = new System.Drawing.Size(337, 20);
            this.txtCZip.TabIndex = 28;
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Location = new System.Drawing.Point(13, 79);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(41, 13);
            this.lblCPhone.TabIndex = 20;
            this.lblCPhone.Text = "Phone:";
            // 
            // lblCStreet
            // 
            this.lblCStreet.AutoSize = true;
            this.lblCStreet.Location = new System.Drawing.Point(13, 102);
            this.lblCStreet.Name = "lblCStreet";
            this.lblCStreet.Size = new System.Drawing.Size(38, 13);
            this.lblCStreet.TabIndex = 21;
            this.lblCStreet.Text = "Street:";
            // 
            // txtCPhone
            // 
            this.txtCPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPhone.Location = new System.Drawing.Point(57, 76);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(337, 20);
            this.txtCPhone.TabIndex = 26;
            // 
            // lblCZip
            // 
            this.lblCZip.AutoSize = true;
            this.lblCZip.Location = new System.Drawing.Point(13, 125);
            this.lblCZip.Name = "lblCZip";
            this.lblCZip.Size = new System.Drawing.Size(25, 13);
            this.lblCZip.TabIndex = 22;
            this.lblCZip.Text = "Zip:";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCEmail.Location = new System.Drawing.Point(57, 53);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(337, 20);
            this.txtCEmail.TabIndex = 25;
            // 
            // lblCText
            // 
            this.lblCText.AutoSize = true;
            this.lblCText.Location = new System.Drawing.Point(13, 148);
            this.lblCText.Name = "lblCText";
            this.lblCText.Size = new System.Drawing.Size(37, 13);
            this.lblCText.TabIndex = 23;
            this.lblCText.Text = "Town:";
            // 
            // txtCName
            // 
            this.txtCName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCName.Location = new System.Drawing.Point(57, 30);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(337, 20);
            this.txtCName.TabIndex = 24;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(316, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddCon
            // 
            this.lblAddCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddCon.BackColor = System.Drawing.Color.DimGray;
            this.lblAddCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCon.Location = new System.Drawing.Point(-4, 209);
            this.lblAddCon.Name = "lblAddCon";
            this.lblAddCon.Size = new System.Drawing.Size(426, 25);
            this.lblAddCon.TabIndex = 14;
            this.lblAddCon.Text = "NEW CONTACT";
            this.lblAddCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.lstSearchResult);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.lstContacts);
            this.splitContainer1.Panel1.Controls.Add(this.lblContacts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panAdd);
            this.splitContainer1.Size = new System.Drawing.Size(634, 411);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 14;
            // 
            // lstSearchResult
            // 
            this.lstSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSearchResult.FormattingEnabled = true;
            this.lstSearchResult.Location = new System.Drawing.Point(6, 53);
            this.lstSearchResult.Name = "lstSearchResult";
            this.lstSearchResult.Size = new System.Drawing.Size(139, 69);
            this.lstSearchResult.TabIndex = 17;
            this.lstSearchResult.Visible = false;
            this.lstSearchResult.SelectedIndexChanged += new System.EventHandler(this.lstSearchResult_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(151, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(139, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lstContacts
            // 
            this.lstContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstContacts.BackColor = System.Drawing.Color.White;
            this.lstContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContacts.ForeColor = System.Drawing.Color.DimGray;
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.ItemHeight = 20;
            this.lstContacts.Location = new System.Drawing.Point(8, 65);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(205, 340);
            this.lstContacts.TabIndex = 1;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // lblContacts
            // 
            this.lblContacts.BackColor = System.Drawing.Color.DimGray;
            this.lblContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacts.Location = new System.Drawing.Point(0, 0);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(221, 25);
            this.lblContacts.TabIndex = 0;
            this.lblContacts.Text = "CONTACTS";
            this.lblContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // errorProviderZip
            // 
            this.errorProviderZip.ContainerControl = this;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblAdresses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panAdd.ResumeLayout(false);
            this.panAdd.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblAdresses;
        private System.Windows.Forms.Panel panAdd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.Label lblAddCon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCSave;
        private System.Windows.Forms.Button btnCDelete;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCEmail;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.Label lblCStreet;
        private System.Windows.Forms.Label lblCZip;
        private System.Windows.Forms.Label lblCText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNStreet;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ErrorProvider errorProviderEmail;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.ErrorProvider errorProviderPhone;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.ErrorProvider errorProviderZip;
        public System.Windows.Forms.TextBox txtZip;
        public System.Windows.Forms.ListBox lstContacts;
        public System.Windows.Forms.TextBox txtTown;
        public System.Windows.Forms.TextBox txtCStreet;
        public System.Windows.Forms.TextBox txtCTown;
        public System.Windows.Forms.TextBox txtCZip;
        public System.Windows.Forms.TextBox txtCPhone;
        public System.Windows.Forms.TextBox txtCEmail;
        public System.Windows.Forms.TextBox txtCName;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtStreet;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.ListBox lstSearchResult;
    }
}

