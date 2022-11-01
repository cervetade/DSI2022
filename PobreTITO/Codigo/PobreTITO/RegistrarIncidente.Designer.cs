namespace PobreTITO
{
    partial class RegistrarIncidente
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCUIL = new System.Windows.Forms.TextBox();
            this.listBoxProblems = new System.Windows.Forms.ListBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.buttonRegistrarIncidente = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "INCIDENTE";
            // 
            // textBoxCUIL
            // 
            this.textBoxCUIL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCUIL.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.textBoxCUIL.Location = new System.Drawing.Point(120, 88);
            this.textBoxCUIL.Name = "textBoxCUIL";
            this.textBoxCUIL.Size = new System.Drawing.Size(180, 33);
            this.textBoxCUIL.TabIndex = 1;
            this.textBoxCUIL.Text = "CUIL";
            this.textBoxCUIL.TextChanged += new System.EventHandler(this.textBoxCUIL_TextChanged);
            // 
            // listBoxProblems
            // 
            this.listBoxProblems.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxProblems.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProblems.FormattingEnabled = true;
            this.listBoxProblems.ItemHeight = 25;
            this.listBoxProblems.Items.AddRange(new object[] {
            "Alumbrado público",
            "Bacheo",
            "Cloacas",
            "Plazas y espacios",
            "Predio baldio o edificado",
            "Semáforos"});
            this.listBoxProblems.Location = new System.Drawing.Point(120, 217);
            this.listBoxProblems.Name = "listBoxProblems";
            this.listBoxProblems.Size = new System.Drawing.Size(180, 29);
            this.listBoxProblems.TabIndex = 2;
            this.listBoxProblems.SelectedIndexChanged += new System.EventHandler(this.listBoxProblems_SelectedIndexChanged);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDireccion.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.textBoxDireccion.Location = new System.Drawing.Point(120, 153);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(180, 33);
            this.textBoxDireccion.TabIndex = 3;
            this.textBoxDireccion.Text = "Direccion";
            // 
            // buttonRegistrarIncidente
            // 
            this.buttonRegistrarIncidente.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.buttonRegistrarIncidente.Location = new System.Drawing.Point(154, 617);
            this.buttonRegistrarIncidente.Name = "buttonRegistrarIncidente";
            this.buttonRegistrarIncidente.Size = new System.Drawing.Size(119, 39);
            this.buttonRegistrarIncidente.TabIndex = 5;
            this.buttonRegistrarIncidente.Text = "Registrar";
            this.buttonRegistrarIncidente.UseVisualStyleBackColor = true;
            this.buttonRegistrarIncidente.Click += new System.EventHandler(this.buttonRegistrarIncidente_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(29, 276);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(395, 306);
            this.dataGridView.TabIndex = 6;
            // 
            // RegistrarIncidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 668);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonRegistrarIncidente);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.listBoxProblems);
            this.Controls.Add(this.textBoxCUIL);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarIncidente";
            this.Text = "RegistrarIncidente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCUIL;
        private System.Windows.Forms.ListBox listBoxProblems;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Button buttonRegistrarIncidente;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}