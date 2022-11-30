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
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderMenuTxt = new System.Windows.Forms.Label();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.VerticalLine = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // orderDrink_Close
            // 
            this.orderDrink_Close.BackColor = System.Drawing.Color.Firebrick;
            this.orderDrink_Close.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderDrink_Close.ForeColor = System.Drawing.Color.Transparent;
            this.orderDrink_Close.Location = new System.Drawing.Point(22, 515);
            this.orderDrink_Close.Name = "orderDrink_Close";
            this.orderDrink_Close.Size = new System.Drawing.Size(182, 97);
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
            this.addDrink.Location = new System.Drawing.Point(715, 515);
            this.addDrink.Name = "addDrink";
            this.addDrink.Size = new System.Drawing.Size(182, 97);
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
            this.callPayment.Location = new System.Drawing.Point(1112, 579);
            this.callPayment.Name = "callPayment";
            this.callPayment.Size = new System.Drawing.Size(188, 78);
            this.callPayment.TabIndex = 2;
            this.callPayment.TabStop = false;
            this.callPayment.Text = "Payment";
            this.callPayment.UseVisualStyleBackColor = false;
            this.callPayment.Click += new System.EventHandler(this.callPayment_Click);
            // 
            // custName
            // 
            this.custName.AutoSize = true;
            this.custName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.custName.Location = new System.Drawing.Point(933, 29);
            this.custName.MinimumSize = new System.Drawing.Size(370, 0);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(370, 30);
            this.custName.TabIndex = 3;
            this.custName.Text = "label1";
            this.custName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.custName.Click += new System.EventHandler(this.custName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1195, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tax: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.richTextBox1.Location = new System.Drawing.Point(967, 105);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(337, 347);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1155, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Subtotal: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1183, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total: ";
            // 
            // OrderMenuTxt
            // 
            this.OrderMenuTxt.AutoSize = true;
            this.OrderMenuTxt.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderMenuTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.OrderMenuTxt.Location = new System.Drawing.Point(22, 13);
            this.OrderMenuTxt.Name = "OrderMenuTxt";
            this.OrderMenuTxt.Size = new System.Drawing.Size(256, 49);
            this.OrderMenuTxt.TabIndex = 11;
            this.OrderMenuTxt.Text = "Order Menu";
            // 
            // horizontalLine
            // 
            this.horizontalLine.AutoSize = true;
            this.horizontalLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.horizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horizontalLine.Location = new System.Drawing.Point(-4, 81);
            this.horizontalLine.MaximumSize = new System.Drawing.Size(0, 2);
            this.horizontalLine.MinimumSize = new System.Drawing.Size(1348, 0);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(1348, 2);
            this.horizontalLine.TabIndex = 12;
            this.horizontalLine.Click += new System.EventHandler(this.horizontalLine_Click);
            // 
            // VerticalLine
            // 
            this.VerticalLine.AutoSize = true;
            this.VerticalLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.VerticalLine.Location = new System.Drawing.Point(940, -7);
            this.VerticalLine.MaximumSize = new System.Drawing.Size(2, 0);
            this.VerticalLine.MinimumSize = new System.Drawing.Size(2, 721);
            this.VerticalLine.Name = "VerticalLine";
            this.VerticalLine.Size = new System.Drawing.Size(2, 721);
            this.VerticalLine.TabIndex = 13;
            this.VerticalLine.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.listBox2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.ForeColor = System.Drawing.Color.Transparent;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 23;
            this.listBox2.Location = new System.Drawing.Point(497, 105);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(400, 349);
            this.listBox2.TabIndex = 5;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Transparent;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(12, 105);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 280);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FormOrderDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.VerticalLine);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.OrderMenuTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.callPayment);
            this.Controls.Add(this.addDrink);
            this.Controls.Add(this.orderDrink_Close);
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.MinimumSize = new System.Drawing.Size(0, 454);
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
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label3;
        private Label OrderMenuTxt;
        private Label horizontalLine;
        private Label VerticalLine;
        private ListBox listBox2;
        private ListBox listBox1;
    }
}