using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using devDept.Serialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eyeshot강의
{
    class DimensionCreator
    {
        

        public void CreateLinearDim(Model model1)
        {
            // Plane 정의(원점(0, 0, 0), 노멀백터(0, 0, 1))
            Point3D point = new Point3D(0, 0, 0);
            Vector3D normal = new Vector3D(0, 0, 1);
            Plane plane = new Plane(point, normal);

            // 치수선 위치
            Point2D extLine1 = new Point2D(5, 5);
            Point2D extLine2 = new Point2D(95, 5);
            Point2D dimLinePos = new Point2D(50, 25);

            // text 높이, 화살표 크기에도 영향
            double textHeight = 3;

            // 치수 생성
            LinearDim dim = new LinearDim(plane, extLine1, extLine2, dimLinePos, textHeight);

            model1.Entities.Add(dim, Color.Red);

            model1.Invalidate();
        }

        public void CreateRadialDim(Model model1)
        {
            // Plane 정의(원점(0, 0, 0), 노멀백터(0, 0, 1))
            Point3D point = new Point3D(0, 0, 0);
            Vector3D normal = new Vector3D(0, 0, 1);
            Plane plane = new Plane(point, normal);

            // 원 생성해서 추가
            Circle circle = new Circle(plane, 35);
            model1.Entities.Add(circle, Color.Blue);

            // 치수선 위치
            Point3D dimLinePos = new Point3D(15, 15);
            double textHeight = 3;

            // 치수 생성
            RadialDim dim = new RadialDim(circle, dimLinePos, textHeight);
            model1.Entities.Add(dim, Color.Red);
            model1.Invalidate();

            
        }

        // 지름 치수 생성
        public void CreateDiametricDim(Model model1)
        {
            // Plane 정의(원점(0, 0, 0), 노멀백터(0, 0, 1))
            Point3D point = new Point3D(0, 0, 0);
            Vector3D normal = new Vector3D(0, 0, 1);
            Plane plane = new Plane(point, normal);

            // 원 생성해서 추가
            Circle circle = new Circle(plane, 35);
            model1.Entities.Add(circle, Color.Blue);

            // 치수선 위치
            Point3D dimLinePos = new Point3D(15, 15);
            double textHeight = 3;

            // 치수 생성
            DiametricDim dim = new DiametricDim(circle, dimLinePos, textHeight);
            model1.Entities.Add(dim, Color.Red);
            model1.Invalidate();

            
        }

        // 각도 치수 생성
        public void CreateAngularDim(Model model1)
        {
            // Plane 정의(원점(0, 0, 0), 노멀백터(0, 0, 1))
            Point3D point = new Point3D(0, 0, 0);
            Vector3D normal = new Vector3D(0, 0, 1);
            Plane plane = new Plane(point, normal);

            // 치수선 위치
            Point3D extLine1 = new Point3D(5, 0);
            Point3D extLine2 = new Point3D(5, 5);
            Point3D dimLinePos = new Point3D(30, 15);

            double textHeight = 3;

            // 치수 생성
            AngularDim dim = new AngularDim(plane, extLine1, extLine2, dimLinePos, textHeight);
            model1.Entities.Add(dim, Color.Red);
            model1.Invalidate();


        }
    }
}
