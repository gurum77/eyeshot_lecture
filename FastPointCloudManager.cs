using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eyeshot강의
{
    class FastPointCloudManager
    {
        
        public void ComputeDistance(Model model1)
        {
            // FastPointCloud 객체를 하나 찾음.
            FastPointCloud fpc = null;
            foreach(var ent in model1.Entities)
            {
                if(ent is FastPointCloud)
                {
                    fpc = ent as FastPointCloud;
                    break;
                }
            }

            // surface 객체를 모두 찾음.
            List<Surface> surfaces = new List<Surface>();
            foreach(var ent in model1.Entities)
            {
                if(ent is Surface)
                {
                    surfaces.Add(ent as Surface);
                }
            }
            
            if(surfaces.Count() == 0)
            {
                MessageBox.Show("Surface 객체가 없어서 거리계산을 할 수 없습니다.");
                return;
            }

            // 서피스와 포인트간의 거리를 계산하는 클래스 생성
            ComputeDistances cd = new ComputeDistances(surfaces, fpc);

            // 거리 계산 시작
            cd.DoWork();
            
            // legend 설정
            Legend legend = model1.ActiveViewport.Legends[0];
            legend.ColorTable = Legend.RedToBlue9;
            legend.Visible = true;
         
            legend.Min = cd.Values.Min();   // 거리계산 결과중 최소값을 legend 최소값으로 설정
            legend.Max = cd.Values.Max();   // 거리계산 결과중 최대값을 legend 최대값으로 설정
            legend.Title = "포인트클라우드";   // 제목 설정
            legend.Subtitle = "포인트와 서피스간 거리 (mm)";  // 부제목 설정

            // 포인트의 색을 거리별로 지정함.
            int colorTableLength = legend.ColorTable.Length;
            int index = 0;            
            for(int i = 2; i < fpc.ColorArray.Length; i+=3)
            {
                // 계산된 거리
                double dist = cd.Values[index];

                // 거리별 색상값을 legend에서 찾음
                for(int j = 0; j < colorTableLength; ++j)
                {
                    if(dist <= legend.Values[j+1])
                    {
                        // 찾은 거리에 대한 색상값을 point cloud에 설정
                        fpc.ColorArray[i - 2] = legend.ColorTable[j].R;
                        fpc.ColorArray[i - 1] = legend.ColorTable[j].G;
                        fpc.ColorArray[i] = legend.ColorTable[j].B;
                        break;
                    }
                }
                index++;
            }

            // 객체가 변경(색상)되면 regen을 해야 갱신됨.
            fpc.Regen(0.001);
            model1.Entities.Regen();
            model1.Invalidate();
        }

        public void CreateFastPointCloud(Model model1)
        {
            // point cloud 의 세로, 가로 갯수
            int rows = 30;
            int cols = 30;

            // z값을 랜덤하게 찾기 위함
            Random random = new Random();

            List<float> points = new List<float>();
            List<byte> rgbs = new List<byte>();
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    float z = random.Next(-20, 20);
                    points.Add(x);
                    points.Add(y);
                    points.Add(z);

                    rgbs.Add(0);
                    rgbs.Add(0);
                    rgbs.Add(0);
                }
            }

            FastPointCloud fpc = new FastPointCloud(points.ToArray(), rgbs.ToArray());
            fpc.LineWeight = 3;
            fpc.LineWeightMethod = colorMethodType.byEntity;
           
            model1.Entities.Add(fpc);

            model1.Invalidate();
        }
    }
}
