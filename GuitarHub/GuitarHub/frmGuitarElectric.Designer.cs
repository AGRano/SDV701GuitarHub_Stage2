namespace GuitarHub
{
    partial class frmGuitarElectric
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
            this.txtTremolo = new System.Windows.Forms.TextBox();
            this.txtPickup = new System.Windows.Forms.TextBox();
            this.lblTremolo = new System.Windows.Forms.Label();
            this.lblPickup = new System.Windows.Forms.Label();
            this.lblAddElectricGuitar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTremolo
            // 
            this.txtTremolo.Location = new System.Drawing.Point(130, 250);
            this.txtTremolo.Name = "txtTremolo";
            this.txtTremolo.Size = new System.Drawing.Size(168, 22);
            this.txtTremolo.TabIndex = 38;
            this.txtTremolo.Text = "Y";
            // 
            // txtPickup
            // 
            this.txtPickup.Location = new System.Drawing.Point(130, 279);
            this.txtPickup.Name = "txtPickup";
            this.txtPickup.Size = new System.Drawing.Size(168, 22);
            this.txtPickup.TabIndex = 39;
            this.txtPickup.Text = "HB";
            // 
            // lblTremolo
            // 
            this.lblTremolo.AutoSize = true;
            this.lblTremolo.Location = new System.Drawing.Point(56, 254);
            this.lblTremolo.Name = "lblTremolo";
            this.lblTremolo.Size = new System.Drawing.Size(60, 17);
            this.lblTremolo.TabIndex = 40;
            this.lblTremolo.Text = "Tremolo";
            // 
            // lblPickup
            // 
            this.lblPickup.AutoSize = true;
            this.lblPickup.Location = new System.Drawing.Point(56, 283);
            this.lblPickup.Name = "lblPickup";
            this.lblPickup.Size = new System.Drawing.Size(50, 17);
            this.lblPickup.TabIndex = 41;
            this.lblPickup.Text = "Pickup";
            // 
            // lblAddElectricGuitar
            // 
            this.lblAddElectricGuitar.AutoSize = true;
            this.lblAddElectricGuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddElectricGuitar.Location = new System.Drawing.Point(12, 9);
            this.lblAddElectricGuitar.Name = "lblAddElectricGuitar";
            this.lblAddElectricGuitar.Size = new System.Drawing.Size(173, 25);
            this.lblAddElectricGuitar.TabIndex = 42;
            this.lblAddElectricGuitar.Text = "Add Electric Guitar";
            // 
            // frmGuitarElectric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(360, 405);
            this.Controls.Add(this.lblAddElectricGuitar);
            this.Controls.Add(this.lblPickup);
            this.Controls.Add(this.lblTremolo);
            this.Controls.Add(this.txtPickup);
            this.Controls.Add(this.txtTremolo);
            this.Name = "frmGuitarElectric";
            this.Text = "Add Electric Guitar";
            this.Controls.SetChildIndex(this.txtTremolo, 0);
            this.Controls.SetChildIndex(this.txtPickup, 0);
            this.Controls.SetChildIndex(this.lblTremolo, 0);
            this.Controls.SetChildIndex(this.lblPickup, 0);
            this.Controls.SetChildIndex(this.lblAddElectricGuitar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTremolo;
        private System.Windows.Forms.TextBox txtPickup;
        private System.Windows.Forms.Label lblTremolo;
        private System.Windows.Forms.Label lblPickup;
        private System.Windows.Forms.Label lblAddElectricGuitar;
    }
}
