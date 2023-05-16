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
using System.Text.RegularExpressions;
using System.IO;

namespace HomeApplianceRental
{
    public partial class Register : Form
    {
        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + "\\HomeApplianceRental\\HomeAppliance.mdf;Integrated Security=True");
        private static string regex = "^(?=.*[a-z])(?=."
                    + "*[A-Z])";    //To use in regular expression
        private Regex re = new Regex(regex);    //to use to validate if password contains atleast one upper case or lowercase

        public Register()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)   //Registrataion button
        {
            if (txtName.Text == "" || txtPass.Text == "" || txtConfirm.Text == "")  //validate if inputs are empty
            {
                MessageBox.Show("Some data is missing.");
            }

            else if (!txtName.Text.All(Char.IsLetterOrDigit))   //validate letters and numbers
            {
                nameErrLbl.Text= "(Name must include only letters and numbers)";
                
            }

            else if (txtPass.Text.Length < 8 || txtPass.Text.Length > 16)   //validate length of password
            {
                passErrLbl.Text = "(Passsword must between 8 and 16 letters)";
                nameErrLbl.Text = "";
            }
            else if (!re.Match(txtPass.Text).Success)   //validate if passord include atleast one upper case and lower case character
            {
                passErrLbl.Text = "(Password must include at least one upper case and one lower case.)";
                nameErrLbl.Text = "";
            }
            else if (txtPass.Text != txtConfirm.Text)   //validate if password and confirm password match
            {
                confirmErrLbl.Text= "(Password and confirm password do not match)";
                nameErrLbl.Text = "";
                passErrLbl.Text = "";
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into customer values(@name,@password)", con);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register sucessful");
                    con.Close();
                    this.Hide();
                    FormProvider.login.Show();
                }
                catch (Exception ex)
                {   
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        public void showBtn_Click(object sender, EventArgs e)  //Show and hide password field
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                txtConfirm.PasswordChar = '\0';
                showBtn.Text = "hide";
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtConfirm.PasswordChar = '*';
                showBtn.Text = "show";
            }
        }

        public void registerGuide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterGuide rg = new RegisterGuide();
            rg.Show();
        }

        public void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.login.Show();
        }
    }
}
