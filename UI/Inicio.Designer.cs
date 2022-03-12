namespace ProyectoCodigoLimpioClient.UI
{
    partial class Inicio
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
            this.BttnServer = new System.Windows.Forms.Button();
            this.labelOpcion = new System.Windows.Forms.Label();
            this.BttnCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BttnServer
            // 
            this.BttnServer.Location = new System.Drawing.Point(138, 213);
            this.BttnServer.Name = "BttnServer";
            this.BttnServer.Size = new System.Drawing.Size(75, 23);
            this.BttnServer.TabIndex = 0;
            this.BttnServer.Text = "Servidor";
            this.BttnServer.UseVisualStyleBackColor = true;
            // 
            // labelOpcion
            // 
            this.labelOpcion.AutoSize = true;
            this.labelOpcion.Location = new System.Drawing.Point(286, 102);
            this.labelOpcion.Name = "labelOpcion";
            this.labelOpcion.Size = new System.Drawing.Size(124, 15);
            this.labelOpcion.TabIndex = 1;
            this.labelOpcion.Text = "eres Servidor o Cliente";
            // 
            // BttnCliente
            // 
            this.BttnCliente.Location = new System.Drawing.Point(335, 215);
            this.BttnCliente.Name = "BttnCliente";
            this.BttnCliente.Size = new System.Drawing.Size(75, 23);
            this.BttnCliente.TabIndex = 2;
            this.BttnCliente.Text = "Cliente";
            this.BttnCliente.UseVisualStyleBackColor = true;
            this.BttnCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BttnCliente);
            this.Controls.Add(this.labelOpcion);
            this.Controls.Add(this.BttnServer);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BttnServer;
        private Label labelOpcion;
        private Button BttnCliente;
    }
}