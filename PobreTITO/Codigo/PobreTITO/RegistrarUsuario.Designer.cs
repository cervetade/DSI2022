namespace PobreTITO
{
    partial class RegistrarUsuario
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
            this.textBoxCUIL = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCUIL
            // 
            this.textBoxCUIL.Location = new System.Drawing.Point(15, 67);
            this.textBoxCUIL.Name = "textBoxCUIL";
            this.textBoxCUIL.Size = new System.Drawing.Size(144, 20);
            this.textBoxCUIL.TabIndex = 0;
            this.textBoxCUIL.Text = "CUIL";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(15, 106);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(144, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "Contraseña";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(15, 144);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(144, 20);
            this.textBoxTelefono.TabIndex = 2;
            this.textBoxTelefono.Text = "Telefono";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(27, 191);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(108, 55);
            this.buttonRegistrar.TabIndex = 3;
            this.buttonRegistrar.Text = "Registrarse";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Complete los siguientes datos a continuacion para poder registrarse.";
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxCUIL);
            this.Name = "RegistrarUsuario";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.RegistrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCUIL;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Label label1;
    }
}