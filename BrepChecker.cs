using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace eyeshot강의
{
    internal class BrepChecker
    {
        public void SelectPlanarFaces(Model model1)
        {
            foreach (Entity ent in model1.Entities)
            {
                // 객체를 Brep로 형변환을 시도
                Brep b = ent as Brep;
                // 변환 실패하면 통과
                if (b == null)
                {
                    continue;
                }

                // brep의 face를 모두 조회
                for (int i = 0; i < b.Faces.Length; ++i)
                {
                    Brep.Face face = b.Faces[i];
                    var surface = face.Surface;

                    // face가 콘 형태이면 선택
                    if (surface is PlanarSurf && !surface.GetType().IsSubclassOf(typeof(PlanarSurf)))
                    {
                        b.SetFaceSelection(i, true);
                    }
                }
            }
            model1.Invalidate();
        }

        public void SelectConeFaces(Model model1)
        {
            foreach (Entity ent in model1.Entities)
            {
                // 객체를 Brep로 형변환을 시도
                Brep b = ent as Brep;
                // 변환 실패하면 통과
                if (b == null)
                {
                    continue;
                }

                // brep의 face를 모두 조회
                for (int i = 0; i < b.Faces.Length; ++i)
                {
                    Brep.Face face = b.Faces[i];
                    var surface = face.Surface;

                    // face가 콘 형태이면 선택
                    if (surface is ConicalSurf && !surface.GetType().IsSubclassOf(typeof(ConicalSurf)))
                    {
                        b.SetFaceSelection(i, true);
                    }
                }
            }
            model1.Invalidate();
        }
        public void SelectCylinderFaces(Model model1)
        {
            foreach (Entity ent in model1.Entities)
            {
                // 객체를 Brep로 형변환을 시도
                Brep b = ent as Brep;
                // 변환 실패하면 통과
                if (b == null)
                {
                    continue;
                }

                // brep의 face를 모두 조회
                for (int i = 0; i < b.Faces.Length; ++i)
                {
                    Brep.Face face = b.Faces[i];
                    var surface = face.Surface;

                    // face가 실린더 형태이면 선택
                    if (surface is CylindricalSurf && !surface.GetType().IsSubclassOf(typeof(CylindricalSurf)))
                    {
                        b.SetFaceSelection(i, true);
                    }
                }
            }
            model1.Invalidate();
        }

        // 화면에 있는 brep의 edge를 모두 추출
        public void GetEdges(Model model1)
        {
            List<Entity> newEntities = new List<Entity>();
            foreach (Entity ent in model1.Entities)
            {
                // 객체를 Brep로 형변환을 시도
                Brep b = ent as Brep;
                // 변환 실패하면 통과
                if (b == null)
                {
                    continue;
                }

                // brep의 edge를 모두 조회
                foreach (Brep.Edge edge in b.Edges)
                {
                    // line이면 line으로 복사
                    if (edge.Curve is Line)
                    {
                        Line line = (Line)edge.Curve;
                        newEntities.Add((Line)line.Clone());
                    }
                    // circle이면 circle로 복사
                    else if (edge.Curve is Circle)
                    {
                        Circle circle = (Circle)edge.Curve;
                        newEntities.Add((Circle)circle.Clone());
                    }
                }
            }

            // 복사한 edge curve의 사본들을 x방향으로 50 이동
            foreach (Entity ent in newEntities)
            {
                ent.Translate(50, 0, 0);
            }

            // edge curve의 사본들을 entities에 추가
            model1.Entities.AddRange(newEntities);
            model1.Invalidate();
        }

        // 화면에 표시되고 있는 brep의 체적을 모두 계산
        public void CalcVolumes(Model model1)
        {
            StringBuilder sb = new StringBuilder();
            // 모든 객체를 검사
            foreach (devDept.Eyeshot.Entities.Entity ent in model1.Entities)
            {

                // 객체를 Brep로 형변환을 시도
                Brep b = ent as Brep;

                // 변환 실패하면 통과
                if (b == null)
                {
                    continue;
                }

                // brep의 체적과 center를 가져옴.
                Point3D center = new Point3D();
                double volume = b.GetVolume(out center);

                // 표시할 내용을 string으로 변환
                string volumeText = volume.ToString("0.00");    // 소수점 2자리
                string xText = center.X.ToString("0.0");        // 소수점 1자리
                string yText = center.Y.ToString("0.0");        // 소수점 1자리
                string zText = center.Z.ToString("0.0");        // 소수점 1자리

                // string builder에 내용 추가
                sb.Append($"Volume : {volumeText}, Center : {xText}, {yText}, {zText}\n");
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
