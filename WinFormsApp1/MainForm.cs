using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraGrid;


namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public static string ItemData;
        public MainForm()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemDetailsForm itemDetailsForm = new ItemDetailsForm();
            itemDetailsForm.ShowDialog();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CustDatabase"].ToString();


            // Iterate through the arrays and insert the records

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtAddCust_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            CustDetailsFormcs custDetailsForm = new CustDetailsFormcs();
            custDetailsForm.ShowDialog();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CustDatabase"].ToString();

            //connection.Open();
            MessageBox.Show("Connect OK");

            string itemData = txtAddCust.Text; // Assuming the item data in the format: "1, 'Name', 36"

            try
            {


                string insertQuery = "INSERT INTO Customer (CustId, CustName, Address) VALUES (" + itemData + ")";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added to the database.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }
}

