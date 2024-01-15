namespace WCRUD2_MD2.UI
{
    partial class Person
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
            this.BuscarBtt = new System.Windows.Forms.Button();
            this.AgregarBtt = new System.Windows.Forms.Button();
            this.ActualizarBtt = new System.Windows.Forms.Button();
            this.EliminarBtt = new System.Windows.Forms.Button();
            this.dataGridViewPersonas = new System.Windows.Forms.DataGridView();
            this.FiltarTexto = new System.Windows.Forms.TextBox();
            this.FiltarText = new System.Windows.Forms.Label();
            this.ConexionText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarBtt
            // 
            this.BuscarBtt.Location = new System.Drawing.Point(190, 65);
            this.BuscarBtt.Name = "BuscarBtt";
            this.BuscarBtt.Size = new System.Drawing.Size(75, 23);
            this.BuscarBtt.TabIndex = 0;
            this.BuscarBtt.Text = "Buscar";
            this.BuscarBtt.UseVisualStyleBackColor = true;
            this.BuscarBtt.Click += new System.EventHandler(this.BuscarBtt_Click);
            // 
            // AgregarBtt
            // 
            this.AgregarBtt.Location = new System.Drawing.Point(285, 65);
            this.AgregarBtt.Name = "AgregarBtt";
            this.AgregarBtt.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtt.TabIndex = 1;
            this.AgregarBtt.Text = "Agregar";
            this.AgregarBtt.UseVisualStyleBackColor = true;
            this.AgregarBtt.Click += new System.EventHandler(this.AgregarBtt_Click);
            // 
            // ActualizarBtt
            // 
            this.ActualizarBtt.Location = new System.Drawing.Point(378, 65);
            this.ActualizarBtt.Name = "ActualizarBtt";
            this.ActualizarBtt.Size = new System.Drawing.Size(75, 23);
            this.ActualizarBtt.TabIndex = 2;
            this.ActualizarBtt.Text = "Actualizar";
            this.ActualizarBtt.UseVisualStyleBackColor = true;
            this.ActualizarBtt.Click += new System.EventHandler(this.ActualizarBtt_Click);
            // 
            // EliminarBtt
            // 
            this.EliminarBtt.Location = new System.Drawing.Point(471, 65);
            this.EliminarBtt.Name = "EliminarBtt";
            this.EliminarBtt.Size = new System.Drawing.Size(75, 23);
            this.EliminarBtt.TabIndex = 3;
            this.EliminarBtt.Text = "Eliminar";
            this.EliminarBtt.UseVisualStyleBackColor = true;
            this.EliminarBtt.Click += new System.EventHandler(this.EliminarBtt_Click);
            // 
            // dataGridViewPersonas
            // 
            this.dataGridViewPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonas.Location = new System.Drawing.Point(24, 104);
            this.dataGridViewPersonas.Name = "dataGridViewPersonas";
            this.dataGridViewPersonas.Size = new System.Drawing.Size(522, 321);
            this.dataGridViewPersonas.TabIndex = 5;
            // 
            // FiltarTexto
            // 
            this.FiltarTexto.Location = new System.Drawing.Point(24, 65);
            this.FiltarTexto.Name = "FiltarTexto";
            this.FiltarTexto.Size = new System.Drawing.Size(143, 20);
            this.FiltarTexto.TabIndex = 6;
            this.FiltarTexto.Text = "Buscar";
            // 
            // FiltarText
            // 
            this.FiltarText.AutoSize = true;
            this.FiltarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltarText.Location = new System.Drawing.Point(20, 33);
            this.FiltarText.Name = "FiltarText";
            this.FiltarText.Size = new System.Drawing.Size(101, 20);
            this.FiltarText.TabIndex = 7;
            this.FiltarText.Text = "Buscar por:";
            // 
            // ConexionText
            // 
            this.ConexionText.AutoSize = true;
            this.ConexionText.Location = new System.Drawing.Point(439, 9);
            this.ConexionText.Name = "ConexionText";
            this.ConexionText.Size = new System.Drawing.Size(54, 13);
            this.ConexionText.TabIndex = 8;
            this.ConexionText.Text = "Conexion:";
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.ConexionText);
            this.Controls.Add(this.FiltarText);
            this.Controls.Add(this.FiltarTexto);
            this.Controls.Add(this.dataGridViewPersonas);
            this.Controls.Add(this.EliminarBtt);
            this.Controls.Add(this.ActualizarBtt);
            this.Controls.Add(this.AgregarBtt);
            this.Controls.Add(this.BuscarBtt);
            this.Name = "Person";
            this.Text = "Person";
            this.Load += new System.EventHandler(this.Person_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarBtt;
        private System.Windows.Forms.Button AgregarBtt;
        private System.Windows.Forms.Button ActualizarBtt;
        private System.Windows.Forms.Button EliminarBtt;
        private System.Windows.Forms.DataGridView dataGridViewPersonas;
        private System.Windows.Forms.TextBox FiltarTexto;
        private System.Windows.Forms.Label FiltarText;
        private System.Windows.Forms.Label ConexionText;
    }
}