namespace WCRUD2_MD2.UI
{
    partial class NewPerson
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
            this.AgregarBtt = new System.Windows.Forms.Button();
            this.textNewP = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.Label();
            this.EdadText = new System.Windows.Forms.TextBox();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AgregarBtt
            // 
            this.AgregarBtt.Location = new System.Drawing.Point(94, 133);
            this.AgregarBtt.Name = "AgregarBtt";
            this.AgregarBtt.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtt.TabIndex = 0;
            this.AgregarBtt.Text = "Agregar";
            this.AgregarBtt.UseVisualStyleBackColor = true;
            this.AgregarBtt.Click += new System.EventHandler(this.AgregarBtt_Click);
            // 
            // textNewP
            // 
            this.textNewP.AutoSize = true;
            this.textNewP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewP.Location = new System.Drawing.Point(44, 9);
            this.textNewP.Name = "textNewP";
            this.textNewP.Size = new System.Drawing.Size(201, 24);
            this.textNewP.TabIndex = 1;
            this.textNewP.Text = "AGREGA PERSONA";
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Location = new System.Drawing.Point(51, 59);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(47, 13);
            this.textNombre.TabIndex = 2;
            this.textNombre.Text = "Nombre:";
            // 
            // textEdad
            // 
            this.textEdad.AutoSize = true;
            this.textEdad.Location = new System.Drawing.Point(51, 93);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(35, 13);
            this.textEdad.TabIndex = 3;
            this.textEdad.Text = "Edad:";
            // 
            // EdadText
            // 
            this.EdadText.Location = new System.Drawing.Point(121, 90);
            this.EdadText.Name = "EdadText";
            this.EdadText.Size = new System.Drawing.Size(124, 20);
            this.EdadText.TabIndex = 4;
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(121, 52);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(124, 20);
            this.NombreText.TabIndex = 5;
            // 
            // NewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 186);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.EdadText);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textNewP);
            this.Controls.Add(this.AgregarBtt);
            this.Name = "NewPerson";
            this.Text = "NewPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarBtt;
        private System.Windows.Forms.Label textNewP;
        private System.Windows.Forms.Label textNombre;
        private System.Windows.Forms.Label textEdad;
        private System.Windows.Forms.TextBox EdadText;
        private System.Windows.Forms.TextBox NombreText;
    }
}