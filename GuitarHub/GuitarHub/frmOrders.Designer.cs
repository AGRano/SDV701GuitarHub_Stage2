namespace GuitarHub
{
    partial class frmOrders
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lblOrderIDHeading = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblTotalPriceHeading = new System.Windows.Forms.Label();
            this.lblCustomerEmailHeading = new System.Windows.Forms.Label();
            this.lblCustomerPhoneHeading = new System.Windows.Forms.Label();
            this.lblCustomerAddessHeading = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblTheOrderHeading = new System.Windows.Forms.Label();
            this.lblTotalPriceNumber = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstOrderItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(138, 47);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(280, 22);
            this.txtOrderID.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(138, 101);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(280, 22);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(138, 129);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(280, 22);
            this.txtCustomerAddress.TabIndex = 5;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(138, 157);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(280, 22);
            this.txtCustomerPhone.TabIndex = 6;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(138, 185);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(280, 22);
            this.txtCustomerEmail.TabIndex = 7;
            // 
            // lblOrderIDHeading
            // 
            this.lblOrderIDHeading.AutoSize = true;
            this.lblOrderIDHeading.Location = new System.Drawing.Point(12, 50);
            this.lblOrderIDHeading.Name = "lblOrderIDHeading";
            this.lblOrderIDHeading.Size = new System.Drawing.Size(62, 17);
            this.lblOrderIDHeading.TabIndex = 8;
            this.lblOrderIDHeading.Text = "Order ID";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(12, 453);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(79, 17);
            this.lblOrderDate.TabIndex = 9;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblTotalPriceHeading
            // 
            this.lblTotalPriceHeading.AutoSize = true;
            this.lblTotalPriceHeading.Location = new System.Drawing.Point(12, 248);
            this.lblTotalPriceHeading.Name = "lblTotalPriceHeading";
            this.lblTotalPriceHeading.Size = new System.Drawing.Size(88, 17);
            this.lblTotalPriceHeading.TabIndex = 11;
            this.lblTotalPriceHeading.Text = "Total Price $";
            // 
            // lblCustomerEmailHeading
            // 
            this.lblCustomerEmailHeading.AutoSize = true;
            this.lblCustomerEmailHeading.Location = new System.Drawing.Point(12, 188);
            this.lblCustomerEmailHeading.Name = "lblCustomerEmailHeading";
            this.lblCustomerEmailHeading.Size = new System.Drawing.Size(106, 17);
            this.lblCustomerEmailHeading.TabIndex = 15;
            this.lblCustomerEmailHeading.Text = "Customer Email";
            // 
            // lblCustomerPhoneHeading
            // 
            this.lblCustomerPhoneHeading.AutoSize = true;
            this.lblCustomerPhoneHeading.Location = new System.Drawing.Point(12, 160);
            this.lblCustomerPhoneHeading.Name = "lblCustomerPhoneHeading";
            this.lblCustomerPhoneHeading.Size = new System.Drawing.Size(113, 17);
            this.lblCustomerPhoneHeading.TabIndex = 14;
            this.lblCustomerPhoneHeading.Text = "Customer Phone";
            // 
            // lblCustomerAddessHeading
            // 
            this.lblCustomerAddessHeading.AutoSize = true;
            this.lblCustomerAddessHeading.Location = new System.Drawing.Point(12, 132);
            this.lblCustomerAddessHeading.Name = "lblCustomerAddessHeading";
            this.lblCustomerAddessHeading.Size = new System.Drawing.Size(124, 17);
            this.lblCustomerAddessHeading.TabIndex = 13;
            this.lblCustomerAddessHeading.Text = "Customer Address";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 104);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 17);
            this.lblCustomerName.TabIndex = 12;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblTheOrderHeading
            // 
            this.lblTheOrderHeading.AutoSize = true;
            this.lblTheOrderHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheOrderHeading.Location = new System.Drawing.Point(10, 9);
            this.lblTheOrderHeading.Name = "lblTheOrderHeading";
            this.lblTheOrderHeading.Size = new System.Drawing.Size(62, 25);
            this.lblTheOrderHeading.TabIndex = 39;
            this.lblTheOrderHeading.Text = "Order";
            // 
            // lblTotalPriceNumber
            // 
            this.lblTotalPriceNumber.AutoSize = true;
            this.lblTotalPriceNumber.Location = new System.Drawing.Point(135, 248);
            this.lblTotalPriceNumber.Name = "lblTotalPriceNumber";
            this.lblTotalPriceNumber.Size = new System.Drawing.Size(16, 17);
            this.lblTotalPriceNumber.TabIndex = 40;
            this.lblTotalPriceNumber.Text = "0";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(283, 445);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 33);
            this.btnOK.TabIndex = 41;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstOrderItems
            // 
            this.lstOrderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrderItems.FormattingEnabled = true;
            this.lstOrderItems.ItemHeight = 18;
            this.lstOrderItems.Location = new System.Drawing.Point(12, 289);
            this.lstOrderItems.Name = "lstOrderItems";
            this.lstOrderItems.Size = new System.Drawing.Size(406, 148);
            this.lstOrderItems.TabIndex = 42;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 490);
            this.Controls.Add(this.lstOrderItems);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTotalPriceNumber);
            this.Controls.Add(this.lblTheOrderHeading);
            this.Controls.Add(this.lblCustomerEmailHeading);
            this.Controls.Add(this.lblCustomerPhoneHeading);
            this.Controls.Add(this.lblCustomerAddessHeading);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblTotalPriceHeading);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblOrderIDHeading);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtOrderID);
            this.Name = "frmOrders";
            this.Text = "Guitar Hub | Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lblOrderIDHeading;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblTotalPriceHeading;
        private System.Windows.Forms.Label lblCustomerEmailHeading;
        private System.Windows.Forms.Label lblCustomerPhoneHeading;
        private System.Windows.Forms.Label lblCustomerAddessHeading;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblTheOrderHeading;
        private System.Windows.Forms.Label lblTotalPriceNumber;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lstOrderItems;
    }
}