using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsd02
{
    public partial class Form1 : Form
    {

        Database myDatabase = new Database();

        public Form1()
        {
            InitializeComponent();
            loadDB();
        }
       


        public void loadDB()
        {
            //load the owner dgv
            DisplayDataGridViewCustomer();
            DisplayDataGridViewMovies();
            DisplayDataGridViewRentedMovies();
        }
        //LOAD THE OWNER DATAGRID 
        private void DisplayDataGridViewCustomer()
        {
            //clear out the old data
            DGVCustomers.DataSource = null;
            try
            {
                DGVCustomers.DataSource = myDatabase.FillDGVCustomerWithCustomer();
                //pass the datatable data to the DataGridView
                DGVCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer query didn't load " + ex.Message);
            }
        }
        

       
      
        
        private void DisplayDataGridViewMovies()
        {
            //clear out the old data
            DGVMovies.DataSource = null;
            try
            {
                DGVMovies.DataSource = myDatabase.FillDGVMoviesWithMovies();
                //pass the datatable data to the DataGridView
                DGVMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Movies query didn't load " + ex.Message);
            }
        }

       
        private void DisplayDataGridViewRentedMovies()
        {
            //clear out the old data
            DGVRentedMovies.DataSource = null;
            try
            {
                DGVRentedMovies.DataSource = myDatabase.FillDGVRentedMoviesWithRentedMovies();
                //pass the datatable data to the DataGridView
                DGVRentedMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Rented Movies query didn't load " + ex.Message);
            }
        }


        private void DGVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pass the value in the data table across to the textbox. The number I need to change is the .Cells[1] value
            //get the customer ID
            txtCustomerId.Text = DGVCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
            //get the Customer firstname
            txtCustomerFirstName.Text = DGVCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            //get the customer lastname
            txtcustomerlastname.Text = DGVCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
            //get the customer address
            txtcustomeraddress.Text = DGVCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
            //get the customer phone number
            txtcustomerphonenumber.Text = DGVCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
            //get the customer date of birth
            txtcuxtomerDOB.Text = DGVCustomers.Rows[e.RowIndex].Cells[5].Value.ToString();
        }




        private void DGVMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pass the value in the data table to the textbox.
            //get the movie id
            txtmovieID.Text = DGVMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
            //get the movie year
            txtmovieyear.Text = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
            //get the movie rating
            txtmovierating.Text = DGVMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
            //get the movie plot
            txtmovieplot.Text = DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
            //get the movie genres
            txtmoviegenres.Text = DGVMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
            //get the number of copies rented by the customer
            txtmoviecopies.Text = DGVMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
            //get the tittle of the movie
            txtmoviestittle.Text = DGVMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void DGVRentedMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pass the value in the table to the textbox
            //get the RMID of movies rented
           txtrentedmovieRMID.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
            //get the IDFK of the movies rented
            txtrentedmovieIDFK.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
            //get the IDFK of the customers
            txtrentedmoviecustIDFK.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
            //get the data of the movie rented
            txtrentedmoviedatareturn.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
            //get the data of the movie that has been return
            txtrentedmoviedatareturn.Text = DGVRentedMovies.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void txtrentedmoviedatareturn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
        string Response =    myDatabase.InsertOrUpdateCustomer(txtCustomerId.Text, txtCustomerFirstName.Text, txtcustomerlastname.Text, txtcustomeraddress.Text, txtcustomerphonenumber.Text, txtcuxtomerDOB.Text, "Add");

            MessageBox.Show(Response);
            DisplayDataGridViewCustomer();

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string Response = myDatabase.InsertOrUpdateCustomer(txtCustomerId.Text, txtCustomerFirstName.Text,
txtcustomerlastname.Text, txtcustomeraddress.Text, txtcustomerphonenumber.Text, txtcuxtomerDOB.Text, "Update");

            MessageBox.Show(Response);

            DisplayDataGridViewCustomer();
        }

        private void btn_add_movies_Click(object sender, EventArgs e)
        {

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Response = myDatabase.InsertOrUpdateMovies(txtmovieID.Text, txtCustomerFirstName.Text, txtmovieyear.Text, txtmovierating.Text, txtmoviegenres.Text, txtmoviecopies.Text,txtmovieplot.Text, "Update");

            MessageBox.Show(Response);

            DisplayDataGridViewCustomer();

        }
    }
}
