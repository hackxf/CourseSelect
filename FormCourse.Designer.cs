namespace CourseSelect
{
    partial class FormCourse
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxCredit = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.TextBoxIdD = new System.Windows.Forms.TextBox();
            this.labelidD = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonBrow = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxIdQ = new System.Windows.Forms.TextBox();
            this.labelIdQ = new System.Windows.Forms.Label();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonOk);
            this.groupBox1.Controls.Add(this.textBoxCredit);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.labelCredit);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(223, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程信息添加";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(117, 134);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(72, 28);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "取消";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(20, 135);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(67, 28);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.Location = new System.Drawing.Point(89, 100);
            this.textBoxCredit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.Size = new System.Drawing.Size(97, 25);
            this.textBoxCredit.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(88, 65);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(101, 25);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(88, 30);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(101, 25);
            this.textBoxId.TabIndex = 4;
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Location = new System.Drawing.Point(17, 92);
            this.labelCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(37, 15);
            this.labelCredit.TabIndex = 3;
            this.labelCredit.Text = "学分";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 60);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 15);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "课程名";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(17, 32);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(52, 15);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "课程号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 535);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.TextBoxIdD);
            this.groupBox2.Controls.Add(this.labelidD);
            this.groupBox2.Location = new System.Drawing.Point(21, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(216, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "课程删除";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(41, 95);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(111, 25);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // TextBoxIdD
            // 
            this.TextBoxIdD.Location = new System.Drawing.Point(97, 34);
            this.TextBoxIdD.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxIdD.Name = "TextBoxIdD";
            this.TextBoxIdD.Size = new System.Drawing.Size(85, 25);
            this.TextBoxIdD.TabIndex = 1;
            // 
            // labelidD
            // 
            this.labelidD.AutoSize = true;
            this.labelidD.Location = new System.Drawing.Point(8, 36);
            this.labelidD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelidD.Name = "labelidD";
            this.labelidD.Size = new System.Drawing.Size(52, 15);
            this.labelidD.TabIndex = 0;
            this.labelidD.Text = "课程号";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.buttonBrow);
            this.groupBox3.Controls.Add(this.buttonQuery);
            this.groupBox3.Controls.Add(this.textBoxIdQ);
            this.groupBox3.Controls.Add(this.labelIdQ);
            this.groupBox3.Location = new System.Drawing.Point(27, 378);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(209, 172);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "课程查询";
            // 
            // buttonBrow
            // 
            this.buttonBrow.Location = new System.Drawing.Point(113, 120);
            this.buttonBrow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrow.Name = "buttonBrow";
            this.buttonBrow.Size = new System.Drawing.Size(88, 30);
            this.buttonBrow.TabIndex = 3;
            this.buttonBrow.Text = "显示全部";
            this.buttonBrow.UseVisualStyleBackColor = true;
            this.buttonBrow.Click += new System.EventHandler(this.buttonBrow_Click);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(23, 120);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 31);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxIdQ
            // 
            this.textBoxIdQ.Location = new System.Drawing.Point(100, 52);
            this.textBoxIdQ.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdQ.Name = "textBoxIdQ";
            this.textBoxIdQ.Size = new System.Drawing.Size(77, 25);
            this.textBoxIdQ.TabIndex = 1;
            // 
            // labelIdQ
            // 
            this.labelIdQ.AutoSize = true;
            this.labelIdQ.Location = new System.Drawing.Point(19, 56);
            this.labelIdQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdQ.Name = "labelIdQ";
            this.labelIdQ.Size = new System.Drawing.Size(52, 15);
            this.labelIdQ.TabIndex = 0;
            this.labelIdQ.Text = "课程号";
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewCourse.Location = new System.Drawing.Point(279, 16);
            this.dataGridViewCourse.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.RowTemplate.Height = 23;
            this.dataGridViewCourse.Size = new System.Drawing.Size(559, 548);
            this.dataGridViewCourse.TabIndex = 3;
            this.dataGridViewCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourse_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "courseId";
            this.Column1.HeaderText = "课程号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "courseName";
            this.Column2.HeaderText = "课程名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "courseCredit";
            this.Column3.HeaderText = "学分";
            this.Column3.Name = "Column3";
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 567);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCourse";
            this.Text = "课程管理";
            this.Load += new System.EventHandler(this.FormCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxCredit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox TextBoxIdD;
        private System.Windows.Forms.Label labelidD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonBrow;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textBoxIdQ;
        private System.Windows.Forms.Label labelIdQ;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

