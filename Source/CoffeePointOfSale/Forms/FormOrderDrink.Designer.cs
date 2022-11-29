namespace CoffeePointOfSale.Forms
{
    partial class FormOrderDrink
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
            this.orderDrink_Close = new System.Windows.Forms.Button();
            this.addDrink = new System.Windows.Forms.Button();
            this.callPayment = new System.Windows.Forms.Button();
            this.custName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // orderDrink_Close
            // 
            this.orderDrink_Close.BackColor = System.Drawing.Color.Firebrick;
            this.orderDrink_Close.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderDrink_Close.ForeColor = System.Drawing.Color.Transparent;
            this.orderDrink_Close.Location = new System.Drawing.Point(22, 16);
            this.orderDrink_Close.Name = "orderDrink_Close";
            this.orderDrink_Close.Size = new System.Drawing.Size(155, 62);
            this.orderDrink_Close.TabIndex = 0;
            this.orderDrink_Close.Text = "Cancel";
            this.orderDrink_Close.UseVisualStyleBackColor = false;
            this.orderDrink_Close.Click += new System.EventHandler(this.orderDrink_Close_Click);
            // 
            // addDrink
            // 
            this.addDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.addDrink.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addDrink.ForeColor = System.Drawing.Color.Transparent;
            this.addDrink.Location = new System.Drawing.Point(666, 566);
            this.addDrink.Name = "addDrink";
            this.addDrink.Size = new System.Drawing.Size(182, 68);
            this.addDrink.TabIndex = 1;
            this.addDrink.Text = "Add Drink";
            this.addDrink.UseVisualStyleBackColor = false;
            this.addDrink.Click += new System.EventHandler(this.addDrink_Click);
            // 
            // callPayment
            // 
            this.callPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(141)))), ((int)(((byte)(91)))));
            this.callPayment.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.callPayment.ForeColor = System.Drawing.Color.Transparent;
            this.callPayment.Location = new System.Drawing.Point(1116, 568);
            this.callPayment.Name = "callPayment";
            this.callPayment.Size = new System.Drawing.Size(188, 64);
            this.callPayment.TabIndex = 2;
            this.callPayment.TabStop = false;
            this.callPayment.Text = "Payment";
            this.callPayment.UseVisualStyleBackColor = false;
            this.callPayment.Click += new System.EventHandler(this.callPayment_Click);
            // 
            // custName
            // 
            this.custName.AutoSize = true;
            this.custName.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custName.Location = new System.Drawing.Point(989, 16);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(96, 33);
            this.custName.TabIndex = 3;
            this.custName.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Transparent;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(22, 105);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 510);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.listBox2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.ForeColor = System.Drawing.Color.Transparent;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 23;
            this.listBox2.Location = new System.Drawing.Point(502, 105);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(346, 418);
            this.listBox2.TabIndex = 5;
            // 
            // FormOrderDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.callPayment);
            this.Controls.Add(this.addDrink);
            this.Controls.Add(this.orderDrink_Close);
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.Name = "FormOrderDrink";
            this.ShowInTaskbar = false;
            this.Text = "FormOrderDrink";
            this.Load += new System.EventHandler(this.FormOrderDrink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button orderDrink_Close;
        private Button addDrink;
        private Button callPayment;
        private Label custName;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}