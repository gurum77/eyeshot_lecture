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
    class MeshManager
    {
        public void VertexColor(Model model1)
        {
            List<PointRGB> vertices = new List<PointRGB>(4);
            vertices.Add(new PointRGB(0, 0, 0, Color.Red));
            vertices.Add(new PointRGB(30, 0, 0, Color.Yellow));
            vertices.Add(new PointRGB(30, 30, 0, Color.Green));
            vertices.Add(new PointRGB(0, 30, 0, Color.Yellow));

            List<IndexTriangle> triangles = new List<IndexTriangle>();
            triangles.Add(new IndexTriangle(0, 1, 2));
            triangles.Add(new IndexTriangle(2, 3, 0));

            Mesh surface = new Mesh();
            surface.Vertices = vertices.ToArray();
            surface.Triangles = triangles.ToArray();

            model1.Entities.Add(surface);
            model1.Invalidate();
        }
    }
}
