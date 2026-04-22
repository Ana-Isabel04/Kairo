using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kairo.Fomularios
{
    public partial class frmEncontrarRecomendacion : Form
    {
        public frmEncontrarRecomendacion()
        {
            InitializeComponent();
        }

        private void frmEncontrarRecomendacion_Load(object sender, EventArgs e)
        {
            bonito();
        }

       void bonito()
        {
            // 🎨 FONDO
            pnlCentro.BackColor = AclararColor("#dec59e", 0.85);

            // 🎯 CONFIGURAR BOTONES
            ConfigurarBotonBorde(btnAventura, "#33432B");
            ConfigurarBotonBorde(btnCultura, "#6A784D");
            ConfigurarBotonBorde(btnEcoturismo, "#DEC59E");
            ConfigurarBotonBorde(btnFamiliar, "#33432B");
            ConfigurarBotonBorde(btnGastronomia, "#6A784D");
            ConfigurarBotonBorde(btnHistoria, "#DEC59E");
            ConfigurarBotonBorde(btnMontaña, "#C4866D");
            ConfigurarBotonBorde(btnNoche, "#33432B");
            ConfigurarBotonBorde(btnPlaya, "#6A784D");
            ConfigurarBotonBorde(btnRelajacion, "#DEC59E");

            // 🎯 EVENTOS CLICK
            btnAventura.Click += (s, ev) => SeleccionarBoton(btnAventura, "#33432B");
            btnCultura.Click += (s, ev) => SeleccionarBoton(btnCultura, "#6A784D");
            btnEcoturismo.Click += (s, ev) => SeleccionarBoton(btnEcoturismo, "#DEC59E");
            btnFamiliar.Click += (s, ev) => SeleccionarBoton(btnFamiliar, "#C4866D");
            btnGastronomia.Click += (s, ev) => SeleccionarBoton(btnGastronomia, "#33432B");
            btnHistoria.Click += (s, ev) => SeleccionarBoton(btnHistoria, "#6A784D");
            btnMontaña.Click += (s, ev) => SeleccionarBoton(btnMontaña, "#DEC59E");
            btnNoche.Click += (s, ev) => SeleccionarBoton(btnNoche, "#C4866D");
            btnPlaya.Click += (s, ev) => SeleccionarBoton(btnPlaya, "#33432B");
            btnRelajacion.Click += (s, ev) => SeleccionarBoton(btnRelajacion, "#6A784D");
        }

        private void FrmDificultad_Resize(object sender, EventArgs e)
        {
            RedondearControl(btnAventura, 20);
            RedondearControl(btnCultura, 20);
            RedondearControl(btnEcoturismo, 20);
            RedondearControl(btnFamiliar, 20);
            RedondearControl(btnGastronomia, 20);
            RedondearControl(btnHistoria, 20);
            RedondearControl(btnMontaña, 20);
            RedondearControl(btnNoche, 20);
            RedondearControl(btnPlaya, 20);
            RedondearControl(btnRelajacion, 20);
        }

        // 🎯 BOTÓN SOLO BORDE
        private void ConfigurarBotonBorde(Button btn, string colorHex)
        {
            Color color = ColorTranslator.FromHtml(colorHex);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = color;

            btn.BackColor = this.BackColor; // mismo fondo
            btn.ForeColor = color;

            RedondearControl(btn, 20);
        }

        // 🔥 SELECCIÓN (RELLENA)
        private void SeleccionarBoton(Button seleccionado, string colorHex)
        {
            // Resetear todos
            ResetBoton(btnAventura, "#33432B");
            ResetBoton(btnCultura, "#6A784D");
            ResetBoton(btnEcoturismo, "#DEC59E");
            ResetBoton(btnFamiliar, "#C4866D");
            ResetBoton(btnGastronomia, "#33432B");
            ResetBoton(btnHistoria, "#6A784D");
            ResetBoton(btnMontaña, "#DEC59E");
            ResetBoton(btnNoche, "#C4866D");
            ResetBoton(btnPlaya, "#DEC59E");
            ResetBoton(btnRelajacion, "#C4866D");

            // Activar seleccionado
            Color color = ColorTranslator.FromHtml(colorHex);
            seleccionado.BackColor = color;
            seleccionado.ForeColor = Color.White;
        }

        // 🔄 RESET BOTÓN
        private void ResetBoton(Button btn, string colorHex)
        {
            Color color = ColorTranslator.FromHtml(colorHex);

            btn.BackColor = this.BackColor;
            btn.ForeColor = color;
            btn.FlatAppearance.BorderColor = color;
        }

        // 🔵 REDONDEAR
        private void RedondearControl(Control ctrl, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(ctrl.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(ctrl.Width - radio, ctrl.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, ctrl.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            ctrl.Region = new Region(path);
        }

        // 🎨 ACLARAR COLOR
        private Color AclararColor(string hex, double factor)
        {
            Color c = ColorTranslator.FromHtml(hex);

            int r = (int)(c.R + (255 - c.R) * factor);
            int g = (int)(c.G + (255 - c.G) * factor);
            int b = (int)(c.B + (255 - c.B) * factor);

            return Color.FromArgb(r, g, b);
        }
    }
           
}

