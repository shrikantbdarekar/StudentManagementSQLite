namespace StudentManagementSQLite
{
    partial class FormStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxAge = new TextBox();
            label1 = new Label();
            textBoxName = new TextBox();
            labelLoginId = new Label();
            buttonAdd = new Button();
            textBoxCourse = new TextBox();
            label3 = new Label();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dataGridViewStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(160, 78);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(228, 31);
            textBoxAge.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 78);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 10;
            label1.Text = "Age";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(160, 31);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(228, 31);
            textBoxName.TabIndex = 9;
            // 
            // labelLoginId
            // 
            labelLoginId.AutoSize = true;
            labelLoginId.Location = new Point(62, 31);
            labelLoginId.Name = "labelLoginId";
            labelLoginId.Size = new Size(59, 25);
            labelLoginId.TabIndex = 8;
            labelLoginId.Text = "Name";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(457, 22);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 42);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxCourse
            // 
            textBoxCourse.Location = new Point(160, 128);
            textBoxCourse.Name = "textBoxCourse";
            textBoxCourse.Size = new Size(228, 31);
            textBoxCourse.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 128);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 14;
            label3.Text = "Course";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(457, 72);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(112, 42);
            buttonUpdate.TabIndex = 16;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(457, 122);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 42);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStudents.BackgroundColor = Color.Gainsboro;
            dataGridViewStudents.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(12, 180);
            dataGridViewStudents.MultiSelect = false;
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.RowHeadersWidth = 62;
            dataGridViewStudents.Size = new Size(619, 430);
            dataGridViewStudents.TabIndex = 18;
            dataGridViewStudents.CellContentClick += dataGridViewStudents_CellContentClick;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(643, 622);
            Controls.Add(dataGridViewStudents);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxCourse);
            Controls.Add(label3);
            Controls.Add(textBoxAge);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(labelLoginId);
            Controls.Add(buttonAdd);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            Load += FormStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAge;
        private Label label1;
        private TextBox textBoxName;
        private Label labelLoginId;
        private Button buttonAdd;
        private TextBox textBoxCourse;
        private Label label3;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dataGridViewStudents;
    }
}