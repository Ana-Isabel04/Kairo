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
    public partial class frmNotificacion : Form
    {
        Color Pine_tree = ColorTranslator.FromHtml("#202818");
        Color kombu_Green = ColorTranslator.FromHtml("#33432b");
        Color dingley = ColorTranslator.FromHtml("#6A784D");
        Color Brandy = ColorTranslator.FromHtml("#DEC59E");
        Color pale_copper = ColorTranslator.FromHtml("#C4866D");
        public frmNotificacion()
        {
            InitializeComponent();
            this.BackColor = AclararColor("#dec59e", 0.85);

        }

        private Color AclararColor(string hex, double factor)
        {
            Color c = ColorTranslator.FromHtml(hex);

            int r = (int)(c.R + (255 - c.R) * factor);
            int g = (int)(c.G + (255 - c.G) * factor);
            int b = (int)(c.B + (255 - c.B) * factor);

            return Color.FromArgb(r, g, b);
        }

        private void HacerCircular(PictureBox pic)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pic.Width, pic.Height);
            pic.Region = new Region(path);
        }

        private void frmNotificacion_Load(object sender, EventArgs e)
        {
            HacerCircular(ptbLogoKairo);
            btnProceder.BackColor = Pine_tree;
            HacerBotonRedondeado(btnProceder,20);
            btnProceder.ForeColor= AclararColor("#dec59e", 0.85);
        }

        public void HacerBotonRedondeado(Button btn, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            int d = radio * 2;

            // Esquinas redondeadas
            path.AddArc(0, 0, d, d, 180, 90); // arriba izquierda
            path.AddArc(btn.Width - d, 0, d, d, 270, 90); // arriba derecha
            path.AddArc(btn.Width - d, btn.Height - d, d, d, 0, 90); // abajo derecha
            path.AddArc(0, btn.Height - d, d, d, 90, 90); // abajo izquierda

            path.CloseFigure();

            btn.Region = new Region(path);

            // Opcional: quitar borde feo
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }

    }
}
