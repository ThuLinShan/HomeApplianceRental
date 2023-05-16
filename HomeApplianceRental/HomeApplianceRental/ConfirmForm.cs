using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeApplianceRental
{
    public partial class ConfirmForm : Form
    {
        public ConfirmForm(int total)
        {
            InitializeComponent();
            costLbl.Text = "£ " + total;
        }

        public void confirmBtn_Click(object sender, EventArgs e)
        {
            if (paymentCombo.SelectedItem == null)
            {
                MessageBox.Show("Please Select a payment method");
            }
            else
            {
                MessageBox.Show("Thank you for using our service.");
            }
        }
    }
}
