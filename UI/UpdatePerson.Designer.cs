namespace WCRUD2_MD2.UI
{
    partial class UpdatePerson
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
            this.textBuscarU = new System.Windows.Forms.Label();
            this.textNombreU = new System.Windows.Forms.Label();
            this.textEdadU = new System.Windows.Forms.Label();
            this.FiltrarUP = new System.Windows.Forms.TextBox();
            this.NombreUpdateP = new System.Windows.Forms.TextBox();
            this.EdadUpdateP = new System.Windows.Forms.TextBox();
            this.BuscarPUpdate = new System.Windows.Forms.Button();
            this.UpdateBtt = new System.Windows.Forms.Button();
            this.textUP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBuscarU
            // 
            this.textBuscarU.AutoSize = true;
            this.textBuscarU.Location = new System.Drawing.Point(12, 52);
            this.textBuscarU.Name = "textBuscarU";
            this.textBuscarU.Size = new System.Drawing.Size(57, 13);
            this.textBuscarU.TabIndex = 0;
            this.textBuscarU.Text = "Buscar ID:";
            // 
            // textNombreU
            // 
            this.textNombreU.AutoSize = true;
            this.textNombreU.Location = new System.Drawing.Point(18, 90);
            this.textNombreU.Name = "textNombreU";
            this.textNombreU.Size = new System.Drawing.Size(80, 13);
            this.textNombreU.TabIndex = 1;
            this.textNombreU.Text = "Nombre nuevo:";
            // 
            // textEdadU
            // 
            this.textEdadU.AutoSize = true;
            this.textEdadU.Location = new System.Drawing.Point(18, 127);
            this.textEdadU.Name = "textEdadU";
            this.textEdadU.Size = new System.Drawing.Size(68, 13);
            this.textEdadU.TabIndex = 2;
            this.textEdadU.Text = "Edad nueva:";
            // 
            // FiltrarUP
            // 
            this.FiltrarUP.Location = new System.Drawing.Point(88, 49);
            this.FiltrarUP.Name = "FiltrarUP";
            this.FiltrarUP.Size = new System.Drawing.Size(72, 20);
            this.FiltrarUP.TabIndex = 3;
            // 
            // NombreUpdateP
            // 
            this.NombreUpdateP.Location = new System.Drawing.Point(118, 87);
            this.NombreUpdateP.Name = "NombreUpdateP";
            this.NombreUpdateP.Size = new System.Drawing.Size(135, 20);
            this.NombreUpdateP.TabIndex = 4;
            // 
            // EdadUpdateP
            // 
            this.EdadUpdateP.Location = new System.Drawing.Point(118, 124);
            this.EdadUpdateP.Name = "EdadUpdateP";
            this.EdadUpdateP.Size = new System.Drawing.Size(135, 20);
            this.EdadUpdateP.TabIndex = 5;
            // 
            // BuscarPUpdate
            // 
            this.BuscarPUpdate.Location = new System.Drawing.Point(188, 49);
            this.BuscarPUpdate.Name = "BuscarPUpdate";
            this.BuscarPUpdate.Size = new System.Drawing.Size(75, 23);
            this.BuscarPUpdate.TabIndex = 6;
            this.BuscarPUpdate.Text = "Buscar";
            this.BuscarPUpdate.UseVisualStyleBackColor = true;
            this.BuscarPUpdate.Click += new System.EventHandler(this.BuscarPUpdate_Click);
            // 
            // UpdateBtt
            // 
            this.UpdateBtt.Location = new System.Drawing.Point(85, 161);
            this.UpdateBtt.Name = "UpdateBtt";
            this.UpdateBtt.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtt.TabIndex = 7;
            this.UpdateBtt.Text = "Actualizar";
            this.UpdateBtt.UseVisualStyleBackColor = true;
            this.UpdateBtt.Click += new System.EventHandler(this.UpdateBtt_Click);
            // 
            // textUP
            // 
            this.textUP.AutoSize = true;
            this.textUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUP.Location = new System.Drawing.Point(22, 9);
            this.textUP.Name = "textUP";
            this.textUP.Size = new System.Drawing.Size(241, 24);
            this.textUP.TabIndex = 8;
            this.textUP.Text = "ACTUALIZAR PERSONA";
            // 
            // UpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 198);
            this.Controls.Add(this.textUP);
            this.Controls.Add(this.UpdateBtt);
            this.Controls.Add(this.BuscarPUpdate);
            this.Controls.Add(this.EdadUpdateP);
            this.Controls.Add(this.NombreUpdateP);
            this.Controls.Add(this.FiltrarUP);
            this.Controls.Add(this.textEdadU);
            this.Controls.Add(this.textNombreU);
            this.Controls.Add(this.textBuscarU);
            this.Name = "UpdatePerson";
            this.Text = "UpdatePerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textBuscarU;
        private System.Windows.Forms.Label textNombreU;
        private System.Windows.Forms.Label textEdadU;
        private System.Windows.Forms.TextBox FiltrarUP;
        private System.Windows.Forms.TextBox NombreUpdateP;
        private System.Windows.Forms.TextBox EdadUpdateP;
        private System.Windows.Forms.Button BuscarPUpdate;
        private System.Windows.Forms.Button UpdateBtt;
        private System.Windows.Forms.Label textUP;
    }
}