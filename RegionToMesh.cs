using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Region = devDept.Eyeshot.Entities.Region;

namespace eyeshot강의
{
    class RegionToMesh
    {
        public void CreateExtrudeMesh(Model model1)
        {
            Shapes shapes = new Shapes();
            // Curve로 Region 생성
            Region region = new Region(shapes.RoundRectangle());

            Mesh mesh = region.ExtrudeAsMesh(new Vector3D(0, 0, 50), 0.001, Mesh.natureType.Plain);
            mesh.Color = Color.Aquamarine;
            mesh.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(mesh);
            model1.Invalidate();
        }

        public void CreateSweepMesh(Model model1)
        {
            // Shapes를 통해서 RoundRectangle과 Arc 생성
            Shapes shapes = new Shapes();
            Region region = new Region(shapes.RoundRectangle());
            Arc arc = shapes.StandingArc();

            // RoundRectangle을 Arc를 따라 쓸기
            Mesh mesh = region.SweepAsMesh(arc, 0.001);
            mesh.Color = Color.Red;
            mesh.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(mesh);
            model1.Invalidate();
        }

        public void CreateRevolveMesh(Model model1)
        {
            Shapes shapes = new Shapes();
            Region region = new Region(shapes.StandingCircle());

            var startAngle = Utility.DegToRad(0);
            var deltaAngle = Utility.DegToRad(90);
            var axisStart = new Point3D(-50, 0, 0);
            var axisEnd = new Point3D(-50, 0, 100);
            var slices = 10;
            var tolerance = 0.1;

            Mesh mesh = region.RevolveAsMesh(startAngle, deltaAngle, axisStart, axisEnd, slices, tolerance, Mesh.natureType.Plain);
            mesh.Color = Color.YellowGreen;
            mesh.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(mesh);
            model1.Invalidate();
        }
    }
}
