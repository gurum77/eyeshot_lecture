﻿namespace eyeshot강의
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton1 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar1 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Red, 1D, true, cancelToolBarButton1, false, 0.2D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings1 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 5.2199996448962454D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton1 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton1 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton1 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton1 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton1 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton1 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton1 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar1 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton1))});
            devDept.Eyeshot.Grid grid1 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.OriginSymbol originSymbol1 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.RotateSettings rotateSettings1 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings1 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings1 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings1 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager1 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport1 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(520, 522), backgroundSettings1, camera1, new devDept.Eyeshot.ToolBar[] {
            toolBar1}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid1}, new devDept.Eyeshot.OriginSymbol[] {
            originSymbol1}, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, savedViewsManager1, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            devDept.Graphics.BackgroundSettings backgroundSettings2 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.Solid, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.DodgerBlue, System.Drawing.Color.Gainsboro, 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera2 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(-4.5374030325107811E-16D, 2.0434646606445304D, 47.596564948558793D), 97.257904648780823D, new devDept.Geometry.Quaternion(0.49999999999999989D, 0.5D, 0.5D, 0.50000000000000011D), devDept.Graphics.projectionType.Orthographic, 40D, 1.8474081455133815D, false, 0.001D);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton2 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton2 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton2 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton2 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton2 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar2 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton2))});
            devDept.Eyeshot.Grid grid2 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 5D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, false, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.OriginSymbol originSymbol2 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.RotateSettings rotateSettings2 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, false, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings2 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings2 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings2 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager2 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport2 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(524, 0), new System.Drawing.Size(520, 522), backgroundSettings2, camera2, new devDept.Eyeshot.ToolBar[] {
            toolBar2}, devDept.Eyeshot.displayType.Shaded, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid2}, new devDept.Eyeshot.OriginSymbol[] {
            originSymbol2}, false, rotateSettings2, zoomSettings2, panSettings2, navigationSettings2, savedViewsManager2, devDept.Eyeshot.viewType.Top);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon2 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon2 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, false, System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            this.model1 = new devDept.Eyeshot.Model();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.객체만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cylinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.springToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.가져오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eye가져오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // model1
            // 
            this.model1.Cursor = System.Windows.Forms.Cursors.Default;
            this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.model1.Location = new System.Drawing.Point(0, 24);
            this.model1.Name = "model1";
            this.model1.ProgressBar = progressBar1;
            this.model1.Size = new System.Drawing.Size(1044, 522);
            this.model1.TabIndex = 0;
            this.model1.Text = "model1";
            originSymbol1.LabelFont = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            coordinateSystemIcon1.LabelFont = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            viewport1.CoordinateSystemIcon = coordinateSystemIcon1;
            viewport1.Legends = new devDept.Eyeshot.Legend[0];
            viewCubeIcon1.Font = null;
            viewCubeIcon1.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport1.ViewCubeIcon = viewCubeIcon1;
            originSymbol2.LabelFont = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            coordinateSystemIcon2.LabelFont = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            viewport2.CoordinateSystemIcon = coordinateSystemIcon2;
            viewport2.Legends = new devDept.Eyeshot.Legend[0];
            viewCubeIcon2.Font = null;
            viewCubeIcon2.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport2.ViewCubeIcon = viewCubeIcon2;
            this.model1.Viewports.Add(viewport1);
            this.model1.Viewports.Add(viewport2);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.객체만들기ToolStripMenuItem,
            this.가져오기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 객체만들기ToolStripMenuItem
            // 
            this.객체만들기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meshToolStripMenuItem});
            this.객체만들기ToolStripMenuItem.Name = "객체만들기ToolStripMenuItem";
            this.객체만들기ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.객체만들기ToolStripMenuItem.Text = "객체만들기";
            // 
            // meshToolStripMenuItem
            // 
            this.meshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boxToolStripMenuItem1,
            this.arrowToolStripMenuItem,
            this.cylinderToolStripMenuItem,
            this.coneToolStripMenuItem,
            this.planarToolStripMenuItem,
            this.sphereToolStripMenuItem,
            this.springToolStripMenuItem,
            this.torusToolStripMenuItem});
            this.meshToolStripMenuItem.Name = "meshToolStripMenuItem";
            this.meshToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.meshToolStripMenuItem.Text = "Mesh";
            // 
            // boxToolStripMenuItem1
            // 
            this.boxToolStripMenuItem1.Name = "boxToolStripMenuItem1";
            this.boxToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.boxToolStripMenuItem1.Text = "Box";
            this.boxToolStripMenuItem1.Click += new System.EventHandler(this.boxToolStripMenuItem1_Click);
            // 
            // arrowToolStripMenuItem
            // 
            this.arrowToolStripMenuItem.Name = "arrowToolStripMenuItem";
            this.arrowToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.arrowToolStripMenuItem.Text = "Arrow";
            this.arrowToolStripMenuItem.Click += new System.EventHandler(this.arrowToolStripMenuItem_Click);
            // 
            // cylinderToolStripMenuItem
            // 
            this.cylinderToolStripMenuItem.Name = "cylinderToolStripMenuItem";
            this.cylinderToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cylinderToolStripMenuItem.Text = "Cylinder";
            this.cylinderToolStripMenuItem.Click += new System.EventHandler(this.cylinderToolStripMenuItem_Click);
            // 
            // coneToolStripMenuItem
            // 
            this.coneToolStripMenuItem.Name = "coneToolStripMenuItem";
            this.coneToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.coneToolStripMenuItem.Text = "Cone";
            this.coneToolStripMenuItem.Click += new System.EventHandler(this.coneToolStripMenuItem_Click);
            // 
            // planarToolStripMenuItem
            // 
            this.planarToolStripMenuItem.Name = "planarToolStripMenuItem";
            this.planarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.planarToolStripMenuItem.Text = "Planar";
            this.planarToolStripMenuItem.Click += new System.EventHandler(this.planarToolStripMenuItem_Click);
            // 
            // sphereToolStripMenuItem
            // 
            this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
            this.sphereToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.sphereToolStripMenuItem.Text = "Sphere";
            this.sphereToolStripMenuItem.Click += new System.EventHandler(this.sphereToolStripMenuItem_Click);
            // 
            // springToolStripMenuItem
            // 
            this.springToolStripMenuItem.Name = "springToolStripMenuItem";
            this.springToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.springToolStripMenuItem.Text = "Spring";
            this.springToolStripMenuItem.Click += new System.EventHandler(this.springToolStripMenuItem_Click);
            // 
            // torusToolStripMenuItem
            // 
            this.torusToolStripMenuItem.Name = "torusToolStripMenuItem";
            this.torusToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.torusToolStripMenuItem.Text = "Torus";
            this.torusToolStripMenuItem.Click += new System.EventHandler(this.torusToolStripMenuItem_Click);
            // 
            // 가져오기ToolStripMenuItem
            // 
            this.가져오기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eye가져오기ToolStripMenuItem});
            this.가져오기ToolStripMenuItem.Name = "가져오기ToolStripMenuItem";
            this.가져오기ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.가져오기ToolStripMenuItem.Text = "가져오기";
            // 
            // eye가져오기ToolStripMenuItem
            // 
            this.eye가져오기ToolStripMenuItem.Name = "eye가져오기ToolStripMenuItem";
            this.eye가져오기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eye가져오기ToolStripMenuItem.Text = "Eye 가져오기";
            this.eye가져오기ToolStripMenuItem.Click += new System.EventHandler(this.eye가져오기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 546);
            this.Controls.Add(this.model1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private devDept.Eyeshot.Model model1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 객체만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cylinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem springToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 가져오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eye가져오기ToolStripMenuItem;
    }
}

