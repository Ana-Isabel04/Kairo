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
    public partial class frmBuscarLugaresCercanos : Form
    {
        public frmBuscarLugaresCercanos()
        {
            InitializeComponent();
        }

        private Color AclararColor(string hex, double factor)
        {
            Color c = ColorTranslator.FromHtml(hex);

            int r = (int)(c.R + (255 - c.R) * factor);
            int g = (int)(c.G + (255 - c.G) * factor);
            int b = (int)(c.B + (255 - c.B) * factor);

            return Color.FromArgb(r, g, b);
        }

        private void frmBuscarLugaresCercanos_Load(object sender, EventArgs e)
        {
            panel1.BackColor= AclararColor("#dec59e", 0.85);
        }
    }
}
