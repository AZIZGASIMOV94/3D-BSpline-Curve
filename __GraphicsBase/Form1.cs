using _3DBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __GraphicsBase
{
    /*
     * 3D BSpline 
     */
    public partial class Form1 : Form
    {
        Graphics g;
        Random rnd = new Random();
        Vector3 a, b, c, d, e, f, h, vg;
        List<Vector3> vectors = new List<Vector3>();
        Vector3 winCenter;
     
        Matrix4 mirror;
        float scale;
        Pen linePen = Pens.Black;
        //Color cCurve = Color.Blue;
        //Color cControl = Color.Black;
        Pen greenPen = new Pen(Color.FromArgb(255, 0, 255, 0), 5);

        Matrix4 mirrorYZ;
        Matrix4 mirrorXZ;
        Matrix4 mirrorXY;
      
        public Form1()
        {
            InitializeComponent();
            scale = 1.2f;
            mirrorYZ = Matrix4.MirroringYZ();
            mirrorXZ = Matrix4.MirroringXZ();
            mirrorXY = Matrix4.MirroringXY();
            winCenter = new Vector3(canvas.Width / 2.0f, canvas.Height / 2.0f, 0.0f);
            a = new Vector3(-rnd.Next(100,200), rnd.Next(100,200), -rnd.Next(100,200) );
            b = new Vector3(-rnd.Next(100,200), rnd.Next(100,200), rnd.Next(100,200));
            c = new Vector3(-rnd.Next(100,200), -rnd.Next(100,200), -rnd.Next(100,200));
            d = new Vector3(-rnd.Next(100,200), -rnd.Next(100,200), rnd.Next(100,200));
            e = new Vector3(rnd.Next(100,200), -rnd.Next(100,200), rnd.Next(100,200));
            f = new Vector3(rnd.Next(100,200), rnd.Next(100,200), rnd.Next(100,200));
            h = new Vector3(rnd.Next(100,200), rnd.Next(100,200), -rnd.Next(100,200));
            vg = new Vector3(rnd.Next(100,200), -rnd.Next(100,200), -rnd.Next(100,200));
            vectors.Add(a);
            vectors.Add(b);
            vectors.Add(c);
            vectors.Add(d);
            vectors.Add(e);
            vectors.Add(f);
            vectors.Add(h);
            vectors.Add(vg); 
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            for (int i = 0; i < vectors.Count - 1; i++)
                g.DrawLine(linePen, vectors[i] + winCenter, vectors[i + 1] + winCenter);

            Draw3DBspline(vectors);
        }

        private double N0(double t) { return 1.0 / 6.0 * (1 - t) * (1 - t) * (1 - t); }
        private double N1(double t) { return 0.5 * t * t * t - t * t + 2.0 / 3.0; }
        private double N2(double t) { return -0.5 * t * t * t + 0.5 * t * t + 0.5 * t + 1.0 / 6.0; }

        private void yz_radio_CheckedChanged(object sender, EventArgs e)
        {
            mirror = mirrorYZ;
            canvas.Refresh();
        }

        private void xz_radio_CheckedChanged(object sender, EventArgs e)
        {
           
            mirror = mirrorXZ;
            canvas.Refresh();
        }

        private void xy_radio_CheckedChanged(object sender, EventArgs e)
        {
            mirror = mirrorXY;
            canvas.Refresh();
        }

        private double N3(double t) { return 1.0 / 6.0 * t * t * t; }

        private void Draw3DBspline(List<Vector3> vectors)
        {
            for (int i = 0; i < vectors.Count - 3; i++)
                BSpline3D(new Pen(Color.Purple), vectors[i], vectors[i + 1], vectors[i + 2], vectors[i + 3]);
        }
        private void BSpline3D(Pen pen, Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
        {
            Vector3 v = new Vector3(0.3f, 0.2f, 0.8f);
            Matrix4 projection = Matrix4.Parallel(v);

            double a = 0;
            double t = a;
            double h = 1 / 500.0;
            Vector3 v_0, v_1;
            Vector3 pv_0, pv_1;

            v_0 = new Vector3((float)(N0(t) * v0.x + N1(t) * v1.x + N2(t) * v2.x + N3(t) * v3.x) * scale,
                              (float)(N0(t) * v0.y + N1(t) * v1.y + N2(t) * v2.y + N3(t) * v3.y) * scale,
                              (float)(N0(t) * v0.z + N1(t) * v1.z + N2(t) * v2.z + N3(t) * v3.z) * scale);
            while (t < 1)
            {
                t += h;
                v_1 = new Vector3((float)(N0(t) * v0.x + N1(t) * v1.x + N2(t) * v2.x + N3(t) * v3.x) * scale,
                                 (float)(N0(t) * v0.y + N1(t) * v1.y + N2(t) * v2.y + N3(t) * v3.y) * scale,
                                 (float)(N0(t) * v0.z + N1(t) * v1.z + N2(t) * v2.z + N3(t) * v3.z) * scale);

                pv_0 = projection * (mirror  * v_0) + winCenter;
                pv_1 = projection * (mirror  * v_1) + winCenter;

                g.DrawLine(greenPen, pv_0, pv_1);
                v_0 = v_1;
            }
        }

        #region Mouse handling
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {

        }
        private void canvas_MouseWheel(object sender, MouseEventArgs e)
        {

        }
        #endregion
    }
}
