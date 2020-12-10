namespace dsd02
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVRentedMovies = new System.Windows.Forms.DataGridView();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcustomerlastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcustomeraddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcuxtomerDOB = new System.Windows.Forms.TextBox();
            this.txtcustomerphonenumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmoviecopies = new System.Windows.Forms.TextBox();
            this.txtmoviegenres = new System.Windows.Forms.TextBox();
            this.txtmovieplot = new System.Windows.Forms.TextBox();
            this.txtmovierating = new System.Windows.Forms.TextBox();
            this.txtmovieyear = new System.Windows.Forms.TextBox();
            this.txtmoviestittle = new System.Windows.Forms.TextBox();
            this.txtmovieID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtrentedmoviecustIDFK = new System.Windows.Forms.TextBox();
            this.txtrentedmovieIDFK = new System.Windows.Forms.TextBox();
            this.txtrentedmovieRMID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtrentedmoviereturndate = new System.Windows.Forms.TextBox();
            this.txtrentedmoviedatareturn = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btn_add_movies = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentedMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(67, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.DGVCustomers);
            this.Customers.Location = new System.Drawing.Point(4, 25);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(789, 416);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomers.Location = new System.Drawing.Point(3, 3);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.RowHeadersWidth = 51;
            this.DGVCustomers.RowTemplate.Height = 24;
            this.DGVCustomers.Size = new System.Drawing.Size(783, 410);
            this.DGVCustomers.TabIndex = 0;
            this.DGVCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellContentClick);
            this.DGVCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVMovies);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVMovies
            // 
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMovies.Location = new System.Drawing.Point(3, 3);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.RowHeadersWidth = 51;
            this.DGVMovies.RowTemplate.Height = 24;
            this.DGVMovies.Size = new System.Drawing.Size(783, 410);
            this.DGVMovies.TabIndex = 1;
            this.DGVMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            this.DGVMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVRentedMovies);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(789, 416);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Rented Movies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVRentedMovies
            // 
            this.DGVRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRentedMovies.Location = new System.Drawing.Point(3, 3);
            this.DGVRentedMovies.Name = "DGVRentedMovies";
            this.DGVRentedMovies.RowHeadersWidth = 51;
            this.DGVRentedMovies.RowTemplate.Height = 24;
            this.DGVRentedMovies.Size = new System.Drawing.Size(786, 413);
            this.DGVRentedMovies.TabIndex = 0;
            this.DGVRentedMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRentedMovies_CellContentClick);
            this.DGVRentedMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRentedMovies_CellContentClick);
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(141, 509);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(153, 22);
            this.txtCustomerFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(141, 480);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cust ID";
            // 
            // txtcustomerlastname
            // 
            this.txtcustomerlastname.Location = new System.Drawing.Point(141, 538);
            this.txtcustomerlastname.Name = "txtcustomerlastname";
            this.txtcustomerlastname.Size = new System.Drawing.Size(100, 22);
            this.txtcustomerlastname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // txtcustomeraddress
            // 
            this.txtcustomeraddress.Location = new System.Drawing.Point(141, 566);
            this.txtcustomeraddress.Name = "txtcustomeraddress";
            this.txtcustomeraddress.Size = new System.Drawing.Size(100, 22);
            this.txtcustomeraddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // txtcuxtomerDOB
            // 
            this.txtcuxtomerDOB.Location = new System.Drawing.Point(141, 622);
            this.txtcuxtomerDOB.Name = "txtcuxtomerDOB";
            this.txtcuxtomerDOB.Size = new System.Drawing.Size(100, 22);
            this.txtcuxtomerDOB.TabIndex = 9;
            // 
            // txtcustomerphonenumber
            // 
            this.txtcustomerphonenumber.Location = new System.Drawing.Point(141, 594);
            this.txtcustomerphonenumber.Name = "txtcustomerphonenumber";
            this.txtcustomerphonenumber.Size = new System.Drawing.Size(100, 22);
            this.txtcustomerphonenumber.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 625);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "phone number";
            // 
            // txtmoviecopies
            // 
            this.txtmoviecopies.Location = new System.Drawing.Point(445, 653);
            this.txtmoviecopies.Name = "txtmoviecopies";
            this.txtmoviecopies.Size = new System.Drawing.Size(100, 22);
            this.txtmoviecopies.TabIndex = 13;
            // 
            // txtmoviegenres
            // 
            this.txtmoviegenres.Location = new System.Drawing.Point(445, 625);
            this.txtmoviegenres.Name = "txtmoviegenres";
            this.txtmoviegenres.Size = new System.Drawing.Size(100, 22);
            this.txtmoviegenres.TabIndex = 14;
            // 
            // txtmovieplot
            // 
            this.txtmovieplot.Location = new System.Drawing.Point(445, 599);
            this.txtmovieplot.Name = "txtmovieplot";
            this.txtmovieplot.Size = new System.Drawing.Size(100, 22);
            this.txtmovieplot.TabIndex = 15;
            // 
            // txtmovierating
            // 
            this.txtmovierating.Location = new System.Drawing.Point(445, 571);
            this.txtmovierating.Name = "txtmovierating";
            this.txtmovierating.Size = new System.Drawing.Size(100, 22);
            this.txtmovierating.TabIndex = 16;
            // 
            // txtmovieyear
            // 
            this.txtmovieyear.Location = new System.Drawing.Point(445, 542);
            this.txtmovieyear.Name = "txtmovieyear";
            this.txtmovieyear.Size = new System.Drawing.Size(100, 22);
            this.txtmovieyear.TabIndex = 17;
            // 
            // txtmoviestittle
            // 
            this.txtmoviestittle.Location = new System.Drawing.Point(445, 514);
            this.txtmoviestittle.Name = "txtmoviestittle";
            this.txtmoviestittle.Size = new System.Drawing.Size(100, 22);
            this.txtmoviestittle.TabIndex = 18;
            // 
            // txtmovieID
            // 
            this.txtmovieID.Location = new System.Drawing.Point(445, 486);
            this.txtmovieID.Name = "txtmovieID";
            this.txtmovieID.Size = new System.Drawing.Size(100, 22);
            this.txtmovieID.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "movie ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "movie tittle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 547);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "year of movie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 574);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "movie rating";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 602);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "plot";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(346, 628);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "movie genres";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(322, 656);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "number of copies";
            // 
            // txtrentedmoviecustIDFK
            // 
            this.txtrentedmoviecustIDFK.Location = new System.Drawing.Point(720, 547);
            this.txtrentedmoviecustIDFK.Name = "txtrentedmoviecustIDFK";
            this.txtrentedmoviecustIDFK.Size = new System.Drawing.Size(100, 22);
            this.txtrentedmoviecustIDFK.TabIndex = 27;
            // 
            // txtrentedmovieIDFK
            // 
            this.txtrentedmovieIDFK.Location = new System.Drawing.Point(720, 514);
            this.txtrentedmovieIDFK.Name = "txtrentedmovieIDFK";
            this.txtrentedmovieIDFK.Size = new System.Drawing.Size(100, 22);
            this.txtrentedmovieIDFK.TabIndex = 28;
            // 
            // txtrentedmovieRMID
            // 
            this.txtrentedmovieRMID.Location = new System.Drawing.Point(720, 485);
            this.txtrentedmovieRMID.Name = "txtrentedmovieRMID";
            this.txtrentedmovieRMID.Size = new System.Drawing.Size(100, 22);
            this.txtrentedmovieRMID.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(640, 488);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "RMID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(640, 519);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "MovieIDFK";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(640, 550);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "custIDFK";
            // 
            // txtrentedmoviereturndate
            // 
            this.txtrentedmoviereturndate.Location = new System.Drawing.Point(720, 620);
            this.txtrentedmoviereturndate.Name = "txtrentedmoviereturndate";
            this.txtrentedmoviereturndate.Size = new System.Drawing.Size(100, 22);
            this.txtrentedmoviereturndate.TabIndex = 33;
            // 
            // txtrentedmoviedatareturn
            // 
            this.txtrentedmoviedatareturn.Location = new System.Drawing.Point(720, 584);
            this.txtrentedmoviedatareturn.Name = "txtrentedmoviedatareturn";
            this.txtrentedmoviedatareturn.Size = new System.Drawing.Size(100, 22);
            this.txtrentedmoviedatareturn.TabIndex = 34;
            this.txtrentedmoviedatareturn.TextChanged += new System.EventHandler(this.txtrentedmoviedatareturn_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(635, 625);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 17);
            this.label17.TabIndex = 35;
            this.label17.Text = "Date Return";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(632, 587);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "Date rented";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(28, 663);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(79, 52);
            this.btnAddCustomer.TabIndex = 37;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(113, 663);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(106, 52);
            this.btnUpdateCustomer.TabIndex = 38;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btn_add_movies
            // 
            this.btn_add_movies.Location = new System.Drawing.Point(325, 688);
            this.btn_add_movies.Name = "btn_add_movies";
            this.btn_add_movies.Size = new System.Drawing.Size(103, 50);
            this.btn_add_movies.TabIndex = 39;
            this.btn_add_movies.Text = "Add Movies";
            this.btn_add_movies.UseVisualStyleBackColor = true;
            this.btn_add_movies.Click += new System.EventHandler(this.btn_add_movies_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 52);
            this.button1.TabIndex = 40;
            this.button1.Text = "Update Movies";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 818);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add_movies);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtrentedmoviedatareturn);
            this.Controls.Add(this.txtrentedmoviereturndate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtrentedmovieRMID);
            this.Controls.Add(this.txtrentedmovieIDFK);
            this.Controls.Add(this.txtrentedmoviecustIDFK);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmovieID);
            this.Controls.Add(this.txtmoviestittle);
            this.Controls.Add(this.txtmovieyear);
            this.Controls.Add(this.txtmovierating);
            this.Controls.Add(this.txtmovieplot);
            this.Controls.Add(this.txtmoviegenres);
            this.Controls.Add(this.txtmoviecopies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcustomerphonenumber);
            this.Controls.Add(this.txtcuxtomerDOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcustomeraddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcustomerlastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentedMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.DataGridView DGVRentedMovies;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcustomerlastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcustomeraddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcuxtomerDOB;
        private System.Windows.Forms.TextBox txtcustomerphonenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmoviecopies;
        private System.Windows.Forms.TextBox txtmoviegenres;
        private System.Windows.Forms.TextBox txtmovieplot;
        private System.Windows.Forms.TextBox txtmovierating;
        private System.Windows.Forms.TextBox txtmovieyear;
        private System.Windows.Forms.TextBox txtmoviestittle;
        private System.Windows.Forms.TextBox txtmovieID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtrentedmoviecustIDFK;
        private System.Windows.Forms.TextBox txtrentedmovieIDFK;
        private System.Windows.Forms.TextBox txtrentedmovieRMID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtrentedmoviereturndate;
        private System.Windows.Forms.TextBox txtrentedmoviedatareturn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btn_add_movies;
        private System.Windows.Forms.Button button1;
    }
}

