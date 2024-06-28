namespace Payment
{
    public partial class frnCustomer : Form
    {
        public frnCustomer()
        {
            InitializeComponent();
        }

        bool isDataSaved = true;

        private void frnCustomer_Load(object sender, EventArgs e)
        {
            cboNames.Items.Add("Zarina Sayn");
            cboNames.Items.Add("Sevinch Muminova");
            cboNames.Items.Add("Lola Yoldasheva");
            cboNames.Items.Add("Tohir Zokirov");
            cboNames.Items.Add("Munisa Rizayeva");
            cboNames.Items.Add("Shoxrux Alisherov");
        }

        private void lblPayment_TextChanged(object sender, EventArgs e)
        {
            isDataSaved = false; 
        }

        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            isDataSaved = false;
            lblPayment.Text = "";
        }

        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            Form paymentForm = new frmPayment();
            DialogResult selectedButton = paymentForm.ShowDialog();
            if(selectedButton == DialogResult.OK)
            {
                lblPayment.Text = paymentForm.Tag?.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            if(cboNames.SelectedIndex == -1)
            {
                errorMessage += "You must select a customer. \n";
            }
            if(lblPayment.Text == "")
            {
                errorMessage += "You must enter a payment. \n";
            }
            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void SaveData()
        {
            cboNames.SelectedIndex = -1;
            lblPayment.Text = "";
            isDataSaved = true;
            cboNames.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frnCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDataSaved == false)
            {
                string message =
                    "This form contains unsaved date. \n\n" + "Do you want to save it?";

                DialogResult button = MessageBox.Show(message, "Customer",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (button == DialogResult.Yes)
                {
                    if (IsValidData())
                    {
                        SaveData();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                if(button == DialogResult.Cancel) 
                {
                    e.Cancel = true;
                }

            }

        }

    }
}
