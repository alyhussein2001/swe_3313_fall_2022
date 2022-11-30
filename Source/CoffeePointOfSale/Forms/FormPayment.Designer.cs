namespace CoffeePointOfSale.Forms
{
    partial class FormPayment
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
            this.payCard = new System.Windows.Forms.Button();
            this.payPoints = new System.Windows.Forms.Button();
            this.Cancel_Payment = new System.Windows.Forms.Button();
            this.CCnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // payCard
            // 
            this.payCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.payCard.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payCard.ForeColor = System.Drawing.Color.Transparent;
            this.payCard.Location = new System.Drawing.Point(166, 412);
            this.payCard.Name = "payCard";
            this.payCard.Size = new System.Drawing.Size(204, 55);
            this.payCard.TabIndex = 0;
            this.payCard.Text = "Pay With Card";
            this.payCard.UseVisualStyleBackColor = false;
            this.payCard.Click += new System.EventHandler(this.payCard_Click);
            // 
            // payPoints
            // 
            this.payPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.payPoints.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payPoints.ForeColor = System.Drawing.Color.Transparent;
            this.payPoints.Location = new System.Drawing.Point(941, 412);
            this.payPoints.Name = "payPoints";
            this.payPoints.Size = new System.Drawing.Size(204, 55);
            this.payPoints.TabIndex = 1;
            this.payPoints.Text = "Pay With Points";
            this.payPoints.UseVisualStyleBackColor = false;
            this.payPoints.Click += new System.EventHandler(this.payPoints_Click);
            // 
            // Cancel_Payment
            // 
            this.Cancel_Payment.BackColor = System.Drawing.Color.Brown;
            this.Cancel_Payment.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel_Payment.ForeColor = System.Drawing.Color.Transparent;
            this.Cancel_Payment.Location = new System.Drawing.Point(55, 576);
            this.Cancel_Payment.Name = "Cancel_Payment";
            this.Cancel_Payment.Size = new System.Drawing.Size(151, 55);
            this.Cancel_Payment.TabIndex = 2;
            this.Cancel_Payment.Text = "Cancel";
            this.Cancel_Payment.UseVisualStyleBackColor = false;
            this.Cancel_Payment.Click += new System.EventHandler(this.Cancel_Payment_Click);
            // 
            // CCnumber
            // 
            this.CCnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CCnumber.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CCnumber.Location = new System.Drawing.Point(113, 316);
            this.CCnumber.Name = "CCnumber";
            this.CCnumber.Size = new System.Drawing.Size(338, 50);
            this.CCnumber.TabIndex = 3;
            this.CCnumber.TextChanged += new System.EventHandler(this.CCnumber_TextInput);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(580, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Payment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(138, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Credit Card Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(845, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reward Points Available:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(595, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1031, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 28);
            this.label5.TabIndex = 8;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CCnumber);
            this.Controls.Add(this.Cancel_Payment);
            this.Controls.Add(this.payPoints);
            this.Controls.Add(this.payCard);
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button payCard;
        private Button payPoints;
        private Button Cancel_Payment;
        private TextBox CCnumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
} 