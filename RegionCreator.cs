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
    class RegionCreator
    {
        public void CreateCircleRegion(Model model1)
        {
            Region region = Region.CreateCircle(30);
            region.Color = Color.Blue;
            region.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(region);
            model1.Invalidate();
        }

        public void CreateRoundedRectangleRegion(Model model1)
        {
            Region region = Region.CreateRoundedRectangle(50, 30, 10);
            region.Color = Color.DarkGreen;
            region.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(region);
            model1.Invalidate();
        }

        public void CreateEllipseRegion(Model model1)
        {
            Region region = Region.CreateEllipse(60, 30);
            region.Color = Color.LightPink;
            region.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(region);
            model1.Invalidate();
        }

        public void CreateCircularSlotRegion(Model model1)
        {
            double angle = Utility.DegToRad(90);
            double radius = 30;
            double slotRadius = 10;

            Region region = Region.CreateCircularSlot(angle, radius, slotRadius);
            region.Color = Color.Goldenrod;
            region.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(region);
            model1.Invalidate();
        }

        public void CreateSlotRegion(Model model1)
        {
            double length = 50;
            double radius = 3;
            Region region = Region.CreateSlot(length, radius);
            region.Color = Color.DarkRed;
            region.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(region);
            model1.Invalidate();
        }
        
        public void CreatePolygonRegion(Model model1)
        {
            Region region = Region.CreatePolygon(
                new Point3D(0, 0, 0), 
                new Point3D(30, 0, 0), 
                new Point3D(15, 40, 0));
            region.Color = Color.YellowGreen;
            region.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(region);
            model1.Invalidate();
        }
        
        public void CreateHexagonRegion(Model model1)
        {
            Region region = Region.CreateHexagon(30);
            region.Color = Color.Purple;
            region.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(region);
            model1.Invalidate();
        }

        public void CreateRegionFromCurve(Model model1)
        {
            Shapes shapes = new Shapes();
            CompositeCurve roundRect = shapes.RoundRectangle();

            // curve로 Region 만듦
            Region region = new Region(roundRect);
            region.Color = Color.Blue;
            region.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(region);
            model1.Invalidate();
        }
    }
}
