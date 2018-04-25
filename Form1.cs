using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                lstResult.Items.Clear();
                if (rdbCountry.Checked)
                {
                    var customers =
                        from cust in northwindDataSet1.Customers
                        where cust.Country.Contains(txtInput.Text)
                        select cust;
                    foreach (var item in customers)
                    {
                        lstResult.Items.Add(item.CustomerID + " " +
                            item.CompanyName.PadRight(40) + " " +
                            item.Country);
                    } 
                }
                else if (rdbCity.Checked)
                {
                    var customers =
                       from cust in northwindDataSet1.Customers
                       where cust.City.Contains(txtInput.Text)
                       select cust;
                    foreach (var item in customers)
                    {
                        lstResult.Items.Add(item.CustomerID + " " +
                            item.CompanyName.PadRight(40) + " " +
                            item.City);
                    }
                }

                if (lstResult.Items.Count==0)
                {
                    lstResult.Items.Add("There is no matching data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        //if you change the radiobutton which u clicked, it clears the table
        private void rdbCountry_CheckedChanged(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            txtInput.Clear();
        }

        private void rdbCity_CheckedChanged(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            txtInput.Clear();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
        }
    }
}
