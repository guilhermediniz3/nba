namespace NBA3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imlbutton = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(438, 261);
            this.txtsenha.MaxLength = 8;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(70, 22);
            this.txtsenha.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(438, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusuario.Location = new System.Drawing.Point(454, 205);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuário";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsenha.Location = new System.Drawing.Point(454, 244);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(53, 13);
            this.lblsenha.TabIndex = 3;
            this.lblsenha.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imlbutton;
            this.button1.Location = new System.Drawing.Point(514, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // imlbutton
            // 
            this.imlbutton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlbutton.ImageStream")));
            this.imlbutton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlbutton.Images.SetKeyName(0, "bolas.png");
            this.imlbutton.Images.SetKeyName(1, "bola.png");
            this.imlbutton.Images.SetKeyName(2, "simbolo-de-icone-de-acesso-chave-de-seguranca_53876-74634.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::NBA3.Properties.Resources.nba3;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtsenha);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imlbutton;
    }
}

