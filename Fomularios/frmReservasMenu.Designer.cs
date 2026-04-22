namespace Kairo.Fomularios
{
    partial class frmReservasMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnReservaHotel = new System.Windows.Forms.Button();
            this.btnReservarLugar = new System.Windows.Forms.Button();
            this.btnReservaGuia = new System.Windows.Forms.Button();
            this.pnlReservas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al menú de reservas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione que servicio desea reservar";
            // 
            // btnReservaHotel
            // 
            this.btnReservaHotel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservaHotel.Location = new System.Drawing.Point(12, 132);
            this.btnReservaHotel.Name = "btnReservaHotel";
            this.btnReservaHotel.Size = new System.Drawing.Size(188, 65);
            this.btnReservaHotel.TabIndex = 2;
            this.btnReservaHotel.Text = "Hotel";
            this.btnReservaHotel.UseVisualStyleBackColor = true;
            // 
            // btnReservarLugar
            // 
            this.btnReservarLugar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarLugar.Location = new System.Drawing.Point(206, 132);
            this.btnReservarLugar.Name = "btnReservarLugar";
            this.btnReservarLugar.Size = new System.Drawing.Size(198, 65);
            this.btnReservarLugar.TabIndex = 3;
            this.btnReservarLugar.Text = "Complejo turistico";
            this.btnReservarLugar.UseVisualStyleBackColor = true;
            // 
            // btnReservaGuia
            // 
            this.btnReservaGuia.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservaGuia.Location = new System.Drawing.Point(410, 132);
            this.btnReservaGuia.Name = "btnReservaGuia";
            this.btnReservaGuia.Size = new System.Drawing.Size(205, 65);
            this.btnReservaGuia.TabIndex = 4;
            this.btnReservaGuia.Text = "Guía turístico";
            this.btnReservaGuia.UseVisualStyleBackColor = true;
            // 
            // pnlReservas
            // 
            this.pnlReservas.BackColor = System.Drawing.Color.MistyRose;
            this.pnlReservas.Location = new System.Drawing.Point(-2, 279);
            this.pnlReservas.Name = "pnlReservas";
            this.pnlReservas.Size = new System.Drawing.Size(930, 670);
            this.pnlReservas.TabIndex = 5;
            // 
            // frmReservasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 953);
            this.Controls.Add(this.pnlReservas);
            this.Controls.Add(this.btnReservaGuia);
            this.Controls.Add(this.btnReservarLugar);
            this.Controls.Add(this.btnReservaHotel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReservasMenu";
            this.Text = "frmReservasMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReservaHotel;
        private System.Windows.Forms.Button btnReservarLugar;
        private System.Windows.Forms.Button btnReservaGuia;
        private System.Windows.Forms.Panel pnlReservas;
    }
}