using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eyeshot강의
{
    class CurveCreator
    {
        public void Create_Curve_Line(Model model1)
        {
            Line line = new Line(new Point3D(0, 0, 0), new Point3D(30, 30, 0));
            line.Color = Color.IndianRed;
            line.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(line);
            model1.ZoomFit();
            model1.Invalidate();
        }

        public void Create_Curve_Circle(Model model1)
        {
            Circle circle = new Circle(new Point3D(30, 30, 0), 15);
            circle.Color = Color.YellowGreen;
            circle.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(circle);
            model1.ZoomFit();
            model1.Invalidate();
        }

        public void Create_Curve_Arc(Model model1)
        {
            double startRad = Utility.DegToRad(15);
            double endRad   = Utility.DegToRad(135);
            Arc arc = new Arc(new Point3D(0, 0, 0), 30, startRad, endRad);
            arc.Color = Color.Red;
            arc.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(arc);
            model1.ZoomFit();
            model1.Invalidate();
        }

        public void Create_Curve_CompositeCurve(Model model1)
        {
            // Shapes를 사용해서 RoundRectangle형태의 CompositeCurve 생성
            Shapes shapes = new Shapes();
            CompositeCurve roundRect = shapes.RoundRectangle();

            roundRect.Color = Color.Red;
            roundRect.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(roundRect);
            model1.ZoomFit();
            model1.Invalidate();
        }

       
        
    }
}
