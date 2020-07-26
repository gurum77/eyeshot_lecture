using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyeshot강의
{
    class BooleanManager
    {
        // type : 0 - intersection
        // type : 1 - union
        // type : 2 - difference
        public void Boolean(Model model1, int type)
        {
            // 객체가 2개이상 있을때만 실행
            if (model1.Entities.Count < 2)
                return;

            // 1, 2 번째 객체를 brep 로 변환
            Brep brep1 = model1.Entities[0] as Brep;
            Brep brep2 = model1.Entities[1] as Brep;
            if (brep1 == null || brep2 == null)
                return;

            // 두개의 brep에 대해서 intersection 연산 수행
            Brep[] results = null;
            if(type == 0)
            {
                results = Brep.Intersection(brep1, brep2);
            }
            else if(type == 1)
            {
                results = Brep.Union(brep1, brep2);
            }
            else if(type == 2)
            {
                results = Brep.Difference(brep1, brep2);
            }
            
            if (results == null)
                return;

            // 결과를 model에 추가
            model1.Entities.AddRange(results);

            // 연산에 사용되었던 1, 2번째 객체는 삭제
            model1.Entities.Remove(brep1);
            model1.Entities.Remove(brep2);

            // 화면 갱신
            model1.Invalidate();
        }

        public void Intersection(Model model1)
        {
            Boolean(model1, 0);
        }

        public void Union(Model model1)
        {
            Boolean(model1, 1);
        }

        public void Difference(Model model1)
        {
            Boolean(model1, 2);
        }
    }
}
