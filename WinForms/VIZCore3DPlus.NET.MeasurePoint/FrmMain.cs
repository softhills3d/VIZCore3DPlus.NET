﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VIZCore3D.NET.Data;
using VIZCore3D.NET.Dialogs;

namespace VIZCore3DPlus.NET.MeasurePoint
{
    public partial class FrmMain : Form
    {
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;

        public FrmMain()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            // Construction
            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(vizcore3d);

            // Event
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;

            //Set ComboBox Items
            SetPointComboBoxItems();
        }

        // ================================================
        // Event - VIZCore3D.NET
        // ================================================
        #region Event - OnInitializedVIZCore3D
        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            //MessageBox.Show("OnInitializedVIZCore3D", "VIZCore3D.NET");

            // ================================================================
            // Example
            // ================================================================
            //vizcore3d.License.LicenseFile("C:\\Temp\\VIZCore3D.NET.lic");                         // 라이선스 파일
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901);                                   // 라이선스 서버 - 제품 오토 선택
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901, Data.Products.AUTO);               // 라이선스 서버 - 제품 오토 선택
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901, Data.Products.VIZZARD_MANAGER);    // 라이선스 서버 - 지정된 제품으로 인증
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901, Data.Products.VIZZARD_STANDARD);   // 라이선스 서버 - 지정된 제품으로 인증
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901, Data.Products.VIZCORE3D_MANAGER);  // 라이선스 서버 - 지정된 제품으로 인증
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901, Data.Products.VIZCORE3D_STANDARD); // 라이선스 서버 - 지정된 제품으로 인증


            // ================================================================
            // TEST
            // ================================================================
            //VIZCore3D.NET.Data.LicenseResults result = vizcore3d.License.LicenseFile("C:\\License\\VIZCore3D.NET.lic");
            //VIZCore3D.NET.Data.LicenseResults result = vizcore3d.License.LicenseServer("127.0.0.1", 8901);
            //VIZCore3D.NET.Data.LicenseResults result = vizcore3d.License.LicenseServer("192.168.0.215", 8901);
            //if (result != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            //{
            //    MessageBox.Show(string.Format("LICENSE CODE : {0}", result.ToString()), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            // ================================================================
            // License Helper
            // ================================================================
            #region 라이선스
            // 라이선스 정보 조회
            VIZCore3D.NET.Utility.LicenseHelper.LicenseData licenseData = VIZCore3D.NET.Utility.LicenseHelper.GetLicenseDataKind();

            // 등록된 정보 없는 경우, 설정 다이얼로그 실행
            if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.NONE)
            {
                VIZCore3D.NET.Dialogs.LicenseDialog dlg = new VIZCore3D.NET.Dialogs.LicenseDialog();
                if (dlg.ShowDialog() != DialogResult.OK) return;
            }

            // 라이선스 정보 재조회
            licenseData = VIZCore3D.NET.Utility.LicenseHelper.GetLicenseDataKind();

            // 등록된 정보 조회
            Dictionary<string, string> licenseInfo = VIZCore3D.NET.Utility.LicenseHelper.GetLicenseInformation();
            VIZCore3D.NET.Data.LicenseResults licenseResult = VIZCore3D.NET.Data.LicenseResults.NONE;

            // 라이선스 서버
            if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.SERVER)
            {
                licenseResult = vizcore3d.License.LicenseServer(
                    licenseInfo.ContainsKey("LICENSE_IP") == true ? licenseInfo["LICENSE_IP"] : String.Empty
                    , licenseInfo.ContainsKey("LICENSE_PORT") == true ? Convert.ToInt32(licenseInfo["LICENSE_PORT"]) : 8901
                    );
            }
            // 라이선스 파일
            else if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.FILE)
            {
                licenseResult = vizcore3d.License.LicenseFile(
                    licenseInfo.ContainsKey("LICENSE_FILE") == true ? licenseInfo["LICENSE_FILE"] : String.Empty
                    );
            }

            // 인증 결과
            if (licenseResult != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            {
                MessageBox.Show(string.Format("LICENSE CODE : {0}", licenseResult.ToString()), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            // Init. VIZCore3D.NET
            InitializeVIZCore3D();
            InitializeVIZCore3DEvent();
        }
        #endregion

        // ================================================
        // Function - VIZCore3D.NET : Initialize
        // ================================================
        #region Function - VIZCore3D.NET : Initialize
        private void InitializeVIZCore3D()
        {
            // ================================================================
            // 모델 열기 시, 3D 화면 Rendering 차단
            // ================================================================
            vizcore3d.BeginUpdate();


            // ================================================================
            // 설정 - 기본
            // ================================================================
            #region 설정 - 기본
            // 모델 자동 언로드 (파일 노드 언체크 시, 언로드)
            vizcore3d.Model.UncheckToUnload = true;

            // 모델 열기 시, Edge 정보 로드 활성화
            vizcore3d.Model.LoadEdgeData = true;

            // 모델 열기 시, Edge 정보 생성 활성화
            vizcore3d.Model.GenerateEdgeData = true;

            // 모델 조회 시, 하드웨어 가속
            vizcore3d.View.EnableHardwareAcceleration = true;

            // Undo/Redo (비)활성화
            vizcore3d.Model.EnableUndoRedo = false;

            // 모델 열기 시, 스트럭처 병합 설정
            vizcore3d.Model.OpenMergeStructureMode = VIZCore3D.NET.Data.MergeStructureModes.NONE;

            // 모델 저장 시, 스트럭처 병합 설정
            vizcore3d.Model.SaveMergeStructureMode = VIZCore3D.NET.Data.MergeStructureModes.NONE;

            // 실린더 원형 품질 개수 : Nomal(12~36), Small(6~36)
            vizcore3d.Model.ReadNormalCylinderSide = 12;
            vizcore3d.Model.ReadSmallCylinderSide = 6;

            // 보이는 모델만 저장

            // VIZXML to VIZ 옵션
            vizcore3d.Model.VIZXMLtoVIZOption = VIZCore3D.NET.Data.ExportVIZXMLToVIZOptions.LOAD_UNLOADED_NODE;

            // 선택 가능 개체 : 전체, 불투명한 개체
            vizcore3d.View.SelectionObject3DType = VIZCore3D.NET.Data.SelectionObject3DTypes.ALL;

            // 개체 선택 유형 : 색상, 경계로 선택 (개체), 경계로 선택 (전체)
            vizcore3d.View.SelectionMode = VIZCore3D.NET.Data.Object3DSelectionOptions.HIGHLIGHT_COLOR;

            // 개체 선택 색상
            vizcore3d.View.SelectionColor = Color.Red;

            // 모델 조회 시, Pre-Select 설정
            vizcore3d.View.PreSelect.Enable = false;

            // 모델 조회 시, Pre-Select 색상 설정
            vizcore3d.View.PreSelect.HighlightColor = Color.Lime;

            // 모델 조회 시, Pre-Select Label
            vizcore3d.View.PreSelect.Label = VIZCore3D.NET.Data.PreSelectStyle.LabelKind.HIERACHY_BOTTOM_UP;

            // 모델 조회 시, Pre-Select Font
            vizcore3d.View.PreSelect.LabelFont = new Font("Arial", 10.0f);
            #endregion


            // ================================================================
            // 설정 - 보기
            // ================================================================
            #region 설정 - 보기
            // 자동 애니메이션 : 박스줌, 개체로 비행 등 기능에서 애니메이션 활성화/비활성화
            vizcore3d.View.EnableAnimation = true;

            // 자동화면맞춤
            vizcore3d.View.EnableAutoFit = false;

            // 연속회전모드
            vizcore3d.View.EnableInertiaRotate = false;

            // 확대/축소 비율 : 5.0f ~ 50.0f
            vizcore3d.View.ZoomRatio = 30.0f;

            // 회전각도
            vizcore3d.View.RotationAngle = 90.0f;

            // 회전 축
            vizcore3d.View.RotationAxis = VIZCore3D.NET.Data.Axis.X;
            #endregion


            // ================================================================
            // 설정 - 탐색
            // ================================================================
            #region 설정 - 탐색
            // Z축 고정
            vizcore3d.Walkthrough.LockZAxis = false;
            // 선속도 : m/s
            vizcore3d.Walkthrough.Speed = 2.0f;
            // 각속도
            vizcore3d.Walkthrough.AngularSpeed = 30.0f;
            // 높이
            vizcore3d.Walkthrough.AvatarHeight = 1800.0f;
            // 반지름
            vizcore3d.Walkthrough.AvatarCollisionRadius = 400.0f;
            // 숙임높이
            vizcore3d.Walkthrough.AvatarBowWalkHeight = 1300.0f;
            // 충돌
            vizcore3d.Walkthrough.UseAvatarCollision = false;
            // 중력
            vizcore3d.Walkthrough.UseAvatarGravity = false;
            // 숙임
            vizcore3d.Walkthrough.UseAvatarBowWalk = false;
            // 모델
            vizcore3d.Walkthrough.AvatarModel = (int)VIZCore3D.NET.Data.AvatarModels.MAN1;
            // 자동줌
            vizcore3d.Walkthrough.EnableAvatarAutoZoom = true;
            // 충돌상자보기
            vizcore3d.Walkthrough.ShowAvatarCollisionCylinder = false;
            #endregion


            // ================================================================
            // 설정 - 조작
            // ================================================================
            #region 설정 - 조작
            // 시야각
            vizcore3d.View.FOV = 60.0f;
            // 광원 세기
            vizcore3d.View.SpecularGamma = 30.0f;
            // 모서리 굵기
            vizcore3d.View.EdgeWidthRatio = 0.0f;
            // X-Ray 모델 조회 시, 개체 색상 - 선택색상, 모델색상
            vizcore3d.View.XRay.ColorType = VIZCore3D.NET.Data.XRayColorTypes.SELECTION_COLOR;
            // 배경유형
            //vizcore3d.View.BackgroundMode = VIZCore3D.NET.Data.BackgroundModes.COLOR_ONE;
            // 배경색1
            //vizcore3d.View.BackgroundColor1 = Color.Gray;
            // 배경색2
            //vizcore3d.View.BackgroundColor2 = Color.Gray; 
            #endregion


            // ================================================================
            // 설정 - 노트
            // ================================================================
            #region 설정 - 노트
            // 배경색
            vizcore3d.Review.Note.BackgroundColor = Color.Yellow;
            // 배경 투명
            vizcore3d.Review.Note.BackgroudTransparent = false;
            // 글자색
            vizcore3d.Review.Note.FontColor = Color.Black;
            // 글자 크기
            vizcore3d.Review.Note.FontSize = VIZCore3D.NET.Data.FontSizeKind.SIZE16;
            // 글자 굵게
            vizcore3d.Review.Note.FontBold = true;
            // 지시선(라인) 색상
            vizcore3d.Review.Note.LineColor = Color.White;
            // 지시선(라인) 두께
            vizcore3d.Review.Note.LineWidth = 2;
            // 지시선 중앙 연결
            vizcore3d.Review.Note.LinkArrowTailToText = VIZCore3D.NET.Manager.NoteManager.LinkArrowTailToTextKind.OUTLINE;
            // 화살표 색상
            vizcore3d.Review.Note.ArrowColor = Color.Red;
            // 화살표 두께
            vizcore3d.Review.Note.ArrowWidth = 10;
            // 텍스트상자 라인 색상
            vizcore3d.Review.Note.TextBoxLineColor = Color.Black;

            // 심볼 배경색
            vizcore3d.Review.Note.SymbolBackgroundColor = Color.Red;
            // 심볼 글자색
            vizcore3d.Review.Note.SymbolFontColor = Color.White;
            // 심볼 크기
            vizcore3d.Review.Note.SymbolSize = 10;
            // 심볼 글자 크기
            vizcore3d.Review.Note.SymbolFontSize = VIZCore3D.NET.Data.FontSizeKind.SIZE16;
            // 심볼 글자 굵게
            vizcore3d.Review.Note.SymbolFontBold = false;
            #endregion


            // ================================================================
            // 설정 - 측정
            // ================================================================
            #region 설정 - 측정
            // 반복 모드
            vizcore3d.Review.Measure.RepeatMode = false;

            // 기본 스타일
            VIZCore3D.NET.Data.MeasureStyle measureStyle = vizcore3d.Review.Measure.GetStyle();

            // Prefix 조회
            measureStyle.Prefix = true;
            // Frame(좌표계)로 표시
            measureStyle.Frame = true;
            // DX, DY, DZ 표시
            measureStyle.DX_DY_DZ = true;
            // 측정 단위 표시
            measureStyle.Unit = true;
            // 측정 단위 유형
            measureStyle.UnitKind = VIZCore3D.NET.Data.MeasureUnitKind.RUT_MILLIMETER;
            // 소수점 이하 자리수
            measureStyle.NumberOfDecimalPlaces = 2;
            // 연속거리 표시
            measureStyle.ContinuousDistance = true;

            // 배경 투명
            measureStyle.BackgroundTransparent = false;
            // 배경색
            measureStyle.BackgroundColor = Color.Blue;
            // 글자색
            measureStyle.FontColor = Color.White;
            // 글자크기
            measureStyle.FontSize = VIZCore3D.NET.Data.FontSizeKind.SIZE14;
            // 글자 두껍게
            measureStyle.FontBold = false;
            // 지시선 색
            measureStyle.LineColor = Color.White;
            // 지시선 두께
            measureStyle.LineWidth = 2;
            // 화살표 색
            measureStyle.ArrowColor = Color.Red;
            // 화살표 크기
            measureStyle.ArrowSize = 10;
            // 보조 지시선 표시
            measureStyle.AssistantLine = true;
            // 보조 지시선 표시 개수
            measureStyle.AssistantLineCount = -1;
            // 보조 지시선 라인 스타일
            measureStyle.AssistantLineStyle = VIZCore3D.NET.Data.MeasureStyle.AssistantLineType.DOTTEDLINE;
            // 선택 위치 표시
            measureStyle.PickPosition = true;
            // 거리 측정 텍스트 정렬
            measureStyle.AlignDistanceText = true;
            // 거리 측정 텍스트 위치
            measureStyle.AlignDistanceTextPosition = 2;
            // 거리 측정 텍스트 오프셋
            measureStyle.AlignDistanceTextMargine = 5;

            // 측정 스타일 설정
            vizcore3d.Review.Measure.SetStyle(measureStyle);
            #endregion


            // ================================================================
            // 설정 - 단면
            // ================================================================
            #region 설정 - 단면
            // 단면 좌표간격으로 이동
            vizcore3d.Section.MoveSectionByFrameGrid = true;
            // 단면 보기
            vizcore3d.Section.ShowSectionPlane = true;
            // 단면선 표시
            vizcore3d.Section.ShowSectionLine = true;
            // 단면 단일색 표시
            vizcore3d.Section.ShowSectionLineColor = false;
            // 단면 단일색
            vizcore3d.Section.SectionLineColor = Color.Red;
            #endregion


            // ================================================================
            // 설정 - 간섭검사
            // ================================================================
            // 다중간섭검사
            vizcore3d.Clash.EnableMultiThread = true;


            // ================================================================
            // 설정 - 프레임(SHIP GRID)
            // ================================================================
            #region 설정 - 프레임
            // 프레임 평면 설정
            vizcore3d.Frame.XYPlane = true;
            vizcore3d.Frame.YZPlane = true;
            vizcore3d.Frame.ZXPlane = true;
            vizcore3d.Frame.PlanLine = true;
            vizcore3d.Frame.SectionLine = true;
            vizcore3d.Frame.ElevationLine = true;

            // 좌표값 표기
            vizcore3d.Frame.ShowNumber = true;

            // 모델 앞에 표기
            vizcore3d.Frame.BringToFront = false;

            // Frame(좌표계, SHIP GRID) 색상
            vizcore3d.Frame.ForeColor = Color.Black;

            // 홀수번째 표시
            vizcore3d.Frame.ShowOddNumber = true;
            // 짝수번째 표시
            vizcore3d.Frame.ShowEvenNumber = true;
            // 단면상자에 자동 맞춤
            vizcore3d.Frame.AutoFitSectionBox = true;
            #endregion


            // ================================================================
            // 설정 - 툴바
            // ================================================================
            #region 설정 - 툴바
            vizcore3d.ToolbarMain.Visible = true;
            vizcore3d.ToolbarNote.Visible = false;
            vizcore3d.ToolbarMeasure.Visible = false;
            vizcore3d.ToolbarSection.Visible = false;
            vizcore3d.ToolbarClash.Visible = false;
            vizcore3d.ToolbarAnimation.Visible = false;
            vizcore3d.ToolbarSimulation.Visible = false;
            vizcore3d.ToolbarPrimitive.Visible = false;
            vizcore3d.ToolbarDrawing2D.Visible = true;
            #endregion


            // ================================================================
            // 설정 - 상태바
            // ================================================================
            vizcore3d.Statusbar.Visible = false;


            // ================================================================
            // 모델 열기 시, 3D 화면 Rendering 재시작
            // ================================================================
            vizcore3d.EndUpdate();
        }
        #endregion

        #region Function - VIZCore3D.NET : Add Event Handler
        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
        }
        #endregion

        #region Model
        private void btnOpen_Click(object sender, EventArgs e)
        {
            vizcore3d.Model.OpenFileDialog();
        }

        private void cbViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;
            string mode = cbViewMode.SelectedItem.ToString();

            switch (mode)
            {
                case "3D":
                    vizcore3d.ViewMode = VIZCore3D.NET.Data.ViewKind.Model3D;
                    break;
                case "3D / 2D":
                    vizcore3d.ViewMode = VIZCore3D.NET.Data.ViewKind.Both;
                    break;
                case "2D":
                    vizcore3d.ViewMode = VIZCore3D.NET.Data.ViewKind.Drawing2D;
                    break;
                default:
                    vizcore3d.ViewMode = VIZCore3D.NET.Data.ViewKind.Model3D;
                    break;
            }
        }
        #endregion

        #region Object
        /// <summary>
        /// 모델 추가 (카메라 View)
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnAddModel_Click(object sender, EventArgs e)
        {
            vizcore3d.Drawing2D.Object2D.Set2DViewCreateObjectWithModel(false);
        }

        /// <summary>
        /// 모델 삭제
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnDeleteObj_Click(object sender, EventArgs e)
        {
            vizcore3d.Drawing2D.Object2D.DeleteSelectedObjectBy2DView();
        }

        /// <summary>
        /// 초기화
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnClearObj_Click(object sender, EventArgs e)
        {
            // 2D 도면 삭제
            vizcore3d.Drawing2D.Object2D.DeleteAllObjectBy2DView();
            // 2D 도면 외 개체 삭제
            vizcore3d.Drawing2D.Object2D.DeleteAllNonObjectBy2DView();
        }
        #endregion

        #region Point
        private void SetPointComboBoxItems()
        {
            cb3DPointType.Items.Add("자유 타입");
            cb3DPointType.Items.Add("곡선 위 점");
            cb3DPointType.Items.Add("두 직선 교차점");
            cb3DPointType.Items.Add("직선과 곡면의 교차점");
            cb3DPointType.Items.Add("3평면의 교점");
            cb3DPointType.Items.Add("파이프 중심");
            cb3DPointType.Items.Add("방향 옵셋점");
            cb3DPointType.Items.Add("직접 입력");
        }

        /// <summary>
        /// Set LevelMeasurePoint Option Update
        /// </summary>
        private void SetLevelMeasurePointOptionUpdate()
        {
            int pointKind = 0; //설계점


            bool bPoint3DMeasure = ckPoint3DMeasure.Checked;
            bool bPointVerticalMeasure = ckPointVerticalMeasure.Checked;
            bool bPointDesignMeasure = ckPointDesignMeasure.Checked;
            bool bPointLevel = ckPointLevelMeasure.Checked;

            vizcore3d.Drawing2D.Measure.SetLevelMeasurePointOption(pointKind, bPoint3DMeasure, bPointVerticalMeasure, false, bPointDesignMeasure, bPointLevel, false, false);
        }


        /// <summary>
        /// Add 2DPoint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd2DPoint_Click(object sender, EventArgs e)
        {
            SetLevelMeasurePointOptionUpdate();
            vizcore3d.Drawing2D.Measure.Set2DViewCreateWithLevelMeasurePoint();
        }


        /// <summary>
        /// 생성 (좌표) 이벤트
        /// </summary>
        private void p_CreateLevelMeasure(object sender, EventArgs e)
        {
            PositionSelectDialog dlg = (PositionSelectDialog)sender;

            vizcore3d.Drawing2D.Measure.AddUserLevelMeasurePoint(dlg.xPos, dlg.yPos, dlg.zPos);
        }

        /// <summary>
        /// 생성 위치선택 이벤트
        /// </summary>
        private void p_GetPositionSelect(object sender, EventArgs e)
        {
            PositionSelectDialog dlg = (PositionSelectDialog)sender;

            vizcore3d.GeometryUtility.OnOsnapPickingItem += dlg.GeometryUtility_OnOsnapPickingItem;

            //위치 선택
            vizcore3d.GeometryUtility.ShowOsnap(-1, true, true, false, false);
        }


        /// <summary>
        /// Add 3DPoint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd3DPoint_Click(object sender, EventArgs e)
        {
            SetLevelMeasurePointOptionUpdate();


            if (cb3DPointType.Text == "자유 타입")
            {
                vizcore3d.Drawing2D.Measure.AddGeoLevelMeasurePointByPoints();
            }
            else if (cb3DPointType.Text == "곡선 위 점")
            {

                // 반복 측정 모드
                vizcore3d.Review.Measure.RepeatMode = true;

                vizcore3d.Drawing2D.Measure.AddGeoLevelMeasurePointBySurface();
            }
            else if (cb3DPointType.Text == "두 직선 교차점")
            {
                // 반복 측정 모드
                vizcore3d.Review.Measure.RepeatMode = true;

                vizcore3d.Drawing2D.Measure.AddGeoLevelMeasurePointByLineCross();
            }
            else if (cb3DPointType.Text == "직선과 곡면의 교차점")
            {
                // 반복 측정 모드
                vizcore3d.Review.Measure.RepeatMode = true;

                vizcore3d.Drawing2D.Measure.AddGeoLevelMeasurePointByLine2SurfaceCross();
            }
            else if (cb3DPointType.Text == "3평면의 교점")
            {
                // 반복 측정 모드
                vizcore3d.Review.Measure.RepeatMode = true;

                vizcore3d.Drawing2D.Measure.AddGeoLevelMeasurePointBy3SurfaceCross();
            }
            else if (cb3DPointType.Text == "파이프 중심")
            {
                // 반복 측정 모드
                vizcore3d.Review.Measure.RepeatMode = true;

                vizcore3d.Drawing2D.Measure.AddGeoLevelMeasurePointByCircleCenter();
            }
            else if (cb3DPointType.Text == "방향 옵셋점")
            {
                // 반복 측정 모드
                vizcore3d.Review.Measure.RepeatMode = true;

                vizcore3d.Drawing2D.Measure.AddGeoLevelMeasurePointByOffsetPos();
            }
            else if (cb3DPointType.Text == "직접 입력")
            {
                PositionSelectDialog dlg = new PositionSelectDialog();
                dlg.OKEventHandler += p_CreateLevelMeasure;
                dlg.GetPositionModel += p_GetPositionSelect;
                dlg.Show();
            }
            else
            {
                vizcore3d.Drawing2D.Measure.AddGeoLevelMeasurePointByPoints();
            }
        }
        #endregion

        #region Translate Point
        /// <summary>
        /// Drawing2D : 축방향 이동 (3D)
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnTranslatePointByAxis_Click(object sender, EventArgs e)
        {
            List<MeasureItem> selecteItems = new List<MeasureItem>();
            List<MeasureItem> list = vizcore3d.Review.Measure.Items;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Selected)
                {
                    selecteItems.Add(list[i]);
                }
            }
            // 선택된 측정 리뷰가 없는 경우 return
            if (selecteItems.Count <= 0) return;

            vizcore3d.Drawing2D.Measure.AddGeoMoveLevelMeasureDesignPointByRefAxis();
        }
        #endregion

        #region Unselect
        /// <summary>
        ///  3D 측정 - 계측점 모두 선택 해제
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();
            vizcore3d.Drawing2D.Measure.SetUnselectAllLevelMeasurePoint();
            vizcore3d.EndUpdate();
        }
        #endregion

        #region Delete
        /// <summary>
        /// 계측점 선택 삭제
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();
            vizcore3d.Drawing2D.Measure.DeleteSelLevelMeasurePoint();
            vizcore3d.EndUpdate();
        }
        #endregion

        #region Show / Hide
        /// <summary>
        /// 계측점 모두 보이기
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();
            vizcore3d.Drawing2D.Measure.ShowAllLevelMeasurePoint();
            vizcore3d.EndUpdate();
        }

        /// <summary>
        /// 계측점 모두 숨기기
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnHideAll_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();
            vizcore3d.Drawing2D.Measure.HideAllLevelMeasurePoint();
            vizcore3d.EndUpdate();
        }

        /// <summary>
        /// 계측점 선택 숨기기
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnHideSelected_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();
            vizcore3d.Drawing2D.Measure.HideSelLevelMeasurePoint();
            vizcore3d.EndUpdate();
        }
        #endregion

        /// <summary>
        /// 3D 뷰 측정 2D 뷰에 측정 추가
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnAdd2DFrom3D_Click(object sender, EventArgs e)
        {
            List<MeasureItem> item = vizcore3d.Review.Measure.Items;
            List<int> list = new List<int>();

            for (int i = 0; i < item.Count; i++)
            {
                if (item[i].Kind == VIZCore3D.NET.Manager.ReviewManager.ReviewKind.RK_MEASURE_POS || item[i].Kind == VIZCore3D.NET.Manager.ReviewManager.ReviewKind.RK_MEASURE_DISTANCE)
                {
                    list.Add(item[i].ID);
                }
            }

            int current = vizcore3d.Drawing2D.Object2D.GetCurrentWork3DObjectBy2DView();

            if (current < 0)
            {
                MessageBox.Show("2D 도면을 선택해 주세요.");
                return;
            }

            vizcore3d.Drawing2D.Measure.Add2DMeasureFrom3DMeasure(list.ToArray());

        }
    }
}
