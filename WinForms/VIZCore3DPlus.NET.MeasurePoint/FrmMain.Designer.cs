namespace VIZCore3DPlus.NET.MeasurePoint
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnHideAll = new System.Windows.Forms.Button();
            this.btnHideSelected = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTranslatePointByAxis = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb3DPointType = new System.Windows.Forms.ComboBox();
            this.btnAdd3DPoint = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ckPointLevelMeasure = new System.Windows.Forms.CheckBox();
            this.ckPointDesignMeasure = new System.Windows.Forms.CheckBox();
            this.ckPointVerticalMeasure = new System.Windows.Forms.CheckBox();
            this.ckPoint3DMeasure = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteObj = new System.Windows.Forms.Button();
            this.btnClearObj = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbViewMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd2DFrom3D = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd2DFrom3D);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox8);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox9);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnHideAll);
            this.groupBox7.Controls.Add(this.btnHideSelected);
            this.groupBox7.Controls.Add(this.btnShowAll);
            this.groupBox7.Location = new System.Drawing.Point(12, 491);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(277, 87);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Show / Hide";
            // 
            // btnHideAll
            // 
            this.btnHideAll.Location = new System.Drawing.Point(145, 20);
            this.btnHideAll.Name = "btnHideAll";
            this.btnHideAll.Size = new System.Drawing.Size(126, 23);
            this.btnHideAll.TabIndex = 3;
            this.btnHideAll.Text = "Hide All";
            this.btnHideAll.UseVisualStyleBackColor = true;
            this.btnHideAll.Click += new System.EventHandler(this.btnHideAll_Click);
            // 
            // btnHideSelected
            // 
            this.btnHideSelected.Location = new System.Drawing.Point(6, 49);
            this.btnHideSelected.Name = "btnHideSelected";
            this.btnHideSelected.Size = new System.Drawing.Size(265, 23);
            this.btnHideSelected.TabIndex = 2;
            this.btnHideSelected.Text = "Hide Selected";
            this.btnHideSelected.UseVisualStyleBackColor = true;
            this.btnHideSelected.Click += new System.EventHandler(this.btnHideSelected_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(6, 20);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(126, 23);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTranslatePointByAxis);
            this.groupBox4.Location = new System.Drawing.Point(12, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 52);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Translate Point ";
            // 
            // btnTranslatePointByAxis
            // 
            this.btnTranslatePointByAxis.Location = new System.Drawing.Point(6, 21);
            this.btnTranslatePointByAxis.Name = "btnTranslatePointByAxis";
            this.btnTranslatePointByAxis.Size = new System.Drawing.Size(265, 23);
            this.btnTranslatePointByAxis.TabIndex = 0;
            this.btnTranslatePointByAxis.Text = "By Axis";
            this.btnTranslatePointByAxis.UseVisualStyleBackColor = true;
            this.btnTranslatePointByAxis.Click += new System.EventHandler(this.btnTranslatePointByAxis_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnDeleteSelected);
            this.groupBox8.Location = new System.Drawing.Point(12, 433);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(277, 52);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Delete";
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(6, 20);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(265, 23);
            this.btnDeleteSelected.TabIndex = 0;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.cb3DPointType);
            this.groupBox6.Controls.Add(this.btnAdd3DPoint);
            this.groupBox6.Location = new System.Drawing.Point(12, 209);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 100);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "3D Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Point Type";
            // 
            // cb3DPointType
            // 
            this.cb3DPointType.FormattingEnabled = true;
            this.cb3DPointType.Location = new System.Drawing.Point(95, 26);
            this.cb3DPointType.Name = "cb3DPointType";
            this.cb3DPointType.Size = new System.Drawing.Size(176, 20);
            this.cb3DPointType.TabIndex = 4;
            this.cb3DPointType.Text = "자유 타입";
            // 
            // btnAdd3DPoint
            // 
            this.btnAdd3DPoint.Location = new System.Drawing.Point(74, 65);
            this.btnAdd3DPoint.Name = "btnAdd3DPoint";
            this.btnAdd3DPoint.Size = new System.Drawing.Size(123, 23);
            this.btnAdd3DPoint.TabIndex = 6;
            this.btnAdd3DPoint.Text = "Add 3D Point";
            this.btnAdd3DPoint.UseVisualStyleBackColor = true;
            this.btnAdd3DPoint.Click += new System.EventHandler(this.btnAdd3DPoint_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnUnselectAll);
            this.groupBox9.Location = new System.Drawing.Point(12, 373);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(277, 54);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Unselect";
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Location = new System.Drawing.Point(6, 20);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(265, 23);
            this.btnUnselectAll.TabIndex = 3;
            this.btnUnselectAll.Text = "Unselect All";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ckPointLevelMeasure);
            this.groupBox5.Controls.Add(this.ckPointDesignMeasure);
            this.groupBox5.Controls.Add(this.ckPointVerticalMeasure);
            this.groupBox5.Controls.Add(this.ckPoint3DMeasure);
            this.groupBox5.Location = new System.Drawing.Point(12, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 65);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Point Option";
            // 
            // ckPointLevelMeasure
            // 
            this.ckPointLevelMeasure.AutoSize = true;
            this.ckPointLevelMeasure.Location = new System.Drawing.Point(159, 42);
            this.ckPointLevelMeasure.Name = "ckPointLevelMeasure";
            this.ckPointLevelMeasure.Size = new System.Drawing.Size(76, 16);
            this.ckPointLevelMeasure.TabIndex = 3;
            this.ckPointLevelMeasure.Text = "레벨 계측";
            this.ckPointLevelMeasure.UseVisualStyleBackColor = true;
            // 
            // ckPointDesignMeasure
            // 
            this.ckPointDesignMeasure.AutoSize = true;
            this.ckPointDesignMeasure.Location = new System.Drawing.Point(159, 20);
            this.ckPointDesignMeasure.Name = "ckPointDesignMeasure";
            this.ckPointDesignMeasure.Size = new System.Drawing.Size(76, 16);
            this.ckPointDesignMeasure.TabIndex = 2;
            this.ckPointDesignMeasure.Text = "의장 계측";
            this.ckPointDesignMeasure.UseVisualStyleBackColor = true;
            // 
            // ckPointVerticalMeasure
            // 
            this.ckPointVerticalMeasure.AutoSize = true;
            this.ckPointVerticalMeasure.Location = new System.Drawing.Point(42, 42);
            this.ckPointVerticalMeasure.Name = "ckPointVerticalMeasure";
            this.ckPointVerticalMeasure.Size = new System.Drawing.Size(60, 16);
            this.ckPointVerticalMeasure.TabIndex = 1;
            this.ckPointVerticalMeasure.Text = "수직도";
            this.ckPointVerticalMeasure.UseVisualStyleBackColor = true;
            // 
            // ckPoint3DMeasure
            // 
            this.ckPoint3DMeasure.AutoSize = true;
            this.ckPoint3DMeasure.Checked = true;
            this.ckPoint3DMeasure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckPoint3DMeasure.Location = new System.Drawing.Point(42, 20);
            this.ckPoint3DMeasure.Name = "ckPoint3DMeasure";
            this.ckPoint3DMeasure.Size = new System.Drawing.Size(66, 16);
            this.ckPoint3DMeasure.TabIndex = 0;
            this.ckPoint3DMeasure.Text = "3D 계측";
            this.ckPoint3DMeasure.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteObj);
            this.groupBox2.Controls.Add(this.btnClearObj);
            this.groupBox2.Controls.Add(this.btnAddModel);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 57);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Object";
            // 
            // btnDeleteObj
            // 
            this.btnDeleteObj.Location = new System.Drawing.Point(101, 20);
            this.btnDeleteObj.Name = "btnDeleteObj";
            this.btnDeleteObj.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteObj.TabIndex = 2;
            this.btnDeleteObj.Text = "Delete";
            this.btnDeleteObj.UseVisualStyleBackColor = true;
            this.btnDeleteObj.Click += new System.EventHandler(this.btnDeleteObj_Click);
            // 
            // btnClearObj
            // 
            this.btnClearObj.Location = new System.Drawing.Point(196, 20);
            this.btnClearObj.Name = "btnClearObj";
            this.btnClearObj.Size = new System.Drawing.Size(75, 23);
            this.btnClearObj.TabIndex = 1;
            this.btnClearObj.Text = "Clear";
            this.btnClearObj.UseVisualStyleBackColor = true;
            this.btnClearObj.Click += new System.EventHandler(this.btnClearObj_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.Location = new System.Drawing.Point(6, 20);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(75, 23);
            this.btnAddModel.TabIndex = 0;
            this.btnAddModel.Text = "Model";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbViewMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // cbViewMode
            // 
            this.cbViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViewMode.FormattingEnabled = true;
            this.cbViewMode.Items.AddRange(new object[] {
            "3D",
            "3D / 2D",
            "2D"});
            this.cbViewMode.Location = new System.Drawing.Point(181, 22);
            this.cbViewMode.Name = "cbViewMode";
            this.cbViewMode.Size = new System.Drawing.Size(90, 20);
            this.cbViewMode.TabIndex = 3;
            this.cbViewMode.SelectedIndexChanged += new System.EventHandler(this.cbViewMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Mode";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAdd2DFrom3D
            // 
            this.btnAdd2DFrom3D.Location = new System.Drawing.Point(12, 584);
            this.btnAdd2DFrom3D.Name = "btnAdd2DFrom3D";
            this.btnAdd2DFrom3D.Size = new System.Drawing.Size(277, 23);
            this.btnAdd2DFrom3D.TabIndex = 21;
            this.btnAdd2DFrom3D.Text = "Add 2DMeasure From 3DMeasure";
            this.btnAdd2DFrom3D.UseVisualStyleBackColor = true;
            this.btnAdd2DFrom3D.Click += new System.EventHandler(this.btnAdd2DFrom3D_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "VIZCore3DPlus.NET.MeasurePoint";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbViewMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteObj;
        private System.Windows.Forms.Button btnClearObj;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAdd3DPoint;
        private System.Windows.Forms.ComboBox cb3DPointType;
        private System.Windows.Forms.CheckBox ckPointLevelMeasure;
        private System.Windows.Forms.CheckBox ckPointDesignMeasure;
        private System.Windows.Forms.CheckBox ckPointVerticalMeasure;
        private System.Windows.Forms.CheckBox ckPoint3DMeasure;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTranslatePointByAxis;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnHideAll;
        private System.Windows.Forms.Button btnHideSelected;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Button btnAdd2DFrom3D;
    }
}

