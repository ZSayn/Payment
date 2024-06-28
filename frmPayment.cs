using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lstCreditCardType.Items.Add("Visa");
            lstCreditCardType.Items.Add("MasterCard");
            lstCreditCardType.Items.Add("American Express");
            lstCreditCardType.SelectedIndex = 0;

            string[] months = { "Select a month...",
            "January", "February", "March", "April", "May", "June", "July", "August",
            "September", "October", "November", "December"};

            foreach (string month in months)
            {
                cboExpirationMonth.Items.Add(month);
            }
            cboExpirationMonth.SelectedIndex = 0;

            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cboExpirationYear.Items.Add("Select a year...");
            while (year < endYear)
            {
                cboExpirationYear.Items.Add(year);
                year++;
            }
            cboExpirationYear.SelectedIndex = 0;

        }

        private void frmPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            string msg = "";
            if (rdoCreditCard.Checked)
            {
                msg += "Charge to credit card." + "\n\n";
                msg += "Credit type: " + lstCreditCardType.Text + "\n";
                msg += "Credit number: " + txtCardNumber.Text + "\n";
                msg += "Expiration date: " + cboExpirationMonth.Text + "/" + cboExpirationYear.Text + "\n";

            }
            else
            {
                msg += "Send bill to customer."+ "\n\n";
            }
            bool isDefaultBilling = chkDefault.Checked;
            msg += "Default billing:" + isDefaultBilling;
            Tag = msg;
            DialogResult = DialogResult.OK;

        }

        private bool IsValidData()
        {
            bool success = true;

            if (rdoCreditCard.Checked)
            {
                string errorMessage = "";
                if(lstCreditCardType.SelectedIndex == -1)
                {
                    errorMessage += "Select credit card type. \n";
                }
                if(txtCardNumber.Text == "")
                {
                    errorMessage += "Enter a credit card number. \n";
                }
                if(cboExpirationMonth.SelectedIndex == 0) 
                {
                    errorMessage += "Select a month. \n";
                }
                if(cboExpirationYear.SelectedIndex == 0)
                {
                    errorMessage += "Select a year. \n";
                }
                if (errorMessage != "")
                {
                    success = false;
                    MessageBox.Show(errorMessage, "Entry Error");
                }
            }
            return success;
        }

        private void Billing_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoCreditCard.Checked)
            {
                EnableControls();
            }
            else
            {
                DisableControls();
            }
        }

        private void DisableControls()
        {
            lstCreditCardType.Enabled = false;
            txtCardNumber.Enabled = false;
            cboExpirationMonth.Enabled = false;
            cboExpirationYear.Enabled = false;

        }

        private void EnableControls()
        {
            lstCreditCardType.Enabled = true;
            txtCardNumber.Enabled = true;
            cboExpirationMonth.Enabled = true;
            cboExpirationYear.Enabled = true;
        }
    }
}
