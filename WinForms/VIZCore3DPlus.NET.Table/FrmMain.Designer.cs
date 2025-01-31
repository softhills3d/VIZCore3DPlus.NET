namespace VIZCore3DPlus.NET.Table
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddVerticalPoint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.btnVertical = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInside = new System.Windows.Forms.TextBox();
            this.btnStepMeasure = new System.Windows.Forms.Button();
            this.txtAbacus = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTolerance = new System.Windows.Forms.Button();
            this.txtVerticality = new System.Windows.Forms.TextBox();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteObj = new System.Windows.Forms.Button();
            this.btnClearObj = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbViewMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddVerticalPoint);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtColumn);
            this.groupBox5.Controls.Add(this.txtRow);
            this.groupBox5.Controls.Add(this.txtCell);
            this.groupBox5.Controls.Add(this.btnVertical);
            this.groupBox5.Location = new System.Drawing.Point(12, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 184);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vertical Table";
            // 
            // btnAddVerticalPoint
            // 
            this.btnAddVerticalPoint.Location = new System.Drawing.Point(6, 29);
            this.btnAddVerticalPoint.Name = "btnAddVerticalPoint";
            this.btnAddVerticalPoint.Size = new System.Drawing.Size(265, 23);
            this.btnAddVerticalPoint.TabIndex = 7;
            this.btnAddVerticalPoint.Text = "Add Vertical Point";
            this.btnAddVerticalPoint.UseVisualStyleBackColor = true;
            this.btnAddVerticalPoint.Click += new System.EventHandler(this.btnAddVerticalPoint_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Column :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Row :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cell Num :";
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(95, 124);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(176, 21);
            this.txtColumn.TabIndex = 3;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(95, 97);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(176, 21);
            this.txtRow.TabIndex = 2;
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(95, 70);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(176, 21);
            this.txtCell.TabIndex = 1;
            // 
            // btnVertical
            // 
            this.btnVertical.Location = new System.Drawing.Point(6, 151);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(265, 23);
            this.btnVertical.TabIndex = 0;
            this.btnVertical.Text = "Vertical Table";
            this.btnVertical.UseVisualStyleBackColor = true;
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtInside);
            this.groupBox6.Controls.Add(this.btnStepMeasure);
            this.groupBox6.Controls.Add(this.txtAbacus);
            this.groupBox6.Location = new System.Drawing.Point(12, 328);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 107);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Step Measure Table";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Inside Num :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Abacus Num :";
            // 
            // txtInside
            // 
            this.txtInside.Location = new System.Drawing.Point(95, 47);
            this.txtInside.Name = "txtInside";
            this.txtInside.Size = new System.Drawing.Size(176, 21);
            this.txtInside.TabIndex = 2;
            // 
            // btnStepMeasure
            // 
            this.btnStepMeasure.Location = new System.Drawing.Point(6, 74);
            this.btnStepMeasure.Name = "btnStepMeasure";
            this.btnStepMeasure.Size = new System.Drawing.Size(265, 23);
            this.btnStepMeasure.TabIndex = 1;
            this.btnStepMeasure.Text = "Step Measure Table";
            this.btnStepMeasure.UseVisualStyleBackColor = true;
            this.btnStepMeasure.Click += new System.EventHandler(this.btnStepMeasure_Click);
            // 
            // txtAbacus
            // 
            this.txtAbacus.Location = new System.Drawing.Point(95, 20);
            this.txtAbacus.Name = "txtAbacus";
            this.txtAbacus.Size = new System.Drawing.Size(176, 21);
            this.txtAbacus.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.btnTolerance);
            this.groupBox7.Controls.Add(this.txtVerticality);
            this.groupBox7.Controls.Add(this.txtDimension);
            this.groupBox7.Controls.Add(this.txtLevel);
            this.groupBox7.Location = new System.Drawing.Point(12, 441);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(277, 137);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tolerance Table";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Verticality Num :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "Dimension Num :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "Level Num :";
            // 
            // btnTolerance
            // 
            this.btnTolerance.Location = new System.Drawing.Point(6, 101);
            this.btnTolerance.Name = "btnTolerance";
            this.btnTolerance.Size = new System.Drawing.Size(265, 23);
            this.btnTolerance.TabIndex = 2;
            this.btnTolerance.Text = "Tolerance Table";
            this.btnTolerance.UseVisualStyleBackColor = true;
            this.btnTolerance.Click += new System.EventHandler(this.btnTolerance_Click);
            // 
            // txtVerticality
            // 
            this.txtVerticality.Location = new System.Drawing.Point(124, 74);
            this.txtVerticality.Name = "txtVerticality";
            this.txtVerticality.Size = new System.Drawing.Size(147, 21);
            this.txtVerticality.TabIndex = 3;
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(124, 47);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(147, 21);
            this.txtDimension.TabIndex = 2;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(124, 20);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(147, 21);
            this.txtLevel.TabIndex = 1;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "VIZCore3DPlus.NET.Table";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
        private System.Windows.Forms.Button btnTolerance;
        private System.Windows.Forms.Button btnStepMeasure;
        private System.Windows.Forms.Button btnVertical;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInside;
        private System.Windows.Forms.TextBox txtAbacus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVerticality;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Button btnAddVerticalPoint;
    }
}

