namespace View
{
    partial class MarksEntry_StudentWise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarksEntry_StudentWise));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MarksEntry_StudentWise_ID_ComboBx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultProcessingDataDataSet1 = new View.ResultProcessingDataDataSet1();
            this.theoryCourseTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theoryCourseTableTableAdapter = new View.ResultProcessingDataDataSet1TableAdapters.TheoryCourseTableTableAdapter();
            this.tableAdapterManager = new View.ResultProcessingDataDataSet1TableAdapters.TableAdapterManager();
            this.sessionalCourseTableTableAdapter = new View.ResultProcessingDataDataSet1TableAdapters.SessionalCourseTableTableAdapter();
            this.sessionalCourseTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MarksEntry_StudentWise_Save_Btn = new System.Windows.Forms.Button();
            this.resultProcessingDataDataSet2 = new View.ResultProcessingDataDataSet2();
            this.theoryCourseTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.theoryCourseTableTableAdapter1 = new View.ResultProcessingDataDataSet2TableAdapters.TheoryCourseTableTableAdapter();
            this.tableAdapterManager1 = new View.ResultProcessingDataDataSet2TableAdapters.TableAdapterManager();
            this.sessionalCourseTableTableAdapter1 = new View.ResultProcessingDataDataSet2TableAdapters.SessionalCourseTableTableAdapter();
            this.theoryCourseTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionalCourseTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sessionalCourseTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultProcessingDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryCourseTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionalCourseTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultProcessingDataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryCourseTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryCourseTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionalCourseTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionalCourseTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MarksEntry_StudentWise_ID_ComboBx
            // 
            this.MarksEntry_StudentWise_ID_ComboBx.FormattingEnabled = true;
            this.MarksEntry_StudentWise_ID_ComboBx.Location = new System.Drawing.Point(341, 22);
            this.MarksEntry_StudentWise_ID_ComboBx.Name = "MarksEntry_StudentWise_ID_ComboBx";
            this.MarksEntry_StudentWise_ID_ComboBx.Size = new System.Drawing.Size(250, 26);
            this.MarksEntry_StudentWise_ID_ComboBx.TabIndex = 9;
            this.MarksEntry_StudentWise_ID_ComboBx.SelectedIndexChanged += new System.EventHandler(this.MarksEntry_StudentWise_ID_ComboBx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student ID :";
            // 
            // resultProcessingDataDataSet1
            // 
            this.resultProcessingDataDataSet1.DataSetName = "ResultProcessingDataDataSet1";
            this.resultProcessingDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theoryCourseTableBindingSource
            // 
            this.theoryCourseTableBindingSource.DataMember = "TheoryCourseTable";
            this.theoryCourseTableBindingSource.DataSource = this.resultProcessingDataDataSet1;
            // 
            // theoryCourseTableTableAdapter
            // 
            this.theoryCourseTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SessionalCourseTableTableAdapter = this.sessionalCourseTableTableAdapter;
            this.tableAdapterManager.TheoryCourseTableTableAdapter = this.theoryCourseTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = View.ResultProcessingDataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sessionalCourseTableTableAdapter
            // 
            this.sessionalCourseTableTableAdapter.ClearBeforeFill = true;
            // 
            // sessionalCourseTableBindingSource
            // 
            this.sessionalCourseTableBindingSource.DataMember = "SessionalCourseTable";
            this.sessionalCourseTableBindingSource.DataSource = this.resultProcessingDataDataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Theory :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sessional :";
            // 
            // MarksEntry_StudentWise_Save_Btn
            // 
            this.MarksEntry_StudentWise_Save_Btn.Location = new System.Drawing.Point(774, 611);
            this.MarksEntry_StudentWise_Save_Btn.Name = "MarksEntry_StudentWise_Save_Btn";
            this.MarksEntry_StudentWise_Save_Btn.Size = new System.Drawing.Size(85, 27);
            this.MarksEntry_StudentWise_Save_Btn.TabIndex = 14;
            this.MarksEntry_StudentWise_Save_Btn.Text = "Save";
            this.MarksEntry_StudentWise_Save_Btn.UseVisualStyleBackColor = true;
            this.MarksEntry_StudentWise_Save_Btn.Click += new System.EventHandler(this.MarksEntry_StudentWise_Save_Btn_Click);
            // 
            // resultProcessingDataDataSet2
            // 
            this.resultProcessingDataDataSet2.DataSetName = "ResultProcessingDataDataSet2";
            this.resultProcessingDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theoryCourseTableBindingSource1
            // 
            this.theoryCourseTableBindingSource1.DataMember = "TheoryCourseTable";
            this.theoryCourseTableBindingSource1.DataSource = this.resultProcessingDataDataSet2;
            // 
            // theoryCourseTableTableAdapter1
            // 
            this.theoryCourseTableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.SessionalCourseTableTableAdapter = this.sessionalCourseTableTableAdapter1;
            this.tableAdapterManager1.TheoryCourseTableTableAdapter = this.theoryCourseTableTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = View.ResultProcessingDataDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sessionalCourseTableTableAdapter1
            // 
            this.sessionalCourseTableTableAdapter1.ClearBeforeFill = true;
            // 
            // theoryCourseTableDataGridView
            // 
            this.theoryCourseTableDataGridView.AllowUserToOrderColumns = true;
            this.theoryCourseTableDataGridView.AutoGenerateColumns = false;
            this.theoryCourseTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.theoryCourseTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.theoryCourseTableDataGridView.DataSource = this.theoryCourseTableBindingSource1;
            this.theoryCourseTableDataGridView.Location = new System.Drawing.Point(49, 103);
            this.theoryCourseTableDataGridView.Name = "theoryCourseTableDataGridView";
            this.theoryCourseTableDataGridView.Size = new System.Drawing.Size(782, 227);
            this.theoryCourseTableDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CourseTaken";
            this.dataGridViewTextBoxColumn1.HeaderText = "CourseTaken";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CT";
            this.dataGridViewTextBoxColumn2.HeaderText = "CT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Attendance";
            this.dataGridViewTextBoxColumn3.HeaderText = "Attendance";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Final";
            this.dataGridViewTextBoxColumn4.HeaderText = "Final";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn6.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // sessionalCourseTableBindingSource1
            // 
            this.sessionalCourseTableBindingSource1.DataMember = "SessionalCourseTable";
            this.sessionalCourseTableBindingSource1.DataSource = this.resultProcessingDataDataSet2;
            // 
            // sessionalCourseTableDataGridView
            // 
            this.sessionalCourseTableDataGridView.AutoGenerateColumns = false;
            this.sessionalCourseTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionalCourseTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.sessionalCourseTableDataGridView.DataSource = this.sessionalCourseTableBindingSource1;
            this.sessionalCourseTableDataGridView.Location = new System.Drawing.Point(4, 373);
            this.sessionalCourseTableDataGridView.Name = "sessionalCourseTableDataGridView";
            this.sessionalCourseTableDataGridView.Size = new System.Drawing.Size(873, 220);
            this.sessionalCourseTableDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CourseTaken";
            this.dataGridViewTextBoxColumn7.HeaderText = "CourseTaken";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LabWork";
            this.dataGridViewTextBoxColumn8.HeaderText = "LabWork";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LabTest";
            this.dataGridViewTextBoxColumn9.HeaderText = "LabTest";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Attendence";
            this.dataGridViewTextBoxColumn10.HeaderText = "Attendence";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Vaiva";
            this.dataGridViewTextBoxColumn11.HeaderText = "Vaiva";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn12.HeaderText = "Total";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn13.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // MarksEntry_StudentWise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(881, 661);
            this.Controls.Add(this.sessionalCourseTableDataGridView);
            this.Controls.Add(this.theoryCourseTableDataGridView);
            this.Controls.Add(this.MarksEntry_StudentWise_Save_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MarksEntry_StudentWise_ID_ComboBx);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MarksEntry_StudentWise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarksEntry_StudentWise";
            this.Load += new System.EventHandler(this.MarksEntry_StudentWise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultProcessingDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryCourseTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionalCourseTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultProcessingDataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryCourseTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryCourseTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionalCourseTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionalCourseTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox MarksEntry_StudentWise_ID_ComboBx;
        private System.Windows.Forms.Label label1;
        private ResultProcessingDataDataSet1 resultProcessingDataDataSet1;
        private System.Windows.Forms.BindingSource theoryCourseTableBindingSource;
        private ResultProcessingDataDataSet1TableAdapters.TheoryCourseTableTableAdapter theoryCourseTableTableAdapter;
        private ResultProcessingDataDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private ResultProcessingDataDataSet1TableAdapters.SessionalCourseTableTableAdapter sessionalCourseTableTableAdapter;
        private System.Windows.Forms.BindingSource sessionalCourseTableBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MarksEntry_StudentWise_Save_Btn;
        private ResultProcessingDataDataSet2 resultProcessingDataDataSet2;
        private System.Windows.Forms.BindingSource theoryCourseTableBindingSource1;
        private ResultProcessingDataDataSet2TableAdapters.TheoryCourseTableTableAdapter theoryCourseTableTableAdapter1;
        private ResultProcessingDataDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private ResultProcessingDataDataSet2TableAdapters.SessionalCourseTableTableAdapter sessionalCourseTableTableAdapter1;
        private System.Windows.Forms.DataGridView theoryCourseTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource sessionalCourseTableBindingSource1;
        private System.Windows.Forms.DataGridView sessionalCourseTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}