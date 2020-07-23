using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Translators;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
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
            model1.WorkCompleted += Model1_WorkCompleted;
        }

        private void Model1_WorkCompleted(object sender, WorkCompletedEventArgs e)
        {
            if(e.WorkUnit is ReadFile)
            {
                ReadFile rf = e.WorkUnit as ReadFile;
                rf.AddToScene(model1);
            }
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
            // 파일 선택
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = "eye";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                // 파일 읽기 클래스 생성
                devDept.Eyeshot.Translators.ReadFile rf = new devDept.Eyeshot.Translators.ReadFile(dlg.FileName);

                // 파일 읽기 시작
                model1.StartWork(rf);
            }
        }
        #region 객체 편집
        private void 이동ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 객체 생성
            var arrow = Mesh.CreateArrow(5, 50, 10, 15, 16, Mesh.natureType.Smooth);

            // 객체 이동
            arrow.Translate(30, 30, 0);

            // 객체 추가
            model1.Entities.Add(arrow, Color.GreenYellow);

            // zoom fit
            model1.ZoomFit();

            // 화면 갱신
            model1.Invalidate();
        }

        private void 회전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 객체 생성
            var arrow = Mesh.CreateArrow(5, 50, 10, 15, 16, Mesh.natureType.Smooth);

            // 객체 이동
            arrow.Rotate(45.0f / 180.0f * Math.PI, new Vector3D(0, 0, 1));

            // 객체 추가
            model1.Entities.Add(arrow, Color.GreenYellow);

            // zoom fit
            model1.ZoomFit();

            // 화면 갱신
            model1.Invalidate();
        }

        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 객체 생성
            var arrow = Mesh.CreateArrow(5, 50, 10, 15, 16, Mesh.natureType.Smooth);
            // 객체 확대
            arrow.Scale(2);
            // 객체 추가
            model1.Entities.Add(arrow, Color.GreenYellow);
            // zoom fit
            model1.ZoomFit();
            // 화면 갱신
            model1.Invalidate();
        }

        private void 이동회전확대조합ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 객체 생성
            var arrow = Mesh.CreateArrow(5, 50, 10, 15, 16, Mesh.natureType.Smooth);
            // 객체 편집(변형) 정보
            double rad = Utility.DegToRad(90);
            Rotation rotation = new Rotation(rad, new Vector3D(0, 0, 1), new Point3D(0, 0, 0));  // 회전
            Translation translation = new Translation(10, 10, 0);   // 이동
            Scaling scaling = new Scaling(2);   // 확대
            // 조합
            Transformation trans = new Transformation();
            trans = rotation * translation * scaling;
            // 객체 편집(변형)
            arrow.TransformBy(trans);
            // 객체를 추가하고 화면 갱신
            model1.Entities.Add(arrow, Color.GreenYellow);
            model1.ZoomFit();
            model1.Invalidate();
        }
        #endregion
    }
}
