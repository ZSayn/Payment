namespace Payment
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorDialog1 = new ColorDialog();
            groupBox1 = new GroupBox();
            rdoBillCustomer = new RadioButton();
            rdoCreditCard = new RadioButton();
            lblCreditCardType = new Label();
            lblCardNumber = new Label();
            lblExpirationDate = new Label();
            lstCreditCardType = new ListBox();
            txtCardNumber = new TextBox();
            cboExpirationMonth = new ComboBox();
            cboExpirationYear = new ComboBox();
            chkDefault = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoBillCustomer);
            groupBox1.Controls.Add(rdoCreditCard);
            groupBox1.Location = new Point(27, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Billing";
            // 
            // rdoBillCustomer
            // 
            rdoBillCustomer.AutoSize = true;
            rdoBillCustomer.Location = new Point(264, 35);
            rdoBillCustomer.Name = "rdoBillCustomer";
            rdoBillCustomer.Size = new Size(72, 24);
            rdoBillCustomer.TabIndex = 1;
            rdoBillCustomer.Text = "Billing";
            rdoBillCustomer.UseVisualStyleBackColor = true;
            // 
            // rdoCreditCard
            // 
            rdoCreditCard.AutoSize = true;
            rdoCreditCard.Checked = true;
            rdoCreditCard.Location = new Point(17, 31);
            rdoCreditCard.Name = "rdoCreditCard";
            rdoCreditCard.Size = new Size(105, 24);
            rdoCreditCard.TabIndex = 0;
            rdoCreditCard.TabStop = true;
            rdoCreditCard.Text = "Credit Card";
            rdoCreditCard.UseVisualStyleBackColor = true;
            // 
            // lblCreditCardType
            // 
            lblCreditCardType.AutoSize = true;
            lblCreditCardType.Location = new Point(51, 173);
            lblCreditCardType.Name = "lblCreditCardType";
            lblCreditCardType.Size = new Size(122, 20);
            lblCreditCardType.TabIndex = 1;
            lblCreditCardType.Text = "Credit card type: ";
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Location = new Point(58, 277);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(105, 20);
            lblCardNumber.TabIndex = 2;
            lblCardNumber.Text = "Card Number: ";
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Location = new Point(58, 360);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(119, 20);
            lblExpirationDate.TabIndex = 3;
            lblExpirationDate.Text = "Expiration Date: ";
            // 
            // lstCreditCardType
            // 
            lstCreditCardType.FormattingEnabled = true;
            lstCreditCardType.ItemHeight = 20;
            lstCreditCardType.Location = new Point(261, 174);
            lstCreditCardType.Name = "lstCreditCardType";
            lstCreditCardType.Size = new Size(462, 84);
            lstCreditCardType.TabIndex = 4;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(261, 272);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(462, 27);
            txtCardNumber.TabIndex = 5;
            // 
            // cboExpirationMonth
            // 
            cboExpirationMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExpirationMonth.FormattingEnabled = true;
            cboExpirationMonth.Location = new Point(266, 359);
            cboExpirationMonth.Name = "cboExpirationMonth";
            cboExpirationMonth.Size = new Size(151, 28);
            cboExpirationMonth.TabIndex = 6;
            // 
            // cboExpirationYear
            // 
            cboExpirationYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExpirationYear.FormattingEnabled = true;
            cboExpirationYear.Location = new Point(459, 357);
            cboExpirationYear.Name = "cboExpirationYear";
            cboExpirationYear.Size = new Size(151, 28);
            cboExpirationYear.TabIndex = 7;
            // 
            // chkDefault
            // 
            chkDefault.AutoSize = true;
            chkDefault.Checked = true;
            chkDefault.CheckState = CheckState.Checked;
            chkDefault.Location = new Point(61, 413);
            chkDefault.Name = "chkDefault";
            chkDefault.Size = new Size(223, 24);
            chkDefault.TabIndex = 8;
            chkDefault.Text = "Set as default billing method";
            chkDefault.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(459, 412);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(580, 413);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(chkDefault);
            Controls.Add(cboExpirationYear);
            Controls.Add(cboExpirationMonth);
            Controls.Add(txtCardNumber);
            Controls.Add(lstCreditCardType);
            Controls.Add(lblExpirationDate);
            Controls.Add(lblCardNumber);
            Controls.Add(lblCreditCardType);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPayment";
            Text = "Payment";
            Load += frmPayment_Load;
            TextChanged += frmPayment_TextChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private GroupBox groupBox1;
        private RadioButton rdoBillCustomer;
        private RadioButton rdoCreditCard;
        private Label lblCreditCardType;
        private Label lblCardNumber;
        private Label lblExpirationDate;
        private ListBox lstCreditCardType;
        private TextBox txtCardNumber;
        private ComboBox cboExpirationMonth;
        private ComboBox cboExpirationYear;
        private CheckBox chkDefault;
        private Button btnOK;
        private Button btnCancel;
    }
}