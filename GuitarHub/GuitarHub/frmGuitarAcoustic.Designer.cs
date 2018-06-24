namespace GuitarHub
{
    partial class frmGuitarAcoustic
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
            this.lblHollow = new System.Windows.Forms.Label();
            this.lblElectric = new System.Windows.Forms.Label();
            this.txtHollow = new System.Windows.Forms.TextBox();
            this.txtElectric = new System.Windows.Forms.TextBox();
            this.lblAddAcousticGuitar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHollow
            // 
            this.lblHollow.AutoSize = true;
            this.lblHollow.Location = new System.Drawing.Point(56, 284);
            this.lblHollow.Name = "lblHollow";
            this.lblHollow.Size = new System.Drawing.Size(49, 17);
            this.lblHollow.TabIndex = 45;
            this.lblHollow.Text = "Hollow";
            // 
            // lblElectric
            // 
            this.lblElectric.AutoSize = true;
            this.lblElectric.Location = new System.Drawing.Point(56, 255);
            this.lblElectric.Name = "lblElectric";
            this.lblElectric.Size = new System.Drawing.Size(54, 17);
            this.lblElectric.TabIndex = 44;
            this.lblElectric.Text = "Electric";
            // 
            // txtHollow
            // 
            this.txtHollow.Location = new System.Drawing.Point(130, 280);
            this.txtHollow.Name = "txtHollow";
            this.txtHollow.Size = new System.Drawing.Size(168, 22);
            this.txtHollow.TabIndex = 43;
            // 
            // txtElectric
            // 
            this.txtElectric.Location = new System.Drawing.Point(130, 251);
            this.txtElectric.Name = "txtElectric";
            this.txtElectric.Size = new System.Drawing.Size(168, 22);
            this.txtElectric.TabIndex = 42;
            // 
            // lblAddAcousticGuitar
            // 
            this.lblAddAcousticGuitar.AutoSize = true;
            this.lblAddAcousticGuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAcousticGuitar.Location = new System.Drawing.Point(12, 9);
            this.lblAddAcousticGuitar.Name = "lblAddAcousticGuitar";
            this.lblAddAcousticGuitar.Size = new System.Drawing.Size(185, 25);
            this.lblAddAcousticGuitar.TabIndex = 46;
            this.lblAddAcousticGuitar.Text = "Add Acoustic Guitar";
            // 
            // frmGuitarAcoustic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(356, 403);
            this.Controls.Add(this.lblAddAcousticGuitar);
            this.Controls.Add(this.lblHollow);
            this.Controls.Add(this.lblElectric);
            this.Controls.Add(this.txtHollow);
            this.Controls.Add(this.txtElectric);
            this.Name = "frmGuitarAcoustic";
            this.Text = "Add Acoustic Guitar";
            this.Controls.SetChildIndex(this.txtElectric, 0);
            this.Controls.SetChildIndex(this.txtHollow, 0);
            this.Controls.SetChildIndex(this.lblElectric, 0);
            this.Controls.SetChildIndex(this.lblHollow, 0);
            this.Controls.SetChildIndex(this.lblAddAcousticGuitar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHollow;
        private System.Windows.Forms.Label lblElectric;
        private System.Windows.Forms.TextBox txtHollow;
        private System.Windows.Forms.TextBox txtElectric;
        private System.Windows.Forms.Label lblAddAcousticGuitar;
    }
}
