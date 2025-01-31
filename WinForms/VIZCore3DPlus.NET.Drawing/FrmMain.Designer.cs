namespace VIZCore3DPlus.NET.Drawing
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnHideSelected = new System.Windows.Forms.Button();
            this.btnShowSelected = new System.Windows.Forms.Button();
            this.btnHideAll = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteObjectWithSelectObject = new System.Windows.Forms.Button();
            this.btnDeleteAllNonObject = new System.Windows.Forms.Button();
            this.btnDeleteAllObject = new System.Windows.Forms.Button();
            this.btnDeleteSelectedObject = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDrawingType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteObj = new System.Windows.Forms.Button();
            this.btnClearObj = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbViewMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnLineTypeSelected = new System.Windows.Forms.Button();
            this.btnTextSizeSelected = new System.Windows.Forms.Button();
            this.btnLineWidthSelsted = new System.Windows.Forms.Button();
            this.btnColorSelected = new System.Windows.Forms.Button();
            this.btnTextBoxLineWidthSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnUnselectAll);
            this.groupBox6.Controls.Add(this.btnSelectAll);
            this.groupBox6.Location = new System.Drawing.Point(12, 395);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 57);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Select / Unselect";
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Location = new System.Drawing.Point(145, 20);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(126, 23);
            this.btnUnselectAll.TabIndex = 3;
            this.btnUnselectAll.Text = "Unselect All";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(6, 20);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(126, 23);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnHideSelected);
            this.groupBox5.Controls.Add(this.btnShowSelected);
            this.groupBox5.Controls.Add(this.btnHideAll);
            this.groupBox5.Controls.Add(this.btnShowAll);
            this.groupBox5.Location = new System.Drawing.Point(12, 458);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 81);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Show / Hide";
            // 
            // btnHideSelected
            // 
            this.btnHideSelected.Location = new System.Drawing.Point(145, 49);
            this.btnHideSelected.Name = "btnHideSelected";
            this.btnHideSelected.Size = new System.Drawing.Size(126, 23);
            this.btnHideSelected.TabIndex = 5;
            this.btnHideSelected.Text = "Hide Selected";
            this.btnHideSelected.UseVisualStyleBackColor = true;
            this.btnHideSelected.Click += new System.EventHandler(this.btnHideSelected_Click);
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.Location = new System.Drawing.Point(6, 49);
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.Size = new System.Drawing.Size(126, 23);
            this.btnShowSelected.TabIndex = 4;
            this.btnShowSelected.Text = "Show Selected";
            this.btnShowSelected.UseVisualStyleBackColor = true;
            this.btnShowSelected.Click += new System.EventHandler(this.btnShowSelected_Click);
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
            this.groupBox4.Controls.Add(this.btnDeleteObjectWithSelectObject);
            this.groupBox4.Controls.Add(this.btnDeleteAllNonObject);
            this.groupBox4.Controls.Add(this.btnDeleteAllObject);
            this.groupBox4.Controls.Add(this.btnDeleteSelectedObject);
            this.groupBox4.Location = new System.Drawing.Point(12, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 146);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete";
            // 
            // btnDeleteObjectWithSelectObject
            // 
            this.btnDeleteObjectWithSelectObject.Location = new System.Drawing.Point(6, 107);
            this.btnDeleteObjectWithSelectObject.Name = "btnDeleteObjectWithSelectObject";
            this.btnDeleteObjectWithSelectObject.Size = new System.Drawing.Size(265, 23);
            this.btnDeleteObjectWithSelectObject.TabIndex = 3;
            this.btnDeleteObjectWithSelectObject.Text = "Delete Object With Select Object";
            this.btnDeleteObjectWithSelectObject.UseVisualStyleBackColor = true;
            this.btnDeleteObjectWithSelectObject.Click += new System.EventHandler(this.btnDeleteObjectWithSelectObject_Click);
            // 
            // btnDeleteAllNonObject
            // 
            this.btnDeleteAllNonObject.Location = new System.Drawing.Point(6, 49);
            this.btnDeleteAllNonObject.Name = "btnDeleteAllNonObject";
            this.btnDeleteAllNonObject.Size = new System.Drawing.Size(265, 23);
            this.btnDeleteAllNonObject.TabIndex = 2;
            this.btnDeleteAllNonObject.Text = "Delete All Non Object";
            this.btnDeleteAllNonObject.UseVisualStyleBackColor = true;
            this.btnDeleteAllNonObject.Click += new System.EventHandler(this.btnDeleteAllNonObject_Click);
            // 
            // btnDeleteAllObject
            // 
            this.btnDeleteAllObject.Location = new System.Drawing.Point(6, 20);
            this.btnDeleteAllObject.Name = "btnDeleteAllObject";
            this.btnDeleteAllObject.Size = new System.Drawing.Size(265, 23);
            this.btnDeleteAllObject.TabIndex = 1;
            this.btnDeleteAllObject.Text = "Delete All Object";
            this.btnDeleteAllObject.UseVisualStyleBackColor = true;
            this.btnDeleteAllObject.Click += new System.EventHandler(this.btnDeleteAllObject_Click);
            // 
            // btnDeleteSelectedObject
            // 
            this.btnDeleteSelectedObject.Location = new System.Drawing.Point(6, 78);
            this.btnDeleteSelectedObject.Name = "btnDeleteSelectedObject";
            this.btnDeleteSelectedObject.Size = new System.Drawing.Size(265, 23);
            this.btnDeleteSelectedObject.TabIndex = 0;
            this.btnDeleteSelectedObject.Text = "Delete Selected Object";
            this.btnDeleteSelectedObject.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedObject.Click += new System.EventHandler(this.btnDeleteSelectedObject_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbDrawingType);
            this.groupBox3.Location = new System.Drawing.Point(12, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 99);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drawing";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 61);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(265, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type :";
            // 
            // cbDrawingType
            // 
            this.cbDrawingType.FormattingEnabled = true;
            this.cbDrawingType.Location = new System.Drawing.Point(65, 26);
            this.cbDrawingType.Name = "cbDrawingType";
            this.cbDrawingType.Size = new System.Drawing.Size(192, 20);
            this.cbDrawingType.TabIndex = 0;
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnTextBoxLineWidthSelected);
            this.groupBox7.Controls.Add(this.btnLineTypeSelected);
            this.groupBox7.Controls.Add(this.btnTextSizeSelected);
            this.groupBox7.Controls.Add(this.btnLineWidthSelsted);
            this.groupBox7.Controls.Add(this.btnColorSelected);
            this.groupBox7.Location = new System.Drawing.Point(12, 545);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(277, 114);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Style";
            // 
            // btnLineTypeSelected
            // 
            this.btnLineTypeSelected.Location = new System.Drawing.Point(145, 49);
            this.btnLineTypeSelected.Name = "btnLineTypeSelected";
            this.btnLineTypeSelected.Size = new System.Drawing.Size(126, 23);
            this.btnLineTypeSelected.TabIndex = 5;
            this.btnLineTypeSelected.Text = "Line Type Selected";
            this.btnLineTypeSelected.UseVisualStyleBackColor = true;
            this.btnLineTypeSelected.Click += new System.EventHandler(this.btnLineTypeSelected_Click);
            // 
            // btnTextSizeSelected
            // 
            this.btnTextSizeSelected.Location = new System.Drawing.Point(6, 49);
            this.btnTextSizeSelected.Name = "btnTextSizeSelected";
            this.btnTextSizeSelected.Size = new System.Drawing.Size(126, 23);
            this.btnTextSizeSelected.TabIndex = 4;
            this.btnTextSizeSelected.Text = "Text Size Selected";
            this.btnTextSizeSelected.UseVisualStyleBackColor = true;
            this.btnTextSizeSelected.Click += new System.EventHandler(this.btnTextSizeSelected_Click);
            // 
            // btnLineWidthSelsted
            // 
            this.btnLineWidthSelsted.Location = new System.Drawing.Point(145, 20);
            this.btnLineWidthSelsted.Name = "btnLineWidthSelsted";
            this.btnLineWidthSelsted.Size = new System.Drawing.Size(126, 23);
            this.btnLineWidthSelsted.TabIndex = 3;
            this.btnLineWidthSelsted.Text = "Line Width Selsted";
            this.btnLineWidthSelsted.UseVisualStyleBackColor = true;
            this.btnLineWidthSelsted.Click += new System.EventHandler(this.btnLineWidthSelsted_Click);
            // 
            // btnColorSelected
            // 
            this.btnColorSelected.Location = new System.Drawing.Point(6, 20);
            this.btnColorSelected.Name = "btnColorSelected";
            this.btnColorSelected.Size = new System.Drawing.Size(126, 23);
            this.btnColorSelected.TabIndex = 1;
            this.btnColorSelected.Text = "Color Selected";
            this.btnColorSelected.UseVisualStyleBackColor = true;
            this.btnColorSelected.Click += new System.EventHandler(this.btnColorSelected_Click);
            // 
            // btnTextBoxLineWidthSelected
            // 
            this.btnTextBoxLineWidthSelected.Location = new System.Drawing.Point(6, 78);
            this.btnTextBoxLineWidthSelected.Name = "btnTextBoxLineWidthSelected";
            this.btnTextBoxLineWidthSelected.Size = new System.Drawing.Size(265, 23);
            this.btnTextBoxLineWidthSelected.TabIndex = 6;
            this.btnTextBoxLineWidthSelected.Text = "TextBox Line Width Selected";
            this.btnTextBoxLineWidthSelected.UseVisualStyleBackColor = true;
            this.btnTextBoxLineWidthSelected.Click += new System.EventHandler(this.btnTextBoxLineWidthSelected_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "VIZCore3DPlus.NET.Drawing";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDrawingType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnHideAll;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteObjectWithSelectObject;
        private System.Windows.Forms.Button btnDeleteAllNonObject;
        private System.Windows.Forms.Button btnDeleteAllObject;
        private System.Windows.Forms.Button btnDeleteSelectedObject;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnHideSelected;
        private System.Windows.Forms.Button btnShowSelected;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnLineTypeSelected;
        private System.Windows.Forms.Button btnTextSizeSelected;
        private System.Windows.Forms.Button btnLineWidthSelsted;
        private System.Windows.Forms.Button btnColorSelected;
        private System.Windows.Forms.Button btnTextBoxLineWidthSelected;
    }
}

