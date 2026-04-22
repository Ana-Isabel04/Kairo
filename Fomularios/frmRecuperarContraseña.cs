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
    public partial class frmRecuperarContraseña : Form
    {
        Color Pine_tree = ColorTranslator.FromHtml("#202818");
        Color kombu_Green = ColorTranslator.FromHtml("#33432b");
        Color dingley = ColorTranslator.FromHtml("#6A784D");
        Color Brandy = ColorTranslator.FromHtml("#DEC59E");
        Color pale_copper = ColorTranslator.FromHtml("#C4866D");
        public frmRecuperarContraseña()
        {
            InitializeComponent();
            poner_colores();
        }

        private void frmRecuperarContraseña_Load(object sender, EventArgs e)
        {
            HacerCircular(ptbLogo);
            btnRecuperar.BackColor = kombu_Green;
            btnRecuperar.ForeColor = Color.White;
        }

        void poner_colores() {
            
            btnRecuperar.ForeColor = kombu_Green;
            
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
    }
}
