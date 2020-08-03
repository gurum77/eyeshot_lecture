using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Fem;
using devDept.Eyeshot.Translators;
using devDept.Geometry;
using devDept.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            devDept.Geometry.Rotation rotation = new devDept.Geometry.Rotation(rad, new Vector3D(0, 0, 1), new Point3D(0, 0, 0));  // 회전
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
            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "eyeshot 파일 (*.eye)|*.eye"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
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
            devDept.Eyeshot.Environment.SelectedItem something = model1.GetItemUnderMouseCursor(e.Location);
            if (something == null)
            {
                return;
            }

            // 뭔가의 아이템이 객체라면?
            if (something.Item is Entity)
            {
                // 객체 리스트에 뭔가의 아이템을 객체로 변환해서 추가
                List<Entity> entities = new List<Entity>();
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
            if (e.Button == MouseButtons.Right)
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
            foreach (Entity ent in model1.Entities)
            {
                ent.Selected = true;
            }
            model1.Invalidate();
        }

        private void 선택해제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Entity ent in model1.Entities)
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
            for (int i = 0; i < cd.Result.Count; ++i)
            {
                CollisionDetection2D.CollisionResult result = cd.Result[i];
                result.CollidedEntities.Item1.Entity.Selected = true;
                result.CollidedEntities.Item2.Entity.Selected = true;
            }
            model1.Invalidate();
        }

        private void ellipsoidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SurfaceCreator sc = new SurfaceCreator();
            sc.CreateEllipsoid(model1);
        }

        private void planarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SurfaceCreator sc = new SurfaceCreator();
            sc.CreateLoft(model1);
        }

        private void extrudeWithTwistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SurfaceCreator sc = new SurfaceCreator();
            sc.CreateExtrudeWithTwist(model1);
        }

        private void volumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrepChecker bc = new BrepChecker();
            bc.CalcVolumes(model1);
        }

        private void edge추출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrepChecker bc = new BrepChecker();
            bc.GetEdges(model1);
        }

        private void cylinderFace선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 실린더 형태의 face 선택
            BrepChecker bc = new BrepChecker();
            bc.SelectCylinderFaces(model1);
        }

        private void coneFace선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 콘 형태의 face 선택
            BrepChecker bc = new BrepChecker();
            bc.SelectConeFaces(model1);
        }

        private void planeFace선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 평면 형태의 face 선택
            BrepChecker bc = new BrepChecker();
            bc.SelectPlanarFaces(model1);
        }

        // 2d view
        private void dViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // origin 심볼 숨김
            model1.ActiveViewport.OriginSymbol.Visible = false;

            // 원근법 미적용
            model1.ActiveViewport.Camera.ProjectionMode = projectionType.Orthographic;

            // 그리드 숨김
            model1.ActiveViewport.Grid.Visible = false;

            // 배경은 검정색으로
            model1.ActiveViewport.Background.TopColor = Color.Black;
            model1.ActiveViewport.Background.BottomColor = Color.Black;

            // top view로 변경
            model1.ActiveViewport.SetView(viewType.Top);

            // view 회전 비활성화
            model1.ActiveViewport.Rotate.Enabled = false;

            // wireframe 모드로 변경
            model1.ActiveViewport.DisplayMode = displayType.Wireframe;

            model1.ActiveViewport.Invalidate();
        }

        // 3d view
        private void dViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // origin 심볼 표시
            model1.ActiveViewport.OriginSymbol.Visible = true;

            // 원근법 적용
            model1.ActiveViewport.Camera.ProjectionMode = projectionType.Perspective;

            // 그리드 표시
            model1.ActiveViewport.Grid.Visible = false;

            // 배경은 파란색 -> 흰색으로 그라데이션
            model1.ActiveViewport.Background.TopColor = Color.Blue;
            model1.ActiveViewport.Background.BottomColor = Color.White;


            // 삼차원 보기로 변경
            model1.ActiveViewport.SetView(viewType.Trimetric);

            // view 회전 활성화
            model1.ActiveViewport.Rotate.Enabled = true;

            // render 모드로 변경
            model1.ActiveViewport.DisplayMode = displayType.Rendered;

            model1.ActiveViewport.Invalidate();
        }



        private void customData추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Entity ent in model1.Entities)
            {
                ent.EntityData = "custom data가 있습니다.";
            }

            MessageBox.Show("모든 객체에 custom data 설정 완료.");
        }

        private void customData보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int count = 0;
            foreach (Entity ent in model1.Entities)
            {
                if (ent.EntityData == null)
                {
                    continue;
                }

                count++;

                MessageBox.Show(ent.EntityData.ToString());
            }

            MessageBox.Show($"{count}개의 객체에 custom data가 있습니다.");
        }

        private void linearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DimensionCreator dc = new DimensionCreator();
            dc.CreateLinearDim(model1);
        }

        private void radiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DimensionCreator dc = new DimensionCreator();
            dc.CreateRadialDim(model1);
        }

        private void diametricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DimensionCreator dc = new DimensionCreator();
            dc.CreateDiametricDim(model1);
        }

        private void angularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DimensionCreator dc = new DimensionCreator();
            dc.CreateAngularDim(model1);
        }

        private void xY평면ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CircleCreator cc = new CircleCreator();
            cc.CreateCircleOnXYPlane(model1);
        }

        private void yZ평면ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CircleCreator cc = new CircleCreator();
            cc.CreateCircleOnYZPlane(model1);
        }

        private void xZ평면ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CircleCreator cc = new CircleCreator();
            cc.CreateCircleOnXZPlane(model1);
        }

        private void block등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlockReferenceManager brm = new BlockReferenceManager();
            brm.RegisterBlockByAllEntities(model1);
        }

        private void block사용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlockReferenceManager brm = new BlockReferenceManager();
            brm.UseBlock(model1);
        }

        private void vertexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.ShowVertices = !model1.ShowVertices;
            model1.Invalidate();
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.ShowNormals = !model1.ShowNormals;
            model1.Invalidate();


        }

        private void vertexIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.ShowVertexIndices = !model1.ShowVertexIndices;
            model1.Invalidate();



        }

        private void curveDirectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.ShowCurveDirection = !model1.ShowCurveDirection;
            model1.Invalidate();

        }

        private void fpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.ShowFps = !model1.ShowFps;
            model1.Invalidate();
        }

        private void 그림자OnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (model1.Rendered.ShadowMode == shadowType.None)
            {
                model1.Rendered.ShadowMode = shadowType.Planar;
            }
            else
            {
                model1.Rendered.ShadowMode = shadowType.None;
            }
            model1.Invalidate();
        }

 
        private void 생성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastPointCloudManager fpcm = new FastPointCloudManager();
            fpcm.CreateFastPointCloud(model1);
        }

        private void 거리계산ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastPointCloudManager fpcm = new FastPointCloudManager();
            fpcm.ComputeDistance(model1);
        }

        private void delaunayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rows = 100;
            int cols = 100;
            Point3D[] points = new Point3D[rows * cols];

            int min = -2;
            int max = 2;

            int minxy = -1000;
            int maxxy = 1000;
            Random random = new Random();
            int index = 0;
            for(int i = 0; i < rows; ++i)
            {
                for(int j = 0; j < cols; ++j)
                {
                    points[index] = new Point3D(random.Next(minxy, maxxy), random.Next(minxy, maxxy), random.Next(min, max));
                    index++;
                }
            }

            Mesh tin = UtilityEx.Triangulate(points, Mesh.natureType.RichSmooth);
            if(tin != null)
            {
                model1.Entities.Add(tin, Color.YellowGreen);
            }
        }

        void MakeFemMeshSample()
        {
            Line l1 = new Line(0, 0, 100, 0);
            Line l2 = new Line(100, 0, 100, 30);
            Line l3 = new Line(100, 30, 80, 30);
            Arc a1 = new Arc(80, 50, 0, 20, Utility.DegToRad(180), Utility.DegToRad(270));
            Line l4 = new Line(60, 50, 60, 80);
            Line l5 = new Line(60, 80, 30, 80);
            Line l6 = new Line(30, 80, 30, 31);
            Arc a2 = new Arc(29, 31, 0, 1, Utility.DegToRad(270), Utility.DegToRad(360));
            Line l7 = new Line(29, 30, 26, 30);
            Arc a3 = new Arc(26, 31, 0, 1, Utility.DegToRad(180), Utility.DegToRad(270));
            Line l8 = new Line(25, 31, 25, 80);

            Line l9 = new Line(25, 80, 15, 80);
            Line l10 = new Line(15, 80, 15, 31);
            Arc a4 = new Arc(14, 31, 0, 1, Utility.DegToRad(270), Utility.DegToRad(360));
            Line l11 = new Line(14, 30, 11, 30);
            Arc a5 = new Arc(11, 31, 0, 1, Utility.DegToRad(180), Utility.DegToRad(270));
            Line l12 = new Line(10, 31, 10, 80);
            Line l13 = new Line(10, 80, 0, 80);
            Line l14 = new Line(0, 80, 0, 0);

            Circle c1 = new Circle(20, 15, 0, 5);
            Circle c2 = new Circle(35, 15, 0, 5);
            Circle c3 = new Circle(50, 15, 0, 5);
            Circle c4 = new Circle(65, 15, 0, 5);

            devDept.Eyeshot.Entities.Region reg = new devDept.Eyeshot.Entities.Region(new ICurve[]{ new CompositeCurve(l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, a1, a2, a3, a4, a5), c1,
                c2, c3, c4}, Plane.XY);

            Mesh m = UtilityEx.Triangulate(reg, 3);

            Material copper = Material.Copper;
            copper.ElementThickness = 6;
            copper.ElementType = elementType.PlaneStress;

            FemMesh fMesh = m.ConvertToFemMesh(copper, true);

            fMesh.FixAll(new Point3D(0, 0), new Point3D(100, 0), .1);

            fMesh.SetForce(new Point3D(0, 70), new Point3D(50, 70), .1, new Vector3D(-1, 0, 0));

            model1.Entities.Add(fMesh);

            model1.Invalidate();

            Solver s1 = new Solver(fMesh);
            model1.DoWork(s1);
            model1.Invalidate();

            fMesh.PlotMode = FemMesh.plotType.U;
            fMesh.NodalAverages = true;
            fMesh.ComputePlot(model1, model1.ActiveViewport.Legends[0]);
            model1.ZoomFit();
        }

        void MakeFemMeshSample2()
        {
            // rectangle FemMesh 생성
            FemMesh fMesh = new FemMesh();
            FemMesh.CreateRectangleQuad4(200, 200, 30, 30, Material.Copper, out fMesh);

            // 고정점 설정
            fMesh.FixAll(new Point3D(0, 0), new Point3D(200, 0), .1);

            // 힘 적용
            fMesh.SetForce(new Point3D(100, 200), new Point3D(120, 200), .1, new Vector3D(0, -100, 0));

            // fem mesh 객체 추가
            model1.Entities.Add(fMesh);
            model1.Invalidate();

            // 솔버에 fem mesh를 추가해서 해석.
            Solver s1 = new Solver(fMesh);
            model1.DoWork(s1);
            model1.Invalidate();

            // fem mesh plot mode 설정
            fMesh.PlotMode = FemMesh.plotType.U;
            fMesh.NodalAverages = true;

            // 등고선 계산해서 표시하고, legend 설정
            fMesh.ComputePlot(model1, model1.ActiveViewport.Legends[0]);
        }
        private void 생성ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MakeFemMeshSample2();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 화면에 있는 객체를 block으로 만듦
            Block block = new Block("block");
            foreach(var ent in model1.Entities)
            {
                block.Entities.Add(ent.Clone() as Entity);
            }
            model1.Blocks.Add(block);

            // 화면에 있는 객체는 삭제
            model1.Entities.Clear();

            // Animation하는 객체에 block을 넣어서 추가
            TranslatingAlongX br = new TranslatingAlongX("block");
            model1.Entities.Add(br);
            model1.Invalidate();

            // Animation 시작(인터벌 100)
            model1.StartAnimation(100);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model1.StopAnimation();
        }
    }
}
