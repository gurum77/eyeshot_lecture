using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyeshot강의
{
    class BrepCreator
    {
        public void CreateBox(Model model1)
        {
            Brep brep = Brep.CreateBox(30, 50, 70);
            brep.Color = Color.BlanchedAlmond;
            brep.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(brep);
            model1.Invalidate();
        }

        public void CreateCylinder(Model model1)
        {
            Brep brep = Brep.CreateCylinder(10, 30);
            brep.Color = Color.DarkBlue;
            brep.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(brep);
            model1.Invalidate();
        }
        public void CreateCone(Model model1)
        {
            Brep brep = Brep.CreateCone(30, 60);
            brep.Color = Color.DarkRed;
            brep.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(brep);
            model1.Invalidate();
        }

        public void CreateSphere(Model model1)
        {
            Brep brep = Brep.CreateSphere(30);
            brep.Color = Color.YellowGreen;
            brep.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(brep);
            model1.Invalidate();
        }

        public void CreateTorus(Model model1)
        {
            Brep brep = Brep.CreateTorus(50, 10);
            brep.Color = Color.Purple;
            brep.ColorMethod = colorMethodType.byEntity;
            model1.Entities.Add(brep);
            model1.Invalidate();
        }


    }
}
