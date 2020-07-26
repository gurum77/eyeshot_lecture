using devDept.Eyeshot.Entities;
using devDept.Geometry;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyeshot강의
{
    class Shapes
    {
        public Line StandingLine()
        {
            Line line = new Line(new Point3D(0, 0, 0), new Point3D(30, 0, 30));
            return line;
        }

        public Arc StandingArc()
        {
            Plane XZ = new Plane(new Point3D(0, 0, 0), Vector3D.AxisX, Vector3D.AxisZ);

            double startRad = Utility.DegToRad(0);
            double endRad = Utility.DegToRad(90);
            Arc arc = new Arc(XZ, new Point3D(-50, 0, 0), 30, startRad, endRad);
            return arc;
        }

        public Circle StandingCircle()
        {
            Plane XZ = new Plane(new Point3D(0, 0, 0), Vector3D.AxisX, Vector3D.AxisZ);
            Circle circle = new Circle(XZ, 30);
            return circle;
        }

        public CompositeCurve RoundRectangle()
        {
            double startRad1 = Utility.DegToRad(-90);
            double endRad1 = Utility.DegToRad(90);
            double startRad2 = Utility.DegToRad(90);
            double endRad2 = Utility.DegToRad(270);

            CompositeCurve roundRect = new CompositeCurve(
                new Line(0, 0, 30, 0),
                new Arc(new Point3D(30, 15), 15, startRad1, endRad1),
                new Line(30, 30, 0, 30),
                new Arc(new Point3D(0, 15), 15, startRad2, endRad2)
                );

            return roundRect;
        }
    }
}
