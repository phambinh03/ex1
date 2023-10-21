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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WinFormsApp1
{
    public partial class ItemDetailsForm : Form
    {
        public ItemDetailsForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            // Get the values from the text boxes
            int itemID = int.Parse(ItemIDTextBox.Text);
            string itemName = ItemNameTextBox.Text;
            string size = SizeTextBox.Text;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CustDatabase"].ToString();
            connection.Open();
            // Here, you can perform additional validation if needed.
            string insertQuery = "INSERT INTO Item (ItemID, ItemName, Size) VALUES (@ItemID, @ItemName, @Size)";

            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@ItemID", itemID);
                cmd.Parameters.AddWithValue("@ItemName", itemName);
                cmd.Parameters.AddWithValue("@Size", size);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully added");
                // Pass the data back to the ItemEntryForm
                //MainForm.DisplayInsertedItemData($"{itemID}, '{itemName}', {size}");
            }
        }
    }
}
