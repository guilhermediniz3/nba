namespace NBA3
{
    partial class Usuariocs
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
            this.btnbotao = new System.Windows.Forms.Button();
            this.butao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbotao
            // 
            this.btnbotao.Location = new System.Drawing.Point(305, 115);
            this.btnbotao.Name = "btnbotao";
            this.btnbotao.Size = new System.Drawing.Size(75, 23);
            this.btnbotao.TabIndex = 10;
            this.btnbotao.Text = "btnbotao";
            this.btnbotao.UseVisualStyleBackColor = true;
            this.btnbotao.Click += new System.EventHandler(this.btnbotao_Click);
            // 
            // butao
            // 
            this.butao.Location = new System.Drawing.Point(100, 115);
            this.butao.Name = "butao";
            this.butao.Size = new System.Drawing.Size(75, 23);
            this.butao.TabIndex = 11;
            this.butao.Text = "button1";
            this.butao.UseVisualStyleBackColor = true;
            this.butao.Click += new System.EventHandler(this.butao_Click);
            // 
            // Usuariocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 384);
            this.Controls.Add(this.butao);
            this.Controls.Add(this.btnbotao);
            this.Name = "Usuariocs";
            this.Text = "Usuariocs";
            this.Load += new System.EventHandler(this.Usuariocs_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnbotao;
        private System.Windows.Forms.Button butao;
    }
}