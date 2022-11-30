namespace CoffeePointOfSale.Forms
{
    partial class FormCustomerList
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
            this.bMM_CustList = new System.Windows.Forms.Button();
            this.addCust = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bMM_CustList
            // 
            this.bMM_CustList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.bMM_CustList.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMM_CustList.ForeColor = System.Drawing.Color.Transparent;
            this.bMM_CustList.Location = new System.Drawing.Point(57, 525);
            this.bMM_CustList.Name = "bMM_CustList";
            this.bMM_CustList.Size = new System.Drawing.Size(191, 81);
            this.bMM_CustList.TabIndex = 0;
            this.bMM_CustList.Text = "Main Menu";
            this.bMM_CustList.UseVisualStyleBackColor = false;
            this.bMM_CustList.Click += new System.EventHandler(this.bMM_CustList_Click);
            // 
            // addCust
            // 
            this.addCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.addCust.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCust.ForeColor = System.Drawing.Color.Transparent;
            this.addCust.Location = new System.Drawing.Point(1071, 525);
            this.addCust.Name = "addCust";
            this.addCust.Size = new System.Drawing.Size(204, 81);
            this.addCust.TabIndex = 1;
            this.addCust.Text = "Add Customer";
            this.addCust.UseVisualStyleBackColor = false;
            this.addCust.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Location = new System.Drawing.Point(12, 11);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(1300, 495);
            this.listBox1.TabIndex = 2;
            this.listBox1.UseTabStops = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addCust);
            this.Controls.Add(this.bMM_CustList);
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.Name = "FormCustomerList";
            this.Text = "FormCustomerList";
            this.Load += new System.EventHandler(this.FormCustomerList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bMM_CustList;
        private Button addCust;
        private ListBox listBox1;
        //private Button button;
    }
}