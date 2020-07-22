using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace eyeshot강의
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region mesh 그리기 메뉴
        private void boxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // box 형태의 mesh를 생성
            var box = Mesh.CreateBox(30, 20, 10);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(box, Color.DarkRed);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void arrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // arrow 형태의 mesh를 생성
            var arrow = Mesh.CreateArrow(10, 30, 15, 15, 3, Mesh.natureType.Plain);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(arrow, Color.Yellow);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void cylinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // cylinder 형태의 mesh를 생성
            var cylinder = Mesh.CreateCylinder(10, 30, 10);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(cylinder, Color.Blue);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void coneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // cone 형태의 mesh를 생성
            var cone = Mesh.CreateCone(30, 10, 20, 30);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(cone, Color.Purple);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void planarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Point3D> points = new List<Point3D>();
            points.Add(new Point3D(0, 0, 0));
            points.Add(new Point3D(10, 0, 0));
            points.Add(new Point3D(20, 10, 0));
            points.Add(new Point3D(10, 10, 0));
            points.Add(new Point3D(0, 0, 0));

            // planar 형태의 mesh를 생성
            var cone = Mesh.CreatePlanar(points, Mesh.natureType.Plain);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(cone, Color.Green);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // sphere 형태의 mesh를 생성
            var sphere = Mesh.CreateSphere(20, 30, 5);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(sphere, Color.SkyBlue);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void springToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // spring 형태의 mesh를 생성
            var spring = Mesh.CreateSpring(30, 4, 10, 5, 10, 3, false);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(spring, Color.DarkGoldenrod);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void torusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // torus 형태의 mesh를 생성
            var torus = Mesh.CreateTorus(30, 5, 30, 10);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(torus, Color.Cyan);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }
        #endregion

        private void eye가져오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = "eye";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                devDept.Eyeshot.Translators.ReadFile rf = new devDept.Eyeshot.Translators.ReadFile(dlg.FileName);
                rf.DoWork();

                model1.Entities.AddRange(rf.Entities);
                
                model1.ZoomFit();
            }
        }
    }
}
