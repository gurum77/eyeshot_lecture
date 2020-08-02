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
    class CircleCreator
    {
        public void CreateCircleOnXYPlane(Model model1)
        {
            // 원점이 0,0,0이고, normal이 0,0,1 인 xy평면
            Point3D point = new Point3D(0, 0, 0);
            Vector3D normal = new Vector3D(0, 0, 1);
            Plane plane = new Plane(point, normal);

            // xy평면에 원 생성
            Circle circle = new Circle(plane, 30);
            model1.Entities.Add(circle, Color.Red);

            model1.Invalidate();
        }

        public void CreateCircleOnXZPlane(Model model1)
        {
            // 원점이 0,0,0이고, normal이 0,1,0 인 xz평면
            Point3D point = new Point3D(0, 0, 0);
            Vector3D normal = new Vector3D(0, 1, 0);
            Plane plane = new Plane(point, normal);

            // xz평면에 원 생성
            Circle circle = new Circle(plane, 30);
            model1.Entities.Add(circle, Color.Red);

            model1.Invalidate();
        }

        public void CreateCircleOnYZPlane(Model model1)
        {
            // 원점이 0,0,0이고, normal이 1,0,0 인 yz평면
            Point3D point = new Point3D(0, 0, 0);
            Vector3D normal = new Vector3D(1, 0, 0);
            Plane plane = new Plane(point, normal);

            // yz평면에 원 생성
            Circle circle = new Circle(plane, 30);
            model1.Entities.Add(circle, Color.Red);

            model1.Invalidate();
        }
    }
}
