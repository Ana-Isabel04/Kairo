using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Kairo.Fomularios
{
    public partial class frmMirarFotos : Form
    {
        Color Pine_tree = ColorTranslator.FromHtml("#202818");
        Color kombu_Green = ColorTranslator.FromHtml("#33432b");
        Color dingley = ColorTranslator.FromHtml("#6A784D");
        Color Brandy = ColorTranslator.FromHtml("#DEC59E");
        Color pale_copper = ColorTranslator.FromHtml("#C4866D");
        public frmMirarFotos()
        {
            InitializeComponent();
            this.BackColor= AclararColor("#dec59e", 0.85);
        }



        private void frmMirarFotos_Load(object sender, EventArgs e)
        {
            AplicarFormaCorazon(btnLike, Color.Red);
            AplicarFormaComentario(btnComentar, Color.Gray);
            AplicarFormaCircular(btnAnterior, btnAnterior.BackColor=Brandy);
            AplicarFormaCircular(btnSiguiente, btnSiguiente.BackColor =Brandy);
            pnlFeed.BackColor = Brandy;
        }

        private void AplicarFormaCircular(Button btn, Color color)
        {
            GraphicsPath path = new GraphicsPath();

            int size = Math.Min(btn.Width, btn.Height);
            int x = (btn.Width - size) / 2;
            int y = (btn.Height - size) / 2;

            path.AddEllipse(x, y, size, size);

            AplicarEstiloBoton(btn, path, color);
        }
        private void AplicarFormaCorazon(Button btn, Color color)
        {
            GraphicsPath path = new GraphicsPath();

            int w = btn.Width;
            int h = btn.Height;

            path.StartFigure();

            path.AddBezier(
                new PointF(w / 2f, h),
                new PointF(w * 1f, h * 0.6f),
                new PointF(w * 0.8f, h * 0.1f),
                new PointF(w / 2f, h * 0.3f)
            );

            path.AddBezier(
                new PointF(w / 2f, h * 0.3f),
                new PointF(w * 0.2f, h * 0.1f),
                new PointF(0, h * 0.6f),
                new PointF(w / 2f, h)
            );

            path.CloseFigure();

            AplicarEstiloBoton(btn, path, color);
        }

        private void AplicarFormaComentario(Button btn, Color color)
        {
            GraphicsPath path = new GraphicsPath();

            int w = btn.Width;
            int h = btn.Height;

            Rectangle rect = new Rectangle(0, 0, w, (int)(h * 0.75));
            int radio = 20;

            path.StartFigure();

            // Rectángulo redondeado
            path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
            path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
            path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
            path.CloseFigure();

            // Cola
            Point p1 = new Point(w / 3, (int)(h * 0.75));
            Point p2 = new Point(w / 2, h);
            Point p3 = new Point(w / 2 + 10, (int)(h * 0.75));

            path.AddPolygon(new Point[] { p1, p2, p3 });

            AplicarEstiloBoton(btn, path, color);
        }
        private void AplicarEstiloBoton(Button btn, GraphicsPath path, Color color)
        {
            btn.Region = new Region(path);
            btn.BackColor = color;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
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


