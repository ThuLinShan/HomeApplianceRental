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
    public partial class Admin : Form
    {

        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + "\\HomeApplianceRental\\HomeAppliance.mdf;Integrated Security=True");
        private int id; //to use as primary key in database

        public Admin()
        {
            InitializeComponent();
        }

        public void Admin_Load(object sender, EventArgs e)
        {
            display();
        }

        public void addBtn_Click(object sender, EventArgs e)    //provke event for adding new items
        {
            if(typeTxt.Text == "" || idTxt.Text == ""|| brandTxt.Text =="" || colorTxt.Text == ""|| dimenTxt.Text == ""|| energyTxt.Text == ""|| feeTxt.Text == ""|| modelTxt.Text == "")
            {
                MessageBox.Show("Please fill all of the inputs"); //to check if some input fields are empty
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Product (Id,Type, Brand, Model, Dimensions, Colour, EnergyConsumption_WattPerHour, MonthlyFee, MonthlyRentalPeriod) values (@id, @type,@brand,@model,@dimensions,@colour,@EnergyConsumption,@MonthlyFee,@MonthlyRentalPeriod)", con);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idTxt.Text));
                    cmd.Parameters.AddWithValue("@type", typeTxt.Text);
                    cmd.Parameters.AddWithValue("@brand", brandTxt.Text);
                    cmd.Parameters.AddWithValue("@model", modelTxt.Text);
                    cmd.Parameters.AddWithValue("@dimensions", dimenTxt.Text);
                    cmd.Parameters.AddWithValue("@colour", colorTxt.Text);
                    cmd.Parameters.AddWithValue("@EnergyConsumption", Convert.ToInt32(energyTxt.Text));
                    cmd.Parameters.AddWithValue("@MonthlyFee", Convert.ToInt32(feeTxt.Text));
                    cmd.Parameters.AddWithValue("@MonthlyRentalPeriod", rentalPeriodNum.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved successfully");
                    con.Close();
                    display();
                    clear();
                }
                catch(System.FormatException ex)
                {
                    MessageBox.Show("id, energy consumption and monthly fee only accept whole number values.");
                    con.Close();
                    idTxt.Text = "";
                    feeTxt.Text = "";
                    energyTxt.Text = "";
                    con.Close();
                }
                catch(SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("ID already exist. \n numerial value 0 in front of other values doesn't count.");
                    }
                    else
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }

            }
        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //To select an item from data grid view
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                idTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                typeTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                brandTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                modelTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                dimenTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                colorTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                energyTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                feeTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                rentalPeriodNum.Value = int.Parse( dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString() );
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Select only on rows of the table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateBtn_Click(object sender, EventArgs e) //updating event provking
        {
            if(id != 0)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update product set type=@type, brand=@brand, model=@model, dimensions=@dimensions, colour=@colour, energyConsumption_WattPerHour=@energyConsumption, monthlyFee=@monthlyFee, monthlyRentalPeriod=@monthlyRentalPeriod where id=@id", con);
                    cmd.Parameters.AddWithValue("@id", idTxt.Text);
                    cmd.Parameters.AddWithValue("@type", typeTxt.Text);
                    cmd.Parameters.AddWithValue("@brand", brandTxt.Text);
                    cmd.Parameters.AddWithValue("@model", modelTxt.Text);
                    cmd.Parameters.AddWithValue("@dimensions", dimenTxt.Text);
                    cmd.Parameters.AddWithValue("@colour", colorTxt.Text);
                    cmd.Parameters.AddWithValue("@EnergyConsumption", Convert.ToInt32(energyTxt.Text));
                    cmd.Parameters.AddWithValue("@MonthlyFee", Convert.ToInt32(feeTxt.Text));
                    cmd.Parameters.AddWithValue("@MonthlyRentalPeriod", rentalPeriodNum.Value);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your data has been updated.");
                    display();
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("id, energy consumption and monthly fee only accept whole number values.");
                    con.Close();
                    idTxt.Text = "";
                    feeTxt.Text = "";
                    energyTxt.Text = "";
                    con.Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("ID already exist. \n numerial value 0 in front of other values doesn't count.");
                    }
                    else
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }

            }
        }

        public void deleteBtn_Click(object sender, EventArgs e) //deleting event
        {
            if (id != 0) { 
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from product where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your record has been deleted");
                display();
                clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }
        }

        //for displaying product data
        public void display()
        {
            try
            {
                //List<Product> lis = new List<Product>();
                DataTable dt = new DataTable();
                con.Open();
                SqlDataAdapter adpt= new SqlDataAdapter("select * from product", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[6].Width = 200;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("display funciton :" + ex.ToString());
                con.Close();
            }
        }

        //for clearing input values
        public void clear()
        {
            idTxt.Text = "";
            typeTxt.Text = "";
            brandTxt.Text = "";
            modelTxt.Text = "";
            dimenTxt.Text = "";
            colorTxt.Text = "";
            energyTxt.Text = "";
            feeTxt.Text = "";
            rentalPeriodNum.Value = 1;
        }

        //to return to login form
        public void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.login.Show();
        }
    }
}
