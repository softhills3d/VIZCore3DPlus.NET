namespace VIZCore3DPlus.NET.MeasurePointBase
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
            this.btnBaseCancle = new System.Windows.Forms.Button();
            this.btnBaseSelectSetting = new System.Windows.Forms.Button();
            this.btnBaseInputSetting = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd2DPoint = new System.Windows.Forms.Button();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCreateCP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnBaseCancle);
            this.groupBox7.Controls.Add(this.btnBaseSelectSetting);
            this.groupBox7.Controls.Add(this.btnBaseInputSetting);
            this.groupBox7.Location = new System.Drawing.Point(12, 312);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(277, 127);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Base Point";
            // 
            // btnBaseCancle
            // 
            this.btnBaseCancle.Location = new System.Drawing.Point(6, 88);
            this.btnBaseCancle.Name = "btnBaseCancle";
            this.btnBaseCancle.Size = new System.Drawing.Size(265, 23);
            this.btnBaseCancle.TabIndex = 2;
            this.btnBaseCancle.Text = "Point Base Cancel";
            this.btnBaseCancle.UseVisualStyleBackColor = true;
            this.btnBaseCancle.Click += new System.EventHandler(this.btnBaseCancle_Click);
            // 
            // btnBaseSelectSetting
            // 
            this.btnBaseSelectSetting.Location = new System.Drawing.Point(6, 59);
            this.btnBaseSelectSetting.Name = "btnBaseSelectSetting";
            this.btnBaseSelectSetting.Size = new System.Drawing.Size(265, 23);
            this.btnBaseSelectSetting.TabIndex = 1;
            this.btnBaseSelectSetting.Text = "Point Base Select Setting";
            this.btnBaseSelectSetting.UseVisualStyleBackColor = true;
            this.btnBaseSelectSetting.Click += new System.EventHandler(this.btnBaseSelectSetting_Click);
            // 
            // btnBaseInputSetting
            // 
            this.btnBaseInputSetting.Location = new System.Drawing.Point(6, 30);
            this.btnBaseInputSetting.Name = "btnBaseInputSetting";
            this.btnBaseInputSetting.Size = new System.Drawing.Size(265, 23);
            this.btnBaseInputSetting.TabIndex = 0;
            this.btnBaseInputSetting.Text = "Point Base Input Setting";
            this.btnBaseInputSetting.UseVisualStyleBackColor = true;
            this.btnBaseInputSetting.Click += new System.EventHandler(this.btnBaseInputSetting_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd2DPoint);
            this.groupBox3.Location = new System.Drawing.Point(12, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 63);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2D Point";
            // 
            // btnAdd2DPoint
            // 
            this.btnAdd2DPoint.Location = new System.Drawing.Point(74, 22);
            this.btnAdd2DPoint.Name = "btnAdd2DPoint";
            this.btnAdd2DPoint.Size = new System.Drawing.Size(123, 23);
            this.btnAdd2DPoint.TabIndex = 5;
            this.btnAdd2DPoint.Text = "Add 2D Point";
            this.btnAdd2DPoint.UseVisualStyleBackColor = true;
            this.btnAdd2DPoint.Click += new System.EventHandler(this.btnAdd2DPoint_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ckPointLevelMeasure);
            this.groupBox5.Controls.Add(this.ckPointDesignMeasure);
            this.groupBox5.Controls.Add(this.ckPointVerticalMeasure);
            this.groupBox5.Controls.Add(this.ckPoint3DMeasure);
            this.groupBox5.Location = new System.Drawing.Point(12, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 99);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Point Option";
            // 
            // ckPointLevelMeasure
            // 
            this.ckPointLevelMeasure.AutoSize = true;
            this.ckPointLevelMeasure.Location = new System.Drawing.Point(152, 63);
            this.ckPointLevelMeasure.Name = "ckPointLevelMeasure";
            this.ckPointLevelMeasure.Size = new System.Drawing.Size(76, 16);
            this.ckPointLevelMeasure.TabIndex = 3;
            this.ckPointLevelMeasure.Text = "레벨 계측";
            this.ckPointLevelMeasure.UseVisualStyleBackColor = true;
            // 
            // ckPointDesignMeasure
            // 
            this.ckPointDesignMeasure.AutoSize = true;
            this.ckPointDesignMeasure.Location = new System.Drawing.Point(152, 31);
            this.ckPointDesignMeasure.Name = "ckPointDesignMeasure";
            this.ckPointDesignMeasure.Size = new System.Drawing.Size(76, 16);
            this.ckPointDesignMeasure.TabIndex = 2;
            this.ckPointDesignMeasure.Text = "의장 계측";
            this.ckPointDesignMeasure.UseVisualStyleBackColor = true;
            // 
            // ckPointVerticalMeasure
            // 
            this.ckPointVerticalMeasure.AutoSize = true;
            this.ckPointVerticalMeasure.Location = new System.Drawing.Point(35, 63);
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
            this.ckPoint3DMeasure.Location = new System.Drawing.Point(35, 31);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Controls.Add(this.cbCreateCP);
            this.groupBox4.Location = new System.Drawing.Point(12, 445);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 56);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CP";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 22);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCreateCP
            // 
            this.cbCreateCP.FormattingEnabled = true;
            this.cbCreateCP.Location = new System.Drawing.Point(11, 20);
            this.cbCreateCP.Name = "cbCreateCP";
            this.cbCreateCP.Size = new System.Drawing.Size(178, 20);
            this.cbCreateCP.TabIndex = 0;
            this.cbCreateCP.Text = "CP0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "VIZCore3DPlus.NET.MeasurePointBase";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnBaseCancle;
        private System.Windows.Forms.Button btnBaseSelectSetting;
        private System.Windows.Forms.Button btnBaseInputSetting;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd2DPoint;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ckPointLevelMeasure;
        private System.Windows.Forms.CheckBox ckPointDesignMeasure;
        private System.Windows.Forms.CheckBox ckPointVerticalMeasure;
        private System.Windows.Forms.CheckBox ckPoint3DMeasure;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCreateCP;
    }
}

