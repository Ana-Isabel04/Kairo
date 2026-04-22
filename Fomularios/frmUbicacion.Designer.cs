namespace Kairo.Fomularios
{
    partial class frmUbicacion
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
            this.ptbUbicacion = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Acceso a la ubicación!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solicitamos la ubicación del \r\ndispositivo para que sigas disfrutando\r\nde todas l" +
    "as funciones de nuestra aplicación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbUbicacion
            // 
            this.ptbUbicacion.BackgroundImage = global::Kairo.Properties.Resources.UbicacionVerde;
            this.ptbUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbUbicacion.Location = new System.Drawing.Point(133, 88);
            this.ptbUbicacion.Name = "ptbUbicacion";
            this.ptbUbicacion.Size = new System.Drawing.Size(130, 130);
            this.ptbUbicacion.TabIndex = 2;
            this.ptbUbicacion.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(0, 310);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(401, 66);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Permitir el acceso";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(401, 66);
            this.button2.TabIndex = 4;
            this.button2.Text = "No permitir el acceso";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackgroundImage = global::Kairo.Properties.Resources.logo;
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbLogo.Location = new System.Drawing.Point(54, 38);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(50, 50);
            this.ptbLogo.TabIndex = 5;
            this.ptbLogo.TabStop = false;
            // 
            // frmUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 436);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.ptbUbicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUbicacion";
            this.Text = "frmUbicacion";
            this.Load += new System.EventHandler(this.frmUbicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbUbicacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox ptbLogo;
    }
}