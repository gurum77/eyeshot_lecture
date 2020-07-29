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
    class SurfaceCreator
    {
        public void CreateEllipsoid(Model model1)
        {
            var sur = Surface.CreateEllipsoid(50, 20, 10);
            model1.Entities.Add(sur, Color.Red);
            model1.Invalidate();
        }

        internal void CreateLoft(Model model1)
        {
            // first curve
            Line first = new Line(new Point3D(0, 0, 0), new Point3D(30, 0, 0));

            // second curve
            Line second = new Line(new Point3D(0, 30, 10), new Point3D(40, 30, 10));

            // third curve
            Line third = new Line(new Point3D(0, 60, -10), new Point3D(30, 60, -10));

            List<ICurve> curves = new List<ICurve>();
            curves.Add(first);
            curves.Add(second);
            curves.Add(third);

            Surface[] surfaces = Surface.Loft(curves);
            model1.Entities.AddRange(surfaces, Color.YellowGreen);
        }

        internal void CreateExtrudeWithTwist(Model model1)
        {
            var curve  = new Line(new Point3D(10, 0, 0), new Point3D(30, 0, 0));
            var direction = new Vector3D(0, 0, 50);
            var center = new Point3D(0, 0, 0);
            var angle = Utility.DegToRad(90);


            Surface[] surfaces = Surface.ExtrudeWithTwist(curve, direction, center, angle, 10);;
            model1.Entities.AddRange(surfaces, Color.BlueViolet);
        }
    }
}
