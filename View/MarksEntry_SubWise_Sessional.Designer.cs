namespace View
{
    partial class MarksEntry_SubWise_Sessional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarksEntry_SubWise_Sessional));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MarksEntry_Sub_Sessional_Save_Btn = new System.Windows.Forms.Button();
            this.MarksEntry_Sub_Sessional_CourseName_ComboBx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultProcessingDataDataSet1 = new View.ResultProcessingDataDataSet1();
            this.sessionalCourseTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionalCourseTableTableAdapter = new View.ResultProcessingDataDataSet1TableAdapters.SessionalCourseTableTableAdapter();
            this.tableAdapterManager = new View.ResultProcessingDataDataSet1TableAdapters.TableAdapterManager();
            this.sessionalCourseTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultProcessingDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionalCourseTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionalCourseTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MarksEntry_Sub_Sessional_Save_Btn
            // 
            this.MarksEntry_Sub_Sessional_Save_Btn.Location = new System.Drawing.Point(639, 451);
            this.MarksEntry_Sub_Sessional_Save_Btn.Name = "MarksEntry_Sub_Sessional_Save_Btn";
            this.MarksEntry_Sub_Sessional_Save_Btn.Size = new System.Drawing.Size(75, 29);
            this.MarksEntry_Sub_Sessional_Save_Btn.TabIndex = 8;
            this.MarksEntry_Sub_Sessional_Save_Btn.Text = "Save";
            this.MarksEntry_Sub_Sessional_Save_Btn.UseVisualStyleBackColor = true;
            this.MarksEntry_Sub_Sessional_Save_Btn.Click += new System.EventHandler(this.MarksEntry_Sub_Sessional_Save_Btn_Click);
            // 
            // MarksEntry_Sub_Sessional_CourseName_ComboBx
            // 
            this.MarksEntry_Sub_Sessional_CourseName_ComboBx.FormattingEnabled = true;
            this.MarksEntry_Sub_Sessional_CourseName_ComboBx.Location = new System.Drawing.Point(253, 22);
            this.MarksEntry_Sub_Sessional_CourseName_ComboBx.Name = "MarksEntry_Sub_Sessional_CourseName_ComboBx";
            this.MarksEntry_Sub_Sessional_CourseName_ComboBx.Size = new System.Drawing.Size(304, 26);
            this.MarksEntry_Sub_Sessional_CourseName_ComboBx.TabIndex = 9;
            this.MarksEntry_Sub_Sessional_CourseName_ComboBx.SelectedIndexChanged += new System.EventHandler(this.MarksEntry_Sub_Sessional_CourseName_ComboBx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Course Name :";
            // 
            // resultProcessingDataDataSet1
            // 
            this.resultProcessingDataDataSet1.DataSetName = "ResultProcessingDataDataSet1";
            this.resultProcessingDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionalCourseTableBindingSource
            // 
            this.sessionalCourseTableBindingSource.DataMember = "SessionalCourseTable";
            this.sessionalCourseTableBindingSource.DataSource = this.resultProcessingDataDataSet1;
            // 
            // sessionalCourseTableTableAdapter
            // 
            this.sessionalCourseTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SessionalCourseTableTableAdapter = this.sessionalCourseTableTableAdapter;
            this.tableAdapterManager.TheoryCourseTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = View.ResultProcessingDataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sessionalCourseTableDataGridView
            // 
            this.sessionalCourseTableDataGridView.AutoGenerateColumns = false;
            this.sessionalCourseTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionalCourseTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.sessionalCourseTableDataGridView.DataSource = this.sessionalCourseTableBindingSource;
            this.sessionalCourseTableDataGridView.Location = new System.Drawing.Point(2, 75);
            this.sessionalCourseTableDataGridView.Name = "sessionalCourseTableDataGridView";
            this.sessionalCourseTableDataGridView.Size = new System.Drawing.Size(741, 370);
            this.sessionalCourseTableDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Roll";
            this.dataGridViewTextBoxColumn1.HeaderText = "Roll";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LabWork";
            this.dataGridViewTextBoxColumn2.HeaderText = "LabWork";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LabTest";
            this.dataGridViewTextBoxColumn3.HeaderText = "LabTest";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Attendence";
            this.dataGridViewTextBoxColumn4.HeaderText = "Attendence";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Vaiva";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vaiva";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // MarksEntry_SubWise_Sessional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(745, 492);
            this.Controls.Add(this.sessionalCourseTableDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MarksEntry_Sub_Sessional_CourseName_ComboBx);
            this.Controls.Add(this.MarksEntry_Sub_Sessional_Save_Btn);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MarksEntry_SubWise_Sessional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarksEntry_SubWise_Sessional";
            this.Load += new System.EventHandler(this.MarksEntry_SubWise_Sessional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultProcessingDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionalCourseTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionalCourseTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MarksEntry_Sub_Sessional_Save_Btn;
        private System.Windows.Forms.ComboBox MarksEntry_Sub_Sessional_CourseName_ComboBx;
        private System.Windows.Forms.Label label1;
        private ResultProcessingDataDataSet1 resultProcessingDataDataSet1;
        private System.Windows.Forms.BindingSource sessionalCourseTableBindingSource;
        private ResultProcessingDataDataSet1TableAdapters.SessionalCourseTableTableAdapter sessionalCourseTableTableAdapter;
        private ResultProcessingDataDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sessionalCourseTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

    }
}