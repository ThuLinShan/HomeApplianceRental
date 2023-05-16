using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace HomeApplianceRental
{
    public partial class Customer : Form
    {

        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + "\\HomeApplianceRental\\HomeAppliance.mdf;Integrated Security=True");
        private int itemCounter = 0;    //to count how many items are there in the cart
        private int total = 0;          //to calculate the total cost of overall items in the cart
        private List<Product> productLis = new List<Product>();
        private List<CartProduct> cartLis = new List<CartProduct>();

        public Customer()
        {
            InitializeComponent();
            display();
        }

        public void button1_Click(object sender, EventArgs e)  //Searching
        {
            if(searchCombo.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to search.");
            }
            else if (searchCombo.SelectedItem.ToString() != "All")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from product where Type=@val1", con);
                    cmd.Parameters.AddWithValue("@val1", searchCombo.SelectedItem.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataGridView1.DataSource = getProductList(reader);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from product", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataGridView1.DataSource = getProductList(reader);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }

        private List<Product> getProductList(SqlDataReader reader)
        {
            List<Product> lis = new List<Product>();

            while (reader.Read())
            {
                lis.Add(new Product {   Id = reader.GetInt32(0),
                                        Type = reader.GetString(1),
                                        Brand = reader.GetString(2),
                                        Model = reader.GetString(3),
                                        Dimensions = reader.GetString(4),
                                        Colour = reader.GetString(5),
                                        EnergyConsumption = reader.GetInt32(6),
                                        MonthlyFee = reader.GetInt32(7),
                                        MonthlyRentalPeriod = reader.GetInt32(8)    }    );
            }
            return lis;
        }

        private Product getProduct(SqlDataReader reader)
        {
            reader.Read();
                Product p = new Product
                {
                    Id = reader.GetInt32(0),
                    Type = reader.GetString(1),
                    Brand = reader.GetString(2),
                    Model = reader.GetString(3),
                    Dimensions = reader.GetString(4),
                    Colour = reader.GetString(5),
                    EnergyConsumption = reader.GetInt32(6),
                    MonthlyFee = reader.GetInt32(7),
                    MonthlyRentalPeriod = reader.GetInt32(8)
                };
                return p;
        }

        private CartProduct getCart(SqlDataReader reader , int month)
        {
            reader.Read();
            CartProduct c = new CartProduct
            {
                Type = reader.GetString(1),
                Brand = reader.GetString(2),
                Model = reader.GetString(3),
                Dimensions = reader.GetString(4),
                Colour = reader.GetString(5),
                EnergyConsumption = reader.GetInt32(6),
                MonthlyFee = reader.GetInt32(7),
                Periods_Month = month,
                Cost_in_pound = reader.GetInt32(7) * month
            }; ;

            return c;
        }

        public void display()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from product", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[8].Width = 200;
                dataGridView1.Columns[10].Width = 120;
                dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.Bisque;
                dataGridView1.Columns[10].DefaultCellStyle.BackColor = Color.Bisque;
                dataGridView1.Columns[9].DefaultCellStyle.BackColor = Color.Aquamarine;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("display funciton :" + ex.ToString());
                con.Close();
            }
        }

        public void sortBtn_Click(object sender, EventArgs e) //Sorting
        {
            if (sortCombo.SelectedItem == null){}
            else if (searchCombo.SelectedItem == null)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from product order by '" + sortCombo.SelectedItem.ToString() + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.DataSource = getProductList(reader);
                con.Close();
            }
            else if (searchCombo.SelectedItem.ToString() == "All")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from product order by '" + sortCombo.SelectedItem.ToString() + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.DataSource = getProductList(reader);
                con.Close();
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from product where type=@val1 order by '" + sortCombo.SelectedItem.ToString() + "'", con);
                cmd.Parameters.AddWithValue("@val1", searchCombo.SelectedItem.ToString());
                SqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.DataSource = getProductList(reader);
                con.Close();
            }
        }

        public void addBtn_Click(object sender, EventArgs e) //Add function
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Add_to_Cart"].Value);
                if (isSelected)
                {
                    if (row.Cells["Months_to_rent"].Value == null) // validation
                    {
                        MessageBox.Show("Please select months period for " + row.Cells["Brand"].Value.ToString() + " " + row.Cells["Type"].Value.ToString());
                    }

                    else if (Convert.ToInt32(row.Cells["Months_to_rent"].Value.ToString()) < Convert.ToInt32(row.Cells["MonthlyRentalPeriod"].Value.ToString())) // validaiton 2 
                    {
                        MessageBox.Show("Months to rent should not be less than monthly rental period");
                    }
                    else { // add to cart function
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("select * from product where id='" + row.Cells["Id"].Value.ToString() + "'", con);
                            SqlDataReader reader = cmd.ExecuteReader();
                            cartLis.Add(getCart(reader, Convert.ToInt32(row.Cells["Months_to_rent"].Value.ToString())));
                            con.Close();
                            itemCounter++;
                            counterLbl.Text = itemCounter + "";

                            total = Convert.ToInt32(row.Cells["MonthlyFee"].Value.ToString()) * Convert.ToInt32(row.Cells["Months_to_rent"].Value.ToString()) + total;
                            costLbl.Text = "£ " + total;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            con.Close();
                        }
                    }

                }

            }
            cartGrid.DataSource = null;
            cartGrid.DataSource = cartLis;
            cartGrid.Columns[8].DefaultCellStyle.BackColor = Color.Aquamarine;
            //MessageBox.Show(message + "\nTotal=" + total);
        }

        public void cleanBtn_Click(object sender, EventArgs e) //to reset everything to zero
        {
            total = 0;
            costLbl.Text = "-";
            itemCounter = 0;
            counterLbl.Text = itemCounter + "";
            cartLis.Clear();
            cartGrid.DataSource = null;
            cartGrid.DataSource = cartLis;
        }

        public void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.login.Show(); 
        }

        public void guideLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CustomerGuide().Show();
        }

        public void buyBtn_Click(object sender, EventArgs e)
        {
            //if the cart is empty, purchasing cannot be done
            if(cartLis.Count == 0)
            {
                MessageBox.Show("Cart is empty");
            }

            //Show the purchase confirmation form
            else
            {
                new ConfirmForm(total).Show();
            }
        }
    }
}
