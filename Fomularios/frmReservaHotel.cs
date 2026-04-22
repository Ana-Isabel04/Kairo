using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kairo.Fomularios
{
    public partial class frmReservaHotel : Form
    {

        Color Pine_tree = ColorTranslator.FromHtml("#202818");
        Color kombu_Green = ColorTranslator.FromHtml("#33432b");
        Color dingley = ColorTranslator.FromHtml("#6A784D");
        Color Brandy = ColorTranslator.FromHtml("#DEC59E");
        Color pale_copper = ColorTranslator.FromHtml("#C4866D");
        public frmReservaHotel()
        {
            InitializeComponent();
        }

        private void frmReservaHotel_Load(object sender, EventArgs e)
        {
            btnConfirmar.BackColor = kombu_Green;
            pnlTotal.BackColor = AclararColor("#dec59e", 0.85);
            btnConfirmar.ForeColor= AclararColor("#dec59e", 0.85);

        }

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
