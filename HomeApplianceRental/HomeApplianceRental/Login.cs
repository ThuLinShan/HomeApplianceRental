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
    public partial class Login : Form
    {
        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + "\\HomeApplianceRental\\HomeAppliance.mdf;Integrated Security=True");

        private Timer timer = new Timer { Interval = 1000 };
        private int timeCounter =30; //waiting duration
        private int counter = 0;    //counting for failing attempts

        public Login()
        {
            InitializeComponent();
        }



        public void btnLogin_Click_1(object sender, EventArgs e) // Login button
        {
            if (cmbType.Text == "")
            {
                timerLbl.Text= "Please select user type (Admin or customer)";
            }
            else
            {
                try
                {
                    timerLbl.Text = "___";
                    string type = cmbType.SelectedItem.ToString();
                    if (type.Equals("Admin"))
                    {
                        if (txtUname.Text.Equals("Admin") && txtPwd.Text.Equals("Admin123"))
                        {
                            Admin a = new Admin();
                            a.Show();
                            txtUname.Text = "";
                            txtPwd.Text = "";
                            FormProvider.login.Hide();
                        }
                        else
                        {
                            counter++;
                            if (counter >= 5)
                            {
                                MessageBox.Show("Too many attempts. Please wait for 30 seconds to login again.");
                                start();
                                counter = 0;
                            }
                            else
                            {
                                MessageBox.Show("Login fail");
                            }
                        }
                    }
                    else
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select * from customer where name=@val1 and password=@val2", con);
                        cmd.Parameters.AddWithValue("@val1", txtUname.Text);
                        cmd.Parameters.AddWithValue("@val2", txtPwd.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtUname.Text = "";
                            txtPwd.Text = "";
                            Customer f = new Customer();
                            f.Show();
                            FormProvider.login.Hide();
                        }
                        else
                        {
                            txtUname.Text = "";
                            txtPwd.Text = "";
                            counter++;
                            if (counter >= 5)
                            {
                                MessageBox.Show("Too many attempts. Please wait for 30 seconds to login again.");
                                start();
                                counter = 0;
                            }
                            else
                            {
                                MessageBox.Show("Login fail");
                            }
                        }
                        con.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)   //To registration 
        {
            txtUname.Text = "";
            txtPwd.Text = "";
            Register f = new Register();
            f.Show();
            FormProvider.login.Hide();
        }

        public void guideLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guide g = new guide();
            g.Show();
        }


        //Timer functions
        public void OnTimerEvent(object sender, EventArgs e)
        {
            timeCounter = timeCounter - 1;
            timerLbl.Text = "Wait until "+ timeCounter + "s";

            if (timeCounter < 0)
            {
                timerLbl.Text = "___";
                stop();
            }
        }

        public void start()
        {
            timer.Enabled = true;
            timer.Tick += new System.EventHandler(OnTimerEvent);
            btnLogin.Enabled = false;
        }
        public void stop()
        {
            timeCounter = 30;
            timer.Tick -= new System.EventHandler(OnTimerEvent);
            timer.Enabled = false;
            btnLogin.Enabled = true;
        }
        //Timer functions







        public void showBtn_Click(object sender, EventArgs e)  //Show and hide password field
        {
            if(txtPwd.PasswordChar == '*')
            {
                txtPwd.PasswordChar = '\0';
                showBtn.Text = "hide";
            }
            else
            {
                txtPwd.PasswordChar = '*';
                showBtn.Text = "show";
            }
        }
        

    }
}
