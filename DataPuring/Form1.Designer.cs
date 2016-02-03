namespace DataPuring
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associationPostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazinePostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundPostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountEmailuuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAcademicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.lb_count = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_upload = new System.Windows.Forms.Button();
            this.tb_uuid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAcademicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tutorDataGridViewTextBoxColumn,
            this.associationDataGridViewTextBoxColumn,
            this.associationPostDataGridViewTextBoxColumn,
            this.magazineDataGridViewTextBoxColumn,
            this.magazinePostDataGridViewTextBoxColumn,
            this.fundDataGridViewTextBoxColumn,
            this.fundPostDataGridViewTextBoxColumn,
            this.academicianDataGridViewTextBoxColumn,
            this.accountEmailuuidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userAcademicBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1353, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorDataGridViewTextBoxColumn
            // 
            this.tutorDataGridViewTextBoxColumn.DataPropertyName = "Tutor";
            this.tutorDataGridViewTextBoxColumn.HeaderText = "Tutor";
            this.tutorDataGridViewTextBoxColumn.Name = "tutorDataGridViewTextBoxColumn";
            this.tutorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // associationDataGridViewTextBoxColumn
            // 
            this.associationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.associationDataGridViewTextBoxColumn.DataPropertyName = "Association";
            this.associationDataGridViewTextBoxColumn.HeaderText = "Association";
            this.associationDataGridViewTextBoxColumn.Name = "associationDataGridViewTextBoxColumn";
            this.associationDataGridViewTextBoxColumn.Width = 124;
            // 
            // associationPostDataGridViewTextBoxColumn
            // 
            this.associationPostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.associationPostDataGridViewTextBoxColumn.DataPropertyName = "AssociationPost";
            this.associationPostDataGridViewTextBoxColumn.HeaderText = "AssociationPost";
            this.associationPostDataGridViewTextBoxColumn.Name = "associationPostDataGridViewTextBoxColumn";
            this.associationPostDataGridViewTextBoxColumn.Width = 156;
            // 
            // magazineDataGridViewTextBoxColumn
            // 
            this.magazineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.magazineDataGridViewTextBoxColumn.DataPropertyName = "Magazine";
            this.magazineDataGridViewTextBoxColumn.HeaderText = "Magazine";
            this.magazineDataGridViewTextBoxColumn.Name = "magazineDataGridViewTextBoxColumn";
            // 
            // magazinePostDataGridViewTextBoxColumn
            // 
            this.magazinePostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.magazinePostDataGridViewTextBoxColumn.DataPropertyName = "MagazinePost";
            this.magazinePostDataGridViewTextBoxColumn.HeaderText = "MagazinePost";
            this.magazinePostDataGridViewTextBoxColumn.Name = "magazinePostDataGridViewTextBoxColumn";
            this.magazinePostDataGridViewTextBoxColumn.Width = 132;
            // 
            // fundDataGridViewTextBoxColumn
            // 
            this.fundDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fundDataGridViewTextBoxColumn.DataPropertyName = "Fund";
            this.fundDataGridViewTextBoxColumn.HeaderText = "Fund";
            this.fundDataGridViewTextBoxColumn.Name = "fundDataGridViewTextBoxColumn";
            this.fundDataGridViewTextBoxColumn.Width = 68;
            // 
            // fundPostDataGridViewTextBoxColumn
            // 
            this.fundPostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fundPostDataGridViewTextBoxColumn.DataPropertyName = "FundPost";
            this.fundPostDataGridViewTextBoxColumn.HeaderText = "FundPost";
            this.fundPostDataGridViewTextBoxColumn.Name = "fundPostDataGridViewTextBoxColumn";
            // 
            // academicianDataGridViewTextBoxColumn
            // 
            this.academicianDataGridViewTextBoxColumn.DataPropertyName = "Academician";
            this.academicianDataGridViewTextBoxColumn.HeaderText = "Academician";
            this.academicianDataGridViewTextBoxColumn.Name = "academicianDataGridViewTextBoxColumn";
            this.academicianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountEmailuuidDataGridViewTextBoxColumn
            // 
            this.accountEmailuuidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountEmailuuidDataGridViewTextBoxColumn.DataPropertyName = "AccountEmail_uuid";
            this.accountEmailuuidDataGridViewTextBoxColumn.HeaderText = "AccountEmail_uuid";
            this.accountEmailuuidDataGridViewTextBoxColumn.Name = "accountEmailuuidDataGridViewTextBoxColumn";
            this.accountEmailuuidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userAcademicBindingSource
            // 
            this.userAcademicBindingSource.DataSource = typeof(BK.Model.DB.UserAcademic);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(626, 25);
            this.textBox1.TabIndex = 1;
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(12, 45);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(91, 23);
            this.bt_refresh.TabIndex = 2;
            this.bt_refresh.Text = "刷新";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(133, 45);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 3;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(1029, 49);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(55, 15);
            this.lb_count.TabIndex = 4;
            this.lb_count.Text = "label1";
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(242, 45);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 5;
            this.bt_delete.Text = "删除";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_upload
            // 
            this.bt_upload.Location = new System.Drawing.Point(349, 45);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.Size = new System.Drawing.Size(75, 23);
            this.bt_upload.TabIndex = 6;
            this.bt_upload.Text = "上传";
            this.bt_upload.UseVisualStyleBackColor = true;
            this.bt_upload.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // tb_uuid
            // 
            this.tb_uuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_uuid.Location = new System.Drawing.Point(736, 6);
            this.tb_uuid.Name = "tb_uuid";
            this.tb_uuid.Size = new System.Drawing.Size(629, 25);
            this.tb_uuid.TabIndex = 7;
            this.tb_uuid.TextChanged += new System.EventHandler(this.tb_uuid_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "uuid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_uuid);
            this.Controls.Add(this.bt_upload);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAcademicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource userAcademicBindingSource;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn associationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn associationPostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazinePostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundPostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountEmailuuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_upload;
        private System.Windows.Forms.TextBox tb_uuid;
        private System.Windows.Forms.Label label1;
    }
}

