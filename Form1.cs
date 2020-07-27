﻿using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Translators;
using devDept.Geometry;
using devDept.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.XPath;

namespace eyeshot강의
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model1.WorkCompleted += Model1_WorkCompleted;
        }



        //private void Model1_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if(model1.ObjectManipulator.Visible)
        //    {
        //        model1.ObjectManipulator.Apply();
        //        model1.Entities.Regen();
        //        model1.Invalidate();
        //    }
        //    else
        //    {
        //        // 마우스 아래에 있는 뭔가(객체, 라벨등..)을 찾음.
        //        var something = model1.GetItemUnderMouseCursor(e.Location);

        //        // 뭔가의 아이템이 객체라면?
        //        if(something.Item is Entity)
        //        {
        //            // 객체 리스트에 뭔가의 아이템을 객체로 변환해서 추가
        //            var entities = new List<Entity>();
        //            Entity ent = something.Item as Entity;
        //            entities.Add(ent);

        //            // 기본 변형정보
        //            Transformation trans = new Transformation();
        //            trans.Identity();

        //            // 객체 편집 도구를 활성화
        //            model1.ObjectManipulator.Enable(trans, true, entities);
        //        }
        //    }    
        //}

        private void Model1_WorkCompleted(object sender, WorkCompletedEventArgs e)
        {
            if (e.WorkUnit is ReadFile)
            {
                ReadFile rf = e.WorkUnit as ReadFile;
                rf.AddToScene(model1);
            }
        }

        #region mesh 그리기 메뉴
        private void boxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // box 형태의 mesh를 생성
            Mesh box = Mesh.CreateBox(30, 20, 10);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(box, Color.DarkRed);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void arrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // arrow 형태의 mesh를 생성
            Mesh arrow = Mesh.CreateArrow(10, 30, 15, 15, 3, Mesh.natureType.Plain);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(arrow, Color.Yellow);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void cylinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // cylinder 형태의 mesh를 생성
            Mesh cylinder = Mesh.CreateCylinder(10, 30, 10);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(cylinder, Color.Blue);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void coneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // cone 형태의 mesh를 생성
            Mesh cone = Mesh.CreateCone(30, 10, 20, 30);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(cone, Color.Purple);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void planarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Point3D> points = new List<Point3D>
            {
                new Point3D(0, 0, 0),
                new Point3D(10, 0, 0),
                new Point3D(20, 10, 0),
                new Point3D(10, 10, 0),
                new Point3D(0, 0, 0)
            };

            // planar 형태의 mesh를 생성
            Mesh cone = Mesh.CreatePlanar(points, Mesh.natureType.Plain);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(cone, Color.Green);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // sphere 형태의 mesh를 생성
            Mesh sphere = Mesh.CreateSphere(20, 30, 5);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(sphere, Color.SkyBlue);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void springToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // spring 형태의 mesh를 생성
            Mesh spring = Mesh.CreateSpring(30, 4, 10, 5, 10, 3, false);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(spring, Color.DarkGoldenrod);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }

        private void torusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // torus 형태의 mesh를 생성
            Mesh torus = Mesh.CreateTorus(30, 5, 30, 10);
            // mesh를 master entity collection에 추가
            model1.Entities.Add(torus, Color.Cyan);
            // zoom fit
            model1.ZoomFit();
            // viewport 갱신
            model1.Invalidate();
        }
        #endregion

        private void eye가져오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 파일 선택
            OpenFileDialog dlg = new OpenFileDialog
            {
                DefaultExt = "eye"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // 파일 읽기 클래스 생성
                devDept.Eyeshot.Translators.ReadFile rf = new devDept.Eyeshot.Translators.ReadFile(dlg.FileName);

                // 파일 읽기 시작
                model1.StartWork(rf);
            }
        }
        #region 객체 편집
        private void 이동ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 객체 생성
            Mesh arrow = Mesh.CreateArrow(5, 50, 10, 15, 16, Mesh.natureType.Smooth);

            // 객체 이동
            arrow.Translate(30, 30, 0);

            // 객체 추가
            model1.Entities.Add(arrow, Color.GreenYellow);

            // zoom fit
            model1.ZoomFit();

            // 화면 갱신
            model1.Invalidate();
        }

        private void 회전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 객체 생성
            Mesh arrow = Mesh.CreateArrow(5, 50, 10, 15, 16, Mesh.natureType.Smooth);

            // 객체 이동
            arrow.Rotate(45.0f / 180.0f * Math.PI, new Vector3D(0, 0, 1));

            // 객체 추가
            model1.Entities.Add(arrow, Color.GreenYellow);

            // zoom fit
            model1.ZoomFit();

            // 화면 갱신
            model1.Invalidate();
        }

        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 객체 생성
            Mesh arrow = Mesh.CreateArrow(5, 50, 10, 15, 16, Mesh.natureType.Smooth);
            // 객체 확대
            arrow.Scale(2);
            // 객체 추가
            model1.Entities.Add(arrow, Color.GreenYellow);
            // zoom fit
            model1.ZoomFit();
            // 화면 갱신
            model1.Invalidate();
        }

        private void 이동회전확대조합ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 객체 생성
            Mesh arrow = Mesh.CreateArrow(5, 50, 10, 15, 16, Mesh.natureType.Smooth);
            // 객체 편집(변형) 정보
            double rad = Utility.DegToRad(90);
            Rotation rotation = new Rotation(rad, new Vector3D(0, 0, 1), new Point3D(0, 0, 0));  // 회전
            Translation translation = new Translation(10, 10, 0);   // 이동
            Scaling scaling = new Scaling(2);   // 확대
            // 조합
            Transformation trans = new Transformation();
            trans = rotation * translation * scaling;
            // 객체 편집(변형)
            arrow.TransformBy(trans);
            // 객체를 추가하고 화면 갱신
            model1.Entities.Add(arrow, Color.GreenYellow);
            model1.ZoomFit();
            model1.Invalidate();
        }
        #endregion

        #region 객체의 속성 변경

        private void byLayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // layer 색으로 설정
            foreach (Entity ent in model1.Entities)
            {
                ent.ColorMethod = colorMethodType.byLayer;
            }
            model1.Invalidate();
        }

        private void byEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // 모든 객체의 색을 변경
                foreach (Entity ent in model1.Entities)
                {
                    ent.Color = dlg.Color;
                    ent.ColorMethod = colorMethodType.byEntity;
                }
                model1.Invalidate();
            }
        }

        private void layer색변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // 첫번째 layer의 색을 변경
                model1.Layers[0].Color = dlg.Color;
            }
        }


        private void layer목록조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Layer layer in model1.Layers)
            {
                sb.Append($"{layer.Name}, {layer.Color.ToString()}\n");
            }

            MessageBox.Show(sb.ToString());
        }

        private void layer추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // layer 이름 결정
            string layerName = $"Layer{model1.Layers.Count + 1}";

            // layer 색상 선택
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                model1.Layers.Add(layerName, dlg.Color);
            }
        }

        // 알파 0
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (Entity ent in model1.Entities)
            {
                ent.Color = Color.FromArgb(0, ent.Color);
            }
            model1.Invalidate();
        }

        // 알파 100
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            foreach (Entity ent in model1.Entities)
            {
                ent.Color = Color.FromArgb(100, ent.Color);
            }
            model1.Invalidate();
        }

        // 알파 255
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            foreach (Entity ent in model1.Entities)
            {
                ent.Color = Color.FromArgb(255, ent.Color);
            }
            model1.Invalidate();
        }


        #endregion

        #region curve 생성
        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurveCreator cc = new CurveCreator();
            cc.Create_Curve_Line(model1);
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurveCreator cc = new CurveCreator();
            cc.Create_Curve_Circle(model1);
        }

        private void arcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurveCreator cc = new CurveCreator();
            cc.Create_Curve_Arc(model1);
        }

        #endregion

        private void compositeCurveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurveCreator cc = new CurveCreator();
            cc.Create_Curve_CompositeCurve(model1);
        }

        private void extrudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurveToMesh cm = new CurveToMesh();
            cm.CreateExtrudeMesh(model1);
                   
        }



        private void xZ평면ArcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shapes shapes = new Shapes();
            model1.Entities.Add(shapes.StandingArc());
            model1.Invalidate();
        }

        private void sweep생성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurveToMesh cm = new CurveToMesh();
            cm.CreateSweepMesh(model1);
        }

        private void revolveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurveToMesh cm = new CurveToMesh();
            cm.CreateRevolveMesh(model1);
        }

        private void curveToRegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegionCreator rc = new RegionCreator();
            rc.CreateCircleRegion(model1);
        }

        private void roundedRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegionCreator rc = new RegionCreator();
            rc.CreateRoundedRectangleRegion(model1);
        }

    
        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegionCreator rc = new RegionCreator();
            rc.CreateEllipseRegion(model1);
        }

        private void circularSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegionCreator rc = new RegionCreator();
            rc.CreateCircularSlotRegion(model1);
        }

        private void slotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegionCreator rc = new RegionCreator();
            rc.CreateSlotRegion(model1);
        }

        private void polygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegionCreator rc = new RegionCreator();
            rc.CreatePolygonRegion(model1);
        }

        private void hexagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegionCreator rc = new RegionCreator();
            rc.CreateHexagonRegion(model1);
        }

        private void fromCurveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegionCreator rc = new RegionCreator();
            rc.CreateRegionFromCurve(model1);
        }

        private void extrudeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegionToMesh rm = new RegionToMesh();
            rm.CreateExtrudeMesh(model1);
        }

        private void sweepToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegionToMesh rm = new RegionToMesh();
            rm.CreateSweepMesh(model1);
        }

        private void revolveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegionToMesh rm = new RegionToMesh();
            rm.CreateRevolveMesh(model1);
        }

        private void flatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.DisplayMode = displayType.Flat;
            model1.Invalidate();
        }

        private void shadedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.DisplayMode = displayType.Shaded;
            model1.Invalidate();
        }

        private void renderedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.DisplayMode = displayType.Rendered;
            model1.Invalidate();
        }

        private void wireframeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.DisplayMode = displayType.Wireframe;
            model1.Invalidate();
        }

        private void hiddeLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.DisplayMode = displayType.HiddenLines;
            model1.Invalidate();
        }

        private void cylinderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //model1.Entities.Add(Solid.CreateCylinder(10, 30, 10));
            model1.Entities.Add(Brep.CreateCylinder(10, 30));
            model1.Invalidate();
            
        }

        #region File
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.Clear();
            model1.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 파일명 입력 dialog
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "eyeshot 파일 (*.eye)|*.eye";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                WriteFileParams wp = new WriteFileParams(model1);
                WriteFile wf = new WriteFile(wp, dlg.FileName);

                // 저장시작
                wf.DoWork();

                // 메세지 표시
                MessageBox.Show("저장 완료");
            }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 기존 객체, 레이어, 블럭등.. 모든 정보 삭제
            model1.Clear();

            // 가져오기 기능 실행
            eye가져오기ToolStripMenuItem_Click(sender, e);
        }
        #endregion

        private void boxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrepCreator bc = new BrepCreator();
            bc.CreateBox(model1);
        }

        private void cylinderToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            BrepCreator bc = new BrepCreator();
            bc.CreateCylinder(model1);
        }

        private void coneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BrepCreator bc = new BrepCreator();
            bc.CreateCone(model1);
        }

        private void sphereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BrepCreator bc = new BrepCreator();
            bc.CreateSphere(model1);
        }

        private void torusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BrepCreator bc = new BrepCreator();
            bc.CreateTorus(model1);
        }

        private void model1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 마우스 아래에 있는 뭔가(객체, 라벨등..)을 찾음.
            var something = model1.GetItemUnderMouseCursor(e.Location);
            if (something == null)
                return;

            // 뭔가의 아이템이 객체라면?
            if (something.Item is Entity)
            {
                // 객체 리스트에 뭔가의 아이템을 객체로 변환해서 추가
                var entities = new List<Entity>();
                Entity ent = something.Item as Entity;
                entities.Add(ent);

                // 기본 변형정보
                Transformation trans = new Transformation();
                trans.Identity();

                // 객체 편집 도구를 활성화
                model1.ObjectManipulator.Enable(trans, true, entities);
            }
        }

        private void model1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                // 편집툴이 보이는 상태라면 적용하고 갱신
                if (model1.ObjectManipulator.Visible)
                {
                    // 편집 내용을 객체에 적용
                    model1.ObjectManipulator.Apply();

                    // 객체의 형태를 다시 계산
                    model1.Entities.Regen();

                    // 화면갱신
                    model1.Invalidate();
                }
            }
        }

        private void intersectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooleanManager bm = new BooleanManager();
            bm.Intersection(model1);

        }

        private void unionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooleanManager bm = new BooleanManager();
            bm.Union(model1);
        }

        private void differenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooleanManager bm = new BooleanManager();
            bm.Difference(model1);
        }

        private void vertexColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeshManager mm = new MeshManager();
            mm.VertexColor(model1);
        }


        private void textureMappingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TextureMappingManager tm = new TextureMappingManager();
            tm.TextureMapping(model1);
        }

        private void 선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var ent in model1.Entities)
            {
                ent.Selected = true;
            }
            model1.Invalidate();
        }

        private void 선택해제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var ent in model1.Entities)
            {
                ent.Selected = false;
            }
            model1.Invalidate();
        }

        private void 선택한객체삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.Entities.DeleteSelected();
            model1.Invalidate();
        }

        private void cuttingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 편집중인 clipping을 모두 적용(편집 완료)
            // -> 편집은 한개의 clipping plane 가능
            model1.ClippingPlane1.Apply();
            model1.ClippingPlane2.Apply();
            model1.ClippingPlane1.Edit(Color.FromArgb(50, Color.Red));
            model1.Invalidate();
        }

        private void clippingPlane2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 편집중인 clipping을 모두 적용(편집 완료)
            // -> 편집은 한개의 clipping plane 가능
            model1.ClippingPlane1.Apply();
            model1.ClippingPlane2.Apply();
            model1.ClippingPlane2.Edit(Color.FromArgb(50, Color.Red));
            model1.Invalidate();
        }

        private void clippingPlane제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.ClippingPlane1.Cancel();
            model1.ClippingPlane2.Cancel();
            model1.Invalidate();
        }

        private void clippingPlane적용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.ClippingPlane1.Apply();
            model1.ClippingPlane2.Apply();
            model1.Invalidate();
        }

        private void 충돌체크ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 충돌체크 클래스 구성
            CollisionDetection cd = new CollisionDetection(model1.Entities, model1.Blocks);

            // 충돌체크 시작
            model1.DoWork(cd);

            // 충돌체크 된 객체를 선택
            for(int i = 0; i < cd.Result.Count; ++i)
            {
                var result = cd.Result[i];
                result.CollidedEntities.Item1.Entity.Selected = true;
                result.CollidedEntities.Item2.Entity.Selected = true;
            }
            model1.Invalidate();
        }
    }
}
