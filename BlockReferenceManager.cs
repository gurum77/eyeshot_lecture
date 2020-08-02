using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eyeshot강의
{
    class BlockReferenceManager
    {
        // 모든 객체를 블럭으로 등록합니다.
        public void RegisterBlockByAllEntities(Model model1)
        {
            // 이미 block이 있다면 등록할 수 없습니다.
            if(model1.Blocks.Contains("my block"))
            {
                MessageBox.Show("이미 추가됨");
                return;
            }

            // block 생성
            Block block = new Block("my block", new Point3D(0, 0, 0));

            // block에 객체 추가
            foreach(var ent in model1.Entities)
            {
                var newEntity = ent.Clone() as Entity;
                block.Entities.Add(newEntity);
            }
            
            // block 등록
            model1.Blocks.Add(block);
        }

        public void UseBlock(Model model1)
        {
            // x 변수를 0에서 1000까지 100씩 증가하면서 반복합니다.(10번 반복)
            for(int x = 0; x < 1000; x += 100)
            {
                // y 변수를 0에서 1000까지 100씩 증가하면서 반복합니다.(10번 반복)
                for(int y = 0; y < 1000; y += 100)
                {
                    // BlockReference 객체 생성
                    BlockReference br = new BlockReference("my block");

                    // BlockReference 객체를 x, y 만큼 이동
                    br.Translate(x, y);

                    // 객체 추가
                    model1.Entities.Add(br);
                }
            }

            model1.Invalidate();
        }
    }
}
