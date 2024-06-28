namespace Payment
{
    partial class frnCustomer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            cboNames = new ComboBox();
            lblPayment = new Label();
            lblCustomerName = new Label();
            lblPaymentMethod = new Label();
            btnSelectPayment = new Button();
            btnSave = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // cboNames
            // 
            cboNames.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNames.FormattingEnabled = true;
            cboNames.Location = new Point(324, 40);
            cboNames.Name = "cboNames";
            cboNames.Size = new Size(378, 28);
            cboNames.TabIndex = 0;
            cboNames.SelectedIndexChanged += cboNames_SelectedIndexChanged;
            // 
            // lblPayment
            // 
            lblPayment.BorderStyle = BorderStyle.Fixed3D;
            lblPayment.Location = new Point(62, 221);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(383, 168);
            lblPayment.TabIndex = 1;
            lblPayment.TextChanged += lblPayment_TextChanged;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(64, 42);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(123, 20);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Customer Name: ";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(63, 184);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(128, 20);
            lblPaymentMethod.TabIndex = 3;
            lblPaymentMethod.Text = "Payment method: ";
            // 
            // btnSelectPayment
            // 
            btnSelectPayment.Location = new Point(499, 221);
            btnSelectPayment.Name = "btnSelectPayment";
            btnSelectPayment.Size = new Size(203, 34);
            btnSelectPayment.TabIndex = 4;
            btnSelectPayment.Text = "Select Payment";
            btnSelectPayment.UseVisualStyleBackColor = true;
            btnSelectPayment.Click += btnSelectPayment_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(508, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(608, 379);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // frnCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnSelectPayment);
            Controls.Add(lblPaymentMethod);
            Controls.Add(lblCustomerName);
            Controls.Add(lblPayment);
            Controls.Add(cboNames);
            Name = "frnCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += frnCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private ComboBox cboNames;
        private Label lblPayment;
        private Label lblCustomerName;
        private Label lblPaymentMethod;
        private Button btnSelectPayment;
        private Button btnSave;
        private Button btnExit;
    }
}
