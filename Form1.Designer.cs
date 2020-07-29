namespace eyeshot강의
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
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton6 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar6 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Red, 1D, true, cancelToolBarButton6, false, 0.2D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings11 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera11 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 4.1299999416891362D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton6 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton11 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton11 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton11 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton11 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton6 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton11 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar11 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton6)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton11)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton11)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton11)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton11)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton6)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton11))});
            devDept.Eyeshot.Grid grid11 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.OriginSymbol originSymbol11 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.RotateSettings rotateSettings11 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings11 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings11 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings11 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager11 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport11 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(520, 413), backgroundSettings11, camera11, new devDept.Eyeshot.ToolBar[] {
            toolBar11}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid11}, new devDept.Eyeshot.OriginSymbol[] {
            originSymbol11}, false, rotateSettings11, zoomSettings11, panSettings11, navigationSettings11, savedViewsManager11, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon11 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon11 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            devDept.Graphics.BackgroundSettings backgroundSettings12 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.Solid, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.DodgerBlue, System.Drawing.Color.Gainsboro, 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera12 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(-4.5374030325107811E-16D, 2.0434646606445304D, 47.596564948558793D), 97.257904648780823D, new devDept.Geometry.Quaternion(0.49999999999999989D, 0.5D, 0.5D, 0.50000000000000011D), devDept.Graphics.projectionType.Orthographic, 40D, 1.4616467533108335D, false, 0.001D);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton12 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton12 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton12 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton12 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton12 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar12 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton12)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton12)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton12)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton12)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton12))});
            devDept.Eyeshot.Grid grid12 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 5D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, false, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.OriginSymbol originSymbol12 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.RotateSettings rotateSettings12 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, false, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings12 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings12 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings12 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager12 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport12 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(524, 0), new System.Drawing.Size(520, 413), backgroundSettings12, camera12, new devDept.Eyeshot.ToolBar[] {
            toolBar12}, devDept.Eyeshot.displayType.Shaded, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid12}, new devDept.Eyeshot.OriginSymbol[] {
            originSymbol12}, false, rotateSettings12, zoomSettings12, panSettings12, navigationSettings12, savedViewsManager12, devDept.Eyeshot.viewType.Top);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon12 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon12 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, false, System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            this.model1 = new devDept.Eyeshot.Model();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.curveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compositeCurveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compositeCurveToMeshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sweepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xZ평면ArcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sweep생성ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revolveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curveToRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundedRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromCurveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.region으로Mesh생성ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrudeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sweepToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.revolveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bRepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cylinderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.coneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.torusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.가져오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eye가져오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.객체편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이동회전확대조합ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택해제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택한객체삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.객체속성ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.투명도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.vertexColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layer색변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layer목록조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layer추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wireframeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddeLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intersectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textureMappingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textureMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuttingPlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuttingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clippingPlane2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clippingPlane제거ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clippingPlane적용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.충돌체크ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRepToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.volumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edge추출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cylinderFace선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coneFace선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // model1
            // 
            this.model1.Cursor = System.Windows.Forms.Cursors.Default;
            this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.model1.Location = new System.Drawing.Point(0, 24);
            this.model1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.model1.Name = "model1";
            this.model1.ProgressBar = progressBar6;
            this.model1.Size = new System.Drawing.Size(1044, 413);
            this.model1.TabIndex = 0;
            this.model1.Text = "model1";
            originSymbol11.LabelFont = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            coordinateSystemIcon11.LabelFont = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            viewport11.CoordinateSystemIcon = coordinateSystemIcon11;
            viewport11.Legends = new devDept.Eyeshot.Legend[0];
            viewCubeIcon11.Font = null;
            viewCubeIcon11.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport11.ViewCubeIcon = viewCubeIcon11;
            originSymbol12.LabelFont = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            coordinateSystemIcon12.LabelFont = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            viewport12.CoordinateSystemIcon = coordinateSystemIcon12;
            viewport12.Legends = new devDept.Eyeshot.Legend[0];
            viewCubeIcon12.Font = null;
            viewCubeIcon12.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport12.ViewCubeIcon = viewCubeIcon12;
            this.model1.Viewports.Add(viewport11);
            this.model1.Viewports.Add(viewport12);
            this.model1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.model1_MouseDoubleClick);
            this.model1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.model1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.객체만들기ToolStripMenuItem,
            this.가져오기ToolStripMenuItem,
            this.객체편집ToolStripMenuItem,
            this.객체속성ToolStripMenuItem,
            this.layerToolStripMenuItem,
            this.displayModeToolStripMenuItem,
            this.booleanToolStripMenuItem,
            this.textureMappingToolStripMenuItem1,
            this.cuttingPlaneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // 객체만들기ToolStripMenuItem
            // 
            this.객체만들기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meshToolStripMenuItem,
            this.curveToolStripMenuItem,
            this.compositeCurveToMeshToolStripMenuItem,
            this.regionToolStripMenuItem,
            this.region으로Mesh생성ToolStripMenuItem,
            this.bRepToolStripMenuItem});
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
            this.meshToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
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
            // curveToolStripMenuItem
            // 
            this.curveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.arcToolStripMenuItem,
            this.compositeCurveToolStripMenuItem});
            this.curveToolStripMenuItem.Name = "curveToolStripMenuItem";
            this.curveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.curveToolStripMenuItem.Text = "Curve";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // arcToolStripMenuItem
            // 
            this.arcToolStripMenuItem.Name = "arcToolStripMenuItem";
            this.arcToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.arcToolStripMenuItem.Text = "Arc";
            this.arcToolStripMenuItem.Click += new System.EventHandler(this.arcToolStripMenuItem_Click);
            // 
            // compositeCurveToolStripMenuItem
            // 
            this.compositeCurveToolStripMenuItem.Name = "compositeCurveToolStripMenuItem";
            this.compositeCurveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.compositeCurveToolStripMenuItem.Text = "CompositeCurve";
            this.compositeCurveToolStripMenuItem.Click += new System.EventHandler(this.compositeCurveToolStripMenuItem_Click);
            // 
            // compositeCurveToMeshToolStripMenuItem
            // 
            this.compositeCurveToMeshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extrudeToolStripMenuItem,
            this.sweepToolStripMenuItem,
            this.revolveToolStripMenuItem});
            this.compositeCurveToMeshToolStripMenuItem.Name = "compositeCurveToMeshToolStripMenuItem";
            this.compositeCurveToMeshToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.compositeCurveToMeshToolStripMenuItem.Text = "Curve로 Mesh생성";
            // 
            // extrudeToolStripMenuItem
            // 
            this.extrudeToolStripMenuItem.Name = "extrudeToolStripMenuItem";
            this.extrudeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.extrudeToolStripMenuItem.Text = "Extrude";
            this.extrudeToolStripMenuItem.Click += new System.EventHandler(this.extrudeToolStripMenuItem_Click);
            // 
            // sweepToolStripMenuItem
            // 
            this.sweepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xZ평면ArcToolStripMenuItem,
            this.sweep생성ToolStripMenuItem});
            this.sweepToolStripMenuItem.Name = "sweepToolStripMenuItem";
            this.sweepToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sweepToolStripMenuItem.Text = "Sweep";
            // 
            // xZ평면ArcToolStripMenuItem
            // 
            this.xZ평면ArcToolStripMenuItem.Name = "xZ평면ArcToolStripMenuItem";
            this.xZ평면ArcToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.xZ평면ArcToolStripMenuItem.Text = "XZ평면Arc";
            this.xZ평면ArcToolStripMenuItem.Click += new System.EventHandler(this.xZ평면ArcToolStripMenuItem_Click);
            // 
            // sweep생성ToolStripMenuItem
            // 
            this.sweep생성ToolStripMenuItem.Name = "sweep생성ToolStripMenuItem";
            this.sweep생성ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sweep생성ToolStripMenuItem.Text = "Sweep생성";
            this.sweep생성ToolStripMenuItem.Click += new System.EventHandler(this.sweep생성ToolStripMenuItem_Click);
            // 
            // revolveToolStripMenuItem
            // 
            this.revolveToolStripMenuItem.Name = "revolveToolStripMenuItem";
            this.revolveToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.revolveToolStripMenuItem.Text = "Revolve";
            this.revolveToolStripMenuItem.Click += new System.EventHandler(this.revolveToolStripMenuItem_Click);
            // 
            // regionToolStripMenuItem
            // 
            this.regionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curveToRegionToolStripMenuItem,
            this.roundedRectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.circularSlotToolStripMenuItem,
            this.slotToolStripMenuItem,
            this.polygonToolStripMenuItem,
            this.hexagonToolStripMenuItem,
            this.fromCurveToolStripMenuItem});
            this.regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            this.regionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.regionToolStripMenuItem.Text = "Region";
            // 
            // curveToRegionToolStripMenuItem
            // 
            this.curveToRegionToolStripMenuItem.Name = "curveToRegionToolStripMenuItem";
            this.curveToRegionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.curveToRegionToolStripMenuItem.Text = "Circle";
            this.curveToRegionToolStripMenuItem.Click += new System.EventHandler(this.curveToRegionToolStripMenuItem_Click);
            // 
            // roundedRectangleToolStripMenuItem
            // 
            this.roundedRectangleToolStripMenuItem.Name = "roundedRectangleToolStripMenuItem";
            this.roundedRectangleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.roundedRectangleToolStripMenuItem.Text = "RoundedRectangle";
            this.roundedRectangleToolStripMenuItem.Click += new System.EventHandler(this.roundedRectangleToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // circularSlotToolStripMenuItem
            // 
            this.circularSlotToolStripMenuItem.Name = "circularSlotToolStripMenuItem";
            this.circularSlotToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.circularSlotToolStripMenuItem.Text = "CircularSlot";
            this.circularSlotToolStripMenuItem.Click += new System.EventHandler(this.circularSlotToolStripMenuItem_Click);
            // 
            // slotToolStripMenuItem
            // 
            this.slotToolStripMenuItem.Name = "slotToolStripMenuItem";
            this.slotToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.slotToolStripMenuItem.Text = "Slot";
            this.slotToolStripMenuItem.Click += new System.EventHandler(this.slotToolStripMenuItem_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.polygonToolStripMenuItem.Text = "Polygon";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.polygonToolStripMenuItem_Click);
            // 
            // hexagonToolStripMenuItem
            // 
            this.hexagonToolStripMenuItem.Name = "hexagonToolStripMenuItem";
            this.hexagonToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.hexagonToolStripMenuItem.Text = "Hexagon";
            this.hexagonToolStripMenuItem.Click += new System.EventHandler(this.hexagonToolStripMenuItem_Click);
            // 
            // fromCurveToolStripMenuItem
            // 
            this.fromCurveToolStripMenuItem.Name = "fromCurveToolStripMenuItem";
            this.fromCurveToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.fromCurveToolStripMenuItem.Text = "FromCurve";
            this.fromCurveToolStripMenuItem.Click += new System.EventHandler(this.fromCurveToolStripMenuItem_Click);
            // 
            // region으로Mesh생성ToolStripMenuItem
            // 
            this.region으로Mesh생성ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extrudeToolStripMenuItem1,
            this.sweepToolStripMenuItem1,
            this.revolveToolStripMenuItem1});
            this.region으로Mesh생성ToolStripMenuItem.Name = "region으로Mesh생성ToolStripMenuItem";
            this.region으로Mesh생성ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.region으로Mesh생성ToolStripMenuItem.Text = "Region으로 Mesh생성";
            // 
            // extrudeToolStripMenuItem1
            // 
            this.extrudeToolStripMenuItem1.Name = "extrudeToolStripMenuItem1";
            this.extrudeToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.extrudeToolStripMenuItem1.Text = "Extrude";
            this.extrudeToolStripMenuItem1.Click += new System.EventHandler(this.extrudeToolStripMenuItem1_Click);
            // 
            // sweepToolStripMenuItem1
            // 
            this.sweepToolStripMenuItem1.Name = "sweepToolStripMenuItem1";
            this.sweepToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.sweepToolStripMenuItem1.Text = "Sweep";
            this.sweepToolStripMenuItem1.Click += new System.EventHandler(this.sweepToolStripMenuItem1_Click);
            // 
            // revolveToolStripMenuItem1
            // 
            this.revolveToolStripMenuItem1.Name = "revolveToolStripMenuItem1";
            this.revolveToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.revolveToolStripMenuItem1.Text = "Revolve";
            this.revolveToolStripMenuItem1.Click += new System.EventHandler(this.revolveToolStripMenuItem1_Click);
            // 
            // bRepToolStripMenuItem
            // 
            this.bRepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boxToolStripMenuItem,
            this.cylinderToolStripMenuItem1,
            this.coneToolStripMenuItem1,
            this.sphereToolStripMenuItem1,
            this.torusToolStripMenuItem1});
            this.bRepToolStripMenuItem.Name = "bRepToolStripMenuItem";
            this.bRepToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.bRepToolStripMenuItem.Text = "Brep";
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.boxToolStripMenuItem.Text = "Box";
            this.boxToolStripMenuItem.Click += new System.EventHandler(this.boxToolStripMenuItem_Click);
            // 
            // cylinderToolStripMenuItem1
            // 
            this.cylinderToolStripMenuItem1.Name = "cylinderToolStripMenuItem1";
            this.cylinderToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.cylinderToolStripMenuItem1.Text = "Cylinder";
            this.cylinderToolStripMenuItem1.Click += new System.EventHandler(this.cylinderToolStripMenuItem1_Click_1);
            // 
            // coneToolStripMenuItem1
            // 
            this.coneToolStripMenuItem1.Name = "coneToolStripMenuItem1";
            this.coneToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.coneToolStripMenuItem1.Text = "Cone";
            this.coneToolStripMenuItem1.Click += new System.EventHandler(this.coneToolStripMenuItem1_Click);
            // 
            // sphereToolStripMenuItem1
            // 
            this.sphereToolStripMenuItem1.Name = "sphereToolStripMenuItem1";
            this.sphereToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.sphereToolStripMenuItem1.Text = "Sphere";
            this.sphereToolStripMenuItem1.Click += new System.EventHandler(this.sphereToolStripMenuItem1_Click);
            // 
            // torusToolStripMenuItem1
            // 
            this.torusToolStripMenuItem1.Name = "torusToolStripMenuItem1";
            this.torusToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.torusToolStripMenuItem1.Text = "Torus";
            this.torusToolStripMenuItem1.Click += new System.EventHandler(this.torusToolStripMenuItem1_Click);
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
            this.eye가져오기ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.eye가져오기ToolStripMenuItem.Text = "Eye 가져오기";
            this.eye가져오기ToolStripMenuItem.Click += new System.EventHandler(this.eye가져오기ToolStripMenuItem_Click);
            // 
            // 객체편집ToolStripMenuItem
            // 
            this.객체편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이동ToolStripMenuItem,
            this.회전ToolStripMenuItem,
            this.확대ToolStripMenuItem,
            this.이동회전확대조합ToolStripMenuItem,
            this.toolStripSeparator1,
            this.선택ToolStripMenuItem,
            this.선택해제ToolStripMenuItem,
            this.선택한객체삭제ToolStripMenuItem});
            this.객체편집ToolStripMenuItem.Name = "객체편집ToolStripMenuItem";
            this.객체편집ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.객체편집ToolStripMenuItem.Text = "객체 편집";
            // 
            // 이동ToolStripMenuItem
            // 
            this.이동ToolStripMenuItem.Name = "이동ToolStripMenuItem";
            this.이동ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.이동ToolStripMenuItem.Text = "이동";
            this.이동ToolStripMenuItem.Click += new System.EventHandler(this.이동ToolStripMenuItem_Click);
            // 
            // 회전ToolStripMenuItem
            // 
            this.회전ToolStripMenuItem.Name = "회전ToolStripMenuItem";
            this.회전ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.회전ToolStripMenuItem.Text = "회전";
            this.회전ToolStripMenuItem.Click += new System.EventHandler(this.회전ToolStripMenuItem_Click);
            // 
            // 확대ToolStripMenuItem
            // 
            this.확대ToolStripMenuItem.Name = "확대ToolStripMenuItem";
            this.확대ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.확대ToolStripMenuItem.Text = "확대";
            this.확대ToolStripMenuItem.Click += new System.EventHandler(this.확대ToolStripMenuItem_Click);
            // 
            // 이동회전확대조합ToolStripMenuItem
            // 
            this.이동회전확대조합ToolStripMenuItem.Name = "이동회전확대조합ToolStripMenuItem";
            this.이동회전확대조합ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.이동회전확대조합ToolStripMenuItem.Text = "이동회전확대조합";
            this.이동회전확대조합ToolStripMenuItem.Click += new System.EventHandler(this.이동회전확대조합ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // 선택ToolStripMenuItem
            // 
            this.선택ToolStripMenuItem.Name = "선택ToolStripMenuItem";
            this.선택ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.선택ToolStripMenuItem.Text = "선택";
            this.선택ToolStripMenuItem.Click += new System.EventHandler(this.선택ToolStripMenuItem_Click);
            // 
            // 선택해제ToolStripMenuItem
            // 
            this.선택해제ToolStripMenuItem.Name = "선택해제ToolStripMenuItem";
            this.선택해제ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.선택해제ToolStripMenuItem.Text = "선택해제";
            this.선택해제ToolStripMenuItem.Click += new System.EventHandler(this.선택해제ToolStripMenuItem_Click);
            // 
            // 선택한객체삭제ToolStripMenuItem
            // 
            this.선택한객체삭제ToolStripMenuItem.Name = "선택한객체삭제ToolStripMenuItem";
            this.선택한객체삭제ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.선택한객체삭제ToolStripMenuItem.Text = "선택한객체삭제";
            this.선택한객체삭제ToolStripMenuItem.Click += new System.EventHandler(this.선택한객체삭제ToolStripMenuItem_Click);
            // 
            // 객체속성ToolStripMenuItem
            // 
            this.객체속성ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.색변경ToolStripMenuItem,
            this.투명도ToolStripMenuItem,
            this.vertexColorToolStripMenuItem});
            this.객체속성ToolStripMenuItem.Name = "객체속성ToolStripMenuItem";
            this.객체속성ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.객체속성ToolStripMenuItem.Text = "객체 속성";
            // 
            // 색변경ToolStripMenuItem
            // 
            this.색변경ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byEntityToolStripMenuItem,
            this.byLayerToolStripMenuItem});
            this.색변경ToolStripMenuItem.Name = "색변경ToolStripMenuItem";
            this.색변경ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.색변경ToolStripMenuItem.Text = "색 변경";
            // 
            // byEntityToolStripMenuItem
            // 
            this.byEntityToolStripMenuItem.Name = "byEntityToolStripMenuItem";
            this.byEntityToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.byEntityToolStripMenuItem.Text = "byEntity";
            this.byEntityToolStripMenuItem.Click += new System.EventHandler(this.byEntityToolStripMenuItem_Click);
            // 
            // byLayerToolStripMenuItem
            // 
            this.byLayerToolStripMenuItem.Name = "byLayerToolStripMenuItem";
            this.byLayerToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.byLayerToolStripMenuItem.Text = "byLayer";
            this.byLayerToolStripMenuItem.Click += new System.EventHandler(this.byLayerToolStripMenuItem_Click);
            // 
            // 투명도ToolStripMenuItem
            // 
            this.투명도ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.투명도ToolStripMenuItem.Name = "투명도ToolStripMenuItem";
            this.투명도ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.투명도ToolStripMenuItem.Text = "투명도";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem3.Text = "Alpha 0";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem4.Text = "Alpha 100";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem5.Text = "Alpha 255";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // vertexColorToolStripMenuItem
            // 
            this.vertexColorToolStripMenuItem.Name = "vertexColorToolStripMenuItem";
            this.vertexColorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.vertexColorToolStripMenuItem.Text = "VertexColor";
            this.vertexColorToolStripMenuItem.Click += new System.EventHandler(this.vertexColorToolStripMenuItem_Click);
            // 
            // layerToolStripMenuItem
            // 
            this.layerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layer색변경ToolStripMenuItem,
            this.layer목록조회ToolStripMenuItem,
            this.layer추가ToolStripMenuItem});
            this.layerToolStripMenuItem.Name = "layerToolStripMenuItem";
            this.layerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.layerToolStripMenuItem.Text = "Layer";
            // 
            // layer색변경ToolStripMenuItem
            // 
            this.layer색변경ToolStripMenuItem.Name = "layer색변경ToolStripMenuItem";
            this.layer색변경ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.layer색변경ToolStripMenuItem.Text = "Layer색변경";
            this.layer색변경ToolStripMenuItem.Click += new System.EventHandler(this.layer색변경ToolStripMenuItem_Click);
            // 
            // layer목록조회ToolStripMenuItem
            // 
            this.layer목록조회ToolStripMenuItem.Name = "layer목록조회ToolStripMenuItem";
            this.layer목록조회ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.layer목록조회ToolStripMenuItem.Text = "Layer목록조회";
            this.layer목록조회ToolStripMenuItem.Click += new System.EventHandler(this.layer목록조회ToolStripMenuItem_Click);
            // 
            // layer추가ToolStripMenuItem
            // 
            this.layer추가ToolStripMenuItem.Name = "layer추가ToolStripMenuItem";
            this.layer추가ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.layer추가ToolStripMenuItem.Text = "Layer추가";
            this.layer추가ToolStripMenuItem.Click += new System.EventHandler(this.layer추가ToolStripMenuItem_Click);
            // 
            // displayModeToolStripMenuItem
            // 
            this.displayModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flatToolStripMenuItem,
            this.shadedToolStripMenuItem,
            this.renderedToolStripMenuItem,
            this.wireframeToolStripMenuItem,
            this.hiddeLinesToolStripMenuItem});
            this.displayModeToolStripMenuItem.Name = "displayModeToolStripMenuItem";
            this.displayModeToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.displayModeToolStripMenuItem.Text = "DisplayMode";
            // 
            // flatToolStripMenuItem
            // 
            this.flatToolStripMenuItem.Name = "flatToolStripMenuItem";
            this.flatToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.flatToolStripMenuItem.Text = "Flat";
            this.flatToolStripMenuItem.Click += new System.EventHandler(this.flatToolStripMenuItem_Click);
            // 
            // shadedToolStripMenuItem
            // 
            this.shadedToolStripMenuItem.Name = "shadedToolStripMenuItem";
            this.shadedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.shadedToolStripMenuItem.Text = "Shaded";
            this.shadedToolStripMenuItem.Click += new System.EventHandler(this.shadedToolStripMenuItem_Click);
            // 
            // renderedToolStripMenuItem
            // 
            this.renderedToolStripMenuItem.Name = "renderedToolStripMenuItem";
            this.renderedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.renderedToolStripMenuItem.Text = "Rendered";
            this.renderedToolStripMenuItem.Click += new System.EventHandler(this.renderedToolStripMenuItem_Click);
            // 
            // wireframeToolStripMenuItem
            // 
            this.wireframeToolStripMenuItem.Name = "wireframeToolStripMenuItem";
            this.wireframeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.wireframeToolStripMenuItem.Text = "Wireframe";
            this.wireframeToolStripMenuItem.Click += new System.EventHandler(this.wireframeToolStripMenuItem_Click);
            // 
            // hiddeLinesToolStripMenuItem
            // 
            this.hiddeLinesToolStripMenuItem.Name = "hiddeLinesToolStripMenuItem";
            this.hiddeLinesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.hiddeLinesToolStripMenuItem.Text = "HiddeLines";
            this.hiddeLinesToolStripMenuItem.Click += new System.EventHandler(this.hiddeLinesToolStripMenuItem_Click);
            // 
            // booleanToolStripMenuItem
            // 
            this.booleanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intersectToolStripMenuItem,
            this.unionToolStripMenuItem,
            this.differenceToolStripMenuItem});
            this.booleanToolStripMenuItem.Name = "booleanToolStripMenuItem";
            this.booleanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.booleanToolStripMenuItem.Text = "Boolean";
            // 
            // intersectToolStripMenuItem
            // 
            this.intersectToolStripMenuItem.Name = "intersectToolStripMenuItem";
            this.intersectToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.intersectToolStripMenuItem.Text = "Intersect";
            this.intersectToolStripMenuItem.Click += new System.EventHandler(this.intersectToolStripMenuItem_Click);
            // 
            // unionToolStripMenuItem
            // 
            this.unionToolStripMenuItem.Name = "unionToolStripMenuItem";
            this.unionToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.unionToolStripMenuItem.Text = "Union";
            this.unionToolStripMenuItem.Click += new System.EventHandler(this.unionToolStripMenuItem_Click);
            // 
            // differenceToolStripMenuItem
            // 
            this.differenceToolStripMenuItem.Name = "differenceToolStripMenuItem";
            this.differenceToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.differenceToolStripMenuItem.Text = "Difference";
            this.differenceToolStripMenuItem.Click += new System.EventHandler(this.differenceToolStripMenuItem_Click);
            // 
            // textureMappingToolStripMenuItem1
            // 
            this.textureMappingToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textureMappingToolStripMenuItem});
            this.textureMappingToolStripMenuItem1.Name = "textureMappingToolStripMenuItem1";
            this.textureMappingToolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.textureMappingToolStripMenuItem1.Text = "TextureMapping";
            // 
            // textureMappingToolStripMenuItem
            // 
            this.textureMappingToolStripMenuItem.Name = "textureMappingToolStripMenuItem";
            this.textureMappingToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.textureMappingToolStripMenuItem.Text = "New TextureMapping";
            this.textureMappingToolStripMenuItem.Click += new System.EventHandler(this.textureMappingToolStripMenuItem_Click_1);
            // 
            // cuttingPlaneToolStripMenuItem
            // 
            this.cuttingPlaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuttingToolStripMenuItem,
            this.clippingPlane2ToolStripMenuItem,
            this.clippingPlane제거ToolStripMenuItem,
            this.clippingPlane적용ToolStripMenuItem,
            this.toolStripSeparator2,
            this.충돌체크ToolStripMenuItem,
            this.bRepToolStripMenuItem1});
            this.cuttingPlaneToolStripMenuItem.Name = "cuttingPlaneToolStripMenuItem";
            this.cuttingPlaneToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.cuttingPlaneToolStripMenuItem.Text = "검토";
            // 
            // cuttingToolStripMenuItem
            // 
            this.cuttingToolStripMenuItem.Name = "cuttingToolStripMenuItem";
            this.cuttingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cuttingToolStripMenuItem.Text = "ClippingPlane1";
            this.cuttingToolStripMenuItem.Click += new System.EventHandler(this.cuttingToolStripMenuItem_Click);
            // 
            // clippingPlane2ToolStripMenuItem
            // 
            this.clippingPlane2ToolStripMenuItem.Name = "clippingPlane2ToolStripMenuItem";
            this.clippingPlane2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clippingPlane2ToolStripMenuItem.Text = "ClippingPlane2";
            this.clippingPlane2ToolStripMenuItem.Click += new System.EventHandler(this.clippingPlane2ToolStripMenuItem_Click);
            // 
            // clippingPlane제거ToolStripMenuItem
            // 
            this.clippingPlane제거ToolStripMenuItem.Name = "clippingPlane제거ToolStripMenuItem";
            this.clippingPlane제거ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clippingPlane제거ToolStripMenuItem.Text = "ClippingPlane제거";
            this.clippingPlane제거ToolStripMenuItem.Click += new System.EventHandler(this.clippingPlane제거ToolStripMenuItem_Click);
            // 
            // clippingPlane적용ToolStripMenuItem
            // 
            this.clippingPlane적용ToolStripMenuItem.Name = "clippingPlane적용ToolStripMenuItem";
            this.clippingPlane적용ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clippingPlane적용ToolStripMenuItem.Text = "ClippingPlane적용";
            this.clippingPlane적용ToolStripMenuItem.Click += new System.EventHandler(this.clippingPlane적용ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // 충돌체크ToolStripMenuItem
            // 
            this.충돌체크ToolStripMenuItem.Name = "충돌체크ToolStripMenuItem";
            this.충돌체크ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.충돌체크ToolStripMenuItem.Text = "충돌체크";
            this.충돌체크ToolStripMenuItem.Click += new System.EventHandler(this.충돌체크ToolStripMenuItem_Click);
            // 
            // bRepToolStripMenuItem1
            // 
            this.bRepToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volumnToolStripMenuItem,
            this.edge추출ToolStripMenuItem,
            this.cylinderFace선택ToolStripMenuItem,
            this.coneFace선택ToolStripMenuItem});
            this.bRepToolStripMenuItem1.Name = "bRepToolStripMenuItem1";
            this.bRepToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bRepToolStripMenuItem1.Text = "BRep";
            // 
            // volumnToolStripMenuItem
            // 
            this.volumnToolStripMenuItem.Name = "volumnToolStripMenuItem";
            this.volumnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.volumnToolStripMenuItem.Text = "Volume";
            this.volumnToolStripMenuItem.Click += new System.EventHandler(this.volumnToolStripMenuItem_Click);
            // 
            // edge추출ToolStripMenuItem
            // 
            this.edge추출ToolStripMenuItem.Name = "edge추출ToolStripMenuItem";
            this.edge추출ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edge추출ToolStripMenuItem.Text = "Edge 추출";
            this.edge추출ToolStripMenuItem.Click += new System.EventHandler(this.edge추출ToolStripMenuItem_Click);
            // 
            // cylinderFace선택ToolStripMenuItem
            // 
            this.cylinderFace선택ToolStripMenuItem.Name = "cylinderFace선택ToolStripMenuItem";
            this.cylinderFace선택ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cylinderFace선택ToolStripMenuItem.Text = "Cylinder face 선택";
            this.cylinderFace선택ToolStripMenuItem.Click += new System.EventHandler(this.cylinderFace선택ToolStripMenuItem_Click);
            // 
            // coneFace선택ToolStripMenuItem
            // 
            this.coneFace선택ToolStripMenuItem.Name = "coneFace선택ToolStripMenuItem";
            this.coneFace선택ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coneFace선택ToolStripMenuItem.Text = "Cone face 선택";
            this.coneFace선택ToolStripMenuItem.Click += new System.EventHandler(this.coneFace선택ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 437);
            this.Controls.Add(this.model1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ToolStripMenuItem 객체편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이동회전확대조합ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 객체속성ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byEntityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layer색변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layer목록조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layer추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 투명도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem curveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compositeCurveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compositeCurveToMeshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sweepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xZ평면ArcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sweep생성ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revolveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curveToRegionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roundedRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularSlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexagonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromCurveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem region으로Mesh생성ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrudeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sweepToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem revolveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displayModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wireframeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shadedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiddeLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bRepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cylinderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem coneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem torusToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem booleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intersectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vertexColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textureMappingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textureMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택해제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택한객체삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuttingPlaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuttingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clippingPlane2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clippingPlane제거ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clippingPlane적용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 충돌체크ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bRepToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem volumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edge추출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cylinderFace선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coneFace선택ToolStripMenuItem;
    }
}

