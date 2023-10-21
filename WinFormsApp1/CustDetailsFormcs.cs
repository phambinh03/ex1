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

namespace WinFormsApp1
{
    public partial class CustDetailsFormcs : Form
    {
        public CustDetailsFormcs()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            // Get the values from the text boxes
            string CustID = CustIDTextBox.Text;
            string CustName = CustNameTextBox.Text;
            string Address = AddressTextBox.Text;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CustDatabase"].ToString();
            connection.Open();
            // Here, you can perform additional validation if needed.
            string insertQuery = "INSERT INTO Customer (CustID, CustID, Address) VALUES (@CustID, @CustName, @Address)";

            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@CustID", CustID);
                cmd.Parameters.AddWithValue("@CustName", CustName);
                cmd.Parameters.AddWithValue("@Address", Address);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully added");
                // Pass the data back to the ItemEntryForm
                //MainForm.DisplayInsertedItemData($"{itemID}, '{itemName}', {size}");
            }
        }
    }
}
