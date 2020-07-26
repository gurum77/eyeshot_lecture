using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyeshot강의
{
    class CurveToMesh
    {
     
        public void CreateExtrudeMesh(Model model1)
        {
            Shapes shapes = new Shapes();
            CompositeCurve roundRect = shapes.RoundRectangle();

            Mesh mesh = roundRect.ExtrudeAsMesh(new Vector3D(0, 0, 50), 0.001, Mesh.natureType.Plain);
            mesh.Color = Color.Aquamarine;
            mesh.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(mesh);
            model1.Invalidate();
        }

        public void CreateSweepMesh(Model model1)
        {
            // Shapes를 통해서 RoundRectangle과 Arc 생성
            Shapes shapes = new Shapes();
            CompositeCurve roundRect = shapes.RoundRectangle();
            Arc arc = shapes.StandingArc();

            // RoundRectangle을 Arc를 따라 쓸기
            Mesh mesh = roundRect.SweepAsMesh(arc, 0.001);
            mesh.Color = Color.Red;
            mesh.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(mesh);
            model1.Invalidate();
        }

        public void CreateRevolveMesh(Model model1)
        {
            Shapes shapes = new Shapes();
            Arc arc = shapes.StandingArc();

            var startAngle = Utility.DegToRad(0);
            var deltaAngle = Utility.DegToRad(90);
            var axisStart = new Point3D(0, 0, 0);
            var axisEnd = new Point3D(0, 0, 100);
            var slices = 10;
            var tolerance = 0.001;

            Mesh mesh = arc.RevolveAsMesh(startAngle, deltaAngle, axisStart, axisEnd, slices, tolerance, Mesh.natureType.Plain);
            mesh.Color = Color.YellowGreen;
            mesh.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(mesh);
        }
    }
}
