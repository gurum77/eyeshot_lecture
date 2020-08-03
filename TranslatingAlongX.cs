using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyeshot강의
{
    class TranslatingAlongX : BlockReference
    {
        private double xPos;
        private Transformation customTransform;

        public TranslatingAlongX(string blockName)
            : base(0, 0, 0, blockName, 1, 1, 1, 0)
        {
        }

        protected override void Animate(int frameNumber)
        {
            double alpha = (frameNumber % 359) * 10;
            double radius = 10;
            xPos = radius * Math.Cos(Utility.DegToRad(alpha)) - radius;
            base.Animate(frameNumber);
        }

        public override void MoveTo(DrawParams data)
        {
            base.MoveTo(data);
            customTransform = new Translation(xPos, 0, 0);
            data.RenderContext.MultMatrixModelView(customTransform);
        }

        public override bool IsInFrustum(FrustumParams data, Point3D center, double radius)
        {
            return true;
        }
    }
}
