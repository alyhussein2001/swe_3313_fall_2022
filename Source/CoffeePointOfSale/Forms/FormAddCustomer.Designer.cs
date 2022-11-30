namespace CoffeePointOfSale.Forms
{
    partial class FormAddCustomer
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
            this.firstLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addNew = new System.Windows.Forms.Button();
            this.addCust_Cancel = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.label_addCustomer = new System.Windows.Forms.Label();
            this.cust_data_error = new System.Windows.Forms.Label();
            this.invalidDataError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.firstLabel.Location = new System.Drawing.Point(354, 152);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(247, 49);
            this.firstLabel.TabIndex = 1;
            this.firstLabel.Text = "First Name: ";
            this.firstLabel.Click += new System.EventHandler(this.firstLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(650, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 36);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "\r\n\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.FirstName);
            // 
            // lastName
            // 
            this.lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(650, 258);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(350, 36);
            this.lastName.TabIndex = 3;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(354, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Name:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumber.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.Location = new System.Drawing.Point(650, 353);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(350, 36);
            this.phoneNumber.TabIndex = 5;
            this.phoneNumber.TextChanged += new System.EventHandler(this.phoneNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(271, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone Number:";
            // 
            // addNew
            // 
            this.addNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.addNew.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNew.ForeColor = System.Drawing.Color.Transparent;
            this.addNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNew.Location = new System.Drawing.Point(659, 519);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(148, 63);
            this.addNew.TabIndex = 7;
            this.addNew.Text = "Add";
            this.addNew.UseVisualStyleBackColor = false;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // addCust_Cancel
            // 
            this.addCust_Cancel.BackColor = System.Drawing.Color.Brown;
            this.addCust_Cancel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCust_Cancel.ForeColor = System.Drawing.Color.Transparent;
            this.addCust_Cancel.Location = new System.Drawing.Point(1147, 570);
            this.addCust_Cancel.Name = "addCust_Cancel";
            this.addCust_Cancel.Size = new System.Drawing.Size(143, 52);
            this.addCust_Cancel.TabIndex = 8;
            this.addCust_Cancel.Text = "Cancel";
            this.addCust_Cancel.UseVisualStyleBackColor = false;
            this.addCust_Cancel.Click += new System.EventHandler(this.addCust_Cancel_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(639, 486);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(181, 21);
            this.error.TabIndex = 9;
            this.error.Text = "All fields must be filled!";
            this.error.Click += new System.EventHandler(this.error_Click);
            // 
            // label_addCustomer
            // 
            this.label_addCustomer.AutoSize = true;
            this.label_addCustomer.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_addCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.label_addCustomer.Location = new System.Drawing.Point(544, 43);
            this.label_addCustomer.Name = "label_addCustomer";
            this.label_addCustomer.Size = new System.Drawing.Size(301, 47);
            this.label_addCustomer.TabIndex = 10;
            this.label_addCustomer.Text = "Add Customer";
            this.label_addCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_addCustomer.Click += new System.EventHandler(this.label3_Click);
            // 
            // cust_data_error
            // 
            this.cust_data_error.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cust_data_error.ForeColor = System.Drawing.Color.Red;
            this.cust_data_error.Location = new System.Drawing.Point(580, 486);
            this.cust_data_error.Name = "cust_data_error";
            this.cust_data_error.Size = new System.Drawing.Size(291, 21);
            this.cust_data_error.TabIndex = 10;
            this.cust_data_error.Text = "This customer is already in the database!";
            this.cust_data_error.Click += new System.EventHandler(this.cust_data_error_Click);
            // 
            // invalidDataError
            // 
            this.invalidDataError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invalidDataError.ForeColor = System.Drawing.Color.Red;
            this.invalidDataError.Location = new System.Drawing.Point(580, 486);
            this.invalidDataError.Name = "invalidDataError";
            this.invalidDataError.Size = new System.Drawing.Size(291, 21);
            this.invalidDataError.TabIndex = 11;
            this.invalidDataError.Text = "Invalid Data!";
            this.invalidDataError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.invalidDataError);
            this.Controls.Add(this.label_addCustomer);
            this.Controls.Add(this.cust_data_error);
            this.Controls.Add(this.error);
            this.Controls.Add(this.addCust_Cancel);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.firstLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "FormAddCustomer";
            this.Text = "FormAddCustomer";
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label firstLabel;
        private TextBox textBox1;
        private TextBox lastName;
        private Label label1;
        private TextBox phoneNumber;
        private Label label2;
        private Button addNew;
        private Button addCust_Cancel;
        private Label error;
        private Label label_addCustomer;
        private Label cust_data_error;
        private Label invalidDataError;
    }
}