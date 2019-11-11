namespace NBA3
{
    partial class time
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
            this.txttimes = new System.Windows.Forms.TextBox();
            this.lbltime1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txttimes
            // 
            this.txttimes.Location = new System.Drawing.Point(142, 67);
            this.txttimes.Name = "txttimes";
            this.txttimes.Size = new System.Drawing.Size(100, 20);
            this.txttimes.TabIndex = 0;
            // 
            // lbltime1
            // 
            this.lbltime1.AutoSize = true;
            this.lbltime1.Location = new System.Drawing.Point(165, 51);
            this.lbltime1.Name = "lbltime1";
            this.lbltime1.Size = new System.Drawing.Size(35, 13);
            this.lbltime1.TabIndex = 1;
            this.lbltime1.Text = "Times";
            // 
            // time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 165);
            this.Controls.Add(this.lbltime1);
            this.Controls.Add(this.txttimes);
            this.Name = "time";
            this.Text = "time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttimes;
        private System.Windows.Forms.Label lbltime1;
    }
}