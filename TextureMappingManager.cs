using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eyeshot강의
{
    class TextureMappingManager
    {
        public void TextureMapping(Model model1)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "jpg 파일 (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // material 생성
                Material mat = new Material("new_material", new Bitmap(dlg.FileName));
                model1.Materials.Add(mat);

                // box 생성
                Mesh rm = Mesh.CreateBox(100, 100, 100);

                // box에 material 적용
                rm.ApplyMaterial(mat.Name, textureMappingType.Cubic, 1, 1);

                model1.Entities.Add(rm);
                model1.Invalidate();
            }
        }
    }
}
