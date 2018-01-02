namespace View
{
    partial class MarksEntry_SubWise_Theory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarksEntry_SubWise_Theory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MarksEntry_Sub_Theory_CourseName_ComboBx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultProcessingDataDataSet1 = new View.ResultProcessingDataDataSet1();
            this.theoryCourseTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theoryCourseTableTableAdapter = new View.ResultProcessingDataDataSet1TableAdapters.TheoryCourseTableTableAdapter();
            this.tableAdapterManager = new View.ResultProcessingDataDataSet1TableAdapters.TableAdapterManager();
            this.theoryCourseTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarksEntry_Sub_Theory_Save_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultProcessingDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryCourseTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryCourseTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MarksEntry_Sub_Theory_CourseName_ComboBx
            // 
            this.MarksEntry_Sub_Theory_CourseName_ComboBx.FormattingEnabled = true;
            this.MarksEntry_Sub_Theory_CourseName_ComboBx.Location = new System.Drawing.Point(279, 21);
            this.MarksEntry_Sub_Theory_CourseName_ComboBx.Name = "MarksEntry_Sub_Theory_CourseName_ComboBx";
            this.MarksEntry_Sub_Theory_CourseName_ComboBx.Size = new System.Drawing.Size(270, 26);
            this.MarksEntry_Sub_Theory_CourseName_ComboBx.TabIndex = 7;
            this.MarksEntry_Sub_Theory_CourseName_ComboBx.SelectedIndexChanged += new System.EventHandler(this.MarksEntry_Sub_Theory_CourseName_ComboBx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Course Name :";
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
            this.tableAdapterManager.SessionalCourseTableTableAdapter = null;
            this.tableAdapterManager.TheoryCourseTableTableAdapter = this.theoryCourseTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = View.ResultProcessingDataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // theoryCourseTableDataGridView
            // 
            this.theoryCourseTableDataGridView.AutoGenerateColumns = false;
            this.theoryCourseTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.theoryCourseTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.theoryCourseTableDataGridView.DataSource = this.theoryCourseTableBindingSource;
            this.theoryCourseTableDataGridView.Location = new System.Drawing.Point(22, 78);
            this.theoryCourseTableDataGridView.Name = "theoryCourseTableDataGridView";
            this.theoryCourseTableDataGridView.Size = new System.Drawing.Size(643, 346);
            this.theoryCourseTableDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Roll";
            this.dataGridViewTextBoxColumn1.HeaderText = "Roll";
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
            // MarksEntry_Sub_Theory_Save_Btn
            // 
            this.MarksEntry_Sub_Theory_Save_Btn.Location = new System.Drawing.Point(590, 433);
            this.MarksEntry_Sub_Theory_Save_Btn.Name = "MarksEntry_Sub_Theory_Save_Btn";
            this.MarksEntry_Sub_Theory_Save_Btn.Size = new System.Drawing.Size(75, 31);
            this.MarksEntry_Sub_Theory_Save_Btn.TabIndex = 10;
            this.MarksEntry_Sub_Theory_Save_Btn.Text = "Save";
            this.MarksEntry_Sub_Theory_Save_Btn.UseVisualStyleBackColor = true;
            this.MarksEntry_Sub_Theory_Save_Btn.Click += new System.EventHandler(this.MarksEntry_Sub_Theory_Save_Btn_Click);
            // 
            // MarksEntry_SubWise_Theory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(684, 476);
            this.Controls.Add(this.MarksEntry_Sub_Theory_Save_Btn);
            this.Controls.Add(this.theoryCourseTableDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MarksEntry_Sub_Theory_CourseName_ComboBx);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MarksEntry_SubWise_Theory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarksEntry_SubWise_Theory";
            this.Load += new System.EventHandler(this.MarksEntry_SubWise_Theory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultProcessingDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryCourseTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoryCourseTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox MarksEntry_Sub_Theory_CourseName_ComboBx;
        private System.Windows.Forms.Label label1;
        private ResultProcessingDataDataSet1 resultProcessingDataDataSet1;
        private System.Windows.Forms.BindingSource theoryCourseTableBindingSource;
        private ResultProcessingDataDataSet1TableAdapters.TheoryCourseTableTableAdapter theoryCourseTableTableAdapter;
        private ResultProcessingDataDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView theoryCourseTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button MarksEntry_Sub_Theory_Save_Btn;
    }
}