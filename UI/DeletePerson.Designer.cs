namespace WCRUD2_MD2.UI
{
    partial class DeletePerson
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
            this.textDeleteP = new System.Windows.Forms.Label();
            this.textDNombre = new System.Windows.Forms.Label();
            this.NombreDText = new System.Windows.Forms.Label();
            this.textDEdad = new System.Windows.Forms.Label();
            this.EdadDText = new System.Windows.Forms.Label();
            this.textBuscarID = new System.Windows.Forms.Label();
            this.FiltrarDP = new System.Windows.Forms.TextBox();
            this.BuscarBttD = new System.Windows.Forms.Button();
            this.DeleteBtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDeleteP
            // 
            this.textDeleteP.AutoSize = true;
            this.textDeleteP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDeleteP.Location = new System.Drawing.Point(52, 9);
            this.textDeleteP.Name = "textDeleteP";
            this.textDeleteP.Size = new System.Drawing.Size(210, 24);
            this.textDeleteP.TabIndex = 0;
            this.textDeleteP.Text = "ELIMINAR PERSONA";
            // 
            // textDNombre
            // 
            this.textDNombre.AutoSize = true;
            this.textDNombre.Location = new System.Drawing.Point(53, 106);
            this.textDNombre.Name = "textDNombre";
            this.textDNombre.Size = new System.Drawing.Size(47, 13);
            this.textDNombre.TabIndex = 2;
            this.textDNombre.Text = "Nombre:";
            // 
            // NombreDText
            // 
            this.NombreDText.AutoSize = true;
            this.NombreDText.Location = new System.Drawing.Point(134, 106);
            this.NombreDText.Name = "NombreDText";
            this.NombreDText.Size = new System.Drawing.Size(91, 13);
            this.NombreDText.TabIndex = 3;
            this.NombreDText.Text = "----------------------------";
            // 
            // textDEdad
            // 
            this.textDEdad.AutoSize = true;
            this.textDEdad.Location = new System.Drawing.Point(53, 146);
            this.textDEdad.Name = "textDEdad";
            this.textDEdad.Size = new System.Drawing.Size(35, 13);
            this.textDEdad.TabIndex = 4;
            this.textDEdad.Text = "Edad:";
            // 
            // EdadDText
            // 
            this.EdadDText.AutoSize = true;
            this.EdadDText.Location = new System.Drawing.Point(134, 146);
            this.EdadDText.Name = "EdadDText";
            this.EdadDText.Size = new System.Drawing.Size(91, 13);
            this.EdadDText.TabIndex = 5;
            this.EdadDText.Text = "----------------------------";
            // 
            // textBuscarID
            // 
            this.textBuscarID.AutoSize = true;
            this.textBuscarID.Location = new System.Drawing.Point(12, 59);
            this.textBuscarID.Name = "textBuscarID";
            this.textBuscarID.Size = new System.Drawing.Size(57, 13);
            this.textBuscarID.TabIndex = 6;
            this.textBuscarID.Text = "Buscar ID:";
            // 
            // FiltrarDP
            // 
            this.FiltrarDP.Location = new System.Drawing.Point(94, 56);
            this.FiltrarDP.Name = "FiltrarDP";
            this.FiltrarDP.Size = new System.Drawing.Size(100, 20);
            this.FiltrarDP.TabIndex = 7;
            // 
            // BuscarBttD
            // 
            this.BuscarBttD.Location = new System.Drawing.Point(215, 59);
            this.BuscarBttD.Name = "BuscarBttD";
            this.BuscarBttD.Size = new System.Drawing.Size(75, 23);
            this.BuscarBttD.TabIndex = 8;
            this.BuscarBttD.Text = "Buscar";
            this.BuscarBttD.UseVisualStyleBackColor = true;
            this.BuscarBttD.Click += new System.EventHandler(this.BuscarBttD_Click);
            // 
            // DeleteBtt
            // 
            this.DeleteBtt.Location = new System.Drawing.Point(94, 202);
            this.DeleteBtt.Name = "DeleteBtt";
            this.DeleteBtt.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtt.TabIndex = 9;
            this.DeleteBtt.Text = "Eliminar";
            this.DeleteBtt.UseVisualStyleBackColor = true;
            this.DeleteBtt.Click += new System.EventHandler(this.DeleteBtt_Click);
            // 
            // DeletePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 254);
            this.Controls.Add(this.DeleteBtt);
            this.Controls.Add(this.BuscarBttD);
            this.Controls.Add(this.FiltrarDP);
            this.Controls.Add(this.textBuscarID);
            this.Controls.Add(this.EdadDText);
            this.Controls.Add(this.textDEdad);
            this.Controls.Add(this.NombreDText);
            this.Controls.Add(this.textDNombre);
            this.Controls.Add(this.textDeleteP);
            this.Name = "DeletePerson";
            this.Text = "DeletePerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textDeleteP;
        private System.Windows.Forms.Label textDNombre;
        private System.Windows.Forms.Label NombreDText;
        private System.Windows.Forms.Label textDEdad;
        private System.Windows.Forms.Label EdadDText;
        private System.Windows.Forms.Label textBuscarID;
        private System.Windows.Forms.TextBox FiltrarDP;
        private System.Windows.Forms.Button BuscarBttD;
        private System.Windows.Forms.Button DeleteBtt;
    }
}