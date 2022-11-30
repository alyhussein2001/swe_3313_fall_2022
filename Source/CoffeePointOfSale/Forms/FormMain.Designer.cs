namespace CoffeePointOfSale.Forms;

sealed partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnManagement = new System.Windows.Forms.Button();
            this.bCustList = new System.Windows.Forms.Button();
            this.bOrderDrink = new System.Windows.Forms.Button();
            this.cafe404 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManagement
            // 
            this.btnManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnManagement.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManagement.ForeColor = System.Drawing.Color.Transparent;
            this.btnManagement.Location = new System.Drawing.Point(414, 458);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(545, 119);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.OnClickBtnManagement);
            // 
            // bCustList
            // 
            this.bCustList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.bCustList.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCustList.ForeColor = System.Drawing.Color.Transparent;
            this.bCustList.Location = new System.Drawing.Point(414, 299);
            this.bCustList.Name = "bCustList";
            this.bCustList.Size = new System.Drawing.Size(545, 119);
            this.bCustList.TabIndex = 1;
            this.bCustList.Text = "Customer List";
            this.bCustList.UseVisualStyleBackColor = false;
            this.bCustList.Click += new System.EventHandler(this.bCustList_Click);
            // 
            // bOrderDrink
            // 
            this.bOrderDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.bOrderDrink.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOrderDrink.ForeColor = System.Drawing.Color.Transparent;
            this.bOrderDrink.Location = new System.Drawing.Point(414, 135);
            this.bOrderDrink.Name = "bOrderDrink";
            this.bOrderDrink.Size = new System.Drawing.Size(545, 119);
            this.bOrderDrink.TabIndex = 2;
            this.bOrderDrink.Text = "Order Drink";
            this.bOrderDrink.UseVisualStyleBackColor = false;
            this.bOrderDrink.Click += new System.EventHandler(this.bOrderDrink_Click);
            // 
            // cafe404
            // 
            this.cafe404.AutoSize = true;
            this.cafe404.Font = new System.Drawing.Font("Lucida Handwriting", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cafe404.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.cafe404.Location = new System.Drawing.Point(448, 23);
            this.cafe404.Name = "cafe404";
            this.cafe404.Size = new System.Drawing.Size(350, 83);
            this.cafe404.TabIndex = 3;
            this.cafe404.Text = "Café 404";
            this.cafe404.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(804, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 119);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cafe404);
            this.Controls.Add(this.bOrderDrink);
            this.Controls.Add(this.bCustList);
            this.Controls.Add(this.btnManagement);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormMainClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button btnManagement;
    private Button bCustList;
    public Button bOrderDrink;
    private Label cafe404;
    private PictureBox pictureBox1;
}