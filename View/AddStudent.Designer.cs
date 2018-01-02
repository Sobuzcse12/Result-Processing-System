namespace View
{
    partial class AddStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddStudent_Term_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddStudent_BatchName_ComboBox = new System.Windows.Forms.ComboBox();
            this.resultProcessingDataDataSet = new View.ResultProcessingDataDataSet();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableTableAdapter = new View.ResultProcessingDataDataSetTableAdapters.StudentTableTableAdapter();
            this.tableAdapterManager = new View.ResultProcessingDataDataSetTableAdapters.TableAdapterManager();
            this.studentTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddStudent_DeleteStudent_Btn = new System.Windows.Forms.Button();
            this.AddStudent_AddNewStudent_Btn = new System.Windows.Forms.Button();
            this.AddStudent_Save_Btn = new System.Windows.Forms.Button();
            this.AddStudent_Exit_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultProcessingDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Khulna University";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // AddStudent_Term_ComboBox
            // 
            this.AddStudent_Term_ComboBox.FormattingEnabled = true;
            this.AddStudent_Term_ComboBox.Items.AddRange(new object[] {
            "1st",
            "2nd"});
            this.AddStudent_Term_ComboBox.Location = new System.Drawing.Point(388, 69);
            this.AddStudent_Term_ComboBox.Name = "AddStudent_Term_ComboBox";
            this.AddStudent_Term_ComboBox.Size = new System.Drawing.Size(140, 26);
            this.AddStudent_Term_ComboBox.TabIndex = 26;
            this.AddStudent_Term_ComboBox.SelectedIndexChanged += new System.EventHandler(this.AddStudent_Term_ComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Batch :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Term :";
            // 
            // AddStudent_BatchName_ComboBox
            // 
            this.AddStudent_BatchName_ComboBox.FormattingEnabled = true;
            this.AddStudent_BatchName_ComboBox.Location = new System.Drawing.Point(160, 69);
            this.AddStudent_BatchName_ComboBox.Name = "AddStudent_BatchName_ComboBox";
            this.AddStudent_BatchName_ComboBox.Size = new System.Drawing.Size(140, 26);
            this.AddStudent_BatchName_ComboBox.TabIndex = 29;
            this.AddStudent_BatchName_ComboBox.SelectedIndexChanged += new System.EventHandler(this.AddStudent_BatchName_ComboBox_SelectedIndexChanged);
            // 
            // resultProcessingDataDataSet
            // 
            this.resultProcessingDataDataSet.DataSetName = "ResultProcessingDataDataSet";
            this.resultProcessingDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "StudentTable";
            this.studentTableBindingSource.DataSource = this.resultProcessingDataDataSet;
            // 
            // studentTableTableAdapter
            // 
            this.studentTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentTableTableAdapter = this.studentTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = View.ResultProcessingDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentTableDataGridView
            // 
            this.studentTableDataGridView.AutoGenerateColumns = false;
            this.studentTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.studentTableDataGridView.DataSource = this.studentTableBindingSource;
            this.studentTableDataGridView.Location = new System.Drawing.Point(12, 131);
            this.studentTableDataGridView.Name = "studentTableDataGridView";
            this.studentTableDataGridView.Size = new System.Drawing.Size(660, 320);
            this.studentTableDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Roll";
            this.dataGridViewTextBoxColumn1.FillWeight = 73.85786F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Roll";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentName";
            this.dataGridViewTextBoxColumn2.FillWeight = 152.2843F;
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Credit";
            this.dataGridViewTextBoxColumn3.FillWeight = 73.85786F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Credit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // AddStudent_DeleteStudent_Btn
            // 
            this.AddStudent_DeleteStudent_Btn.Location = new System.Drawing.Point(338, 468);
            this.AddStudent_DeleteStudent_Btn.Name = "AddStudent_DeleteStudent_Btn";
            this.AddStudent_DeleteStudent_Btn.Size = new System.Drawing.Size(116, 31);
            this.AddStudent_DeleteStudent_Btn.TabIndex = 31;
            this.AddStudent_DeleteStudent_Btn.Text = "Delete Student";
            this.AddStudent_DeleteStudent_Btn.UseVisualStyleBackColor = true;
            this.AddStudent_DeleteStudent_Btn.Click += new System.EventHandler(this.AddStudent_DeleteStudent_Btn_Click);
            // 
            // AddStudent_AddNewStudent_Btn
            // 
            this.AddStudent_AddNewStudent_Btn.Location = new System.Drawing.Point(171, 468);
            this.AddStudent_AddNewStudent_Btn.Name = "AddStudent_AddNewStudent_Btn";
            this.AddStudent_AddNewStudent_Btn.Size = new System.Drawing.Size(129, 31);
            this.AddStudent_AddNewStudent_Btn.TabIndex = 32;
            this.AddStudent_AddNewStudent_Btn.Text = "Add New Student";
            this.AddStudent_AddNewStudent_Btn.UseVisualStyleBackColor = true;
            this.AddStudent_AddNewStudent_Btn.Click += new System.EventHandler(this.AddStudent_AddNewStudent_Btn_Click);
            // 
            // AddStudent_Save_Btn
            // 
            this.AddStudent_Save_Btn.Location = new System.Drawing.Point(492, 468);
            this.AddStudent_Save_Btn.Name = "AddStudent_Save_Btn";
            this.AddStudent_Save_Btn.Size = new System.Drawing.Size(75, 31);
            this.AddStudent_Save_Btn.TabIndex = 33;
            this.AddStudent_Save_Btn.Text = "Save";
            this.AddStudent_Save_Btn.UseVisualStyleBackColor = true;
            this.AddStudent_Save_Btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddStudent_Exit_Btn
            // 
            this.AddStudent_Exit_Btn.Location = new System.Drawing.Point(597, 468);
            this.AddStudent_Exit_Btn.Name = "AddStudent_Exit_Btn";
            this.AddStudent_Exit_Btn.Size = new System.Drawing.Size(75, 31);
            this.AddStudent_Exit_Btn.TabIndex = 34;
            this.AddStudent_Exit_Btn.Text = "Exit";
            this.AddStudent_Exit_Btn.UseVisualStyleBackColor = true;
            this.AddStudent_Exit_Btn.Click += new System.EventHandler(this.AddStudent_Exit_Btn_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.AddStudent_Exit_Btn);
            this.Controls.Add(this.AddStudent_Save_Btn);
            this.Controls.Add(this.AddStudent_AddNewStudent_Btn);
            this.Controls.Add(this.AddStudent_DeleteStudent_Btn);
            this.Controls.Add(this.studentTableDataGridView);
            this.Controls.Add(this.AddStudent_BatchName_ComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddStudent_Term_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultProcessingDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox AddStudent_Term_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AddStudent_BatchName_ComboBox;
        private ResultProcessingDataDataSet resultProcessingDataDataSet;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private ResultProcessingDataDataSetTableAdapters.StudentTableTableAdapter studentTableTableAdapter;
        private ResultProcessingDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView studentTableDataGridView;
        private System.Windows.Forms.Button AddStudent_DeleteStudent_Btn;
        private System.Windows.Forms.Button AddStudent_AddNewStudent_Btn;
        private System.Windows.Forms.Button AddStudent_Save_Btn;
        private System.Windows.Forms.Button AddStudent_Exit_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}